namespace WaviewReplay4
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pbLive1 = new System.Windows.Forms.PictureBox();
            this.pbLive2 = new System.Windows.Forms.PictureBox();
            this.pbLive3 = new System.Windows.Forms.PictureBox();
            this.pbLive4 = new System.Windows.Forms.PictureBox();
            this.btnOpenInputSettings = new System.Windows.Forms.Button();
            this.btnStartAllBuffer = new System.Windows.Forms.Button();
            this.btnBuffer1 = new System.Windows.Forms.Button();
            this.btnBuffer2 = new System.Windows.Forms.Button();
            this.btnBuffer3 = new System.Windows.Forms.Button();
            this.btnBuffer4 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.TimerUpdateBufferInfos = new System.Windows.Forms.Timer(this.components);
            this.pbReplay = new System.Windows.Forms.PictureBox();
            this.lblReplayLabel = new System.Windows.Forms.Label();
            this.TimerReplayPlayback = new System.Windows.Forms.Timer(this.components);
            this.lblBufferResolution = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLive1
            // 
            this.pbLive1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLive1.Image = ((System.Drawing.Image)(resources.GetObject("pbLive1.Image")));
            this.pbLive1.Location = new System.Drawing.Point(10, 10);
            this.pbLive1.Margin = new System.Windows.Forms.Padding(4);
            this.pbLive1.Name = "pbLive1";
            this.pbLive1.Size = new System.Drawing.Size(640, 360);
            this.pbLive1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLive1.TabIndex = 0;
            this.pbLive1.TabStop = false;
            // 
            // pbLive2
            // 
            this.pbLive2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLive2.Image = ((System.Drawing.Image)(resources.GetObject("pbLive2.Image")));
            this.pbLive2.Location = new System.Drawing.Point(660, 10);
            this.pbLive2.Margin = new System.Windows.Forms.Padding(4);
            this.pbLive2.Name = "pbLive2";
            this.pbLive2.Size = new System.Drawing.Size(640, 360);
            this.pbLive2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLive2.TabIndex = 1;
            this.pbLive2.TabStop = false;
            // 
            // pbLive3
            // 
            this.pbLive3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLive3.Image = ((System.Drawing.Image)(resources.GetObject("pbLive3.Image")));
            this.pbLive3.Location = new System.Drawing.Point(10, 380);
            this.pbLive3.Margin = new System.Windows.Forms.Padding(4);
            this.pbLive3.Name = "pbLive3";
            this.pbLive3.Size = new System.Drawing.Size(640, 360);
            this.pbLive3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLive3.TabIndex = 2;
            this.pbLive3.TabStop = false;
            // 
            // pbLive4
            // 
            this.pbLive4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLive4.Image = ((System.Drawing.Image)(resources.GetObject("pbLive4.Image")));
            this.pbLive4.Location = new System.Drawing.Point(660, 380);
            this.pbLive4.Margin = new System.Windows.Forms.Padding(4);
            this.pbLive4.Name = "pbLive4";
            this.pbLive4.Size = new System.Drawing.Size(640, 360);
            this.pbLive4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLive4.TabIndex = 3;
            this.pbLive4.TabStop = false;
            // 
            // btnOpenInputSettings
            // 
            this.btnOpenInputSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenInputSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenInputSettings.ForeColor = System.Drawing.Color.White;
            this.btnOpenInputSettings.Location = new System.Drawing.Point(10, 748);
            this.btnOpenInputSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenInputSettings.Name = "btnOpenInputSettings";
            this.btnOpenInputSettings.Size = new System.Drawing.Size(452, 61);
            this.btnOpenInputSettings.TabIndex = 6;
            this.btnOpenInputSettings.Text = "Open Inputs";
            this.btnOpenInputSettings.UseVisualStyleBackColor = true;
            this.btnOpenInputSettings.Click += new System.EventHandler(this.btnOpenInputSettings_Click);
            // 
            // btnStartAllBuffer
            // 
            this.btnStartAllBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartAllBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAllBuffer.ForeColor = System.Drawing.Color.White;
            this.btnStartAllBuffer.Location = new System.Drawing.Point(660, 748);
            this.btnStartAllBuffer.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartAllBuffer.Name = "btnStartAllBuffer";
            this.btnStartAllBuffer.Size = new System.Drawing.Size(236, 61);
            this.btnStartAllBuffer.TabIndex = 7;
            this.btnStartAllBuffer.Text = "Start All Buffer";
            this.btnStartAllBuffer.UseVisualStyleBackColor = true;
            this.btnStartAllBuffer.Click += new System.EventHandler(this.btnStartAllBuffer_Click);
            // 
            // btnBuffer1
            // 
            this.btnBuffer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuffer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuffer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuffer1.ForeColor = System.Drawing.Color.Red;
            this.btnBuffer1.Location = new System.Drawing.Point(906, 749);
            this.btnBuffer1.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuffer1.Name = "btnBuffer1";
            this.btnBuffer1.Size = new System.Drawing.Size(93, 61);
            this.btnBuffer1.TabIndex = 11;
            this.btnBuffer1.Text = "B1";
            this.btnBuffer1.UseVisualStyleBackColor = true;
            this.btnBuffer1.Click += new System.EventHandler(this.btnBuffer1_Click);
            // 
            // btnBuffer2
            // 
            this.btnBuffer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuffer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuffer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuffer2.ForeColor = System.Drawing.Color.Red;
            this.btnBuffer2.Location = new System.Drawing.Point(1006, 749);
            this.btnBuffer2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuffer2.Name = "btnBuffer2";
            this.btnBuffer2.Size = new System.Drawing.Size(93, 61);
            this.btnBuffer2.TabIndex = 12;
            this.btnBuffer2.Text = "B2";
            this.btnBuffer2.UseVisualStyleBackColor = true;
            this.btnBuffer2.Click += new System.EventHandler(this.btnBuffer2_Click);
            // 
            // btnBuffer3
            // 
            this.btnBuffer3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuffer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuffer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuffer3.ForeColor = System.Drawing.Color.Red;
            this.btnBuffer3.Location = new System.Drawing.Point(1106, 749);
            this.btnBuffer3.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuffer3.Name = "btnBuffer3";
            this.btnBuffer3.Size = new System.Drawing.Size(93, 61);
            this.btnBuffer3.TabIndex = 13;
            this.btnBuffer3.Text = "B3";
            this.btnBuffer3.UseVisualStyleBackColor = true;
            this.btnBuffer3.Click += new System.EventHandler(this.btnBuffer3_Click);
            // 
            // btnBuffer4
            // 
            this.btnBuffer4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuffer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuffer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuffer4.ForeColor = System.Drawing.Color.Red;
            this.btnBuffer4.Location = new System.Drawing.Point(1207, 749);
            this.btnBuffer4.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuffer4.Name = "btnBuffer4";
            this.btnBuffer4.Size = new System.Drawing.Size(93, 61);
            this.btnBuffer4.TabIndex = 14;
            this.btnBuffer4.Text = "B4";
            this.btnBuffer4.UseVisualStyleBackColor = true;
            this.btnBuffer4.Click += new System.EventHandler(this.btnBuffer4_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(470, 748);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(180, 61);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // TimerUpdateBufferInfos
            // 
            this.TimerUpdateBufferInfos.Tick += new System.EventHandler(this.TimerUpdateBufferInfos_Tick);
            // 
            // pbReplay
            // 
            this.pbReplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReplay.Image = ((System.Drawing.Image)(resources.GetObject("pbReplay.Image")));
            this.pbReplay.Location = new System.Drawing.Point(1307, 127);
            this.pbReplay.Margin = new System.Windows.Forms.Padding(4);
            this.pbReplay.Name = "pbReplay";
            this.pbReplay.Size = new System.Drawing.Size(538, 302);
            this.pbReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReplay.TabIndex = 16;
            this.pbReplay.TabStop = false;
            // 
            // lblReplayLabel
            // 
            this.lblReplayLabel.BackColor = System.Drawing.Color.Red;
            this.lblReplayLabel.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplayLabel.ForeColor = System.Drawing.Color.White;
            this.lblReplayLabel.Location = new System.Drawing.Point(1307, 10);
            this.lblReplayLabel.Name = "lblReplayLabel";
            this.lblReplayLabel.Size = new System.Drawing.Size(538, 100);
            this.lblReplayLabel.TabIndex = 17;
            this.lblReplayLabel.Text = "Replay OFF";
            this.lblReplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerReplayPlayback
            // 
            this.TimerReplayPlayback.Tick += new System.EventHandler(this.TimerReplayPlayback_Tick);
            // 
            // lblBufferResolution
            // 
            this.lblBufferResolution.BackColor = System.Drawing.Color.Black;
            this.lblBufferResolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBufferResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBufferResolution.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBufferResolution.Location = new System.Drawing.Point(661, 829);
            this.lblBufferResolution.Name = "lblBufferResolution";
            this.lblBufferResolution.Size = new System.Drawing.Size(639, 100);
            this.lblBufferResolution.TabIndex = 18;
            this.lblBufferResolution.Text = "1920 x 1080 / 30";
            this.lblBufferResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.lblBufferResolution);
            this.Controls.Add(this.lblReplayLabel);
            this.Controls.Add(this.pbReplay);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnBuffer4);
            this.Controls.Add(this.btnBuffer3);
            this.Controls.Add(this.btnBuffer2);
            this.Controls.Add(this.btnBuffer1);
            this.Controls.Add(this.btnStartAllBuffer);
            this.Controls.Add(this.btnOpenInputSettings);
            this.Controls.Add(this.pbLive4);
            this.Controls.Add(this.pbLive3);
            this.Controls.Add(this.pbLive2);
            this.Controls.Add(this.pbLive1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waview Replay 4 CAMS";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbLive1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLive1;
        private System.Windows.Forms.PictureBox pbLive2;
        private System.Windows.Forms.PictureBox pbLive3;
        private System.Windows.Forms.PictureBox pbLive4;
        private System.Windows.Forms.Button btnOpenInputSettings;
        private System.Windows.Forms.Button btnStartAllBuffer;
        private System.Windows.Forms.Button btnBuffer1;
        private System.Windows.Forms.Button btnBuffer2;
        private System.Windows.Forms.Button btnBuffer3;
        private System.Windows.Forms.Button btnBuffer4;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer TimerUpdateBufferInfos;
        private System.Windows.Forms.PictureBox pbReplay;
        private System.Windows.Forms.Label lblReplayLabel;
        private System.Windows.Forms.Timer TimerReplayPlayback;
        private System.Windows.Forms.Label lblBufferResolution;
    }
}

