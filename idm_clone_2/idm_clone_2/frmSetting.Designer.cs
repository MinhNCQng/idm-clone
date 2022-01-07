
namespace idm_clone_2
{
    partial class frmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxDownloadClients = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseAudio = new System.Windows.Forms.Button();
            this.txtPathExecutable = new System.Windows.Forms.TextBox();
            this.txtPathAudio = new System.Windows.Forms.TextBox();
            this.btnBrowseExecutable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.txtPathCompressed = new System.Windows.Forms.TextBox();
            this.txtPathVideo = new System.Windows.Forms.TextBox();
            this.btnBrowseCompressed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.txtPathDocument = new System.Windows.Forms.TextBox();
            this.txtPathImage = new System.Windows.Forms.TextBox();
            this.btnBrowseDocument = new System.Windows.Forms.Button();
            this.btnBrowseDefault = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPathDefault = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(487, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Max Clients Download";
            // 
            // txtMaxDownloadClients
            // 
            this.txtMaxDownloadClients.Location = new System.Drawing.Point(148, 19);
            this.txtMaxDownloadClients.Name = "txtMaxDownloadClients";
            this.txtMaxDownloadClients.Size = new System.Drawing.Size(396, 20);
            this.txtMaxDownloadClients.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Audio Path";
            // 
            // btnBrowseAudio
            // 
            this.btnBrowseAudio.Location = new System.Drawing.Point(500, 100);
            this.btnBrowseAudio.Name = "btnBrowseAudio";
            this.btnBrowseAudio.Size = new System.Drawing.Size(33, 20);
            this.btnBrowseAudio.TabIndex = 10;
            this.btnBrowseAudio.Text = "...";
            this.btnBrowseAudio.UseVisualStyleBackColor = true;
            this.btnBrowseAudio.Click += new System.EventHandler(this.btnBrowseAudio_Click);
            // 
            // txtPathExecutable
            // 
            this.txtPathExecutable.Location = new System.Drawing.Point(121, 153);
            this.txtPathExecutable.Name = "txtPathExecutable";
            this.txtPathExecutable.Size = new System.Drawing.Size(374, 20);
            this.txtPathExecutable.TabIndex = 12;
            this.txtPathExecutable.TextChanged += new System.EventHandler(this.txtPathExecutable_TextChanged);
            // 
            // txtPathAudio
            // 
            this.txtPathAudio.Location = new System.Drawing.Point(121, 101);
            this.txtPathAudio.Name = "txtPathAudio";
            this.txtPathAudio.Size = new System.Drawing.Size(374, 20);
            this.txtPathAudio.TabIndex = 9;
            this.txtPathAudio.TextChanged += new System.EventHandler(this.txtPathAudio_TextChanged);
            // 
            // btnBrowseExecutable
            // 
            this.btnBrowseExecutable.Location = new System.Drawing.Point(500, 152);
            this.btnBrowseExecutable.Name = "btnBrowseExecutable";
            this.btnBrowseExecutable.Size = new System.Drawing.Size(33, 20);
            this.btnBrowseExecutable.TabIndex = 13;
            this.btnBrowseExecutable.Text = "...";
            this.btnBrowseExecutable.UseVisualStyleBackColor = true;
            this.btnBrowseExecutable.Click += new System.EventHandler(this.btnBrowseExecutable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Video Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Executable Path";
            // 
            // btnBrowseVideo
            // 
            this.btnBrowseVideo.Location = new System.Drawing.Point(500, 74);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(33, 20);
            this.btnBrowseVideo.TabIndex = 7;
            this.btnBrowseVideo.Text = "...";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            this.btnBrowseVideo.Click += new System.EventHandler(this.btnBrowseVideo_Click);
            // 
            // txtPathCompressed
            // 
            this.txtPathCompressed.Location = new System.Drawing.Point(121, 179);
            this.txtPathCompressed.Name = "txtPathCompressed";
            this.txtPathCompressed.Size = new System.Drawing.Size(374, 20);
            this.txtPathCompressed.TabIndex = 15;
            this.txtPathCompressed.TextChanged += new System.EventHandler(this.txtPathCompressed_TextChanged);
            // 
            // txtPathVideo
            // 
            this.txtPathVideo.Location = new System.Drawing.Point(121, 75);
            this.txtPathVideo.Name = "txtPathVideo";
            this.txtPathVideo.Size = new System.Drawing.Size(374, 20);
            this.txtPathVideo.TabIndex = 6;
            this.txtPathVideo.TextChanged += new System.EventHandler(this.txtPathVideo_TextChanged);
            // 
            // btnBrowseCompressed
            // 
            this.btnBrowseCompressed.Location = new System.Drawing.Point(500, 178);
            this.btnBrowseCompressed.Name = "btnBrowseCompressed";
            this.btnBrowseCompressed.Size = new System.Drawing.Size(33, 20);
            this.btnBrowseCompressed.TabIndex = 16;
            this.btnBrowseCompressed.Text = "...";
            this.btnBrowseCompressed.UseVisualStyleBackColor = true;
            this.btnBrowseCompressed.Click += new System.EventHandler(this.btnBrowseCompressed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Image Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Compressed Path";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(500, 48);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(33, 20);
            this.btnBrowseImage.TabIndex = 4;
            this.btnBrowseImage.Text = "...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // txtPathDocument
            // 
            this.txtPathDocument.Location = new System.Drawing.Point(121, 127);
            this.txtPathDocument.Name = "txtPathDocument";
            this.txtPathDocument.Size = new System.Drawing.Size(374, 20);
            this.txtPathDocument.TabIndex = 18;
            this.txtPathDocument.TextChanged += new System.EventHandler(this.txtPathDocument_TextChanged);
            // 
            // txtPathImage
            // 
            this.txtPathImage.Location = new System.Drawing.Point(121, 49);
            this.txtPathImage.Name = "txtPathImage";
            this.txtPathImage.Size = new System.Drawing.Size(374, 20);
            this.txtPathImage.TabIndex = 3;
            this.txtPathImage.TextChanged += new System.EventHandler(this.txtPathImage_TextChanged);
            // 
            // btnBrowseDocument
            // 
            this.btnBrowseDocument.Location = new System.Drawing.Point(500, 126);
            this.btnBrowseDocument.Name = "btnBrowseDocument";
            this.btnBrowseDocument.Size = new System.Drawing.Size(33, 20);
            this.btnBrowseDocument.TabIndex = 19;
            this.btnBrowseDocument.Text = "...";
            this.btnBrowseDocument.UseVisualStyleBackColor = true;
            this.btnBrowseDocument.Click += new System.EventHandler(this.btnBrowseDocument_Click);
            // 
            // btnBrowseDefault
            // 
            this.btnBrowseDefault.Location = new System.Drawing.Point(500, 22);
            this.btnBrowseDefault.Name = "btnBrowseDefault";
            this.btnBrowseDefault.Size = new System.Drawing.Size(33, 20);
            this.btnBrowseDefault.TabIndex = 1;
            this.btnBrowseDefault.Text = "...";
            this.btnBrowseDefault.UseVisualStyleBackColor = true;
            this.btnBrowseDefault.Click += new System.EventHandler(this.btnBrowseDefault_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Document Path";
            // 
            // txtPathDefault
            // 
            this.txtPathDefault.Location = new System.Drawing.Point(121, 23);
            this.txtPathDefault.Name = "txtPathDefault";
            this.txtPathDefault.Size = new System.Drawing.Size(374, 20);
            this.txtPathDefault.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Default Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowseVideo);
            this.groupBox1.Controls.Add(this.txtPathDefault);
            this.groupBox1.Controls.Add(this.txtPathCompressed);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPathVideo);
            this.groupBox1.Controls.Add(this.btnBrowseDefault);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBrowseCompressed);
            this.groupBox1.Controls.Add(this.btnBrowseDocument);
            this.groupBox1.Controls.Add(this.btnBrowseExecutable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPathImage);
            this.groupBox1.Controls.Add(this.txtPathAudio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPathDocument);
            this.groupBox1.Controls.Add(this.txtPathExecutable);
            this.groupBox1.Controls.Add(this.btnBrowseAudio);
            this.groupBox1.Controls.Add(this.btnBrowseImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 214);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaxDownloadClients);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 55);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other settings";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 333);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxDownloadClients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowseAudio;
        private System.Windows.Forms.TextBox txtPathExecutable;
        private System.Windows.Forms.TextBox txtPathAudio;
        private System.Windows.Forms.Button btnBrowseExecutable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseVideo;
        private System.Windows.Forms.TextBox txtPathCompressed;
        private System.Windows.Forms.TextBox txtPathVideo;
        private System.Windows.Forms.Button btnBrowseCompressed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtPathDocument;
        private System.Windows.Forms.TextBox txtPathImage;
        private System.Windows.Forms.Button btnBrowseDocument;
        private System.Windows.Forms.Button btnBrowseDefault;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPathDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}