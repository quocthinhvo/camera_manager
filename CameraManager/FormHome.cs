using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CameraManager
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            var Settings = new IniFile("data.ini");
            var strIP = Settings.Read("IP");
            vlcControl1.Play(new Uri(strIP));
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var formsetup = new FormSetup();
            formsetup.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formsaved = new FormSaved();
            formsaved.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Settings = new IniFile("data.ini");
            var strip = Settings.Read("IP");
            var username = Settings.Read("USERNAME");
            var pass = Settings.Read("PASSWORD");
            var admin = Settings.Read("ADMIN");
            string command = "/C python " + Directory.GetCurrentDirectory() + "/main.py " + strip + " " + username + " " + pass + " "+ admin;
            //System.Diagnostics.Process.Start("CMD.exe", command);
            /*
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = command;
            Process.Start(ps); */
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = command;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            var Logs = new IniFile("logs.ini");
            Logs.Write("COMMAND", command);
            Logs.Write("OUTPUT", output);
        }

        private void resetccc_Click(object sender, EventArgs e)
        {
            var Settings = new IniFile("data.ini");
            Settings.Write("RAN", "");
            Application.Restart();
            Environment.Exit(0);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var Settings = new IniFile("data.ini");
            string command = "ssh pi@" + Settings.Read("IP");
            System.Diagnostics.Process.Start("CMD.exe", command);

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            var Settings = new IniFile("data.ini");
            var strip = Settings.Read("IP");
            var username = Settings.Read("USERNAME");
            var pass = Settings.Read("PASSWORD");
            var admin = Settings.Read("ADMIN");
            string command = "/C python " + Directory.GetCurrentDirectory() + "/main.py " + strip + " " + username + " " + pass + " " + admin;
            //System.Diagnostics.Process.Start("CMD.exe", command);
            /*
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = command;
            Process.Start(ps); */
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = command;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            var Logs = new IniFile("logs.ini");
            Logs.Write("COMMAND", command);
            Logs.Write("OUTPUT", output);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            var Settings = new IniFile("data.ini");
            var strip = Settings.Read("IP");
            var username = Settings.Read("USERNAME");
            var pass = Settings.Read("PASSWORD");
            var admin = Settings.Read("ADMIN");
            string command = "/C python " + Directory.GetCurrentDirectory() + "/main.py "  + Directory.GetCurrentDirectory() + "/fighting.mp4" + " " + username + " " + pass + " " + admin;
            //System.Diagnostics.Process.Start("CMD.exe", command);
            /*
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = command;
            Process.Start(ps); */
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = command;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            var Logs = new IniFile("logs.ini");
            Logs.Write("COMMAND", command);
            Logs.Write("OUTPUT", output);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            var formthietbi = new Device();
            formthietbi.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            var formInfo = new FormInfo();
            formInfo.Show();
        }
    }
}