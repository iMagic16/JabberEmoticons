using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net;
using System.Text;

namespace JabberEmoticons
{
    public partial class FrmAddEmoticon : Form
    {
        public FrmAddEmoticon()
        {
            InitializeComponent();
        }

        private FrmMain FrmMain = new FrmMain();
        private void FrmAddEmoticon_Load(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    string localdir = Directory.GetCurrentDirectory() + @"\temporary";
                    TxtFileLoc.Text = openFileDialog.FileName;
                    Directory.CreateDirectory(localdir);
                    if (File.Exists(localdir + "\\Emoticon.zip"))
                        File.Delete(localdir + "\\Emoticon.zip");

                    File.Copy(openFileDialog.FileName, localdir + "\\Emoticon.zip");
                    BtnSubmit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Debug_log(ex.Message);
                MessageBox.Show("Jabber Emoticons", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("By clicking OK you agree that this zip does not contain personal information, or anything that will defame or discriminate another person", "Jabber Emoticons", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                BtnBrowse.Enabled = false;
                TxtEmoticonName.Enabled = false;
                TxtEmoticonShortcut.Enabled = false;

                FrmMain.Debug_log("Creating XML");
                MakeXML(TxtEmoticonShortcut.Text, TxtEmoticonName.Text);
                FrmMain.Debug_log("Compressing into zip");
                ZipAll();
                FrmMain.Debug_log("Uploading to server");
                UploadToServer();
                MessageBox.Show("Upload complete, Let James know and he will sort out adding your emoji");
                this.Close();
            }
            else
            {
                FrmMain.Debug_log("User selected No to update");
            }



        }

        private void MakeXML(string shortcut, string name)
        {
            try
            {
                //   <emoticon defaultKey="(zzz)" image="7.png" text="Tired" order="106"/>
                string outcome;

                outcome = "<emoticon defaultKey=\"" + shortcut + "\" image=\"1x.png\" text=\"" + name + "\" order=\"11x\"/>";
                FrmMain.Debug_log("Writing... (" + outcome + ")");
                File.WriteAllText(Directory.GetCurrentDirectory() + @"\temporary\emoticonDefs.xml", outcome);

            }
            catch (Exception e)
            {
                FrmMain.Debug_log(e.Message);
                MessageBox.Show("Jabber Emoticons", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ZipAll()
        {
            try
            {
                //  FileInfo[] filesToZip = new FileInfo[2];
                //  filesToZip = "emoticonDefs.xml", TxtFileLoc.Text;

                string startPath = Directory.GetCurrentDirectory() + @"\temporary";
                string zipPath = Environment.UserName + "_" + DateTime.Today.DayOfYear + "_result.zip";
                if (File.Exists(zipPath))
                    File.Delete(zipPath);

                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            catch (Exception e)
            {
                FrmMain.Debug_log(e.Message);
                MessageBox.Show("Jabber Emoticons", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void UploadToServer()
        {
            try
            {
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://magicorp.me/" + Environment.UserName + "_" + DateTime.Today.DayOfYear + "_result.zip");
                request.Method = WebRequestMethods.Ftp.UploadFile;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential("egg", "fy16egg");

                // Copy the contents of the file to the request stream.
                StreamReader sourceStream = new StreamReader(Environment.UserName + "_" + DateTime.Today.DayOfYear + "_result.zip");
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

                response.Close();
            }
            catch (Exception e)
            {
                FrmMain.Debug_log(e.Message);
                MessageBox.Show("Jabber Emoticons", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

    }
}
