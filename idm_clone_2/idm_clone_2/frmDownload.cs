using AltoHttp;
using System;
using System.IO;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace idm_clone_2
{
    public partial class frmDownload : Form
    {
        static readonly object _lock = new object();
        public frmDownload(frMain _frmMain)
        {
            InitializeComponent();
            this.mainListView = _frmMain.listView1;

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.Url);
            FileName = System.IO.Path.GetFileName(uri.LocalPath);

            httpDownloader = new HttpDownloader(this.Url, this.downloadPath + "/" + FileName);
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.Start();
        }

        private string getDownloadPathBasedOnFileType(string fileExtension)
        {
            string[] imageExt = {".gif", ".jpg", ".jpeg", ".jpe", ".bmp", ".png"};
            string[] videoExt = {".mp4", ".mov", ".wmv", ".avi", ".flv", ".mkv"};
            string[] audioExt = {".m4a", ".mp3", ".flac", ".wav", ".wma", ".aac"};
            string[] documentExt = {".pdf", ".docx", ".xlsx", ".pptx", ".txt"};
            string[] compressedExt = {".zip", ".rar", ".gzip", ".tar", ".7z"};

            foreach (string ele in imageExt) {
                if (fileExtension == ele) { 
                    return Properties.Settings.Default.ImagePath;
                }
            }
            foreach (string ele in videoExt) {
                if (fileExtension == ele) { 
                    return Properties.Settings.Default.VideoPath;
                }
            }
            foreach (string ele in audioExt) {
                if (fileExtension == ele) { 
                    return Properties.Settings.Default.AudioPath;
                }
            }
            foreach (string ele in documentExt) {
                if (fileExtension == ele) {
                    return Properties.Settings.Default.DocumentPath;
                }
            }
            foreach (string ele in compressedExt) {
                if (fileExtension == ele) { 
                    return Properties.Settings.Default.CompressedPath;
                }
            }

            return Properties.Settings.Default.DefaultPath;
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.FileSize = httpDownloader.TotalBytesReceived;

            Database.FilesRow row = App.DB.Files.NewFilesRow();
            row.Url = Url;
            row.FileName = FileName;
            row.FileSize = (string.Format("{0:0.##} KB", FileSize / 1024));

            row.DateTime = DateTime.Now;
            App.DB.Files.AddFilesRow(row);
            App.DB.AcceptChanges();
            App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            ListViewItem item = new ListViewItem(row.Id.ToString());

            item.SubItems.Add(row.Url);
            item.SubItems.Add(row.FileName);
            item.SubItems.Add(row.FileSize);
            item.SubItems.Add(row.DateTime.ToLongDateString());
            this.Invoke((MethodInvoker)delegate
            {
                this.mainListView.Items.Add(item);
            });

            this.DialogResult = DialogResult.OK;
        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {

            progressBar.Minimum = 0;

            txtDownSpeed.Text = e.SpeedInBytes.ToHumanReadableSize() + "/s";
            lblStatus.Text = $"Downloaded {e.Progress.ToString("0.00")}%";
            progressBar.Value = int.Parse(Math.Truncate(double.Parse(e.Progress.ToString("0.00"))).ToString());
            progressBar.Update();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null) 
            {
                httpDownloader.Pause();
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    Properties.Settings.Default.ImagePath = txtPath.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        HttpDownloader httpDownloader;
        public string Url { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public double Percentage { get; set; }

        public string fileExtension { get; set; }

        public string downloadPath { get; set; }

        private ListView mainListView;

        public bool stop = false;

        private void frmDownload_Load(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.Url);
            fileExtension = System.IO.Path.GetExtension(uri.LocalPath);

            this.downloadPath = this.getDownloadPathBasedOnFileType(fileExtension);

            txtAddress.Text = Url;
            txtPath.Text = downloadPath;
            Console.WriteLine(fileExtension);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
            { 
                httpDownloader.Pause();
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null) 
            { 
                httpDownloader.Resume() ;
            }
        }
    }
}
