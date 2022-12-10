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
    public class LiveInput
    {
        #region Variables privées
        private VideoCaptureDevice _inputDevice;
        private PictureBox _pbReplay;
        private Buffer _buff;
        #endregion

        #region Variables publiques
        public VideoCaptureDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }
        public PictureBox PbReplay { get => _pbReplay; set => _pbReplay = value; }
        public Buffer Buffer { get => _buff; set => _buff = value; }
        #endregion

        public LiveInput(VideoCaptureDevice vcd, PictureBox pb)
        {
            this.PbReplay = pb;

            this.InputDevice = vcd;
            this.InputDevice.NewFrame += new_frame;
            
            this.Buffer = new Buffer();
        }

        public LiveInput()
        {
            this.Buffer = new Buffer();
        }

        #region Input device

        /// <summary>
        /// Démarre la capture vidéo de l'entrée
        /// </summary>
        public void Start() 
        {
            this.InputDevice.Start();
        }

        /// <summary>
        /// Arrêter l'entrée vidéo
        /// </summary>
        public void Stop()
        {
            this.InputDevice.Stop();
        }  

        /// <summary>
        ///  Ce produit à chaque nouvelle image reçu par l'entrée vidéo
        /// </summary>
        private void new_frame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame;
            this.Buffer.AddFrame(image);

            this.PbReplay.Invoke(new Action(() => this.PbReplay.Image = image));
        }

        #endregion

        #region Buffer

        /// <summary>
        /// Démarre le buffer pour l'entrée
        /// </summary>
        public void StartBuffer()
        {
            this.Buffer.Start();
        }

        /// <summary>
        /// Arrête le Buffer pour l'entrée
        /// </summary>
        public void StopBuffer()
        {
            this.Buffer.Stop();
        }

        #endregion
    }
}
