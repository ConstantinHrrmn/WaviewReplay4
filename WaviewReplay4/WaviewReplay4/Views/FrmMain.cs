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
    }
}
