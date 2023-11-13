namespace takattoLostArkClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbStatus = new Label();
            timerGettingGameStatusAndKey = new System.Windows.Forms.Timer(components);
            cbInfChaosMode = new CheckBox();
            cbDailyChaos = new CheckBox();
            toolTip = new ToolTip(components);
            cbPreciseMode = new CheckBox();
            btnStart = new Button();
            panel1 = new Panel();
            cbClass = new ComboBox();
            lbClass = new Label();
            btnCheckAll = new Button();
            cbKeyX = new CheckBox();
            cbKeyZ = new CheckBox();
            cbKeyF = new CheckBox();
            cbKeyD = new CheckBox();
            cbKeyS = new CheckBox();
            cbKeyA = new CheckBox();
            cbKeyR = new CheckBox();
            cbKeyE = new CheckBox();
            cbKeyW = new CheckBox();
            cbKeyQ = new CheckBox();
            lbSkillToUse = new Label();
            cbAlwaysOnTop = new CheckBox();
            botTimer = new System.Windows.Forms.Timer(components);
            richTextBox = new RichTextBox();
            timerCheckCor = new System.Windows.Forms.Timer(components);
            lbInfo = new Label();
            panel2 = new Panel();
            lbMode = new Label();
            btnTest = new Button();
            btnSpaceBarSpamming = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(12, 9);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(87, 20);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "Initializing...";
            // 
            // timerGettingGameStatusAndKey
            // 
            timerGettingGameStatusAndKey.Enabled = true;
            timerGettingGameStatusAndKey.Interval = 3000;
            timerGettingGameStatusAndKey.Tick += timerGettingGameStatusAndKey_Tick;
            // 
            // cbInfChaosMode
            // 
            cbInfChaosMode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbInfChaosMode.AutoSize = true;
            cbInfChaosMode.Location = new Point(10, 36);
            cbInfChaosMode.Margin = new Padding(3, 4, 3, 4);
            cbInfChaosMode.Name = "cbInfChaosMode";
            cbInfChaosMode.Size = new Size(120, 24);
            cbInfChaosMode.TabIndex = 1;
            cbInfChaosMode.Text = "Infinity Chaos";
            toolTip.SetToolTip(cbInfChaosMode, "Infinity loop the Chaos Dungeon, exit after clearing the 2nd room");
            cbInfChaosMode.UseVisualStyleBackColor = true;
            cbInfChaosMode.CheckedChanged += cbInfChaosMode_CheckedChanged;
            // 
            // cbDailyChaos
            // 
            cbDailyChaos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbDailyChaos.AutoSize = true;
            cbDailyChaos.Location = new Point(10, 66);
            cbDailyChaos.Margin = new Padding(3, 4, 3, 4);
            cbDailyChaos.Name = "cbDailyChaos";
            cbDailyChaos.Size = new Size(109, 24);
            cbDailyChaos.TabIndex = 2;
            cbDailyChaos.Text = "Daily Chaos";
            toolTip.SetToolTip(cbDailyChaos, "Clear the Chaos Dungeon  with all three gates; this task requires the use of both the keyboard and mouse");
            cbDailyChaos.UseVisualStyleBackColor = true;
            cbDailyChaos.CheckedChanged += cbDailyChaos_CheckedChanged;
            // 
            // cbPreciseMode
            // 
            cbPreciseMode.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbPreciseMode.AutoSize = true;
            cbPreciseMode.Location = new Point(444, 261);
            cbPreciseMode.Margin = new Padding(3, 4, 3, 4);
            cbPreciseMode.Name = "cbPreciseMode";
            cbPreciseMode.Size = new Size(120, 24);
            cbPreciseMode.TabIndex = 8;
            cbPreciseMode.Text = "Precise Mode";
            toolTip.SetToolTip(cbPreciseMode, "Scan the game for correct movement");
            cbPreciseMode.UseVisualStyleBackColor = true;
            cbPreciseMode.CheckedChanged += cbPreciseMode_CheckedChanged;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStart.Location = new Point(570, 258);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(cbClass);
            panel1.Controls.Add(lbClass);
            panel1.Controls.Add(btnCheckAll);
            panel1.Controls.Add(cbKeyX);
            panel1.Controls.Add(cbKeyZ);
            panel1.Controls.Add(cbKeyF);
            panel1.Controls.Add(cbKeyD);
            panel1.Controls.Add(cbKeyS);
            panel1.Controls.Add(cbKeyA);
            panel1.Controls.Add(cbKeyR);
            panel1.Controls.Add(cbKeyE);
            panel1.Controls.Add(cbKeyW);
            panel1.Controls.Add(cbKeyQ);
            panel1.Controls.Add(lbSkillToUse);
            panel1.Location = new Point(328, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 136);
            panel1.TabIndex = 4;
            // 
            // cbClass
            // 
            cbClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.FormattingEnabled = true;
            cbClass.Items.AddRange(new object[] { " None", " Bard", " Aero", " Artist" });
            cbClass.Location = new Point(246, 102);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(94, 28);
            cbClass.TabIndex = 18;
            cbClass.SelectedIndexChanged += cbClass_SelectedIndexChanged;
            // 
            // lbClass
            // 
            lbClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbClass.AutoSize = true;
            lbClass.ForeColor = Color.FromArgb(34, 34, 34);
            lbClass.Location = new Point(199, 105);
            lbClass.Name = "lbClass";
            lbClass.Size = new Size(45, 20);
            lbClass.TabIndex = 17;
            lbClass.Text = "Class:";
            // 
            // btnCheckAll
            // 
            btnCheckAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckAll.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckAll.Location = new Point(6, 102);
            btnCheckAll.Margin = new Padding(3, 4, 3, 4);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(88, 29);
            btnCheckAll.TabIndex = 16;
            btnCheckAll.Text = "All";
            btnCheckAll.UseVisualStyleBackColor = true;
            btnCheckAll.Click += btnCheckAll_Click;
            // 
            // cbKeyX
            // 
            cbKeyX.AutoSize = true;
            cbKeyX.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyX.Location = new Point(296, 66);
            cbKeyX.Margin = new Padding(3, 4, 3, 4);
            cbKeyX.Name = "cbKeyX";
            cbKeyX.Size = new Size(40, 24);
            cbKeyX.TabIndex = 15;
            cbKeyX.Text = "X";
            // 
            // cbKeyZ
            // 
            cbKeyZ.AutoSize = true;
            cbKeyZ.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyZ.Location = new Point(296, 36);
            cbKeyZ.Margin = new Padding(3, 4, 3, 4);
            cbKeyZ.Name = "cbKeyZ";
            cbKeyZ.Size = new Size(40, 24);
            cbKeyZ.TabIndex = 14;
            cbKeyZ.Text = "Z";
            // 
            // cbKeyF
            // 
            cbKeyF.AutoSize = true;
            cbKeyF.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyF.Location = new Point(160, 66);
            cbKeyF.Margin = new Padding(3, 4, 3, 4);
            cbKeyF.Name = "cbKeyF";
            cbKeyF.Size = new Size(38, 24);
            cbKeyF.TabIndex = 13;
            cbKeyF.Text = "F";
            // 
            // cbKeyD
            // 
            cbKeyD.AutoSize = true;
            cbKeyD.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyD.Location = new Point(110, 66);
            cbKeyD.Margin = new Padding(3, 4, 3, 4);
            cbKeyD.Name = "cbKeyD";
            cbKeyD.Size = new Size(42, 24);
            cbKeyD.TabIndex = 12;
            cbKeyD.Text = "D";
            // 
            // cbKeyS
            // 
            cbKeyS.AutoSize = true;
            cbKeyS.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyS.Location = new Point(60, 66);
            cbKeyS.Margin = new Padding(3, 4, 3, 4);
            cbKeyS.Name = "cbKeyS";
            cbKeyS.Size = new Size(39, 24);
            cbKeyS.TabIndex = 11;
            cbKeyS.Text = "S";
            // 
            // cbKeyA
            // 
            cbKeyA.AutoSize = true;
            cbKeyA.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyA.Location = new Point(10, 66);
            cbKeyA.Margin = new Padding(3, 4, 3, 4);
            cbKeyA.Name = "cbKeyA";
            cbKeyA.Size = new Size(41, 24);
            cbKeyA.TabIndex = 10;
            cbKeyA.Text = "A";
            // 
            // cbKeyR
            // 
            cbKeyR.AutoSize = true;
            cbKeyR.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyR.Location = new Point(160, 36);
            cbKeyR.Margin = new Padding(3, 4, 3, 4);
            cbKeyR.Name = "cbKeyR";
            cbKeyR.Size = new Size(40, 24);
            cbKeyR.TabIndex = 9;
            cbKeyR.Text = "R";
            // 
            // cbKeyE
            // 
            cbKeyE.AutoSize = true;
            cbKeyE.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyE.Location = new Point(110, 36);
            cbKeyE.Margin = new Padding(3, 4, 3, 4);
            cbKeyE.Name = "cbKeyE";
            cbKeyE.Size = new Size(39, 24);
            cbKeyE.TabIndex = 8;
            cbKeyE.Text = "E";
            // 
            // cbKeyW
            // 
            cbKeyW.AutoSize = true;
            cbKeyW.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyW.Location = new Point(60, 36);
            cbKeyW.Margin = new Padding(3, 4, 3, 4);
            cbKeyW.Name = "cbKeyW";
            cbKeyW.Size = new Size(45, 24);
            cbKeyW.TabIndex = 7;
            cbKeyW.Text = "W";
            // 
            // cbKeyQ
            // 
            cbKeyQ.AutoSize = true;
            cbKeyQ.ForeColor = Color.FromArgb(54, 54, 54);
            cbKeyQ.Location = new Point(10, 36);
            cbKeyQ.Margin = new Padding(3, 4, 3, 4);
            cbKeyQ.Name = "cbKeyQ";
            cbKeyQ.Size = new Size(42, 24);
            cbKeyQ.TabIndex = 6;
            cbKeyQ.Text = "Q";
            // 
            // lbSkillToUse
            // 
            lbSkillToUse.AutoSize = true;
            lbSkillToUse.ForeColor = Color.FromArgb(34, 34, 34);
            lbSkillToUse.Location = new Point(7, 9);
            lbSkillToUse.Name = "lbSkillToUse";
            lbSkillToUse.Size = new Size(99, 20);
            lbSkillToUse.TabIndex = 5;
            lbSkillToUse.Text = "Skill(s) to use:";
            // 
            // cbAlwaysOnTop
            // 
            cbAlwaysOnTop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbAlwaysOnTop.AutoSize = true;
            cbAlwaysOnTop.Location = new Point(12, 261);
            cbAlwaysOnTop.Margin = new Padding(3, 4, 3, 4);
            cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            cbAlwaysOnTop.Size = new Size(125, 24);
            cbAlwaysOnTop.TabIndex = 5;
            cbAlwaysOnTop.Text = "Always on top";
            cbAlwaysOnTop.UseVisualStyleBackColor = true;
            cbAlwaysOnTop.CheckedChanged += cbAlwaysOnTop_CheckedChanged;
            // 
            // botTimer
            // 
            botTimer.Interval = 1000;
            botTimer.Tick += botTimer_Tick;
            // 
            // richTextBox
            // 
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBox.BackColor = Color.FromArgb(244, 244, 234);
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox.ForeColor = Color.DimGray;
            richTextBox.HideSelection = false;
            richTextBox.Location = new Point(328, 138);
            richTextBox.Margin = new Padding(3, 4, 3, 4);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.Size = new Size(348, 63);
            richTextBox.TabIndex = 6;
            richTextBox.Text = "Log and stuffs will be written there~";
            // 
            // timerCheckCor
            // 
            timerCheckCor.Tick += timerCheckCor_Tick;
            // 
            // lbInfo
            // 
            lbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbInfo.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbInfo.ForeColor = SystemColors.ButtonShadow;
            lbInfo.Location = new Point(328, 202);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(348, 20);
            lbInfo.TabIndex = 9;
            lbInfo.Text = "[Click to get pointer]";
            lbInfo.TextAlign = ContentAlignment.TopRight;
            lbInfo.Click += lbInfo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 242, 242);
            panel2.Controls.Add(lbMode);
            panel2.Controls.Add(cbInfChaosMode);
            panel2.Controls.Add(cbDailyChaos);
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 156);
            panel2.TabIndex = 10;
            // 
            // lbMode
            // 
            lbMode.AutoSize = true;
            lbMode.ForeColor = Color.FromArgb(34, 34, 34);
            lbMode.Location = new Point(7, 9);
            lbMode.Name = "lbMode";
            lbMode.Size = new Size(51, 20);
            lbMode.TabIndex = 6;
            lbMode.Text = "Mode:";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(328, 208);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 11;
            btnTest.Text = "TEST";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnSpaceBarSpamming
            // 
            btnSpaceBarSpamming.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSpaceBarSpamming.Location = new Point(570, 226);
            btnSpaceBarSpamming.Margin = new Padding(3, 4, 3, 4);
            btnSpaceBarSpamming.Name = "btnSpaceBarSpamming";
            btnSpaceBarSpamming.Size = new Size(94, 29);
            btnSpaceBarSpamming.TabIndex = 12;
            btnSpaceBarSpamming.Text = "Spacebar";
            toolTip.SetToolTip(btnSpaceBarSpamming, "Spamming the space key 50 times in a short perioid of time");
            btnSpaceBarSpamming.UseVisualStyleBackColor = true;
            btnSpaceBarSpamming.Click += btnSpaceBarSpamming_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(676, 298);
            Controls.Add(btnSpaceBarSpamming);
            Controls.Add(btnTest);
            Controls.Add(panel2);
            Controls.Add(lbInfo);
            Controls.Add(cbPreciseMode);
            Controls.Add(richTextBox);
            Controls.Add(cbAlwaysOnTop);
            Controls.Add(panel1);
            Controls.Add(btnStart);
            Controls.Add(lbStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "LostArk Cat helper, made for ning neechan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStatus;
        private System.Windows.Forms.Timer timerGettingGameStatusAndKey;
        private CheckBox cbInfChaosMode;
        private CheckBox cbDailyChaos;
        private ToolTip toolTip;
        private Button btnStart;
        private Panel panel1;
        private Label lbSkillToUse;
        private CheckBox cbAlwaysOnTop;
        private CheckBox cbKeyQ;
        private CheckBox cbKeyF;
        private CheckBox cbKeyD;
        private CheckBox cbKeyS;
        private CheckBox cbKeyA;
        private CheckBox cbKeyR;
        private CheckBox cbKeyE;
        private CheckBox cbKeyW;
        private CheckBox cbKeyX;
        private CheckBox cbKeyZ;
        private System.Windows.Forms.Timer botTimer;
        private Button btnCheckAll;
        private CheckBox cbPreciseMode;
        private ComboBox cbClass;
        private Label lbClass;
        private RichTextBox richTextBox;
        private System.Windows.Forms.Timer timerCheckCor;
        private Label lbInfo;
        private Panel panel2;
        private Label lbMode;
        private Button btnTest;
        private Button btnSpaceBarSpamming;
    }
}