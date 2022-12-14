using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaviewReplay4
{
    public class Buffer
    {
        #region VARIABLES
        
        #region Variables privées
        private int _fPS;
        private int _timeInSeconds;
        private int _frames;
        private int _compressionRatio;
        private Size _outputResolution;
        
        private bool _running;
        
        private List<Bitmap> _compressedImages;
        private List<Bitmap> _images;
        #endregion

        #region Constantes publiques
        public static int DEFAULT_FPS = 25;
        public static int DEFAULT_TIME = 5;
        public static int DEFAULT_COMPRESSION_RATIO = 4;

        public static Size DISPLAY_SIZE = new Size(640, 360);
        public static Size DEFAULT_RESOLUTION = new Size(1920, 1080);
        #endregion

        #region Variables publiques
        public int FPS { get => _fPS; set => _fPS = value; }
        public int TimeInSeconds { get => _timeInSeconds; set => _timeInSeconds = value; }
        public int Frames { get => _frames; set => _frames = value; }
        public List<Bitmap> CompressedImages { get => _compressedImages; set => _compressedImages = value; }
        public List<Bitmap> Images { get => _images; set => _images = value; }
        public bool Running { get => _running; set => _running = value; }
        public int CompressionRatio { get => _compressionRatio; set => _compressionRatio = value; }
        public Size OutputResolution { get => _outputResolution; set => _outputResolution = value; }
        #endregion

        #endregion

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Buffer()
        {
            this.FPS = DEFAULT_FPS;
            this.TimeInSeconds = DEFAULT_TIME;
            this.CompressionRatio = DEFAULT_COMPRESSION_RATIO;
            this.OutputResolution = DEFAULT_RESOLUTION;
            this.Running = false;

            this.Frames = this.FPS * this.TimeInSeconds;
            
            this.CompressedImages = new List<Bitmap>();
            this.Images = new List<Bitmap>();
        }

        /// <summary>
        /// Ajouter une frame dans la liste des images du buffer ainsi que des images compressées
        /// </summary>
        /// <param name="Frame">L'image à ajouter</param>
        public void AddFrame(Bitmap Frame, Bitmap Compressed)
        {
            // SI le buffer est en train de fonctionner
            if (this.Running)
            {
                // SI le nombre de frames dans le buffer est supérieur au nombre de frames maximum
                if (this.Images.Count >= this.Frames)
                {
                    
                    this.Images.RemoveAt(0);
                    this.CompressedImages.RemoveAt(0);
                    GC.Collect();
                }

                this.Images.Add(Frame);
                this.CompressedImages.Add(Compressed);  
            }
        }

        /// <summary>
        /// Donner le nombre de de secondes dans le Buffer
        /// </summary>
        /// <returns>un float avec le nombre de Buffer</returns>
        public float SecondsInBuffer()
        {
            return (float)this.Images.Count / (float)this.FPS;
        }

        #region DEMARRER / STOPPER LE BUFFER
        /// <summary>
        /// Démarrer le Buffer
        /// </summary>
        public void Start()
        {
            this.Running = true;
        }

        /// <summary>
        /// Changes the Buffer and output resolution. 
        /// ATTENTION : It clear the actual buffer
        /// </summary>
        /// <param name="resolution">new resolution</param>
        /// <param name="fPS">new framerate</param>
        public void SetOutputSettings(Size resolution, int fPS)
        {
            this.Images.Clear();
            this.CompressedImages.Clear();

            this.FPS = fPS;
            this.OutputResolution = resolution;
            this.Frames = this.FPS * this.TimeInSeconds;
        }

        /// <summary>
        /// Stopper le Buffer
        /// </summary>
        public void Stop()
        {
            this.Running = false;
        }
        #endregion
    }
}
