using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WaviewReplay4
{
    public class MainController
    {
        #region Variables privées
        private FrmMain _frame;
        private FilterInfoCollection _filterInfoCollection;

        private List<LiveInput> LI;

        #endregion

        #region Variable publiques
        public FrmMain Frame { get => _frame; set => _frame = value; }
        public FilterInfoCollection FilterInfoCollection { get => _filterInfoCollection; set => _filterInfoCollection = value; }
        #endregion

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="a_frame">La form par défaut</param>
        public MainController(FrmMain a_frame)
        {
            this.Frame = a_frame;

            

            this.SetupLiveInputs();
            this.InstantiateInputs();
        }

        public void SetupLiveInputs()
        {
            this.LI = new List<LiveInput>();
            
            this.LI.Add(new LiveInput(0));
            this.LI.Add(new LiveInput(1));
            this.LI.Add(new LiveInput(2));
            this.LI.Add(new LiveInput(3));

            this.LI[0].Callback = this.Frame.UpdateLive;
            this.LI[1].Callback = this.Frame.UpdateLive;
            this.LI[2].Callback = this.Frame.UpdateLive;
            this.LI[3].Callback = this.Frame.UpdateLive;
        }

        /// <summary>
        /// Permet de charger toutes les instances d'entrées vidéo de l'oirdinateur
        /// </summary>
        public FilterInfoCollection InstantiateInputs()
        {
            this.FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            return this.FilterInfoCollection;
        }    

        /// <summary>
        /// Permet de mettre a jour l'entrée vidéo pour un live
        /// </summary>
        /// <param name="indexInput">l'index de l'entrée</param>
        /// <param name="indexView">l'index du gestionnaire de live</param>
        public void SetInput(int indexInput, int indexView)
        {
            if (indexView >= 0 && indexView < this.LI.Count)
            {
                this.LI[indexView].Stop();
                this.LI[indexView].SetInputDevice(new VideoCaptureDevice(this.FilterInfoCollection[indexInput].MonikerString));
                this.LI[indexView].Start();
            }
        }
    }
}
