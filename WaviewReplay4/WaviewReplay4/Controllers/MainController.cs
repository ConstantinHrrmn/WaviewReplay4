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

            this.LI = new List<LiveInput>();
            
            this.LI.Add(new LiveInput());
            this.LI.Add(new LiveInput());
            this.LI.Add(new LiveInput());
            this.LI.Add(new LiveInput());

            this.InstantiateInputs();
        }

        /// <summary>
        /// Permet de charger toutes les instances d'entrées vidéo de l'oirdinateur
        /// </summary>
        public void InstantiateInputs()
        {
            this.FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            this.Frame.UpdateInputComboBoxes(this.FilterInfoCollection);
        }    

        /// <summary>
        /// Permet de mettre a jour l'entrée vidéo pour un live
        /// </summary>
        /// <param name="indexInput">l'index de l'entrée</param>
        /// <param name="indexView">l'index du gestionnaire de live</param>
        public void SetInput(int indexInput, int indexView)
        {
            if (indexView >= 0 && indexView < this.LI.Count)
                this.LI[indexView].InputDevice = new VideoCaptureDevice(this.FilterInfoCollection[indexInput].MonikerString);
        }

        
    }
}
