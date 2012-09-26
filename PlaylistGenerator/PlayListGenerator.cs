using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace PlaylistGenerator
{
    /// <summary>
    /// Author: Vishal R. Joshi
    /// Date: 8/8/2008 (while watching Beijing Olympics 2008)
    /// </summary>
    public partial class PlayListGenerator : Form
    {
        #region UI Jazz

        private void PlayListGenerator_Load(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            AboutKritzu about = new AboutKritzu();
            about.Show();
        }

        private void maroonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            this.txtMusicFolderPath.ForeColor = System.Drawing.Color.White;
            this.btnMusicFolderSelect.ForeColor = System.Drawing.Color.White;
            this.txtPlaylistLocation.ForeColor = System.Drawing.Color.White;
            this.btnPlaylistFolderSelect.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePlaylist.ForeColor = System.Drawing.Color.White;


            this.lblMusicFolder.ForeColor = System.Drawing.Color.Maroon;
            this.txtMusicFolderPath.BackColor = System.Drawing.Color.Maroon;
            this.btnMusicFolderSelect.BackColor = System.Drawing.Color.Maroon;
            this.chkCreateSubFolderPlaylist.ForeColor = System.Drawing.Color.Maroon;
            this.txtPlaylistLocation.BackColor = System.Drawing.Color.Maroon;
            this.btnPlaylistFolderSelect.BackColor = System.Drawing.Color.Maroon;
            this.lblPlaylistFolder.ForeColor = System.Drawing.Color.Maroon;
            this.btnGeneratePlaylist.BackColor = System.Drawing.Color.Maroon;
            this.lblPlaylistGenerator.ForeColor = System.Drawing.Color.Maroon;
            this.lblKritZu.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;

            this.imgZuneFront.Image = global::PlaylistGenerator.Properties.Resources.Zune_Front_Brown;


        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lblMessage.Text = String.Empty;
            this.lblMusicFolder.ForeColor = System.Drawing.Color.LightCoral;
            this.txtMusicFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMusicFolderSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkCreateSubFolderPlaylist.ForeColor = System.Drawing.Color.LightCoral;
            this.txtPlaylistLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlaylistFolderSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlaylistFolder.ForeColor = System.Drawing.Color.LightCoral;
            this.btnGeneratePlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlaylistGenerator.ForeColor = System.Drawing.Color.IndianRed;
            this.lblKritZu.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.imgZuneFront.Image = global::PlaylistGenerator.Properties.Resources.Zune_Front;
            this.txtMusicFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMusicFolderSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlaylistFolderSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGeneratePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPlaylistLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));


        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            this.txtMusicFolderPath.ForeColor = System.Drawing.Color.White;
            this.btnMusicFolderSelect.ForeColor = System.Drawing.Color.White;
            this.txtPlaylistLocation.ForeColor = System.Drawing.Color.White;
            this.btnPlaylistFolderSelect.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePlaylist.ForeColor = System.Drawing.Color.White;


            this.lblMusicFolder.ForeColor = System.Drawing.Color.Black;
            this.txtMusicFolderPath.BackColor = System.Drawing.Color.DimGray;
            this.btnMusicFolderSelect.BackColor = System.Drawing.Color.DimGray;
            this.chkCreateSubFolderPlaylist.ForeColor = System.Drawing.Color.Black;
            this.txtPlaylistLocation.BackColor = System.Drawing.Color.DimGray;
            this.btnPlaylistFolderSelect.BackColor = System.Drawing.Color.DimGray;
            this.lblPlaylistFolder.ForeColor = System.Drawing.Color.Black;
            this.btnGeneratePlaylist.BackColor = System.Drawing.Color.DimGray;
            this.lblPlaylistGenerator.ForeColor = System.Drawing.Color.Black;
            this.lblKritZu.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;

            this.imgZuneFront.Image = global::PlaylistGenerator.Properties.Resources.Zune_Front_Black;

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            this.txtMusicFolderPath.ForeColor = System.Drawing.Color.White;
            this.btnMusicFolderSelect.ForeColor = System.Drawing.Color.White;
            this.txtPlaylistLocation.ForeColor = System.Drawing.Color.White;
            this.btnPlaylistFolderSelect.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePlaylist.ForeColor = System.Drawing.Color.White;


            this.lblMusicFolder.ForeColor = System.Drawing.Color.Olive;
            this.txtMusicFolderPath.BackColor = System.Drawing.Color.Olive;
            this.btnMusicFolderSelect.BackColor = System.Drawing.Color.Olive;
            this.chkCreateSubFolderPlaylist.ForeColor = System.Drawing.Color.Olive;
            this.txtPlaylistLocation.BackColor = System.Drawing.Color.Olive;
            this.btnPlaylistFolderSelect.BackColor = System.Drawing.Color.Olive;
            this.lblPlaylistFolder.ForeColor = System.Drawing.Color.Olive;
            this.btnGeneratePlaylist.BackColor = System.Drawing.Color.Olive;
            this.lblPlaylistGenerator.ForeColor = System.Drawing.Color.Olive;
            this.lblKritZu.ForeColor = System.Drawing.Color.Olive;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;

            this.imgZuneFront.Image = global::PlaylistGenerator.Properties.Resources.Zune_Front_Green;
        }

        #endregion

        #region Global Variables
        int fileCounter;
        string title = "KritZu";
        #endregion

        #region Event Handlers

        public PlayListGenerator()
        {
            InitializeComponent();
        }

        private void folderSelect_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            musicFolderPopup.ShowDialog();
            txtMusicFolderPath.Text = musicFolderPopup.SelectedPath;

        }

        private void generatePlaylist_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            try
            {
                string message = String.Empty;
                lblMessage.Text = GeneratePlaylist(txtMusicFolderPath.Text);                 
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Failed!! Error on " + title + " " + ex.Message;
            }

        }

        private void playlistFolderSelect_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            playlistFolderPopup.ShowDialog();
            txtPlaylistLocation.Text = playlistFolderPopup.SelectedPath;
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {

            lblMessage.Text = String.Empty;
            Help kritzuHelp = new Help();
            kritzuHelp.Show();
        }

        #endregion

        #region Playlist Generation
        private string GeneratePlaylist(string path)
        {

            string message = String.Empty;
            string playlistString = String.Empty;

            if (Directory.Exists(path))
            {
                if (Directory.GetFiles(path).Length > 0)
                {

                    playlistString = String.Empty;
                    playlistString = GeneratePlayListString(path);
                    if (playlistString.Trim().Length > 0)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(playlistString);
                        if (!Directory.Exists(txtPlaylistLocation.Text))
                        {
                            Directory.CreateDirectory(txtPlaylistLocation.Text);
                        }
                        doc.Save(txtPlaylistLocation.Text + "\\" + title + ".zpl");
                    }

                    if (chkCreateSubFolderPlaylist.Checked)
                    {
                        // Recurse into subdirectories.
                        string[] subfolderEntries = Directory.GetDirectories(path);
                        foreach (string subfolder in subfolderEntries)
                        {
                            GeneratePlaylist(subfolder);

                        }
                    }
                    message = "Playlist/s were created successfully"; 
                }
                else
                {
                    message = "No media files found in the source folder"; 
                }

            }
            return message;

        }

        private string GeneratePlayListString(string targetFolder)
        {
            fileCounter = 0;
            string playlist = String.Empty;
            string tillItemCount = "<?zpl version='2.0'?><smil><head><meta name='generator' content='Zune -- 2.5.447.0'/><meta name='itemCount' content='";
            string itemCount = "0";
            string tillTitle = "' /><meta name='totalDuration' content='0' /><meta name='averageRating' content='0'/><title>";
            string tillMediaSrc = "</title></head><body><seq>";
            string finalMediaSource = GenerateMediaSrcForFolder(targetFolder);
            string trailer = "</seq></body></smil>";
            if (finalMediaSource.Trim().Length > 0)
            {
                itemCount = fileCounter.ToString();
                string[] folderSplit = targetFolder.Split(new Char[] { '\\' });
                title = folderSplit[folderSplit.Length - 1];
                string xmlTitle = title;
                xmlTitle = xmlTitle.Replace("&", "&amp;");
                xmlTitle = xmlTitle.Replace("'", "&apos;");
                xmlTitle = xmlTitle.Replace("<", "&lt;");
                xmlTitle = xmlTitle.Replace(">", "&gt;");
                playlist = tillItemCount + itemCount + tillTitle + xmlTitle + tillMediaSrc + finalMediaSource + trailer;
            }

            return playlist;
        }

        private string GenerateMediaSrcForFolder(string targetFolder)
        {
            string mediaSources = String.Empty;

            //Process MP3 file in this current folder
            string[] fileEntries = Directory.GetFiles(targetFolder);
            foreach (string fileName in fileEntries)
                mediaSources += GenerateMediaSrcForFile(fileName);


            // Recurse into subdirectories of this directory.
            string[] subfolderEntries = Directory.GetDirectories(targetFolder);
            foreach (string subfolder in subfolderEntries)
                mediaSources += GenerateMediaSrcForFolder(subfolder);

            return mediaSources;
        }

        //Generate Media Source for each MP3 file
        public string GenerateMediaSrcForFile(string filePath)
        {
            if (filePath.ToLower().Contains(".mp3") || filePath.ToLower().Contains(".wma") || filePath.ToLower().Contains(".m4v") || filePath.ToLower().Contains(".mp4") || filePath.ToLower().Contains(".m4a") || filePath.ToLower().Contains(".m4b") || filePath.ToLower().Contains(".mov"))
            {
                fileCounter++;
                filePath = filePath.Replace("&", "&amp;");
                filePath = filePath.Replace("'", "&apos;");
                filePath = filePath.Replace("<", "&lt;");
                filePath = filePath.Replace(">", "&gt;");
                return "<media src='" + filePath + "'/>";
            }
            else
            {
                return String.Empty;
            }
        }

        #endregion

    }
}
