using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;
using System.Threading;


namespace idm_clone_2
{
    public partial class frMain : Form
    {
        public int numberOfThread = 1;

        public int maxNumOfThread = Properties.Settings.Default.MaxNumDownloadFiles;

        public frMain()
        {
            InitializeComponent();
        }

        private void tsSettings_Click(object sender, EventArgs e)
        {
            //Mở frmSetting
            using (frmSetting frm = new frmSetting())
            {
                frm.ShowDialog();
                maxNumOfThread = Properties.Settings.Default.MaxNumDownloadFiles;
            }
        }

        private void tsAddUrl_Click(object sender, EventArgs e)
        {
               // Kiểm tra số lượng thread có nhỏ hơn số lượng tối đa cho phép hay không
            if (numberOfThread <= maxNumOfThread)
            {
                new Thread(() =>
                {   
                    // tạo fragment tải xuống
                    using (frmAddUrl frm = new frmAddUrl(this))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            frmDownload frmDownload = new frmDownload(this);
                            frmDownload.Url = frm.Url;
                            DialogResult res = frmDownload.ShowDialog();

                            numberOfThread--;
                        }
                        else
                        {
                            numberOfThread--;
                        }
                    }
                })
                { IsBackground = true }.Start();
            }
            else 
            {
                //Thông báo khi số lượng thread tối đa
                MessageBox.Show("Maximum number of download", "Alert", MessageBoxButtons.OK);
            }

        
        }

        private void tsRemove_Click(object sender, EventArgs e)
        {
             //Thể hiện thông báo xác nhận xóa
            if (MessageBox.Show("Delete?? Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Lấy danh sách các dòng được lựa chọn để xóa
                for (int i = listView1.SelectedItems.Count; i > 0; i--)
                {

                    ListViewItem item = listView1.SelectedItems[i - 1];
                    App.FileManager.delete(item.Index);
                    
                    listView1.Items[item.Index].Remove();

                    
                }
            }
        }

        private void frMain_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}/data.dat", Application.StartupPath);
            if (System.IO.File.Exists(fileName))
                App.DB.ReadXml(fileName);
            foreach (Database.FilesRow row in App.DB.Files)
            {
                ListViewItem item = new ListViewItem(row.Id.ToString());
                item.SubItems.Add(row.Url);
                item.SubItems.Add(row.FileName);
                item.SubItems.Add(row.FileSize);
                item.SubItems.Add(row.DateTime.ToLongDateString());
                listView1.Items.Add(item);
            }
        }
    }
}
