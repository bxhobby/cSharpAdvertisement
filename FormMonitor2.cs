using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advertisement
{
    public partial class FormMonitor2 : Form
    {
        List<string> FileList;
        public FormMonitor2(List<string> fileList)

        {
            this.FileList = fileList;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia media;
            if (FileList.Count != 0)
            {
                foreach (string file in FileList)
                {
                    media = axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(media);
                }
            }
            axWindowsMediaPlayer1.currentPlaylist = playlist;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

    }
}
