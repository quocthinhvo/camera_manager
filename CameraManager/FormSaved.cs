using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace CameraManager
{
    public partial class FormSaved : Form
    {
        public static string fileopen = "";
        public FormSaved()
        {
            InitializeComponent();
        }

        private void FormSaved_Load(object sender, EventArgs e)
        {
            var Settings = new IniFile("logs.ini");
            //vlcControl1.Play(new Uri(Directory.GetCurrentDirectory() + "/output/v_output.avi"));
            string current_dir = Directory.GetCurrentDirectory() + "/output";
            //dataGridView1.DataSource = new System.IO.DirectoryInfo(current_dir).GetFiles();

            String[] files = Directory.GetFiles(current_dir);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                ListViewItem item = new ListViewItem();
                item.Text = file.Name;
                listView1.Items.Add(item);
            }
            

        }

        private void FormSaved_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var firstSelectedItem = listView1.SelectedItems[0];
            //this.Text = firstSelectedItem.Text;
            fileopen = firstSelectedItem.Text;
            PlayVideo playvideo = new PlayVideo();
            playvideo.ShowDialog();
        }
    }
}
