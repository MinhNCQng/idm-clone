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
        //khởi tạo chức năng download và gán fragment Main vào đây để có thể access danh sách tải 
        public frmDownload(frMain _frmMain)
        {
            
            InitializeComponent();
            this.mainListView = _frmMain.listView1;

            Control.CheckForIllegalCrossThreadCalls = false;
        }
        //Xử lý khi ấn nút start download
        private void btnStart_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.Url);
            //Lấy tên file
            FileName = System.IO.Path.GetFileName(uri.LocalPath);
            //Object phục vụ việc tải xuống
            httpDownloader = new HttpDownloader(this.Url, this.downloadPath + "/" + FileName);
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            
            DownloadCommand = new DownloadControllCommandAdvanced(httpDownloader, btnStart, btnResume, btnPause);
            DownloadCommand.execute("Start");
        }
        //phân loại đường dẫn theo dạng tệp
        private string getDownloadPathBasedOnFileType(string fileExtension)
        {

            FileTypeFactory fileType = new FileTypeFactory();
            fileType.findFileType(fileExtension);
            //Console.WriteLine(fileType.getFilePath());
            return fileType.getFilePath();
        }
        //Xử lý khi file tải hoàn thành
        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {

            File newFile = new File();
            newFile.FileSize = httpDownloader.TotalBytesReceived;
            newFile.Url = Url;
            newFile.FileName = FileName;
            newFile.dateTime = DateTime.Now;

            FileManagerDAO fileManager = App.FileManager;
            fileManager.add(newFile);
            ListViewItem item = new ListViewItem(newFile.Id.ToString());
            //Thêm một hàng vào grid dữ liệu
            item.SubItems.Add(newFile.Url);
            item.SubItems.Add(newFile.FileName);
            item.SubItems.Add(newFile.FileSize.ToString());
            item.SubItems.Add(newFile.dateTime.ToLongDateString());
            this.Invoke((MethodInvoker)delegate
            {
                this.mainListView.Items.Add(item);
            });

            this.DialogResult = DialogResult.OK;
        }
        //Xử lý thanh progress bar
        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {

            progressBar.Minimum = 0;
            //Lấy thông tin dữ liệu tải về
            txtDownSpeed.Text = e.SpeedInBytes.ToHumanReadableSize() + "/s";
            lblStatus.Text = $"Downloaded {e.Progress.ToString("0.00")}%";
            progressBar.Value = int.Parse(Math.Truncate(double.Parse(e.Progress.ToString("0.00"))).ToString());
            progressBar.Update();
        }
        //Nút dừng
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null) 
            {
                httpDownloader.Pause();
                this.DialogResult = DialogResult.Cancel;
            }
            
        }
        //Thay đổi đường dẫn
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

        public DownloadControllCommandAdvanced DownloadCommand;
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
        //Dừng tải
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (DownloadCommand != null)
            {
                DownloadCommand.execute("Pause");
            }
        }
        //Tiếp tục tải
        private void btnResume_Click(object sender, EventArgs e)
        {
            if (DownloadCommand != null) 
            {
                DownloadCommand.execute("Resume");
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            this.downloadPath = txtPath.Text;
        }
    }
}
