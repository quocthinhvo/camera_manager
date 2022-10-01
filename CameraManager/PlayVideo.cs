using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraManager
{
    public partial class PlayVideo : Form
    {
        public PlayVideo()
        {
            InitializeComponent();
        }

        private void PlayVideo_Load(object sender, EventArgs e)
        {
            //this.Text = FormSaved.fileopen;
            string files = Directory.GetCurrentDirectory() + "/output/" + FormSaved.fileopen;
            this.Text = FormSaved.fileopen;
            vlcControl1.Play(new Uri(files));
        }
    }
}
