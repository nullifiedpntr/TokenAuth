using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace TokenAuthv2
{
    public partial class Form1 : Form
    {
        private string pcname = Environment.UserName.ToString();
        private string directory = Environment.ProcessPath.Replace(AppDomain.CurrentDomain.FriendlyName + ".exe", String.Empty);
        public Form1()
        {
            InitializeComponent();
        }
        private Boolean mouseDown;
        private Point lastLocation;

        private void button2_Click(object sender, EventArgs e)
        {
            CleanUp();
            Application.Exit();
        }

        private void TokenAuth_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation.X = e.X;
            lastLocation.Y = e.Y;
            mouseDown = true;
        }

        private void TokenAuth_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                Location = new Point(currentScreenPosition.X - lastLocation.X, currentScreenPosition.Y - lastLocation.Y);
            }
        }

        private void TokenAuth_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public async Task CheckLibraries()
        {
            if (!Directory.Exists("C:\\Users\\" + pcname + "\\AppData\\Roaming\\ExodusLibs"))
            {
                Directory.CreateDirectory("C:\\Users\\" + pcname + "\\AppData\\Roaming\\ExodusLibs");
                richTextBox1.Text += "[+] Library folder missing, creating folder ExodusLibs" + Environment.NewLine;
            }
            if (!Directory.Exists("C:\\Users\\" + pcname + "\\AppData\\Roaming\\ExodusLibs\\libraries") && !Directory.Exists("C:\\Users\\" + pcname + "\\AppData\\Roaming\\ExodusLibs\\natives"))
            {
                richTextBox1.Text += "[+] Libraries missing, download them and retry." + Environment.NewLine;
                button1.Enabled = false;
            }
            else
            {
                richTextBox1.Text += "[+] Passed library check" + Environment.NewLine;

            }
        }

        private void CheckJava()
        {

            string filePath = GetJavaInstallationPath();
            string file = filePath + "java.exe";
            if (!System.IO.File.Exists(file))
            {
                richTextBox1.Text += "[+] Cannot find Java installation. Please reinstall jre1.8.0_131 and try again." + Environment.NewLine;
                button1.Enabled = false;
            } else
            {
                richTextBox1.Text += "[+] Found Java installation!" + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            CheckLibraries();
            CheckJava();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CleanUp();
            button1.Text = "Launching JNI...";
            Invalidate();
            Refresh();
            richTextBox1.Text += "[+] Extracting 1.8.8 jar into assembly directory" + Environment.NewLine;
            Extract("TokenAuthv2", "1.8.8.jar", directory);
            Thread.Sleep(150);
            StartMinecraft();
            richTextBox1.Text += "[+] Launching game with session id " + token.Text + Environment.NewLine;
            button1.Text = "Launch";
            button1.Enabled = false;
        }

        private string GetJavaInstallationPath()
        {
            return @"C:\Program Files\Java\jre1.8.0_131\bin\";
        }

        private void CleanUp()
        {
            if (File.Exists(directory + "1.8.8.jar"))
            {
                File.Delete(directory + "1.8.8.jar");
            }
        }

        private void StartMinecraft()
        {
            string text = Environment.UserName.ToString();
            string javaInstallationPath = GetJavaInstallationPath();
            string text2 = javaInstallationPath + "javaw.exe";
            if (File.Exists(text2))
            {
                string text3 = "C:\\Users\\" + text + "\\AppData\\Roaming\\ExodusLibs\\";
                Process process = new Process();
                process.StartInfo.FileName = text2;
                process.StartInfo.CreateNoWindow = false;
                string text5 = "-Xms2024M -Xmx2024M -XX:+UnlockExperimentalVMOptions -XX:G1NewSizePercent=19 -XX:MaxGCPauseMillis=34 -Djava.library.path=" + text3 + "natives -cp " + directory + "1.8.8.jar;" + text3 + "libraries\\authlib-1.5.21.jar;" + text3 + "libraries\\codecjorbis-20101023.jar;" + text3 + "libraries\\codecwav-20101023.jar;" + text3 + "libraries\\commons-codec-1.9.jar;" + text3 + "libraries\\commons-compress-1.8.1.jar;" + text3 + "libraries\\commons-io-2.4.jar;" + text3 + "libraries\\commons-lang3-3.3.2.jar;" + text3 + "libraries\\commons-logging-1.1.3.jar;" + text3 + "libraries\\gson-2.2.4.jar;" + text3 + "libraries\\guava-17.0.jar;" + text3 + "libraries\\httpclient-4.3.3.jar;" + text3 + "libraries\\httpcore-4.3.2.jar;" + text3 + "libraries\\icu4j-core-mojang-51.2.jar;" + text3 + "libraries\\jinput-2.0.5.jar;" + text3 + "libraries\\jinput-platform-2.0.5-natives-windows.jar;" + text3 + "libraries\\jna-3.4.0.jar;" + text3 + "libraries\\jopt-simple-4.6.jar;" + text3 + "libraries\\jutils-1.0.0.jar;" + text3 + "libraries\\libraryjavasound-20101123.jar;" + text3 + "libraries\\librarylwjglopenal-20100824.jar;" + text3 + "libraries\\openauth-1.1.2.jar;" + text3 + "libraries\\log4j-api-2.0-beta9.jar;" + text3 + "libraries\\log4j-core-2.0-beta9.jar;" + text3 + "libraries\\lwjgl_util-2.9.4-nightly-20150209.jar;" + text3 + "libraries\\lwjgl-2.9.4-nightly-20150209.jar;" + text3 + "libraries\\lwjgl-platform-2.9.4-nightly-20150209-natives-windows.jar;" + text3 + "libraries\\netty-1.6.jar;" + text3 + "libraries\\netty-all-4.0.23.Final.jar;" + text3 + "libraries\\oshi-core-1.1.jar;" + text3 + "libraries\\platform-3.4.0.jar;" + text3 + "libraries\\realms-1.7.39.jar;" + text3 + "libraries\\soundsystem-20120107.jar;" + text3 + "libraries\\twitch-6.5.jar;" + text3 + "libraries\\twitch-external-platform-4.5-natives-windows-64.jar;" + text3 + "libraries\\twitch-platform-6.5-natives-windows-64.jar net.minecraft.client.main.Main --width 854 --height 480 --username " + name.Text + " --version 1.8 --gameDir C:\\Users\\" + text + "\\AppData\\Roaming\\.minecraft --assetsDir C:\\Users\\" + text + "\\AppData\\Roaming\\.minecraft\\assets  --assetIndex 1.8 + --uuid " + uuid.Text + " --accessToken " + token.Text + " --userType microsoft";
                process.StartInfo.Arguments = text5.ToString();
                //Thread.Sleep(100);
                process.Start();
            }
        }

        private static void Extract(string NameSpace, string FileName, string OutputDirectory)
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            using Stream stream = assembly.GetManifestResourceStream($"{NameSpace}.{FileName}");
            using BinaryReader Binary_Reader = new BinaryReader(stream);
            using FileStream fs = new FileStream(Path.Combine(OutputDirectory, FileName), FileMode.OpenOrCreate);
            using BinaryWriter Binary_Writer = new BinaryWriter(fs);
            Binary_Writer.Write(Binary_Reader.ReadBytes((int)stream.Length));
        }
    }
}
