namespace MusicPlayerAutoPlaylist
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelAll = new System.Windows.Forms.Panel();
            this.pnlPlaylistControl = new System.Windows.Forms.Panel();
            this.lstbMusicList = new System.Windows.Forms.ListBox();
            this.pnlPlayerControl = new System.Windows.Forms.Panel();
            this.pnlFunctionControl = new System.Windows.Forms.Panel();
            this.lbVolume = new System.Windows.Forms.Label();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panelAll.SuspendLayout();
            this.pnlPlaylistControl.SuspendLayout();
            this.pnlPlayerControl.SuspendLayout();
            this.pnlFunctionControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.pnlPlaylistControl);
            this.panelAll.Controls.Add(this.pnlPlayerControl);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(657, 336);
            this.panelAll.TabIndex = 0;
            // 
            // pnlPlaylistControl
            // 
            this.pnlPlaylistControl.BackColor = System.Drawing.Color.White;
            this.pnlPlaylistControl.Controls.Add(this.btnAdd);
            this.pnlPlaylistControl.Controls.Add(this.btnDel);
            this.pnlPlaylistControl.Controls.Add(this.btnNext);
            this.pnlPlaylistControl.Controls.Add(this.btnPrev);
            this.pnlPlaylistControl.Controls.Add(this.lstbMusicList);
            this.pnlPlaylistControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPlaylistControl.Location = new System.Drawing.Point(460, 0);
            this.pnlPlaylistControl.Name = "pnlPlaylistControl";
            this.pnlPlaylistControl.Size = new System.Drawing.Size(197, 336);
            this.pnlPlaylistControl.TabIndex = 1;
            // 
            // lstbMusicList
            // 
            this.lstbMusicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbMusicList.BackColor = System.Drawing.Color.Beige;
            this.lstbMusicList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbMusicList.FormattingEnabled = true;
            this.lstbMusicList.Location = new System.Drawing.Point(0, 0);
            this.lstbMusicList.Name = "lstbMusicList";
            this.lstbMusicList.Size = new System.Drawing.Size(197, 288);
            this.lstbMusicList.TabIndex = 4;
            this.lstbMusicList.SelectedIndexChanged += new System.EventHandler(this.lstbMusicList_SelectedIndexChanged);
            // 
            // pnlPlayerControl
            // 
            this.pnlPlayerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerControl.Controls.Add(this.pictureBox1);
            this.pnlPlayerControl.Controls.Add(this.pictureBox2);
            this.pnlPlayerControl.Controls.Add(this.pnlFunctionControl);
            this.pnlPlayerControl.Controls.Add(this.mediaPlayer);
            this.pnlPlayerControl.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayerControl.Name = "pnlPlayerControl";
            this.pnlPlayerControl.Size = new System.Drawing.Size(456, 336);
            this.pnlPlayerControl.TabIndex = 0;
            // 
            // pnlFunctionControl
            // 
            this.pnlFunctionControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFunctionControl.Controls.Add(this.lbVolume);
            this.pnlFunctionControl.Controls.Add(this.trbVolume);
            this.pnlFunctionControl.Controls.Add(this.btnFull);
            this.pnlFunctionControl.Controls.Add(this.btnPause);
            this.pnlFunctionControl.Controls.Add(this.btnPlay);
            this.pnlFunctionControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFunctionControl.Location = new System.Drawing.Point(0, 304);
            this.pnlFunctionControl.Name = "pnlFunctionControl";
            this.pnlFunctionControl.Size = new System.Drawing.Size(456, 32);
            this.pnlFunctionControl.TabIndex = 2;
            // 
            // lbVolume
            // 
            this.lbVolume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVolume.AutoSize = true;
            this.lbVolume.ForeColor = System.Drawing.Color.Silver;
            this.lbVolume.Location = new System.Drawing.Point(282, 7);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(24, 13);
            this.lbVolume.TabIndex = 4;
            this.lbVolume.Text = "0 %";
            // 
            // trbVolume
            // 
            this.trbVolume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trbVolume.Location = new System.Drawing.Point(301, 1);
            this.trbVolume.Maximum = 100;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(109, 42);
            this.trbVolume.TabIndex = 3;
            this.trbVolume.Scroll += new System.EventHandler(this.trbVolume_Scroll);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(456, 336);
            this.mediaPlayer.TabIndex = 0;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::MusicPlayerAutoPlaylist.Properties.Resources.AddButton;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(136, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 41);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImage = global::MusicPlayerAutoPlaylist.Properties.Resources.DeleteButton;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(171, 292);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 41);
            this.btnDel.TabIndex = 8;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::MusicPlayerAutoPlaylist.Properties.Resources.NextButton;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(101, 292);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 41);
            this.btnNext.TabIndex = 7;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImage = global::MusicPlayerAutoPlaylist.Properties.Resources.PrevButton;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(66, 292);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 41);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MusicPlayerAutoPlaylist.Properties.Resources.AudioPicture;
            this.pictureBox2.Location = new System.Drawing.Point(113, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MusicPlayerAutoPlaylist.Properties.Resources.SmileFacePicture;
            this.pictureBox1.Location = new System.Drawing.Point(191, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnFull
            // 
            this.btnFull.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFull.BackColor = System.Drawing.Color.Black;
            this.btnFull.BackgroundImage = global::MusicPlayerAutoPlaylist.Properties.Resources.FullScreenButton;
            this.btnFull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFull.FlatAppearance.BorderSize = 0;
            this.btnFull.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFull.Location = new System.Drawing.Point(416, 1);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(26, 24);
            this.btnFull.TabIndex = 2;
            this.btnFull.UseVisualStyleBackColor = false;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Black;
            this.btnPause.BackgroundImage = global::MusicPlayerAutoPlaylist.Properties.Resources.PauseButton;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(41, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(26, 24);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.BackgroundImage = global::MusicPlayerAutoPlaylist.Properties.Resources.PlayButton;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(9, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(26, 24);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(657, 336);
            this.Controls.Add(this.panelAll);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.panelAll.ResumeLayout(false);
            this.pnlPlaylistControl.ResumeLayout(false);
            this.pnlPlayerControl.ResumeLayout(false);
            this.pnlFunctionControl.ResumeLayout(false);
            this.pnlFunctionControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel pnlPlaylistControl;
        private System.Windows.Forms.Panel pnlPlayerControl;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ListBox lstbMusicList;
        private System.Windows.Forms.Panel pnlFunctionControl;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

