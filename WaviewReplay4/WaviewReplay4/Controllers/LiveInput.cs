using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private int _index;
        private Action<Bitmap, int> _callback;
        private VideoCaptureDevice _inputDevice;
        private Buffer _buff;
        private bool _firstFrame;
        #endregion

        #region Variables publiques
        public VideoCaptureDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }
        public Buffer Buffer { get => _buff; set => _buff = value; }
        public int Index { get => _index; set => _index = value; }
        public Action<Bitmap, int> Callback { get => _callback; set => _callback = value; }
        #endregion

        public LiveInput(VideoCaptureDevice vcd)
        {
            this.InputDevice = vcd;
            this.InputDevice.NewFrame += new_frame;
            
            this.Buffer = new Buffer();
        }

        public LiveInput(int index)
        {
            this.Index = index;
            this.Buffer = new Buffer();
        }

        public void SetInputDevice(VideoCaptureDevice vcd)
        {
            this._firstFrame = true;
            this.InputDevice = vcd;
            this.InputDevice.NewFrame += new_frame;
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
            if (this.InputDevice != null)
            {
                if (this.InputDevice.IsRunning)
                    this.InputDevice.Stop();
            }
        }  

        /// <summary>
        ///  Ce produit à chaque nouvelle image reçu par l'entrée vidéo
        /// </summary>
        private void new_frame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame;
            Bitmap Compressed = new Bitmap(image, Buffer.DISPLAY_SIZE);
            
            this.Buffer.AddFrame(image, Compressed);
            this.Callback(Compressed, this.Index);
            GC.Collect();
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

        public Tuple<int, float> GetBufferProgress()
        {
            return new Tuple<int, float>(this.Buffer.Images.Count, this.Buffer.SecondsInBuffer());
        }

        public void SetOutputSettings(Size Resolution, int FPS)
        {
            this.Buffer.SetOutputSettings(Resolution, FPS);
        }

        #endregion
    }
}
