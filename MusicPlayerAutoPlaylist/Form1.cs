using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayerAutoPlaylist
{
    public partial class Form1 : Form
    {
        CirDoublyLinkedList<string> autoPlayList;
        Node<string> theSongToPlay;
        private bool songEnded;

        public Form1()
        {
            InitializeComponent();
            autoPlayList = new CirDoublyLinkedList<string>();
            this.trbVolume.Value = this.mediaPlayer.settings.volume;
            this.lbVolume.Text = this.trbVolume.Value.ToString() + "%";
            songEnded = false;
            
            setButtonsInfo();

            //lstbMusicList.SelectionMode = SelectionMode.MultiExtended;
            //cho phep chon nhieu bai cung luc de delete
        }

        private void setButtonsInfo()
        {
            toolTipInfo.SetToolTip(btnAdd, "Add song");
            toolTipInfo.SetToolTip(btnNext, "Next song");
            toolTipInfo.SetToolTip(btnPrev, "Previous song");
            toolTipInfo.SetToolTip(btnDel, "Remove song");
            toolTipInfo.SetToolTip(btnPlay, "Play song");
            toolTipInfo.SetToolTip(btnPause, "Pause song");
            toolTipInfo.SetToolTip(btnFull, "Full Screen Mode !!!");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //pause # stop
            mediaPlayer.Ctlcontrols.pause();
        }

        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            this.mediaPlayer.settings.volume = this.trbVolume.Value;
            this.lbVolume.Text = this.trbVolume.Value.ToString() + "%";
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.URL.Length > 0)
                mediaPlayer.fullScreen = true;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (lstbMusicList.Items.Count == 0)
                return;

            if (lstbMusicList.SelectedIndex == 0)
                lstbMusicList.SelectedIndex = lstbMusicList.Items.Count - 1;
            else
                lstbMusicList.SelectedIndex--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lstbMusicList.Items.Count == 0)
                return;

            if (lstbMusicList.SelectedIndex == lstbMusicList.Items.Count - 1)
                lstbMusicList.SelectedIndex = 0;
            else
                lstbMusicList.SelectedIndex++;
            //thua vi den day se goi phuong thuc select index changed
            //va se doi bai hat
            //theSongToPlay = theSongToPlay.Next;
            //mediaPlayer.URL = theSongToPlay.Data;
            //mediaPlayer.Ctlcontrols.play();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "All Files|*.*";
            od.Multiselect = true;
            if (od.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] paths = od.FileNames;
                    string[] names = od.SafeFileNames;
                    foreach (var aSongName in names)
                        lstbMusicList.Items.Add(aSongName);
                    foreach (var aSongPath in paths)
                        autoPlayList.addLast(aSongPath);
                }
                catch (Exception err) { MessageBox.Show(err.Message); }

                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                theSongToPlay = autoPlayList.Head;
                lstbMusicList.SelectedIndex = 0;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstbMusicList.Items.Count == 0)
                return;

            int selectIdx = lstbMusicList.SelectedIndex;
            lstbMusicList.Items.RemoveAt(selectIdx);
            autoPlayList.delAt(selectIdx);

            //thay doi idx cho nhieu truong hop
            if (selectIdx > lstbMusicList.Items.Count - 1)
            {
                if (lstbMusicList.Items.Count == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    lstbMusicList.SelectedIndex = -1;
                }
                else
                    lstbMusicList.SelectedIndex = selectIdx - 1;
            }
            else
                lstbMusicList.SelectedIndex = selectIdx;
        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //playState.mediaEnded : bai hat ket thuc
            if (mediaPlayer.playState == WMPPlayState.wmppsMediaEnded)
            {
                songEnded = true;
                if (lstbMusicList.SelectedIndex == lstbMusicList.Items.Count - 1)
                    lstbMusicList.SelectedIndex = 0;
                else
                    lstbMusicList.SelectedIndex++;
            }
            //san sang phat sau khi 1 bai hat ket thuc 
            //va chi nhu vay khi con bai hat de phat 
            //neu ko con thi phai dung(tu khi doi sang ready se ko phat)
            if (mediaPlayer.playState == WMPPlayState.wmppsReady && lstbMusicList.Items.Count != 0)
            {
                mediaPlayer.Ctlcontrols.play();
                songEnded = false;
            }
        }

        private void lstbMusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbMusicList.SelectedIndex != -1)
            {
                int idx = lstbMusicList.SelectedIndex;
                if (!btnNext.Focused && !btnPrev.Focused && !songEnded)//de toi uu neu an nut next thi song=song.next 
                    theSongToPlay = autoPlayList[idx];
                else if (btnNext.Focused || songEnded)
                    theSongToPlay = theSongToPlay.Next;
                else if (btnPrev.Focused)
                    theSongToPlay = theSongToPlay.Prev;

                mediaPlayer.URL = theSongToPlay.Data;
                mediaPlayer.Ctlcontrols.play();
            }
            else
            {
                theSongToPlay = null;
                mediaPlayer.URL = "";
                mediaPlayer.Ctlcontrols.stop();
            }
        }
    }
}
