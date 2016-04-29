using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JabberEmoticons
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }
        //todo:
        //-check for emojis/emojicount updates and have versioning similar to main prog [done]
        //-place version files into jabber emoticon place [done]
        //-serverside controlling of tools & settings 
        //-settings
        //--Auto update
        //--ver check
        //
        ///////////////////////////////////////
        public static int ProgVersion = 116;
        public static int EmojiVersion; // = Convert.ToInt32(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Cisco\Unified Communications\Jabber\CSF\CustomEmoticons\emojiversion.mup")));
        public static int EmojiCount; // = Convert.ToInt32(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Cisco\Unified Communications\Jabber\CSF\CustomEmoticons\emojicount.mup")));
        ///////////////////////////////////////


        private void FrmMain_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;

            /*         try
                     {
                         Process[] proc = Process.GetProcessesByName("JabberEmoticons");
                         proc[1].Kill();
                     }
                     catch (Exception ex)
                     {
                         Debug_log(ex.Message);
                     }*/

            AuthUser();

            Debug_log("JabberEmoticons by James W");
            Debug_log("Program loading...");

            Debug_log("Loading settings...");
            LoadSettings();


            Debug_log("Calling Setup");
            Setup(true);


     //       Debug_log("Calling DownloadEmojis");
       //     DownloadEmojis();

         //   Debug_log("Calling CopyEmojisToJabber()");
           // CopyEmojisToJabber();

            BackgroundStuff(true);
            BackgroundVerCheck();


        }

        Properties.Settings Setting = Properties.Settings.Default;

        private void SaveSettings()
        {

            //Buttons CTRL
            /*       Setting.AddEmoticonsEnabled = false;
                   Setting.UpdateEmoticonsEnabled = false;
                   Setting.UpdateProgramEnabled = false;
                   Setting.QuitProgramEnabled = false;
            */

            //Settings CTRL
            Setting.AutoCheckForUpdates = ChkAutoCheckForUpdates.Checked;
            Setting.AutoCheckForUpdatesInterval = Convert.ToInt32(TxtAutoUpdateEmoticonInterval.Text);
            Setting.AutoUpdateEmoticons = ChkAutoUpdateEmoticon.Checked;
            Setting.AutoUpdateEmoticonInterval = Convert.ToInt32(TxtAutoUpdateEmoticonInterval.Text);

            //SAVE!
            Setting.Save();

        }

        private void LoadSettings()
        {

            ChkAutoCheckForUpdates.Checked = Setting.AutoCheckForUpdates;
            TxtAutoCheckForUpdatesInterval.Text = Convert.ToString(Setting.AutoCheckForUpdatesInterval);

            ChkAutoUpdateEmoticon.Checked = Setting.AutoUpdateEmoticons;
            TxtAutoUpdateEmoticonInterval.Text = Convert.ToString(Setting.AutoCheckForUpdatesInterval);

            BtnAddEmoticons.Enabled = Setting.AddEmoticonsEnabled;
            BtnClose.Enabled = Setting.QuitProgramEnabled;
            BtnUpdateEmoticons.Enabled = Setting.UpdateEmoticonsEnabled;
            BtnUpdateProg.Enabled = Setting.UpdateProgramEnabled;
            BtnSettings.Enabled = Setting.SettingsEnabled;

        }

        private void AdminControl()
        {
            WebClient WebClient = new WebClient();
            string controlCmd = WebClient.DownloadString("http://magicorp.me/Updater/JabberEmoticons/Admin/control.m");

           // string[] controlCmdArray1 = controlCmd.Split(',');
            string[] controlCmdArray = controlCmd.Split('@');

            //1 = AddEmoticonsEnabledUpdateEmoticonsEnabledUpdateProgramEnabledQuitProgramEnabled
            string controlCmd1 = controlCmdArray[0];

            //2 = AutoCheckForUpdatesAutoCheckForUpdatesIntervalAutoUpdateEmoticonsAutoUpdateEmoticonInterval
            string controlCmd2 = controlCmdArray[1];

            string[] controlCmdArray2 = controlCmd1.Split(','); //0 AddEmoEnable 1 etc



            string[] controlCmdArray3 = controlCmd2.Split(','); // 0 AutoCheckFo 2 etc


            foreach (string word in controlCmdArray2)
            {
                Debug_log(word);
            }

            foreach(string word in controlCmdArray3)
            {
                Debug_log(word);
            }
            Console.ReadLine();

        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "swishco";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "swishco";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void AuthUser()
        {
            try
            {
                string User = Environment.UserName;
                bool AuthorisedToUse = false;
                Debug_log(User + " logged in"); //werks
                WebClient WebClient = new WebClient();
                Debug_log("Downloading authorised users...");
                string Authorised = WebClient.DownloadString("http://magicorp.me/Updater/JabberEmoticons/authorised.m");
                Debug_log("Decrypting list of users...");
                string Authorised_decrypted = Decrypt(Authorised);

                string[] lines = Authorised_decrypted.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                Debug_log("Checking authorised users are logged in...");
                foreach (string s in lines)
                {
                    if (User == s)
                    {
                        //     Debug_log(s.ToUpper() + " Logged on to this pc + Authorised");
                        AuthorisedToUse = true;
                        //   break;
                    }
                    else
                    {
                        //       Debug_log(s.ToUpper() + " Not logged on to this PC + Authorised");
                        // AuthorisedToUse = false;
                    }
                }

                if (!(AuthorisedToUse))
                {
                    Debug_log("A problem occurred");
                    Environment.Exit(1);
                }


                //   Console.ReadLine();
            }
            catch (Exception e)
            {
                Debug_log("ERROR: " + e.Message);

            }

        }

        private void Setup(bool first = false)
        {
            Debug_log("Setup()");

            //Do all the label stuff 
            try
            {
                //program update
                Debug_log("Checking for updates...");

                string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Cisco\Unified Communications\Jabber\CSF\CustomEmoticons\");



                string ChkdProgVersion = CheckForUpdates("Program");
                Debug_log("Version " + ChkdProgVersion + " found.");
                if (Convert.ToInt32(ChkdProgVersion) > ProgVersion)
                {
                    LblProgVer.ForeColor = Color.Red;
                    //   TrayIcon.Text = "Update available";
                    Debug_log("Update Available");

                    if (first == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("Update Available, Update now?", "Jabber Emoticons", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //call magicorpupdater.exe
                            Debug_log("User selected Yes to update");
                            UpdateProg();
                        }
                        else
                        {
                            Debug_log("User selected No to update");
                        }
                    }
                }
                else
                {
                    LblProgVer.ForeColor = Color.Green;
                }
                LblProgVer.Text = ProgVersion + " (" + ChkdProgVersion + ")";

                //emoticon version / update

                if (first)
                {
                    if (File.Exists(dir + "emojicount.mup"))
                        File.Delete(dir + "emojicount.mup");
                    if (File.Exists(dir + "emojiversion.mup"))
                        File.Delete(dir + "emojiversion.mup");

                    WebClient WebClient = new WebClient();
                    string URL = "http://magicorp.me/Updater/JabberEmoticons/";
                    EmojiCount = Convert.ToInt32(WebClient.DownloadString(URL + @"/Emoji/emojicount.mup"));
                    EmojiVersion = Convert.ToInt32(WebClient.DownloadString(URL + @"/Emoji/emojiversion.mup"));


                    File.WriteAllText(dir + "emojicount.mup", Convert.ToString(EmojiCount));
                    File.WriteAllText(dir + "emojiversion.mup", Convert.ToString(EmojiVersion));

                    EmojiCount = Convert.ToInt32(File.ReadAllText(dir + "emojicount.mup"));
                    EmojiVersion = Convert.ToInt32(File.ReadAllText(dir + "emojiversion.mup"));
                }

                Debug_log("Checking for emoticon updates...");
                string ChkdEmojiVersion = CheckForUpdates("Emoji");
                Debug_log("Version " + ChkdEmojiVersion + " found.");
                if (Convert.ToInt32(ChkdEmojiVersion) > EmojiVersion)
                {
                    Debug_log("New emoji version found");
                    LblEmoVer.ForeColor = Color.Red;
                }
                else
                {
                    LblEmoVer.ForeColor = Color.Green;

                }


                LblEmoVer.Text = EmojiVersion + " (" + ChkdEmojiVersion + ")";
                //    LblNoOfEmoticons.Text = EmojiCount + " (" + CheckForUpdates("Emoji", true) + ")";

                Debug_log("Checking for emoticon count updates...");
                string ChkdEmojicount = CheckForUpdates("Emoji", true);
                Debug_log("Version " + ChkdEmojicount + " found.");
                if (Convert.ToInt32(ChkdEmojicount) > EmojiCount)
                {
                    Debug_log("New emoji count version found");
                    LblNoOfEmoticons.ForeColor = Color.Red;
                }
                else
                {
                    LblNoOfEmoticons.ForeColor = Color.Green;

                }

                LblNoOfEmoticons.Text = EmojiCount + " (" + ChkdEmojicount + ")";

                //     LblEmoVer.Text = CheckForUpdates("Emoji");
                //  LblNoOfEmoticons.Text = CheckForUpdates("Emoji", true);

            }
            catch (Exception e)
            {
                Debug_log("ERROR: " + e.Message);
            }
            Debug_log("Finished Setup()");
        }

        private void DownloadEmojis()
        {
            try
            {
                //a file that contains a list of emojis? a zip to be extracted? 
                Debug_log("DownloadEmojis()");
                WebClient WebClient = new WebClient();
                string URL = "http://magicorp.me/Updater/JabberEmoticons/Emoji/";
                int EmojiCount = Convert.ToInt32(WebClient.DownloadString(URL + "emojicount.mup"));

                Debug_log("Downloading emoticonDefs.xml");
                WebClient.DownloadFile(URL + "emoticonDefs.xml", "emoticonDefs.xml");

                Debug_log("Downloading emojiversion.mup");
                WebClient.DownloadFile(URL + "emojiversion.mup", "emojiversion.mup");

                Debug_log("Downloading emojicount.mup");
                WebClient.DownloadFile(URL + "emojicount.mup", "emojicount.mup");

                EmojiCount += 1;
                for (int i = 1; i < EmojiCount; i++)
                {
                    if (File.Exists(i + ".png"))
                    {
                        Debug_log("File " + i + ".png Exists, Deleting");
                        File.Delete(i + ".png");
                    }
                    Debug_log("Downloading " + URL + i + ".png");
                    WebClient.DownloadFile(URL + i + ".png", i + ".png");
                }

            }
            catch (Exception e)
            {
                Debug_log("ERROR: " + e.Message);
            }

            Debug_log("Finished DownloadEmojis()");


        }

        private void CopyEmojisToJabber()
        {
            try
            {

                //file.copy shit, but need admin so idk | %USERPROFILE%\AppData\Roaming\Cisco\Unified Communications\Jabber\CSF\CustomEmoticons 
                Debug_log("CopyEmojisToJabber()");

                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                // Debug_log(folder);
                string dest = Path.Combine(folder, @"Cisco\Unified Communications\Jabber\CSF\CustomEmoticons\");
                //  Debug_log(dest);
                string filetocopy = "";
                EmojiCount = Convert.ToInt32(File.ReadAllText("emojicount.mup"));
                if (!(Directory.Exists(dest)))
                    Directory.CreateDirectory(dest);

                bool first = true;
                for (int i = 0; i < Convert.ToInt32(EmojiCount) + 1; i++)
                {
                    if (first)
                    {
                        filetocopy = "emojiversion.mup";
                        //    i = 0;
                        while (File.Exists(dest + filetocopy))
                        {
                            Debug_log("File exists (" + filetocopy + "), deleting");

                            File.Delete(dest + "\\" + filetocopy);
                        }
                        Debug_log("Installing " + filetocopy);
                        File.Copy(Directory.GetCurrentDirectory() + @"\" + filetocopy, dest + filetocopy);
                        //    Debug_log("Cleaning " + filetocopy);
                        File.Delete(Directory.GetCurrentDirectory() + @"\" + filetocopy);

                    }


                    if (i == 0)
                    {
                        filetocopy = "emoticonDefs.xml";
                        first = false;
                    }
                    else
                    {
                        filetocopy = i + ".png";
                    }



                    //   Debug_log(dest + filetocopy);

                    //make sure this dont exist b4 copy
                    while (File.Exists(dest + filetocopy))
                    {
                        Debug_log("File exists (" + filetocopy + "), deleting");

                        File.Delete(dest + "\\" + filetocopy);
                    }
                    //now we copy
                    Debug_log("Installing " + filetocopy);
                    File.Copy(Directory.GetCurrentDirectory() + @"\" + filetocopy, dest + filetocopy);
                    //    Debug_log("Cleaning " + filetocopy);
                    File.Delete(Directory.GetCurrentDirectory() + @"\" + filetocopy);
                }

            }
            catch (Exception e)
            {
                Debug_log("ERROR: " + e.Message);
            }

            Debug_log("Finished CopyEmojisToJabber()");
        }

        string CheckForUpdates(string ToUpdate = "", bool NoOfEmojis = false)
        {
            Debug_log("CheckForUpdates(" + ToUpdate + ", " + NoOfEmojis + ")");
            string MUPType = "version";
            try
            {
                if (NoOfEmojis)
                {
                    MUPType = "emojicount";
                    Debug_log("EmojiCount active");
                }
                if (ToUpdate == "Program")
                {
                    //shoehorning
                    ToUpdate = "";
                }
                else if (ToUpdate == "Emoji")
                {
                    if (!(NoOfEmojis))
                    {
                        MUPType = "emojiversion";
                    }
                }
                WebClient UpdateClient = new WebClient();
                string webver = UpdateClient.DownloadString("http://magicorp.me/Updater/JabberEmoticons/" + ToUpdate + "/" + MUPType + ".mup");
                Debug_log("Received " + webver);
                Debug_log("Finished CheckForUpdates(" + ToUpdate + ", " + NoOfEmojis + ")");
                return webver;
            }
            catch (Exception e)
            {
                Debug_log("ERROR: " + e.Message);
            }

            Debug_log("Finished CheckForUpdates(" + ToUpdate + ", " + NoOfEmojis + ")");

            return "You shouldn't see this";

        }

        private void UpdateProg(string version = "0")
        {
            //   await Task.Run(Action )
            try
            {
                Process.Start("MagiCorpUpdater.exe", "-p:JabberEmoticons -v:" + version + " -s:http://magicorp.me/Updater");
                Environment.Exit(1);
            }
            catch (Exception e)
            {
                Debug_log("ERROR: " + e.Message);

            }
        }

        private async void BackgroundStuff(bool FirstLaunch = false)
        {
            if (!(FirstLaunch))
            {
                // this.Hide();
                Debug_log("Sleeping for 15 mins...");
                await Task.Delay(Setting.AutoUpdateEmoticonInterval);// 900000); // divive by 1000 for seconds... 2000 = 2 seconds (once per 15 mins atm) 900000
            }
            else
            {
                await Task.Delay(5000);
                Debug_log("First launch, not waiting for long...");
            }

            if (Properties.Settings.Default.AutoCheckForUpdates)
            {
                Debug_log("Calling Setup");
                Setup();
            }

            if (Properties.Settings.Default.AutoUpdateEmoticons)
            {

                Debug_log("Calling Setup");
                Setup();


                Debug_log("Calling DownloadEmojis");
                DownloadEmojis();

                Debug_log("Calling CopyEmojisToJabber()");
                CopyEmojisToJabber();

            }
            Debug_log("Running in the background...");
            BackgroundStuff();
            //   BackgroundVerCheck();
        }

        private async void BackgroundVerCheck()
        {
            Debug_log("BackgroundVerCheck()");
            Debug_log("Waiting 30S between version checks");

            await Task.Delay(Setting.AutoCheckForUpdatesInterval);//30000);
            Debug_log("Calling Setup");
            Setup();

            AdminControl();

            Debug_log("Resuming BackgroundVerCheck()");
            BackgroundVerCheck();
        }

        #region Tray Icon

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            try
            {
                if (FormWindowState.Minimized == this.WindowState)
                {
                    Debug_log("Window minimized, hiding...");
                    TrayIcon.Visible = true;
                    TrayIcon.ShowBalloonTip(500);
                    this.Hide();
                    this.ShowInTaskbar = false;
                }

                else if (FormWindowState.Normal == this.WindowState)
                {
                    Debug_log("Window opened, unhiding...");

                    this.ShowInTaskbar = true;
                }
            }
            catch (Exception err)
            {
                Debug_log("" + err.Message);

            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Debug_log("Tray doubleclicked");
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        #endregion

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Debug_log("Insert Pressed, checking user...");
                string user = Environment.UserName;
                if (user == "jamwalsh" | user == "James")
                {
                    Debug_log("User authorised, calling DevMode()");
                    DevMode();
                }
                else
                {
                    Debug_log("User is not authorised");
                }
            }
        }

        public static string DebugLog;
        public void Debug_log(string Debugtxt)
        {
            try
            {
                DebugLog += "(" + System.DateTime.Now + "): " + Debugtxt + Environment.NewLine;
                Debugtxt = "(" + System.DateTime.Now + "): " + Debugtxt;
                TxtDebug.Text += Environment.NewLine + Debugtxt;

                File.WriteAllText("debug.log", DebugLog);//Encrypt(DebugLog));
                Console.WriteLine(Debugtxt);
            }
            catch (Exception e)
            {
                Debug_log("ERROR: " + e.Message);
            }

        }


        private void DevMode()
        {
            //default 177, 194 - extended 700, 194
            //new default 197, 311 - extended 720, 311
            //new default w/ settings - 197, 311 - extended 988, 311
            if (TxtDebug.Enabled == true)
            {
                TxtDebug.Enabled = false;
                Size = new Size(197, 311);
            }
            else
            {
                TxtDebug.Enabled = true;
                Size = new Size(988, 311);
            }
        }

        private void BtnUpdateEmoticon(object sender, EventArgs e)
        {
            Debug_log("Force update emoticons");
            GrpEmoticons.Enabled = false;
            GrpProgram.Enabled = false;

            Debug_log("Calling Setup");
            Setup();

            Debug_log("Calling DownloadEmojis");
            DownloadEmojis();

            Debug_log("Calling CopyEmojisToJabber()");
            CopyEmojisToJabber();

            GrpEmoticons.Enabled = true;
            GrpProgram.Enabled = true;
            MessageBox.Show("Emoticons Update Success", "Jabber Emoticons", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExit(object sender, EventArgs e)
        {
            Debug_log("Exiting program...");
            Environment.Exit(1);
            // this.WindowState = FormWindowState.Minimized;
        }

        private void BtnUpdateProg_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update now?", "Jabber Emoticons", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                //call magicorpupdater.exe
                Debug_log("User selected Yes to update");
                UpdateProg();
            }
            else
            {
                Debug_log("User selected No to update");
            }
            //UpdateProg("0");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug_log("Minimizing on close...");
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAddEmoticons_Click(object sender, EventArgs e)
        {
            Debug_log("Open AddEmoticons form..");
            FrmAddEmoticon FrmAddEmoticon = new FrmAddEmoticon();
            FrmAddEmoticon.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //new default w/ settings - 197, 311 - extended settings 405, 311
            if (GpSettings.Enabled == true)
            {
                GpSettings.Enabled = false;
                Size = new Size(197, 311);
            }
            else
            {
                GpSettings.Enabled = true;
                Size = new Size(405, 311);
            }
        }

        private void ChkAutoUpdateEmoticon_CheckedChanged(object sender, EventArgs e)
        {
            //SaveSettings();
        }

        private void TxtAutoUpdateEmoticonInterval_TextChanged(object sender, EventArgs e)
        {
            //SaveSettings();
        }

        private void ChkAutoCheckForUpdates_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void TxtAutoCheckForUpdatesInterval_TextChanged(object sender, EventArgs e)
        {
            //SaveSettings();
        }
    }
}
