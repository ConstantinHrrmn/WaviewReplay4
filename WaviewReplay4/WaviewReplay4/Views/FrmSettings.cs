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

namespace WaviewReplay4.Views
{
    public partial class FrmSettings : Form
    {
        #region Variables privées
        private Action<Size, int> _callback;
        private Size[] _sizes = new Size[] { new Size(640, 480), new Size(800, 600), new Size(1024, 768), new Size(1280, 720), new Size(1920, 1080) };
        private int[] _fps = new int[] { 10, 15, 20, 25, 30, 50, 60 };

        private bool editing = false;
        #endregion

        #region Variables publiques
        public Action<Size, int> Callback { get => _callback; set => _callback = value; }
        public Size[] Sizes { get => _sizes; set => _sizes = value; }
        public int[] Fps { get => _fps; set => _fps = value; }
        #endregion

        public FrmSettings(Action<Size, int> callback)
        {
            InitializeComponent();
            this.Callback = callback;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            this.CheckReplayFolder();
            this.InstantiateCombobox();
        }

        private void InstantiateCombobox()
        {
            this.cmbResolution.Items.Clear();
            foreach (Size item in this.Sizes)
                this.cmbResolution.Items.Add(item.Width + "x" + item.Height);

            this.cmbFps.Items.Clear();
            foreach (int item in this.Fps)
                this.cmbFps.Items.Add(item + " fps");

            this.cmbResolution.SelectedIndex = Properties.Settings.Default.OutputResolutionIndex;
            this.cmbFps.SelectedIndex = Properties.Settings.Default.OutputFPSIndex;

            this.editing = true;
        }

        /// <summary>
        /// Vérifie que le dossier de replay existe
        /// </summary>
        public void CheckReplayFolder()
        {
            string replayPath = Properties.Settings.Default.ReplayPath;

            if (replayPath != null && replayPath != "")
            {
                if (Directory.Exists(replayPath))
                {
                    this.btnSelectPath.Text = replayPath;
                }
                else
                {
                    Properties.Settings.Default.ReplayPath = "";
                    Properties.Settings.Default.Save();
                }
            }
        }

        #region BUTTON EVENTS
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (fbdReplay.ShowDialog() == DialogResult.OK)
            {
                this.btnSelectPath.Text = fbdReplay.SelectedPath;
                Properties.Settings.Default.ReplayPath = fbdReplay.SelectedPath;
                Properties.Settings.Default.Save();
            } 
        }

        private void cmbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OutputFPSIndex = this.cmbFps.SelectedIndex;
            Properties.Settings.Default.OutputResolutionIndex = this.cmbResolution.SelectedIndex;
            Properties.Settings.Default.Save();

            if (this.editing)
            {
                this.Callback(this.Sizes[this.cmbResolution.SelectedIndex], this.Fps[this.cmbFps.SelectedIndex]);
                this.Callback(this.Sizes[this.cmbResolution.SelectedIndex], this.Fps[this.cmbFps.SelectedIndex]);
            }
        }

        private void btnStartAPP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
