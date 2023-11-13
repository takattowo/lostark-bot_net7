using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using takattoLostArkClicker.Helper;

namespace takattoLostArkClicker.Logic
{
    public static class ClassSkill
    {


        public static int CastingLogic()
        {
            switch (MainForm.characterClass)
            {
                case "Aero":
                    if(Method.AreColorsEqual(Color.FromArgb(204, 247, 255), MainForm.GetPixelColor(1014, 1041)))
                    {
                        // Simulate key press if the checkbox is checked and has a valid key
                        MainForm.pauseCasting = true;
                        return 1;
                    }
                    else if(Method.AreColorsEqual(Color.FromArgb(255, 254, 215), MainForm.GetPixelColor(901, 1043)))
                    {
                        MainForm.pauseCasting = true;
                    }
                    else
                        MainForm.pauseCasting = false;
                    return 0;
                case "None":
                default:
                    bool anyKeyChecked = MainForm.checkBoxSpecialKeyMap.Any(kvp => kvp.Key.Checked && kvp.Value != Keys.None);
                    if (anyKeyChecked)
                    {
                        foreach (var kvp in MainForm.checkBoxSpecialKeyMap)
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
}