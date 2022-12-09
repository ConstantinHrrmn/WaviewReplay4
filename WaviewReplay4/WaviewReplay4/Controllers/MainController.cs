using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaviewReplay4
{
    public class MainController
    {
        #region Variables privées
        private FrmMain _frame;
        #endregion

        #region Variable publiques
        public FrmMain Frame { get => _frame; set => _frame = value; }
        #endregion

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="a_frame">La form par défaut</param>
        public MainController(FrmMain a_frame)
        {
            this.Frame = a_frame;
        }
    }
}
