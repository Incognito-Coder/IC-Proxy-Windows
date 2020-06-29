using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace IC_Proxy
{
    public partial class MainForm : Form
    {
        WebClient client = new WebClient();
        String jsonstring;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("Data");
            LogBox.Text = DateTime.Now.ToString("[H:m:s]: ") + "\nHi, welcome to ic proxy.\nVersion: 1.0 - Build : 20/06/28\nStatus : idle";
        }

        private void TGLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("tg://resolve?domain=ic_mods");
            LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nopening telegram.exe";
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ServerField.Text) & string.IsNullOrEmpty(PortField.Text) & string.IsNullOrEmpty(SecretField.Text))
            {
                LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nno proxy gathered.";
            }
            else
            {
                System.Diagnostics.Process.Start("tg://proxy?server=" + ServerField.Text + "&port=" + PortField.Text + "&secret=" + SecretField.Text);
                LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nlaunching telegram.click on enable.";
            }
        }
        private void GetButton_Click(object sender, EventArgs e)
        {
            jsonstring = client.DownloadString("https://mr-incognito.ir/API/GETMTProto.php");
            //MessageBox.Show(jsonstring);
            LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\nresponse :\n" + jsonstring.ToString();
            dynamic data = JsonConvert.DeserializeObject(jsonstring);
            string address = data.ip;
            string port = data.port;
            string secret = data.secret;
            ServerField.Text = address.ToString();
            PortField.Text = port.ToString();
            SecretField.Text = secret.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("Data/Proxy-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") +".txt");
            writer.Write("tg://proxy?server=" + ServerField.Text + "&port=" + PortField.Text + "&secret=" + SecretField.Text);
            writer.Close();
            LogBox.Text = LogBox.Text + DateTime.Now.ToString("\n[H:m:s]: ") + "\ndone in : " + "Data/Proxy-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";
        }
    }
}
