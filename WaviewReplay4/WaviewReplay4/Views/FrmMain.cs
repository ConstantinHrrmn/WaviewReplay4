using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<PictureBox> _lives;
        private Bitmap[] _currentFrames;
        #endregion

        #region Variables publiques
        public MainController MC { get => _mC; set => _mC = value; }
        public List<PictureBox> Lives { get => _lives; set => _lives = value; }
        public Bitmap[] CurrentFrames { get => _currentFrames; set => _currentFrames = value; }
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.CurrentFrames = new Bitmap[4];
            
            this.MC = new MainController(this);

            this.Lives = new List<PictureBox>();
            this.Lives.Add(this.pbLive1);
            this.Lives.Add(this.pbLive2);
            this.Lives.Add(this.pbLive3);
            this.Lives.Add(this.pbLive4);
        }

        public void UpdateLive(Bitmap image, int index)
        {
            Debug.WriteLine("New Frame from input " + index);
            this.CurrentFrames[index] = new Bitmap(image);
            this.Lives[index].Image = this.CurrentFrames[index];
            GC.Collect();
        }

        #region BUTTONS
        private void btnOpenInputSettings_Click(object sender, EventArgs e)
        {
            InputSettings inSettings = new InputSettings(this.InputChanged, this.MC.InstantiateInputs());
            inSettings.Show();            
        }
        #endregion

        #region ComboBox Input Change
        public void InputChanged(int indexInput, int indexView)
        {
            this.MC.SetInput(indexInput, indexView);
        }
        #endregion
    }
}
