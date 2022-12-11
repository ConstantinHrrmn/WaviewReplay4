using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Buffer _activatedBuffer;
        private int _currentFrame;

        private List<LiveInput> LI;

        #endregion

        #region Variable publiques
        public FrmMain Frame { get => _frame; set => _frame = value; }
        public FilterInfoCollection FilterInfoCollection { get => _filterInfoCollection; set => _filterInfoCollection = value; }
        public Buffer ActivatedBuffer { get => _activatedBuffer; set => _activatedBuffer = value; }
        public int CurrentFrame { get => _currentFrame; set => _currentFrame = value; }
        #endregion

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="a_frame">La form par défaut</param>
        public MainController(FrmMain a_frame)
        {
            this.Frame = a_frame;    

            // On initialise tout ce qu'il faut
            this.SetupLiveInputs();
            this.InstantiateInputs();
        }

        /// <summary>
        /// Création du tableau avec les sources vidéo ainsi que la fonction de callback pour chaque nouvelle frame
        /// </summary>
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
        public VideoCaptureDevice SetInput(int indexInput, int indexView)
        {
            if (indexView >= 0 && indexView < this.LI.Count)
            {
                this.LI[indexView].Stop();
                this.LI[indexView].SetInputDevice(new VideoCaptureDevice(this.FilterInfoCollection[indexInput].MonikerString));
                this.LI[indexView].Start();

                return this.LI[indexView].InputDevice;
            }
            return null;
        }

        /// <summary>
        /// Demarre le buffer pour l'entrée sélectionnée
        /// </summary>
        /// <param name="index">l'identifiant de l'entrée (index du tableau dea entrées)</param>
        /// <returns>True si le Buffer a pu démarrer, False si non</returns>
        public bool StartBuffer(int index)
        {
            if (index >= 0 && index < this.LI.Count)
            {
                if (this.LI[index].InputDevice != null)
                {
                    this.LI[index].StartBuffer();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        
        /// <summary>
        /// Changer les paramètres de sortie pour les Replay
        /// </summary>
        /// <param name="resolution">la résolution demandée</param>
        /// <param name="fps">le nombre d'images par secondes</param>
        public void ChangeOutputSettings(Size resolution, int fps)
        {
            foreach (LiveInput li in this.LI)
                li.SetOutputSettings(resolution, fps);
        }

        /// <summary>
        /// Récupère un tableau avec le nombre de secondes et le nombre d'image contenu dans chaque Buffer
        /// </summary>
        /// <returns>Un tableau de tuple avec le nombre d'images et le nombre de secondes</returns>
        public Tuple<int, float>[] GetBufferInfos()
        {
            Tuple<int, float>[] infos = new Tuple<int, float>[this.LI.Count];
            for (int i = 0; i < this.LI.Count; i++)
            {
                infos[i] = this.LI[i].GetBufferProgress();
            }
            return infos;
        }

        public void StopAndLoadBuffer(int index)
        {
            if (index >= 0 && index < this.LI.Count)
            {
                this.LI[index].StopBuffer();
                this.ActivatedBuffer = this.LI[index].Buffer;
                this.Frame.LoadBuffer(this.LI[index]);
            }
        }

        public Bitmap NextFrame()
        {
            if (this.CurrentFrame >= this.ActivatedBuffer.CompressedImages.Count-1)
                this.CurrentFrame = 0;
            else
                this.CurrentFrame++;

            return this.ActivatedBuffer.CompressedImages[this.CurrentFrame];
        }
    }
}
