using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using takattoLostArkClicker.Helper;

namespace takattoLostArkClicker.Logic
{
    public static class Casting
    {
        public static void CastingAwakening()
        {
            // Simulate key press if the checkbox is checked and has a valid key
        }

        public static void GKey()
        {
            // Simulate key press if the checkbox is checked and has a valid key
        }

        public static void SpacebarKey()
        {
            // Simulate key press if the checkbox is checked and has a valid key
        }

        public static int CastingLogic()
        {
            if (MainForm.pauseCasting)
                return 2;



            bool anyKeyChecked = MainForm.checkBoxKeyMap.Any(kvp => kvp.Key.Checked && kvp.Value != Keys.None);

            if (anyKeyChecked)
            {
                foreach (var kvp in MainForm.checkBoxKeyMap)
                {
                    if (kvp.Key.Checked && kvp.Value != Keys.None)
                    {
                        // Simulate key press if the checkbox is checked and has a valid key
                    }
                }
                return 1;
            }
            else
                return 0;

        }
    }
}
