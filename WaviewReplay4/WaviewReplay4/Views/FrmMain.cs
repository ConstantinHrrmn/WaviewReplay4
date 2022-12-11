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

using WaviewReplay4.Views;

namespace WaviewReplay4
{
    public partial class FrmMain : Form
    {
        #region Variables privées
        private MainController _mC;
        private List<PictureBox> _lives;
        private Bitmap[] _currentFrames;
        private Button[] _bufferBtns;
        #endregion

        #region Variables publiques
        public MainController MC { get => _mC; set => _mC = value; }
        public List<PictureBox> Lives { get => _lives; set => _lives = value; }
        public Bitmap[] CurrentFrames { get => _currentFrames; set => _currentFrames = value; }
        public Button[] BufferBtns { get => _bufferBtns; set => _bufferBtns = value; }
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

            //FrmSettings settings = new FrmSettings(this.UpdateBufferSettings);
            //settings.ShowDialog();

            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;

            this.InstantiateBufferBtns();
        }
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            Debug.Print("Size = " + this.Size);

            float ratioX = 2.969f;
            float ratioY = 1.777777777777777777777777f;
            int spacing = 20;

            this.pbLive1.Size = new Size((int)(this.Size.Width / ratioX), (int)((this.Size.Width / ratioX) / ratioY));
            this.pbLive2.Size = this.pbLive1.Size;
            this.pbLive3.Size = this.pbLive1.Size;
            this.pbLive4.Size = this.pbLive1.Size;

            this.pbLive1.Location = this.pbLive1.Location;
            this.pbLive2.Location = new Point(this.pbLive1.Location.X + this.pbLive1.Size.Width + spacing, this.pbLive1.Location.Y);
            this.pbLive3.Location = new Point(this.pbLive1.Location.X, this.pbLive1.Location.Y + this.pbLive1.Size.Height + spacing);
            this.pbLive4.Location = new Point(this.pbLive1.Location.X + this.pbLive1.Size.Width + spacing, this.pbLive1.Location.Y + this.pbLive1.Size.Height + spacing);

            this.btnOpenInputSettings.Location = new Point(this.pbLive3.Location.X, this.pbLive3.Location.Y + this.pbLive3.Size.Height + spacing);
            this.btnOpenInputSettings.Size = new Size((this.pbLive3.Size.Width / 4) * 3 - (spacing / 2), (int)(this.pbLive1.Size.Height / 5.5));

            this.btnSettings.Location = new Point(this.btnOpenInputSettings.Location.X + this.btnOpenInputSettings.Size.Width + spacing, this.btnOpenInputSettings.Location.Y);
            this.btnSettings.Size = new Size((this.pbLive3.Size.Width / 4) - (spacing / 2), this.btnOpenInputSettings.Size.Height);

            this.btnStartAllBuffer.Location = new Point(this.pbLive4.Location.X, this.pbLive4.Location.Y + this.pbLive4.Size.Height + spacing);
            this.btnStartAllBuffer.Size = new Size(this.pbLive4.Size.Width / 6 * 2 - (spacing / 4), this.btnOpenInputSettings.Height);

            this.btnBuffer1.Location = new Point(this.btnStartAllBuffer.Location.X + this.btnStartAllBuffer.Size.Width + spacing / 4, this.btnStartAllBuffer.Location.Y);
            this.btnBuffer1.Size = new Size(this.btnStartAllBuffer.Size.Width / 2, this.btnStartAllBuffer.Size.Height);

            this.btnBuffer2.Location = new Point(this.btnBuffer1.Location.X + this.btnBuffer1.Size.Width + spacing / 4, this.btnBuffer1.Location.Y);
            this.btnBuffer2.Size = new Size(this.btnBuffer1.Size.Width, this.btnBuffer1.Size.Height);

            this.btnBuffer3.Location = new Point(this.btnBuffer2.Location.X + this.btnBuffer2.Size.Width + spacing / 4, this.btnBuffer2.Location.Y);
            this.btnBuffer3.Size = new Size(this.btnBuffer2.Size.Width, this.btnBuffer2.Size.Height);

            this.btnBuffer4.Location = new Point(this.btnBuffer3.Location.X + this.btnBuffer3.Size.Width + spacing / 4, this.btnBuffer3.Location.Y);
            this.btnBuffer4.Size = new Size(this.btnBuffer3.Size.Width, this.btnBuffer3.Size.Height);

            Font f = new Font("Arial", this.btnOpenInputSettings.Size.Height / 8, FontStyle.Bold);

            this.btnBuffer1.Font = f;
            this.btnBuffer2.Font = f;
            this.btnBuffer3.Font = f;
            this.btnBuffer4.Font = f;

            this.btnOpenInputSettings.Font = f;
            this.btnStartAllBuffer.Font = f;
            this.btnSettings.Font = f;

            f = new Font("Arial", this.btnOpenInputSettings.Size.Height / 4, FontStyle.Bold);

            this.lblReplayLabel.Font = f;

            int maxReplayWidth = this.Size.Width - (this.pbLive2.Width + this.pbLive2.Location.X + spacing * 3);

            this.pbReplay.Size = new Size(maxReplayWidth, (int)(maxReplayWidth / ratioY));
            this.lblReplayLabel.Size = new Size(this.pbReplay.Size.Width, this.pbReplay.Size.Height / 3);
            this.lblReplayLabel.Location = new Point(this.pbLive2.Location.X + spacing + this.pbLive2.Width, this.pbLive2.Location.Y);
            this.pbReplay.Location = new Point(this.pbLive2.Location.X + this.pbLive2.Width + spacing, this.pbLive2.Location.Y + this.lblReplayLabel.Height + spacing);

            f = new Font("Arial", this.btnOpenInputSettings.Font.Size * 3, FontStyle.Bold);
            this.lblBufferResolution.Font = f;
            this.lblBufferResolution.Size = new Size(this.pbLive4.Size.Width, this.btnBuffer1.Height * 2);
            this.lblBufferResolution.Location = new Point(this.btnStartAllBuffer.Location.X, this.btnStartAllBuffer.Location.Y + this.btnStartAllBuffer.Height + spacing);

            GC.Collect();
        }


        /// <summary>
        /// Ajouter tous les boutons des buffer dans un tableau
        /// </summary>
        private void InstantiateBufferBtns()
        {
            this.BufferBtns = new Button[4];
            this.BufferBtns[0] = this.btnBuffer1;
            this.BufferBtns[1] = this.btnBuffer2;
            this.BufferBtns[2] = this.btnBuffer3;
            this.BufferBtns[3] = this.btnBuffer4;
        }

        /// <summary>
        /// Met a jour la picturebox avec la frame actuelle
        /// </summary>
        /// <param name="image">La frame a afficher </param>
        /// <param name="index">L'index de la picturebox</param>
        public void UpdateLive(Bitmap image, int index)
        {
            //Debug.WriteLine("New Frame from input " + index);
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings(this.UpdateBufferSettings);
            settings.ShowDialog();
        }

        private void btnStartAllBuffer_Click(object sender, EventArgs e)
        {
            this.CheckBufferButtons();
        }

        public void CheckBufferButtons()
        {
            bool[] b = new bool[] { this.StartBuffer(0), this.StartBuffer(1), this.StartBuffer(2), this.StartBuffer(3) };

            for (int i = 0; i < this.BufferBtns.Length; i++)
                this.BufferBtns[i].ForeColor = b[i] ? Color.Green : Color.Red;

            if (b.Any(x => x == true))
                this.TimerUpdateBufferInfos.Start();
        }

        public void CheckBufferButtons(int index)
        {
            bool b = this.StartBuffer(index);
            this.BufferBtns[index].ForeColor = b ? Color.Green : Color.Red;

            if (b)
                this.TimerUpdateBufferInfos.Start();
        }

        private void btnBuffer1_Click(object sender, EventArgs e)
        {
            this.CheckBufferButtons(0);
        }

        private void btnBuffer2_Click(object sender, EventArgs e)
        {
            this.CheckBufferButtons(1);
        }

        private void btnBuffer3_Click(object sender, EventArgs e)
        {
            this.CheckBufferButtons(2);
        }

        private void btnBuffer4_Click(object sender, EventArgs e)
        {
            this.CheckBufferButtons(3);
        }
        
        #endregion

        #region ComboBox Input Change
        public void InputChanged(int indexInput, int indexView)
        {
            this.MC.SetInput(indexInput, indexView);
        }
        #endregion

        #region Buffer
        public bool StartBuffer(int index)
        {
            return this.MC.StartBuffer(index);
        }
        
        public void UpdateBufferSettings(Size resolution, int fps)
        {
            this.TimerReplayPlayback.Stop();
            this.MC.ChangeOutputSettings(resolution, fps);
            this.lblBufferResolution.Text = string.Format("{0} x {1} / {2}", resolution.Width, resolution.Height, fps);
        }

        public void LoadBuffer(LiveInput input)
        {
            if (this.BufferBtns[input.Index].ForeColor == Color.Green)
            {
                this.lblReplayLabel.Text = "INPUT : " + (input.Index + 1);
                this.TimerReplayPlayback.Interval = 1000 / input.Buffer.FPS;
                this.TimerReplayPlayback.Start();
            }
            else
            {
                this.lblReplayLabel.Text = "INPUT : " + (input.Index + 1) + " (NOT LOADED)";
            }
        }

        #endregion

        #region TIMERS
        private void TimerUpdateBufferInfos_Tick(object sender, EventArgs e)
        {
            Tuple<int, float>[] infos = this.MC.GetBufferInfos();

            for (int i = 0; i < this.BufferBtns.Length; i++)
                this.BufferBtns[i].Text = infos[i].Item1 == 0 ? "B"+i : infos[i].Item2 + "(" + infos[i].Item1 + ")";
        }

        private void TimerReplayPlayback_Tick(object sender, EventArgs e)
        {
            this.pbReplay.Image = this.MC.NextFrame();
        }
        #endregion

        #region SHORTCUTS
        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            Debug.WriteLine("Key pressed : " + c);
            this.ExecuteCommand(c);
            this.Focus();
        }

        public void ExecuteCommand(char shortcut)
        {
            switch (shortcut)
            {
                case '1':
                    this.MC.StopAndLoadBuffer(0);
                    break;
                case '2':
                    this.MC.StopAndLoadBuffer(1);
                    break;
                case '3':
                    this.MC.StopAndLoadBuffer(2);
                    break;
                case '4':
                    this.MC.StopAndLoadBuffer(3);
                    break;
                    
                default:
                    break;
            }
        }

        #endregion


    }
}
