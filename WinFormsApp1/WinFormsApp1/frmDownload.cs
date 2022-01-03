using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmDownload : Form
    {
        public frmDownload(frMain frm)
        {
            InitializeComponent();
            this._fmMain = frm;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.Url);
            FileName = System.IO.Path.GetFileName(uri.AbsolutePath);
            //client.DownloadFileAsync(uri, Properties.Settings.Default.Path+"/"+FileName);
            httpDownloader = new HttpDownloader(this.Url, Properties.Settings.Default.Path + "/" + FileName);
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.Start();
            
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.FileSize = httpDownloader.TotalBytesReceived;

            DataBase.FilesRow row = App.DB.Files.NewFilesRow();
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
                _fmMain.listView1.Items.Add(item);
            });

            


        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            
            progressBar.Minimum = 0;
            
            lblStatus.Text = $"Downloaded {e.Progress.ToString("0.00")}%";
            progressBar.Value = int.Parse(Math.Truncate(double.Parse(e.Progress.ToString("0.00"))).ToString());
            progressBar.Update();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //client.CancelAsync();
            httpDownloader.StopReset();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    Properties.Settings.Default.Path = txtPath.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        WebClient client;
        HttpDownloader httpDownloader;
        public string Url { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public double Percentage { get; set; }

        private frMain _fmMain;
        private void frmDownload_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadDataCompleted;
            txtAddress.Text = Url;

            txtPath.Text = Properties.Settings.Default.Path;
        }

        private void Client_DownloadDataCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
            DataBase.FilesRow row = App.DB.Files.NewFilesRow();
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
            _fmMain.listView1.Items.Add(item);
            this.Close();
        

        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            System.Console.WriteLine("Writing downed");
            progressBar.Minimum = 0;
            double receive = double.Parse(e.BytesReceived.ToString());
            FileSize = double.Parse(e.TotalBytesToReceive.ToString());
            Percentage = receive / FileSize * 100;
            lblStatus.Text = $"Downloaded {string.Format("{0:0.##}", Percentage)}";
            progressBar.Value = int.Parse(Math.Truncate(Percentage).ToString());
            progressBar.Update();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null) httpDownloader.Pause();
        }

        private void btnRemuse_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null) httpDownloader.Resume() ;
        }
    }
}
