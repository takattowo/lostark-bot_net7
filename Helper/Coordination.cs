using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takattoLostArkClicker.Helper
{
    internal static class Coordination
    {
        //Content List button, should be the first icon from right to left
        internal static uint ContentList = (uint)NativeMethod.MAKELPARAM(1845, 350);
    }
}
