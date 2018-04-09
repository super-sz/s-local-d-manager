using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;
using System.IO;

namespace SQLLOCALDB_MANAGER
{
    public partial class Main : Form
    {
        public bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public Main()
        {
            InitializeComponent();
        }

        public string DATABASE_PATH = Environment.GetEnvironmentVariable("UserProfile");

        private void Main_Load(object sender, EventArgs e)
        {
            Directory.Text = DATABASE_PATH;
        }

        private void BrowseDirectory_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Sélection du fichier MDF à attacher";
            fdlg.InitialDirectory = DATABASE_PATH;
            fdlg.Filter = "Fichiers MDF (*.mdf)|*.mdf|Tous les fichiers (*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Directory.Text = fdlg.FileName;
            }
        }

        private void AttachDatabase_Click(object sender, EventArgs e)
        {
            string DataFullPath = Directory.Text;
            string DataPath = Path.GetDirectoryName(DataFullPath);
            string DatabaseName = Path.GetFileNameWithoutExtension(DataFullPath);
            string instanceName = instanceNameTextbox.Text;
            if (instanceName.Length == 0)
                LocalDB.InstanceNameError();
            else
            {
                if (!File.Exists(DataFullPath))
                    LocalDB.FileNotExist();
                else
                    LocalDB.MAKE_DATABASE(DatabaseName, DataPath, instanceName);
            }
        }

        public void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            Console.WriteLine(outLine.Data);
        }

        public void cmdExecute(string args)
        {
            string instanceName = TextBoxInstanceNameGestion.Text;
            if (instanceName.Length == 0)
                LocalDB.InstanceNameError();
            else
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "CMD.exe";
                proc.StartInfo.Arguments = "/c sqllocaldb " + args + " " + instanceName + "";
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
                proc.Start();
                proc.BeginErrorReadLine();
                textBox_Read.Text = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();
                Refresh();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            cmdExecute("create");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cmdExecute("start");
        }

        private void btnInfos_Click(object sender, EventArgs e)
        {
            cmdExecute("info");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cmdExecute("stop");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmdExecute("delete");
        }
    }
}
