using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Net;

namespace Vysor_Pro_Patcher
{
    public partial class Principal : Form
    {
        string baseFolder;
        string chromeExtensionsFolder;
        string vysorFolder;

        public static bool CheckInternet()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool TryVersion(string version)
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.leparadoxhd.com/crack/vysor/" + version + "/uglify.js"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            source.SelectedIndex = 0;
            // ToolTip
            ToolTip toolTipOffline = new ToolTip();
            toolTipOffline.AutoPopDelay = 500000;
            toolTipOffline.InitialDelay = 500;
            toolTipOffline.ReshowDelay = 500;
            toolTipOffline.ShowAlways = true;
            toolTipOffline.SetToolTip(this.offline, "Si se activa, no se usará el archivo parcheado desde internet, se intentará parchear manualmente.");
            status.Text = "Verifying Vysor...";
            baseFolder = Environment.GetEnvironmentVariable("LocalAppData");
            switch (source.Text)
            {
                case "Default":
                    chromeExtensionsFolder = baseFolder + "\\Google\\Chrome\\User Data\\Default\\Extensions";
                    break;
                case "ChromeDefaultData":
                    chromeExtensionsFolder = baseFolder + "\\Google\\Chrome\\User Data\\ChromeDefaultData\\Extensions";
                    break;
            }
            vysorFolder = chromeExtensionsFolder + "\\gidgenkbbabolejbgbpnhbimgjbffefm";
            if (!Directory.Exists(vysorFolder))
            {
                status.Text = "Vysor App Not Found :(";
            } else
            {
                status.Text = "Verifying Vysor Version...";
                var directory = new DirectoryInfo(vysorFolder);
                var vysorVersion = directory.GetDirectories()
                .OrderByDescending(f => f.LastWriteTime)
                .First();
                var version = vysorVersion.ToString().Substring(0, vysorVersion.ToString().Length - 2);
                status.Text = "Vysor: " + version;
            }
        }

        private void Paso1()
        {
            status.Text = "Verifying Vysor Version...";
            var directory = new DirectoryInfo(vysorFolder);
            var vysorVersion = directory.GetDirectories()
            .OrderByDescending(f => f.LastWriteTime)
            .First();
            var version = vysorVersion.ToString().Substring(0, vysorVersion.ToString().Length - 2);
            status.Text = "Vysor: " + version;
            while (!CheckInternet())
            {
                DialogResult internet = MessageBox.Show("Network Connection not found :(", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (internet == DialogResult.Cancel)
                {
                    System.Environment.Exit(1);
                }
                if (CheckInternet())
                {
                    break;
                }
            }

            if (TryVersion(version))
            {
                if (!offline.Checked)
                {
                    if (File.Exists(vysorFolder + "\\" + version + "_0" + "\\uglify.js"))
                    {
                        File.Delete(vysorFolder + "\\" + version + "_0" + "\\uglify.js");
                    }
                }
                Directory.SetCurrentDirectory(vysorFolder + "\\" + version + "_0");
                if ( offline.Checked )
                {
                    string text = File.ReadAllText("uglify.js");
                    text = text.Replace("this.licensed=false", "this.licensed=true");
                    text = text.Replace("this.licenseCached=false", "this.licenseCached=true");
                    File.WriteAllText("uglify.js", text);
                } else
                {
                    WebClient uglify = new WebClient();
                    uglify.DownloadFile("http://www.leparadoxhd.com/crack/vysor/" + version + "/uglify.js", "uglify.js");
                }
                status.Text = "¡Patched!";
                Process vysor = Process.Start("chrome.exe", "--app-id=gidgenkbbabolejbgbpnhbimgjbffefm");
                Thread.Sleep(2000);
                if ( vysor != null )
                {
                    Process[] vysorPid = Process.GetProcessesByName("chrome");
                    foreach ( Process pid in vysorPid )
                    {
                        pid.Kill();
                    }
                }
                Process.Start("chrome.exe", "--app-id=gidgenkbbabolejbgbpnhbimgjbffefm");
            } else
            {
                MessageBox.Show("I still have not done a crack :(", "Almost There", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult abrirWeb = MessageBox.Show("Do you want to alert me a new version has been released?", 
                    "Leave me a comment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if ( abrirWeb == DialogResult.Yes )
                {
                    Process.Start("https://www.youtube.com/watch?v=G36c-_BdoME#comment-section-renderer");
                }
            }
        }

        private void begin_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(vysorFolder))
            {
                status.Text = "Vysor App Not Found.";
            }
            else
            {
                Paso1();
            }
        }

        
    }
}
