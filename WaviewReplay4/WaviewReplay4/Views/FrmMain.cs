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
    public partial class FrmMain : Form
    {
        #region Variables privées
        private MainController _mC;
        #endregion

        #region Variables publiques
        public MainController MC { get => _mC; set => _mC = value; }
        #endregion

        
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.MC = new MainController(this);
        }

        public void UpdateInputComboBoxes(FilterInfoCollection infos)
        {
            this.UpdateComboBox(infos, cmbInput1);
            this.UpdateComboBox(infos, cmbInput2);
            this.UpdateComboBox(infos, cmbInput3);
            this.UpdateComboBox(infos, cmbInput4);
        }

        public void UpdateComboBox(FilterInfoCollection infos, ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (FilterInfo item in infos)
                cmb.Items.Add(item.Name);
        }

    }
}
