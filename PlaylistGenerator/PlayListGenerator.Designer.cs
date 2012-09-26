namespace PlaylistGenerator
{
    partial class PlayListGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListGenerator));
            this.lblMusicFolder = new System.Windows.Forms.Label();
            this.txtMusicFolderPath = new System.Windows.Forms.TextBox();
            this.musicFolderPopup = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMusicFolderSelect = new System.Windows.Forms.Button();
            this.chkCreateSubFolderPlaylist = new System.Windows.Forms.CheckBox();
            this.txtPlaylistLocation = new System.Windows.Forms.TextBox();
            this.btnPlaylistFolderSelect = new System.Windows.Forms.Button();
            this.lblPlaylistFolder = new System.Windows.Forms.Label();
            this.btnGeneratePlaylist = new System.Windows.Forms.Button();
            this.lblPlaylistGenerator = new System.Windows.Forms.Label();
            this.lblKritZu = new System.Windows.Forms.Label();
            this.playlistFolderPopup = new System.Windows.Forms.FolderBrowserDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.menuMyKritZu = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maroonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgZuneBrand = new System.Windows.Forms.PictureBox();
            this.imgZuneFront = new System.Windows.Forms.PictureBox();
            this.imgZuneBack = new System.Windows.Forms.PictureBox();
            this.menuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgZuneBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZuneFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZuneBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusicFolder
            // 
            this.lblMusicFolder.AutoSize = true;
            this.lblMusicFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicFolder.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMusicFolder.Location = new System.Drawing.Point(4, 183);
            this.lblMusicFolder.Name = "lblMusicFolder";
            this.lblMusicFolder.Size = new System.Drawing.Size(374, 17);
            this.lblMusicFolder.TabIndex = 0;
            this.lblMusicFolder.Text = "Select the folder which you would like to create playlist for:";
            // 
            // txtMusicFolderPath
            // 
            this.txtMusicFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMusicFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusicFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMusicFolderPath.Location = new System.Drawing.Point(7, 205);
            this.txtMusicFolderPath.Name = "txtMusicFolderPath";
            this.txtMusicFolderPath.Size = new System.Drawing.Size(336, 23);
            this.txtMusicFolderPath.TabIndex = 1;
            this.txtMusicFolderPath.Text = "C:\\Users\\Public\\Music\\Sample Music\\";
            // 
            // btnMusicFolderSelect
            // 
            this.btnMusicFolderSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMusicFolderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicFolderSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMusicFolderSelect.Location = new System.Drawing.Point(349, 203);
            this.btnMusicFolderSelect.Name = "btnMusicFolderSelect";
            this.btnMusicFolderSelect.Size = new System.Drawing.Size(29, 25);
            this.btnMusicFolderSelect.TabIndex = 2;
            this.btnMusicFolderSelect.Text = "...";
            this.btnMusicFolderSelect.UseVisualStyleBackColor = false;
            this.btnMusicFolderSelect.Click += new System.EventHandler(this.folderSelect_Click);
            // 
            // chkCreateSubFolderPlaylist
            // 
            this.chkCreateSubFolderPlaylist.AutoSize = true;
            this.chkCreateSubFolderPlaylist.Checked = true;
            this.chkCreateSubFolderPlaylist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateSubFolderPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreateSubFolderPlaylist.ForeColor = System.Drawing.Color.LightCoral;
            this.chkCreateSubFolderPlaylist.Location = new System.Drawing.Point(7, 234);
            this.chkCreateSubFolderPlaylist.Name = "chkCreateSubFolderPlaylist";
            this.chkCreateSubFolderPlaylist.Size = new System.Drawing.Size(269, 21);
            this.chkCreateSubFolderPlaylist.TabIndex = 4;
            this.chkCreateSubFolderPlaylist.Text = "Create seperate playlist per sub-folder";
            this.chkCreateSubFolderPlaylist.UseVisualStyleBackColor = true;
            // 
            // txtPlaylistLocation
            // 
            this.txtPlaylistLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPlaylistLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlaylistLocation.Location = new System.Drawing.Point(7, 293);
            this.txtPlaylistLocation.Name = "txtPlaylistLocation";
            this.txtPlaylistLocation.Size = new System.Drawing.Size(336, 23);
            this.txtPlaylistLocation.TabIndex = 6;
            this.txtPlaylistLocation.Text = "C:\\Users\\Public\\Music\\Sample Music\\Zune\\Playlists";
            // 
            // btnPlaylistFolderSelect
            // 
            this.btnPlaylistFolderSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlaylistFolderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylistFolderSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlaylistFolderSelect.Location = new System.Drawing.Point(349, 292);
            this.btnPlaylistFolderSelect.Name = "btnPlaylistFolderSelect";
            this.btnPlaylistFolderSelect.Size = new System.Drawing.Size(29, 23);
            this.btnPlaylistFolderSelect.TabIndex = 7;
            this.btnPlaylistFolderSelect.Text = "...";
            this.btnPlaylistFolderSelect.UseVisualStyleBackColor = false;
            this.btnPlaylistFolderSelect.Click += new System.EventHandler(this.playlistFolderSelect_Click);
            // 
            // lblPlaylistFolder
            // 
            this.lblPlaylistFolder.AutoSize = true;
            this.lblPlaylistFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistFolder.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPlaylistFolder.Location = new System.Drawing.Point(4, 272);
            this.lblPlaylistFolder.Name = "lblPlaylistFolder";
            this.lblPlaylistFolder.Size = new System.Drawing.Size(392, 17);
            this.lblPlaylistFolder.TabIndex = 5;
            this.lblPlaylistFolder.Text = "Select the folder where your Zune playlists should be placed:";
            // 
            // btnGeneratePlaylist
            // 
            this.btnGeneratePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGeneratePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeneratePlaylist.Location = new System.Drawing.Point(433, 255);
            this.btnGeneratePlaylist.Name = "btnGeneratePlaylist";
            this.btnGeneratePlaylist.Size = new System.Drawing.Size(104, 71);
            this.btnGeneratePlaylist.TabIndex = 8;
            this.btnGeneratePlaylist.Text = "Generate";
            this.btnGeneratePlaylist.UseVisualStyleBackColor = false;
            this.btnGeneratePlaylist.Click += new System.EventHandler(this.generatePlaylist_Click);
            // 
            // lblPlaylistGenerator
            // 
            this.lblPlaylistGenerator.AutoSize = true;
            this.lblPlaylistGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistGenerator.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPlaylistGenerator.Location = new System.Drawing.Point(2, 58);
            this.lblPlaylistGenerator.Name = "lblPlaylistGenerator";
            this.lblPlaylistGenerator.Size = new System.Drawing.Size(153, 22);
            this.lblPlaylistGenerator.TabIndex = 9;
            this.lblPlaylistGenerator.Text = "Playlist Generator";
            // 
            // lblKritZu
            // 
            this.lblKritZu.AutoSize = true;
            this.lblKritZu.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKritZu.ForeColor = System.Drawing.Color.IndianRed;
            this.lblKritZu.Location = new System.Drawing.Point(10, 11);
            this.lblKritZu.Name = "lblKritZu";
            this.lblKritZu.Size = new System.Drawing.Size(109, 58);
            this.lblKritZu.TabIndex = 10;
            this.lblKritZu.Text = "KritZu";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMessage.Location = new System.Drawing.Point(4, 334);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "  ";
            // 
            // menuAbout
            // 
            this.menuAbout.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.ShortcutKeyDisplayString = "Ctrl + A";
            this.menuAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuAbout.Size = new System.Drawing.Size(87, 20);
            this.menuAbout.Text = "About KritZu";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.ShortcutKeyDisplayString = "F1";
            this.menuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.Color.Transparent;
            this.menuFile.Dock = System.Windows.Forms.DockStyle.None;
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMyKritZu,
            this.menuAbout,
            this.menuHelp});
            this.menuFile.Location = new System.Drawing.Point(384, -2);
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(214, 24);
            this.menuFile.TabIndex = 12;
            this.menuFile.Text = "File";
            // 
            // menuMyKritZu
            // 
            this.menuMyKritZu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.maroonToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.pinkToolStripMenuItem});
            this.menuMyKritZu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuMyKritZu.Name = "menuMyKritZu";
            this.menuMyKritZu.ShortcutKeyDisplayString = "Ctrl + C";
            this.menuMyKritZu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuMyKritZu.Size = new System.Drawing.Size(75, 20);
            this.menuMyKritZu.Text = "Customize";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + B";
            this.blackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + P";
            this.pinkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.ForeColor = System.Drawing.Color.Olive;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.greenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.greenToolStripMenuItem.Text = "Olive";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // maroonToolStripMenuItem
            // 
            this.maroonToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.maroonToolStripMenuItem.Name = "maroonToolStripMenuItem";
            this.maroonToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + M";
            this.maroonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.maroonToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.maroonToolStripMenuItem.Text = "Maroon";
            this.maroonToolStripMenuItem.Click += new System.EventHandler(this.maroonToolStripMenuItem_Click);
            // 
            // imgZuneBrand
            // 
            this.imgZuneBrand.Image = global::PlaylistGenerator.Properties.Resources.ZuneLogo;
            this.imgZuneBrand.Location = new System.Drawing.Point(477, 32);
            this.imgZuneBrand.Name = "imgZuneBrand";
            this.imgZuneBrand.Size = new System.Drawing.Size(111, 50);
            this.imgZuneBrand.TabIndex = 8;
            this.imgZuneBrand.TabStop = false;
            // 
            // imgZuneFront
            // 
            this.imgZuneFront.Image = global::PlaylistGenerator.Properties.Resources.Zune_Front;
            this.imgZuneFront.Location = new System.Drawing.Point(362, 26);
            this.imgZuneFront.Name = "imgZuneFront";
            this.imgZuneFront.Size = new System.Drawing.Size(239, 227);
            this.imgZuneFront.TabIndex = 9;
            this.imgZuneFront.TabStop = false;
            // 
            // imgZuneBack
            // 
            this.imgZuneBack.Image = global::PlaylistGenerator.Properties.Resources.Zune_BackAngle;
            this.imgZuneBack.Location = new System.Drawing.Point(140, 25);
            this.imgZuneBack.Name = "imgZuneBack";
            this.imgZuneBack.Size = new System.Drawing.Size(303, 192);
            this.imgZuneBack.TabIndex = 10;
            this.imgZuneBack.TabStop = false;
            // 
            // PlayListGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(590, 353);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPlaylistGenerator);
            this.Controls.Add(this.btnGeneratePlaylist);
            this.Controls.Add(this.imgZuneBrand);
            this.Controls.Add(this.lblPlaylistFolder);
            this.Controls.Add(this.btnPlaylistFolderSelect);
            this.Controls.Add(this.txtPlaylistLocation);
            this.Controls.Add(this.chkCreateSubFolderPlaylist);
            this.Controls.Add(this.btnMusicFolderSelect);
            this.Controls.Add(this.txtMusicFolderPath);
            this.Controls.Add(this.lblMusicFolder);
            this.Controls.Add(this.imgZuneFront);
            this.Controls.Add(this.lblKritZu);
            this.Controls.Add(this.menuFile);
            this.Controls.Add(this.imgZuneBack);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuFile;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(606, 389);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(606, 389);
            this.Name = "PlayListGenerator";
            this.Text = "KritzZu";
            this.Load += new System.EventHandler(this.PlayListGenerator_Load);
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgZuneBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZuneFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZuneBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusicFolder;
        private System.Windows.Forms.TextBox txtMusicFolderPath;
        private System.Windows.Forms.FolderBrowserDialog musicFolderPopup;
        private System.Windows.Forms.Button btnMusicFolderSelect;
        private System.Windows.Forms.CheckBox chkCreateSubFolderPlaylist;
        private System.Windows.Forms.TextBox txtPlaylistLocation;
        private System.Windows.Forms.Button btnPlaylistFolderSelect;
        private System.Windows.Forms.Label lblPlaylistFolder;
        private System.Windows.Forms.PictureBox imgZuneFront;
        private System.Windows.Forms.Button btnGeneratePlaylist;
        private System.Windows.Forms.Label lblPlaylistGenerator;
        private System.Windows.Forms.Label lblKritZu;
        private System.Windows.Forms.PictureBox imgZuneBrand;
        private System.Windows.Forms.PictureBox imgZuneBack;
        private System.Windows.Forms.FolderBrowserDialog playlistFolderPopup;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuMyKritZu;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maroonToolStripMenuItem;
    }
}

