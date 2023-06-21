using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ConnectMe
{
    public class Theme
    {
        public Theme(string themeName, Color mainColor, Color secondryColor, Color textColor, bool isDark)
        {
            ThemeName = themeName;
            MainColor = mainColor;
            SecondryColor = secondryColor;
            TextColor = textColor;
            IsDark = isDark;
        }

        public string ThemeName { get; set; }
        public Color MainColor { get; set; }
        public Color SecondryColor { get; set; }
        public Color TextColor { get; set; }
        public bool IsDark { get; set; }
    }
}

