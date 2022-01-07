using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace idm_clone_2
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnBrowseDefault_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                    txtPathDefault.Text = fdb.SelectedPath;
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                    txtPathImage.Text = fdb.SelectedPath;
            }
        }

        private void btnBrowseVideo_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                    txtPathVideo.Text = fdb.SelectedPath;
            }
        }

        private void btnBrowseAudio_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                    txtPathAudio.Text = fdb.SelectedPath;
            }
        }

        private void btnBrowseDocument_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                    txtPathDocument.Text = fdb.SelectedPath;
            }
        }

        private void btnBrowseExecutable_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                    txtPathExecutable.Text = fdb.SelectedPath;
            }
        }

        private void btnBrowseCompressed_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                    txtPathCompressed.Text = fdb.SelectedPath;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPathDefault.Text) || string.IsNullOrEmpty(txtPathAudio.Text) || string.IsNullOrEmpty(txtPathVideo.Text) ||
                string.IsNullOrEmpty(txtPathImage.Text) || string.IsNullOrEmpty(txtPathDocument.Text) || string.IsNullOrEmpty(txtPathExecutable.Text))
            {
                MessageBox.Show("Please select your path", "Alert", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(txtMaxDownloadClients.Text)) 
            { 
                MessageBox.Show("Please enter max download clients ", "Alert", MessageBoxButtons.OK);
            }
            /*
            else if (!string.IsNullOrEmpty(txtPathDefault.Text))
            {
                Properties.Settings.Default.DefaultPath = txtPathDefault.Text;
                Properties.Settings.Default.Save();
            } 
            else if (!string.IsNullOrEmpty(txtPathImage.Text))
            {
                Properties.Settings.Default.ImagePath = txtPathImage.Text;
                Properties.Settings.Default.Save();
            } 
            else if (!string.IsNullOrEmpty(txtPathVideo.Text))
            {
                Properties.Settings.Default.VideoPath = txtPathVideo.Text;
                Properties.Settings.Default.Save();
            } 
            else if (!string.IsNullOrEmpty(txtPathAudio.Text))
            {
                Properties.Settings.Default.AudioPath = txtPathAudio.Text;
                Properties.Settings.Default.Save();
            } 
            else if (!string.IsNullOrEmpty(txtPathDocument.Text))
            {
                Properties.Settings.Default.DocumentPath = txtPathDocument.Text;
                Properties.Settings.Default.Save();
            } 
            else if (!string.IsNullOrEmpty(txtPathExecutable.Text))
            {
                Properties.Settings.Default.ExecutablePath = txtPathExecutable.Text;
                Properties.Settings.Default.Save();
            } 
            */
            else
            {
                Properties.Settings.Default.DefaultPath = txtPathDefault.Text;
                Properties.Settings.Default.ImagePath = txtPathImage.Text;
                Properties.Settings.Default.VideoPath = txtPathVideo.Text;
                Properties.Settings.Default.AudioPath = txtPathAudio.Text;
                Properties.Settings.Default.DocumentPath = txtPathDocument.Text;
                Properties.Settings.Default.ExecutablePath = txtPathExecutable.Text;

                Properties.Settings.Default.MaxNumDownloadFiles = Convert.ToInt32(txtMaxDownloadClients.Text);

                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
            }

        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            this.txtPathDefault.Text = Properties.Settings.Default.DefaultPath;
            this.txtPathImage.Text = Properties.Settings.Default.ImagePath;
            this.txtPathVideo.Text = Properties.Settings.Default.VideoPath;
            this.txtPathAudio.Text = Properties.Settings.Default.AudioPath;
            this.txtPathDocument.Text = Properties.Settings.Default.DocumentPath;
            this.txtPathCompressed.Text = Properties.Settings.Default.CompressedPath;
            this.txtPathExecutable.Text = Properties.Settings.Default.ExecutablePath;

            this.txtMaxDownloadClients.Text = Convert.ToString(Properties.Settings.Default.MaxNumDownloadFiles);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPathCompressed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPathExecutable_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPathDocument_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPathAudio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPathVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPathImage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
