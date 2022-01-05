using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controller
{
    class DataHelper
    {
        private static Color _colorMode = Color.White;

        public readonly static Color COLOR_MODE_BLACK = Color.FromArgb(50, 50, 50);
        public readonly static Color COLOR_MODE_WHITE = Color.White;

        public static Model.user loginedUser;
        public static Action<Color> colorChangedEvent;
        public static Color colorMode
        {
            get
            {
                return _colorMode;
            }
            set
            {
                _colorMode = value;

                if (colorChangedEvent != null)
                    colorChangedEvent(_colorMode);
            }
        }

        public static void changeColorMode()
        {
            if (_colorMode == COLOR_MODE_BLACK)
                colorMode = COLOR_MODE_WHITE;
            else
                colorMode = COLOR_MODE_BLACK;
        }

    }
}
