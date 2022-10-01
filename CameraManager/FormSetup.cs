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
    public partial class FormSetup : Form
    {
        public FormSetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Settings = new IniFile("data.ini");
            Settings.Write("RAN", "true");
            Settings.Write("IP", textBox_IP.Text);
            Settings.Write("USERNAME", textBox_username.Text);
            Settings.Write("PASSWORD", textBox_password.Text);
            Settings.Write("ADMIN", textBox_recei.Text);
            /*8var formhome = new FormHome();
            formhome.Show();
            this.Hide();*/
            Application.Restart();
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formInfo = new FormInfo();
            formInfo.ShowDialog();
        }
    }
}
