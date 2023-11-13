using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takattoLostArkClicker.Helper
{
    internal static class Method
    {
        internal static bool AreColorsEqual(Color color1, Color color2)//, int tolerance)
        {
            int tolerance = 15;
            // Compare each component of the colors (R, G, B)
            int redDiff = Math.Abs(color1.R - color2.R);
            int greenDiff = Math.Abs(color1.G - color2.G);
            int blueDiff = Math.Abs(color1.B - color2.B);

            return redDiff <= tolerance && greenDiff <= tolerance && blueDiff <= tolerance;
        }

    }
}
