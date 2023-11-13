using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using takattoLostArkClicker.Helper;
using takattoLostArkClicker.Logic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace takattoLostArkClicker
{
    public partial class MainForm : Form
    {
        // static varriables
        public static IntPtr gamePointer = new IntPtr();
        public static string processName = "LOSTARK";

        public static Point originalMousePosition;

        public static bool isBotRunning;

        public static bool infChaosMode;
        public static bool preciseMode;
        public static bool dailyChaosMode;


        public static bool pauseCasting;

        public static int chaosStage = 0; //0: unstarted, 1:entered, 2:cleared g1, 3:cleared g2, 4:cleared g3

        public static string? characterClass;

        //
        private void ApplyButtonStyleToAllControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is System.Windows.Forms.Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.WhiteSmoke;
                }
                else if (control.HasChildren)
                {
                    ApplyButtonStyleToAllControls(control.Controls);
                }
            }
        }

        // logger
        public void Log(string text)
        {
            if (string.IsNullOrEmpty(text))
                return;

            // Append the text with the timestamp to the RichTextBox
            richTextBox.AppendText($"{Environment.NewLine}[{DateTime.Now.ToString("HH:mm:ss")}] {text}");
        }

        // emergency code to cancel bot
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl+C is pressed
            if (e.Control && e.KeyCode == Keys.C)
            {
                // Handle Ctrl+C
                if (botTimer.Enabled)
                {
                    Log($"Ctrl_C Key pressed, stopping bot...");
                    isBotRunning = false;
                    botTimer.Enabled = false;

                    btnStart.Text = "Start";
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            // Subscribe to the KeyDown event
            this.KeyDown += MainForm_KeyDown;

            // Set the form to be able to receive key events
            this.KeyPreview = true;


            ApplyButtonStyleToAllControls(this.Controls);

            // Add CheckBoxes to the dictionary with their associated keys
            checkBoxKeyMap.Add(cbKeyQ, Keys.Q);
            checkBoxKeyMap.Add(cbKeyW, Keys.W);
            checkBoxKeyMap.Add(cbKeyE, Keys.E);
            checkBoxKeyMap.Add(cbKeyR, Keys.R);
            checkBoxKeyMap.Add(cbKeyA, Keys.A);
            checkBoxKeyMap.Add(cbKeyS, Keys.S);
            checkBoxKeyMap.Add(cbKeyD, Keys.D);
            checkBoxKeyMap.Add(cbKeyF, Keys.F);
            checkBoxSpecialKeyMap.Add(cbKeyZ, Keys.Z);
            checkBoxSpecialKeyMap.Add(cbKeyX, Keys.X);

            // Attach the common event handler to all CheckBoxes
            foreach (var checkBox in checkBoxKeyMap.Keys)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }

            foreach (var checkBox in checkBoxSpecialKeyMap.Keys)
            {
                checkBox.CheckedChanged += CheckBoxSpecial_CheckedChanged;
            }

            cbClass.SelectedIndex = 0;
        }

        private void timerGettingGameStatusAndKey_Tick(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process P in processList)
            {
                if (P.ProcessName.Equals(processName))
                {
                    lbStatus.Text = $"Status: Running [{gamePointer.ToString()}]";
                    lbStatus.ForeColor = Color.DarkGreen;
                    gamePointer = P.MainWindowHandle;

                    return;
                }
            }

            lbStatus.Text = "Status: Game not running";
            lbStatus.ForeColor = Color.DarkRed;
            gamePointer = new IntPtr();
        }


        //bots
        private void CancelTasks()
        {
            // Cancel existing tasks if running
            enterChaosDungeonCancellationTokenSource.Cancel();
            skillCancellationTokenSource.Cancel();
            bossCheckCancellationTokenSource.Cancel();
            portalCheckCancellationTokenSource.Cancel();

            // Create new CancellationTokenSources for each task
            enterChaosDungeonCancellationTokenSource = new CancellationTokenSource();
            skillCancellationTokenSource = new CancellationTokenSource();
            bossCheckCancellationTokenSource = new CancellationTokenSource();
            portalCheckCancellationTokenSource = new CancellationTokenSource();
        }

        private static CancellationTokenSource skillCancellationTokenSource = new CancellationTokenSource();
        private static CancellationTokenSource bossCheckCancellationTokenSource = new CancellationTokenSource();
        private static CancellationTokenSource portalCheckCancellationTokenSource = new CancellationTokenSource();
        private static CancellationTokenSource enterChaosDungeonCancellationTokenSource = new CancellationTokenSource();
        private async Task MainBot()
        {
            //try
            //{
            //    // Create a list to store your tasks
            //    var tasks = new List<Task>();

            //    // Start your tasks and add them to the list
            //    tasks.Add(Task.Run(async () => await EnterChaos(enterChaosDungeonCancellationTokenSource.Token)));
            //    tasks.Add(Task.Run(async () => await SpamSkills(skillCancellationTokenSource.Token)));
            //    tasks.Add(Task.Run(async () => await CheckForBoss(bossCheckCancellationTokenSource.Token)));
            //    tasks.Add(Task.Run(async () => await CheckForPortal(portalCheckCancellationTokenSource.Token)));

            //    // Wait for any of the tasks to complete or for cancellation
            //    await Task.WhenAny(tasks.ToArray());

            //    // Cancel all tasks
            //    foreach (var task in tasks)
            //    {
            //        if (!task.IsCompleted)
            //        {
            //            CancelTask(task);
            //        }
            //    }
            //}
            //catch (OperationCanceledException)
            //{
            //    Log("MainBot was canceled");
            //}
        }


        private async Task EnterChaos(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Log("EnterChaos");
                    await Task.Delay(1000, cancellationToken);
                }

                Log("EnterChaos task was canceled");
            }
            catch (OperationCanceledException)
            {
                Log("EnterChaos task was canceled");
            }
        }

        private async Task SpamSkills(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    if (pauseCasting)
                    {
                        Log("SpamSkills task paused");
                        await Task.Delay(1000, cancellationToken);
                        continue;
                    }

                    int castingResult = Casting.CastingLogic();
                    Log(castingResult == 1 ? "Casting skill" : (castingResult == 0 ? "Cannot cast, no skill checked" : "Skill paused"));

                    Casting.GKey();
                    ClassSkill.CastingLogic();

                    await Task.Delay(1000, cancellationToken);
                    await Task.Delay(1000, cancellationToken);
                }

                Log("SpamSkills task was canceled");
            }
            catch (OperationCanceledException)
            {
                Log("SpamSkills task was canceled");
            }
        }

        private async Task CheckForBoss(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Log("CheckForBoss");
                    await Task.Delay(1000, cancellationToken);
                }

                Log("CheckForBoss task was canceled");
            }
            catch (OperationCanceledException)
            {
                Log("CheckForBoss task was canceled");
            }
        }

        private async Task CheckForPortal(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Log("CheckForPortal");
                    await Task.Delay(1000, cancellationToken);
                }

                Log("CheckForPortal task was canceled");
            }
            catch (OperationCanceledException)
            {
                Log("CheckForPortal task was canceled");
            }
        }


        private async Task SpamSkills2(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    int castingResult = Casting.CastingLogic();
                    Log(castingResult == 1 ? "Casting skill" : (castingResult == 0 ? "Cannot cast, no skill checked" : "Skill paused"));


                    ClassSkill.CastingLogic();
                    Casting.GKey();

                    await Task.Delay(1000, cancellationToken);
                }

                Log("Enter chaos task was canceled");
            }
            catch (OperationCanceledException)
            {
                Log("Enter chaos task was canceled");
            }
        }


        private void btnTest_Click(object sender, EventArgs e)
        {

            pauseCasting = true;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!isBotRunning)
            {
                Log($"Starting bot...");
                isBotRunning = true;

                btnStart.Text = "Stop";

                CancelTasks();

                var tasks = new[]
                {
                    EnterChaos(enterChaosDungeonCancellationTokenSource.Token),
                    SpamSkills(skillCancellationTokenSource.Token),
                    CheckForBoss(bossCheckCancellationTokenSource.Token),
                    CheckForPortal(portalCheckCancellationTokenSource.Token)
                };

                await Task.WhenAll(tasks);
            }
            else
            {
                Log($"Stopping bot...");
                isBotRunning = false;

                btnStart.Text = "Start";

                CancelTasks();
            }

        }




        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        private async void botTimer_Tick(object sender, EventArgs e)
        {
            if (gamePointer == IntPtr.Zero)
            {
                Log("Could not start, game process not found");
                Log($"Stopping bot...");
                isBotRunning = false;
                botTimer.Enabled = false;

                btnStart.Text = "Start";
                return;
            }

            await semaphore.WaitAsync();
            try
            {
                await System.Threading.Tasks.Task.Run(async () =>
                {
                    if (!isBotRunning)
                    {
                        return;
                    }

                    //chaos stage 0, starting chaos
                    if (chaosStage == 0)
                    {
                        originalMousePosition = Cursor.Position;
                        await UI.ClickContentButton();
                        await System.Threading.Tasks.Task.Delay(2000);
                        await UI.ClickContent_ChaosButton();
                        await System.Threading.Tasks.Task.Delay(2000);
                        await UI.ClickContent_Chaos_EnterButton();
                        await System.Threading.Tasks.Task.Delay(2000);
                        await UI.ClickContent_Chaos_Enter_YesButton();
                        await System.Threading.Tasks.Task.Delay(5000);

                        await UI.ReturnOriginalMousePos();
                        chaosStage = 1;
                    }


                    if (!isBotRunning)
                        return;

                    //pressing keys


                    bool boss = UI.CheckForBoss();

                    if (boss)
                    {
                        Log("Boss detected");
                        chaosStage = 2;
                        Casting.CastingAwakening();
                    }

                    if (chaosStage == 2 && !boss)
                    {
                        Log("Boss killed");

                        chaosStage = 0;

                        await System.Threading.Tasks.Task.Delay(2000);
                        await UI.Chaos_LeaveButton();
                        await System.Threading.Tasks.Task.Delay(2000);
                        await UI.ClickContent_Chaos_Enter_YesButton();
                        await System.Threading.Tasks.Task.Delay(15000);
                    }

                });
            }
            finally
            {
                // Release the semaphore to allow the next tick to enter
                semaphore.Release();
            }
        }

        private void cbAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cbAlwaysOnTop.Checked;
        }


        //skill key region
        public static Dictionary<CheckBox, Keys> checkBoxKeyMap = new Dictionary<CheckBox, Keys>();
        public static Dictionary<CheckBox, Keys> checkBoxSpecialKeyMap = new Dictionary<CheckBox, Keys>();

        private void SetInitialKey(CheckBox checkBox, Dictionary<CheckBox, Keys> checkB0x)
        {
            // Map each checkbox to its corresponding initial key
            Dictionary<CheckBox, Keys> initialKeys = new Dictionary<CheckBox, Keys>
            {
                { cbKeyQ, Keys.Q },
                { cbKeyW, Keys.W },
                { cbKeyE, Keys.E },
                { cbKeyR, Keys.R },
                { cbKeyA, Keys.A },
                { cbKeyS, Keys.S },
                { cbKeyD, Keys.D },
                { cbKeyF, Keys.F },
                { cbKeyZ, Keys.Z },
                { cbKeyX, Keys.X },
            };

            // Set the initial key based on the checkbox
            if (initialKeys.TryGetValue(checkBox, out var initialKey))
            {
                checkB0x[checkBox] = initialKey;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                // If the checkbox is checked and the current key is Keys.None, set the initial key
                if (checkBox.Checked && checkBoxKeyMap[checkBox] == Keys.None)
                {
                    SetInitialKey(checkBox, checkBoxKeyMap);
                }
                // If the checkbox is unchecked, set the corresponding key to Keys.None
                else if (!checkBox.Checked)
                {
                    checkBoxKeyMap[checkBox] = Keys.None;
                }

                // Print debugging information
                Log($"CheckBox: {checkBox.Name}, checked: {checkBox.Checked}, key value: {checkBoxKeyMap[checkBox]}");
            }
        }

        private void CheckBoxSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                // If the checkbox is checked and the current key is Keys.None, set the initial key
                if (checkBox.Checked && checkBoxSpecialKeyMap[checkBox] == Keys.None)
                {
                    SetInitialKey(checkBox, checkBoxSpecialKeyMap);
                }
                // If the checkbox is unchecked, set the corresponding key to Keys.None
                else if (!checkBox.Checked)
                {
                    checkBoxSpecialKeyMap[checkBox] = Keys.None;
                }

                // Print debugging information
                Log($"CheckBox: {checkBox.Name}, checked: {checkBox.Checked}, key value: {checkBoxSpecialKeyMap[checkBox]}");
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            bool anyCheckBoxChecked = checkBoxKeyMap.Any(entry => entry.Key.Checked);

            // Toggle the checked state of all checkboxes
            foreach (var checkBox in checkBoxKeyMap.Keys)
            {
                checkBox.Checked = !anyCheckBoxChecked;
            }

            foreach (var checkBox in checkBoxSpecialKeyMap.Keys)
            {
                checkBox.Checked = !anyCheckBoxChecked;
            }
        }


        private void cbInfChaosMode_CheckedChanged(object sender, EventArgs e)
        {
            infChaosMode = cbInfChaosMode.Checked;
            Log($"Infinity Chaos Mode: {infChaosMode.ToString()}");
        }

        private void cbDailyChaos_CheckedChanged(object sender, EventArgs e)
        {
            dailyChaosMode = cbDailyChaos.Checked;
            Log($"Daily Chaos Mode: {dailyChaosMode.ToString()}");

            if (cbDailyChaos.Checked)
            {
                cbPreciseMode.Checked = true;
                cbPreciseMode.Enabled = false;
            }
            else
            {
                cbPreciseMode.Checked = false;
                cbPreciseMode.Enabled = true;
            }
        }

        private void cbPreciseMode_CheckedChanged(object sender, EventArgs e)
        {
            preciseMode = cbPreciseMode.Checked;
            Log($"Precise Mode: {preciseMode.ToString()}");
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            characterClass = cbClass.SelectedItem?.ToString()?.Trim();

            Log("Character class sets to " + characterClass);

        }
        //NativeMethod.SendMessage(MainForm.gamePointer, 0x201, 0, (int) Coordination.ContentList); //down
        //NativeMethod.SendMessage(MainForm.gamePointer, 0x202, 0, (int) Coordination.ContentList); //up

        private void timerCheckCor_Tick(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;
            Color pixelColor = GetPixelColor(mousePosition.X, mousePosition.Y);
            lbInfo.Text = $"{mousePosition.X},{mousePosition.Y}, {pixelColor}";

        }
        internal static Color GetPixelColor(int x, int y)
        {
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
                }
                return bmp.GetPixel(0, 0);
            }
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
            if (!timerCheckCor.Enabled)
                timerCheckCor.Enabled = true;
            else
            {
                timerCheckCor.Enabled = false;
                lbInfo.Text = "[Click to get pointer]";
            }
        }

        int spaceBarCount = 0;
        private static CancellationTokenSource spaceBarSpammingCancellationTokenSource = new CancellationTokenSource();
        private async Task SpaceBarSpamming(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    if (spaceBarCount >= 50)
                    {
                        spaceBarSpammingCancellationTokenSource.Cancel();
                        Log("SpaceBarSpamming task was finished");
                        spaceBarCount = 0;
                        continue;
                    }

                    spaceBarCount++;

                    Casting.SpacebarKey();

                    await Task.Delay(5, cancellationToken);
                }

                Log("SpaceBarSpamming task was canceled");
            }
            catch (OperationCanceledException)
            {
                Log("SpaceBarSpamming task was canceled");
            }
        }

        private async void btnSpaceBarSpamming_Click(object sender, EventArgs e)
        {
            spaceBarSpammingCancellationTokenSource.Cancel();

            spaceBarSpammingCancellationTokenSource = new CancellationTokenSource();

            await SpaceBarSpamming(spaceBarSpammingCancellationTokenSource.Token);
        }
    }
}
