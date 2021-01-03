using Newtonsoft.Json;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using WECPOFLogic;

namespace IC_Proxy
{
    public partial class MainForm : Form
    {
        WebClient client = new WebClient();
        String jsonstring;
        public MainForm()
        {
            InitializeComponent();
            MessageBoxManager.Register();
        }
        private void ABOUT_BUTTONS()
        {
            MessageBoxManager.Yes = "Github";
            MessageBoxManager.No = "Website";
            MessageBoxManager.Cancel = "Close";

        }
        private void UPDATE_BUTTONS()
        {
            MessageBoxManager.Yes = "Download";
            MessageBoxManager.No = "Later";

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("Data");
            LogBox.Text = DateTime.Now.ToString("[H:m:s]: ") + "\nHi, welcome to ic proxy.\nVersion: 2.5 - Build : 20/09/09\nStatus : idle";
        }

        private void TGLink_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tg://resolve?domain=ic_mods");
                LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nopening telegram.exe";
            }
            catch (Exception)
            {
                MessageBox.Show("Telegram messenger not found on this machine.");
                LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nno tg process available.";
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ServerField.Text) & string.IsNullOrEmpty(PortField.Text) & string.IsNullOrEmpty(SecretField.Text))
            {
                LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nno proxy gathered.";
            }
            else
            {
                try
                {
                    System.Diagnostics.Process.Start("tg://proxy?server=" + ServerField.Text + "&port=" + PortField.Text + "&secret=" + SecretField.Text);
                    LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nlaunching telegram.click on enable.";
                }
                catch (Exception)
                {
                    MessageBox.Show("Telegram messenger not found on this machine.");
                    LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nlaunch error.maybe telegram not installled.";
                }
            }
        }
        private void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                jsonstring = client.DownloadString("https://mr-alireza.ir/Proxy/server.json");
                //MessageBox.Show(jsonstring);
                LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nresponse :\n" + jsonstring.ToString();
                dynamic data = JsonConvert.DeserializeObject(jsonstring);
                string address = data.ip;
                string port = data.port;
                string secret = data.secret;
                string ptime = data.ping;
                ServerField.Text = address.ToString();
                PortField.Text = port.ToString();
                SecretField.Text = secret.ToString();
                ping.Text = "Ping : " + ptime.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("Data/Proxy-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt");
            writer.Write("tg://proxy?server=" + ServerField.Text + "&port=" + PortField.Text + "&secret=" + SecretField.Text);
            writer.Close();
            LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\ndone in : " + "Data/Proxy-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";
        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void SystemTrayICON_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ABOUT_Click(object sender, EventArgs e)
        {
            ABOUT_BUTTONS();
            DialogResult result;
            result = MessageBox.Show("This application written in C# and free for use.\nRelease: 2020/09/09 v2.5\nDeveloper: Incognito Coder", "about this tool ", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Process.Start("https://github.com/Incognito-Coder");
            }
            else if (result == DialogResult.No)
            {
                Process.Start("https://mr-incognito.ir");
            }
            else
            {

            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ActiveForm.Hide();
            }
        }
        public string CurrentVersion
        {
            get
            {
                return ApplicationDeployment.IsNetworkDeployed
                       ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                       : Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        private void UPDATE_Click(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            jsonstring = client.DownloadString("https://mr-incognito.ir/ICProxy/win/updater.php");
            dynamic data = JsonConvert.DeserializeObject(jsonstring);
            string ver = data.version;
            string url = data.url;
            if (ver == CurrentVersion)
            {
                MessageBox.Show("You are on latest version.", "Updater");
            }
            else if (ver != CurrentVersion)
            {
                UPDATE_BUTTONS();
                DialogResult result;
                result = MessageBox.Show("New update found.\nversion : " + ver, "Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    string download = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    string file = System.IO.Path.GetFileName(url);
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(url, download + "/" + file);
                    MessageBox.Show("Downloaded in : " + download + "/" + file + "\nExtract zip and open app.", "Download Complete");
                }
                else
                {
                    MessageBox.Show("Internet connection error or server is down.", "Error");
                }
            }
        }
    }
}
