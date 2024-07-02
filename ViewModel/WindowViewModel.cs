using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TheBetterWord
{
    public class WindowViewModel : BaseViewModel
    {

        #region Private Member

        private Window mWindow;
        private int mOuterMarginSize = 10;
        private int mWindowRadius = 10;

        #endregion

        #region Public Properties

        public int ResizeBorderThickness { get; set; } = 6;

        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder); } }


        #endregion



        #region Constructor
        public WindowViewModel(Window window)
        {
            mWindow = window;
        }
        #endregion


    }
}
