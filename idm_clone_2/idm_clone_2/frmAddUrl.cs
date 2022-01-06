using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace idm_clone_2
{
    public partial class frmAddUrl : Form
    {
        static readonly object _lock = new object();

        public frmAddUrl(frMain _frmMain)
        {
            InitializeComponent();
            lock (_lock) { 
                _frmMain.numberOfThread++;
            }
        }

        public string Url { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUrl.Text))
            {
                DialogResult result = MessageBox.Show("Please enter URL !!!", "No URL", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.OK:
                        this.DialogResult = DialogResult.None;
                        break;
                    case DialogResult.Cancel:
                        this.DialogResult = DialogResult.Cancel;
                        //this.Close();
                        break;
                    default:
                        this.DialogResult = DialogResult.Cancel;
                        //this.Close();
                        break;
                }
            }
            else
            { 
                this.Url = txtUrl.Text;
                //this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }
    }
}
