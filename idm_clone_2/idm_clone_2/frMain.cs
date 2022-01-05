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

namespace idm_clone_2
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void tsSettings_Click(object sender, EventArgs e)
        {
            using (frmSetting frm = new frmSetting())
            {
                frm.ShowDialog();
            }
        }

        private void tsAddUrl_Click(object sender, EventArgs e)
        {
            using (frmAddUrl frm = new frmAddUrl())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frmDownload frmDownload = new frmDownload(this);
                    frmDownload.Url = frm.Url;
                    frmDownload.Show();
                }
            }
        }

        private void tsRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?? Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = listView1.SelectedItems.Count; i > 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i - 1];
                    App.DB.Files.Rows[item.Index].Delete();
                    listView1.Items[item.Index].Remove();


                    App.DB.AcceptChanges();
                    App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
                }
            }
        }

        private void frMain_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}/data.dat", Application.StartupPath);
            if (File.Exists(fileName))
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
