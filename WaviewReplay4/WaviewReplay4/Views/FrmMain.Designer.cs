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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pbLive1 = new System.Windows.Forms.PictureBox();
            this.pbLive2 = new System.Windows.Forms.PictureBox();
            this.pbLive3 = new System.Windows.Forms.PictureBox();
            this.pbLive4 = new System.Windows.Forms.PictureBox();
            this.pbReplay = new System.Windows.Forms.PictureBox();
            this.btnOpenInputSettings = new System.Windows.Forms.Button();
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
            this.pbLive1.Location = new System.Drawing.Point(13, 13);
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
            this.pbLive2.Location = new System.Drawing.Point(658, 13);
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
            this.pbLive3.Location = new System.Drawing.Point(13, 378);
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
            this.pbLive4.Location = new System.Drawing.Point(658, 378);
            this.pbLive4.Name = "pbLive4";
            this.pbLive4.Size = new System.Drawing.Size(640, 360);
            this.pbLive4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLive4.TabIndex = 3;
            this.pbLive4.TabStop = false;
            // 
            // pbReplay
            // 
            this.pbReplay.Location = new System.Drawing.Point(1431, 13);
            this.pbReplay.Name = "pbReplay";
            this.pbReplay.Size = new System.Drawing.Size(321, 181);
            this.pbReplay.TabIndex = 4;
            this.pbReplay.TabStop = false;
            // 
            // btnOpenInputSettings
            // 
            this.btnOpenInputSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenInputSettings.ForeColor = System.Drawing.Color.White;
            this.btnOpenInputSettings.Location = new System.Drawing.Point(13, 745);
            this.btnOpenInputSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenInputSettings.Name = "btnOpenInputSettings";
            this.btnOpenInputSettings.Size = new System.Drawing.Size(640, 61);
            this.btnOpenInputSettings.TabIndex = 6;
            this.btnOpenInputSettings.Text = "Open Inputs";
            this.btnOpenInputSettings.UseVisualStyleBackColor = true;
            this.btnOpenInputSettings.Click += new System.EventHandler(this.btnOpenInputSettings_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1876, 819);
            this.Controls.Add(this.btnOpenInputSettings);
            this.Controls.Add(this.pbReplay);
            this.Controls.Add(this.pbLive4);
            this.Controls.Add(this.pbLive3);
            this.Controls.Add(this.pbLive2);
            this.Controls.Add(this.pbLive1);
            this.MinimumSize = new System.Drawing.Size(898, 593);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waview Replay 4 CAMS";
            this.Load += new System.EventHandler(this.FrmMain_Load);
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
        private System.Windows.Forms.PictureBox pbReplay;
        private System.Windows.Forms.Button btnOpenInputSettings;
    }
}

