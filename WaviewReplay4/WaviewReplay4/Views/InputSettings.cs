using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaviewReplay4
{
    public partial class InputSettings : Form
    {
        #region Variables privées
        private Action<int, int> _callback;
        private FilterInfoCollection _fic;
        #endregion

        #region Variables publiques
        public Action<int, int> Callback { get => _callback; set => _callback = value; }
        public FilterInfoCollection Fic { get => _fic; set => _fic = value; }
        #endregion

        public InputSettings(Action<int, int> callback, FilterInfoCollection a_fic)
        {
            InitializeComponent();
            this.Callback = callback;
            this.Fic = a_fic;
        }

        private void InputSettings_Load(object sender, EventArgs e)
        {
            this.UpdateInputComboBoxes(this.Fic);
        }

        /// <summary>
        /// Mettre a jour toutes les combobox avec les informations d'entrées vidéo
        /// </summary>
        /// <param name="infos">les informations d'entrées vidéo</param>
        public void UpdateInputComboBoxes(FilterInfoCollection infos)
        {
            this.UpdateComboBox(infos, cmbInput1);
            this.UpdateComboBox(infos, cmbInput2);
            this.UpdateComboBox(infos, cmbInput3);
            this.UpdateComboBox(infos, cmbInput4);
        }

        /// <summary>
        /// Remplir la combobox sélectionnée avec les informations vidéos
        /// </summary>
        /// <param name="infos">les informations vidéos</param>
        /// <param name="cmb">la combobox dans laquelle on affiche les données</param>
        public void UpdateComboBox(FilterInfoCollection infos, ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (FilterInfo item in infos)
                cmb.Items.Add(item.Name);
        }

        #region INPUT CHANGE
        private void cmbInput1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Callback(cmbInput1.SelectedIndex, 0);
            this.lblInfo1.Text = this.InputStringFormater(new VideoCaptureDevice(this.Fic[cmbInput1.SelectedIndex].MonikerString));
        }
        private void cmbInput2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Callback(cmbInput2.SelectedIndex, 1);
            this.lblInfo2.Text = this.InputStringFormater(new VideoCaptureDevice(this.Fic[cmbInput2.SelectedIndex].MonikerString));
        }
        private void cmbInput3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Callback(cmbInput3.SelectedIndex, 2);
            this.lblInfo3.Text = this.InputStringFormater(new VideoCaptureDevice(this.Fic[cmbInput3.SelectedIndex].MonikerString));
        }
        private void cmbInput4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Callback(cmbInput4.SelectedIndex, 3);
            this.lblInfo4.Text = this.InputStringFormater(new VideoCaptureDevice(this.Fic[cmbInput4.SelectedIndex].MonikerString));
        }

        public string InputStringFormater(VideoCaptureDevice vcd)
        {
            return string.Format("{0}x{1} {2}fps", vcd.VideoCapabilities[0].FrameSize.Width, vcd.VideoCapabilities[0].FrameSize.Height, vcd.VideoCapabilities[0].AverageFrameRate);
        }
        #endregion
    }
}
