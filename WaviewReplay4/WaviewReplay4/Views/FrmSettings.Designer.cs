namespace WaviewReplay4.Views
{
    partial class FrmSettings
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
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.fbdReplay = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.cmbFps = new System.Windows.Forms.ComboBox();
            this.btnStartAPP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.BackColor = System.Drawing.Color.Black;
            this.btnSelectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPath.ForeColor = System.Drawing.Color.White;
            this.btnSelectPath.Location = new System.Drawing.Point(12, 12);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(776, 54);
            this.btnSelectPath.TabIndex = 0;
            this.btnSelectPath.Text = "Select Path";
            this.btnSelectPath.UseVisualStyleBackColor = false;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output resolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Framerate";
            // 
            // cmbResolution
            // 
            this.cmbResolution.BackColor = System.Drawing.Color.Black;
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbResolution.ForeColor = System.Drawing.Color.White;
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(178, 118);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(252, 32);
            this.cmbResolution.TabIndex = 3;
            this.cmbResolution.SelectedIndexChanged += new System.EventHandler(this.cmbResolution_SelectedIndexChanged);
            // 
            // cmbFps
            // 
            this.cmbFps.BackColor = System.Drawing.Color.Black;
            this.cmbFps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFps.ForeColor = System.Drawing.Color.White;
            this.cmbFps.FormattingEnabled = true;
            this.cmbFps.Location = new System.Drawing.Point(178, 189);
            this.cmbFps.Name = "cmbFps";
            this.cmbFps.Size = new System.Drawing.Size(252, 32);
            this.cmbFps.TabIndex = 4;
            this.cmbFps.SelectedIndexChanged += new System.EventHandler(this.cmbFps_SelectedIndexChanged);
            // 
            // btnStartAPP
            // 
            this.btnStartAPP.BackColor = System.Drawing.Color.Black;
            this.btnStartAPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartAPP.Location = new System.Drawing.Point(12, 298);
            this.btnStartAPP.Name = "btnStartAPP";
            this.btnStartAPP.Size = new System.Drawing.Size(776, 54);
            this.btnStartAPP.TabIndex = 5;
            this.btnStartAPP.Text = "START APP";
            this.btnStartAPP.UseVisualStyleBackColor = false;
            this.btnStartAPP.Click += new System.EventHandler(this.btnStartAPP_Click);
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnStartAPP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.btnStartAPP);
            this.Controls.Add(this.cmbFps);
            this.Controls.Add(this.cmbResolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.FolderBrowserDialog fbdReplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.ComboBox cmbFps;
        private System.Windows.Forms.Button btnStartAPP;
    }
}