using System;
using System.Threading.Tasks;
using takattoLostArkClicker.Helper;

namespace takattoLostArkClicker.Logic
{
    internal static class UI
    {
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        internal static async System.Threading.Tasks.Task ReturnOriginalMousePos()
        {
            NativeMethod.SetCursorPos(MainForm.originalMousePosition.X, MainForm.originalMousePosition.Y);
            await System.Threading.Tasks.Task.Delay(100); // Adjust the delay if needed
        }

        internal static async System.Threading.Tasks.Task SendClick(int x, int y)
        {
            await System.Threading.Tasks.Task.Delay(100);

            NativeMethod.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero);

            // Wait for a moment (e.g., 100 milliseconds)
            await System.Threading.Tasks.Task.Delay(100);

            // Simulate left mouse button up
            NativeMethod.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero);

            //    uint coor = (uint)NativeMethod.MAKELPARAM(x, y);
            //    NativeMethod.SendMessage(MainForm.gamePointer, 0x201, 0, (int)coor); //down
            //    NativeMethod.SendMessage(MainForm.gamePointer, 0x201, 0, (int)coor); //down
            //    NativeMethod.SendMessage(MainForm.gamePointer, 0x201, 0, (int)coor); //down
            //    await Task.Delay(400);
            //    NativeMethod.SendMessage(MainForm.gamePointer, 0x202, 0, (int)coor); //up

            //    NativeMethod.SendMessage(MainForm.gamePointer, 0x201, 0, (int)coor); //down
            //    await Task.Delay(100);
            //    NativeMethod.SendMessage(MainForm.gamePointer, 0x202, 0, (int)coor); //up
            //    await Task.Delay(100);
            //    NativeMethod.SendMessage(MainForm.gamePointer, 0x201, 0, (int)coor); //down
            //    await Task.Delay(100);
            //    NativeMethod.SendMessage(MainForm.gamePointer, 0x202, 0, (int)coor); //up
        }

        internal static async System.Threading.Tasks.Task ClickContentButton()
        {
            int x = 1845; int y = 350;

            NativeMethod.SetCursorPos(x, y);
            await SendClick(x, y);
        }

        internal static async System.Threading.Tasks.Task ClickContent_ChaosButton()
        {
            int x = 810; int y = 285;

            NativeMethod.SetCursorPos(x, y);
            await SendClick(x, y);
        }

        internal static async System.Threading.Tasks.Task ClickContent_Chaos_EnterButton()
        {
            int x = 1460; int y = 870;

            NativeMethod.SetCursorPos(x, y);
            await SendClick(x, y);
        }

        internal static async System.Threading.Tasks.Task ClickContent_Chaos_Enter_YesButton()
        {
            int x = 910; int y = 600;

            NativeMethod.SetCursorPos(x, y);
            await SendClick(x, y);
        }

        internal static async System.Threading.Tasks.Task Chaos_LeaveButton()
        {
            int x = 150; int y = 320;

            NativeMethod.SetCursorPos(x, y);
            await SendClick(x, y);
        }

        internal static bool CheckForBoss()
        {
            if (Method.AreColorsEqual(Color.FromArgb(210, 134, 38), MainForm.GetPixelColor(625, 80)))
            {
                return true;
            }

            return false;
        }
    }
}
