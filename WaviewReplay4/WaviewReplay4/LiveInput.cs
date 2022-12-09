using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaviewReplay4
{
    public class LiveInput
    {
        #region Variables privées
        private AForge.Video.DirectShow.VideoCaptureDevice _InputDevice;
        private AForge.Video.DirectShow.FilterInfoCollection _VideoDevices;
        private PictureBox _pbReplay;
        #endregion

        #region Variables publiques

        #endregion

        public LiveInput()
        {
            
        }
    }
}
