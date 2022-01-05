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
        public frmAddUrl()
        {
            InitializeComponent();
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
                        break;
                    default:
                        this.DialogResult = DialogResult.Cancel;
                        break;
                }
            }
            else
            { 
                this.Url = txtUrl.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
