﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;


namespace vSongBook
{
    public partial class DdSongEdit : Form
    {
        private int songno = 0;

        string sqlQuery;
        AppDatabase appDB;
        SQLiteDataReader reader;
        DataRowCollection dRowCol;
        private AppFunctions vsbf = new AppFunctions();
        private AppSettings settings = new AppSettings();
        bool setsong;
        public DdSongEdit()
        {
            InitializeComponent();
            setsong = true;
            loadBooks();
            setsong = false;
        }
        
        private void DdSongEdit_Load(object sender, EventArgs e)
        {
            try { lstSongResults.Font = new Font(settings.FontTypeGeneral, settings.FontSizeGeneral, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
            catch (Exception) { }
            try { txtSongContent.Font = new Font(settings.FontTypePreview, settings.FontSizePreview, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
            catch (Exception) { }
            try { grpSongContent.Font = new Font(settings.FontTypeGeneral, settings.FontSizeGeneral, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); }
            catch (Exception) { }
        }

        private void loadFeedback(string fbmessage, bool positive = true, bool timed = false, float interval = 1000)
        {
            jsFeedback.Interval = interval == 0 ? interval : jsFeedback.Interval;
            jsFeedback.IsPositive = positive;
            jsFeedback.IsTimed = timed;
            jsFeedback.Text = fbmessage;
            jsFeedback.Visible = true;
        }

        public void loadBooks()
        {
            try
            {
                cmbBooks.Items.Clear();
                lstBookcodes.Items.Clear();
                sqlQuery = "SELECT * FROM books WHERE state=1;";
                appDB = new AppDatabase();
                dRowCol = appDB.getList(sqlQuery);

                foreach (DataRow row in dRowCol)
                {
                    cmbBooks.Items.Add(row["title"] + " (" + row["songs"] + ")");
                    lstBookcodes.Items.Add(row["code"]);
                    cmbBooks.SelectedIndex = setsong ? settings.SelectedBook : 0;
                    lstBookcodes.SelectedIndex = setsong ? settings.SelectedBook : 0;
                }
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry books listing failed: " + ex.Message, false, true);
            }
        }

        public void loadBookSongs(string code)
        {
            try
            {
                lstSongResults.Items.Clear();

                sqlQuery = "SELECT songid, number, title FROM songs WHERE book='" + code + "';";
                appDB = new AppDatabase();
                dRowCol = appDB.getList(sqlQuery);

                foreach (DataRow row in dRowCol)
                {
                    lstSongResults.Items.Add(row["number"] + "# " + row["title"]);
                    lstSongResults.SelectedIndex = 0;
                }
                grpSongResults.Text = lstSongResults.Items.Count + " " + lstBookcodes.Text + " songs found";
                songno = lstSongResults.Items.Count + 1;
                txtNumber.Placeholder = songno.ToString();
                txtNumber.Text = songno.ToString();
            }
            catch (Exception ex)
            {
               loadFeedback("Oops! Sorry song listing failed: " + ex.Message, false, true);
            }
        }
        
        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBookcodes.SelectedIndex = setsong ? cmbBooks.SelectedIndex : 0;
        }

        private void lstBookcodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBookSongs(lstBookcodes.Text);
        }

        public void loadSingleSong(int songid)
        {
            try
            {
                txtSongContent.Clear();
                sqlQuery = "SELECT * FROM songs WHERE songid=" + songid + ";";
                appDB = new AppDatabase();
                reader = appDB.getSingle(sqlQuery);
                while (reader.Read())
                {
                    txtNumber.Text = vsbf.songRender(reader["number"].ToString());
                    txtSongKey.Text = vsbf.songRender(reader["key"].ToString());
                    txtSongTitle.Text = vsbf.songRender(reader["title"].ToString());
                    txtSongContent.Text = vsbf.songRender(reader["content"].ToString());
                }
                appDB.sqlClose();
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry song viewing failed: " + ex.Message, false, true);
            }
        }
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            appDB = new AppDatabase();
            bool newsong = appDB.addNewSong(lstBookcodes.Text, txtNumber.Text, vsbf.textRendertoDB(txtSongTitle.Text),
                vsbf.songRendertoDB(txtSongContent.Text), txtSongKey.Text, "", "");
            if (newsong)
            {
                appDB.songsUpdate(lstBookcodes.Text, lstSongResults.Items.Count);
                loadFeedback("The song has been updated successfully!", true, true);
            }
            this.Close();
        }

        private void btnSaveOnly_Click(object sender, EventArgs e)
        {
            appDB = new AppDatabase();
            bool newsong = appDB.addNewSong(lstBookcodes.Text, txtNumber.Text, vsbf.textRendertoDB(txtSongTitle.Text),
                vsbf.songRendertoDB(txtSongContent.Text), txtSongKey.Text, "", "");
            if (newsong)
            {
                appDB.songsUpdate(lstBookcodes.Text, lstSongResults.Items.Count);
                loadFeedback("The song has been updated successfully!", true, true);
            }
        }

        private void tsbtnLast_Click(object sender, EventArgs e)
        {
            try
            {
                lstSongResults.SelectedIndex = lstSongResults.SelectedIndex - 1;
            }
            catch (Exception)
            {
                loadFeedback("Oops! Sorry, there no song before the current song ...", false, true);
            }
        }

        private void tsbtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                lstSongResults.SelectedIndex = lstSongResults.SelectedIndex + 1;
            }
            catch (Exception)
            {
                loadFeedback("Oops! Sorry, there no song after the current song ...", false, true);
            }
        }

    }
}
