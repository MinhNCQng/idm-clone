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
        //Thêm một đường dẫn tải
        private void btnOK_Click(object sender, EventArgs e)
        {
            //Kiểm tra nếu người dùng chưa nhập đường dẫn sẽ thông báo lỗi
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
            //Đóng giao diện và trả lại kết quả hủy
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            validation.setValidationStragegy(new UrlValidator());
            if (validation.checkValidate(txtUrl.Text)) { lbCheck.Text = "Valid url"; btnOK.Enabled=true; return; }
            btnOK.Enabled = false;
            validation.setValidationStragegy(new NumberValidator());
            if (validation.checkValidate(txtUrl.Text)) { lbCheck.Text = "Number is not valid url"; return; }
            lbCheck.Text = "Url is not valid";
        }
    }
}
