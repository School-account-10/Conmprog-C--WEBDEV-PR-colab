namespace iLS
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnHistory = new Button();
            label1 = new Label();
            EasyMed_Logo = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            flowSymptoms = new FlowLayoutPanel();
            chkFever = new CheckBox();
            chkCough = new CheckBox();
            chkHeadache = new CheckBox();
            chkFatigue = new CheckBox();
            chkSoreThroat = new CheckBox();
            chkRunnyNose = new CheckBox();
            chkBodyAches = new CheckBox();
            chkNausea = new CheckBox();
            chkVomiting = new CheckBox();
            chkDiarrhea = new CheckBox();
            chkShortBreath = new CheckBox();
            chkChestPain = new CheckBox();
            btnClear = new Button();
            label3 = new Label();
            btnCheck = new Button();
            panel4 = new Panel();
            labelTimestamp = new Label();
            btnInfo = new Button();
            panelResult = new Panel();
            panel7 = new Panel();
            labelOutput = new Label();
            label4 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            toolTipInfo = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EasyMed_Logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            flowSymptoms.SuspendLayout();
            panel4.SuspendLayout();
            panelResult.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EasyMed_Logo);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.ForeColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 168);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = SystemColors.ButtonHighlight;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.ForeColor = SystemColors.ControlText;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.Location = new Point(10, 13);
            btnHistory.Margin = new Padding(4, 5, 4, 5);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(47, 55);
            btnHistory.TabIndex = 2;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(109, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 48);
            label1.TabIndex = 1;
            label1.Text = "EasyMed";
            label1.Click += label1_Click;
            // 
            // EasyMed_Logo
            // 
            EasyMed_Logo.AccessibleRole = AccessibleRole.None;
            EasyMed_Logo.Anchor = AnchorStyles.None;
            EasyMed_Logo.BackColor = Color.Transparent;
            EasyMed_Logo.Image = (Image)resources.GetObject("EasyMed_Logo.Image");
            EasyMed_Logo.Location = new Point(75, 23);
            EasyMed_Logo.Margin = new Padding(4, 5, 4, 5);
            EasyMed_Logo.Name = "EasyMed_Logo";
            EasyMed_Logo.Size = new Size(36, 48);
            EasyMed_Logo.TabIndex = 0;
            EasyMed_Logo.TabStop = false;
            EasyMed_Logo.Click += EasyMed_Logo_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 178);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1898, 49);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(944, 32);
            label2.TabIndex = 0;
            label2.Text = ".DISCLAIMER! THIS APP IS NOT ACCURATE AND GUARANTEED. USE AT YOUR OWN RISK";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(flowSymptoms);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnCheck);
            panel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel3.Location = new Point(-1, 237);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(409, 1500);
            panel3.TabIndex = 2;
            // 
            // flowSymptoms
            // 
            flowSymptoms.AutoScroll = true;
            flowSymptoms.BackColor = SystemColors.ControlLight;
            flowSymptoms.BorderStyle = BorderStyle.FixedSingle;
            flowSymptoms.Controls.Add(chkFever);
            flowSymptoms.Controls.Add(chkCough);
            flowSymptoms.Controls.Add(chkHeadache);
            flowSymptoms.Controls.Add(chkFatigue);
            flowSymptoms.Controls.Add(chkSoreThroat);
            flowSymptoms.Controls.Add(chkRunnyNose);
            flowSymptoms.Controls.Add(chkBodyAches);
            flowSymptoms.Controls.Add(chkNausea);
            flowSymptoms.Controls.Add(chkVomiting);
            flowSymptoms.Controls.Add(chkDiarrhea);
            flowSymptoms.Controls.Add(chkShortBreath);
            flowSymptoms.Controls.Add(chkChestPain);
            flowSymptoms.FlowDirection = FlowDirection.TopDown;
            flowSymptoms.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            flowSymptoms.Location = new Point(42, 95);
            flowSymptoms.Name = "flowSymptoms";
            flowSymptoms.Size = new Size(300, 430);
            flowSymptoms.TabIndex = 10;
            flowSymptoms.WrapContents = false;
            // 
            // chkFever
            // 
            chkFever.AccessibleName = "";
            chkFever.AutoSize = true;
            chkFever.Location = new Point(3, 3);
            chkFever.Name = "chkFever";
            chkFever.Size = new Size(84, 29);
            chkFever.TabIndex = 2;
            chkFever.Text = "Fever";
            chkFever.UseVisualStyleBackColor = true;
            chkFever.CheckedChanged += chkFever_CheckedChanged;
            // 
            // chkCough
            // 
            chkCough.AutoSize = true;
            chkCough.Location = new Point(3, 38);
            chkCough.Name = "chkCough";
            chkCough.Size = new Size(93, 29);
            chkCough.TabIndex = 3;
            chkCough.Text = "Cough";
            chkCough.UseVisualStyleBackColor = true;
            chkCough.CheckedChanged += chkCough_CheckedChanged;
            // 
            // chkHeadache
            // 
            chkHeadache.AutoSize = true;
            chkHeadache.Location = new Point(3, 73);
            chkHeadache.Name = "chkHeadache";
            chkHeadache.Size = new Size(123, 29);
            chkHeadache.TabIndex = 4;
            chkHeadache.Text = "Headache";
            chkHeadache.UseVisualStyleBackColor = true;
            // 
            // chkFatigue
            // 
            chkFatigue.AutoSize = true;
            chkFatigue.Location = new Point(3, 108);
            chkFatigue.Name = "chkFatigue";
            chkFatigue.Size = new Size(100, 29);
            chkFatigue.TabIndex = 5;
            chkFatigue.Text = "Fatigue";
            chkFatigue.UseVisualStyleBackColor = true;
            // 
            // chkSoreThroat
            // 
            chkSoreThroat.AutoSize = true;
            chkSoreThroat.Location = new Point(3, 143);
            chkSoreThroat.Name = "chkSoreThroat";
            chkSoreThroat.Size = new Size(138, 29);
            chkSoreThroat.TabIndex = 6;
            chkSoreThroat.Text = "Sore Throat";
            chkSoreThroat.UseVisualStyleBackColor = true;
            // 
            // chkRunnyNose
            // 
            chkRunnyNose.AutoSize = true;
            chkRunnyNose.Location = new Point(3, 178);
            chkRunnyNose.Name = "chkRunnyNose";
            chkRunnyNose.Size = new Size(141, 29);
            chkRunnyNose.TabIndex = 7;
            chkRunnyNose.Text = "Runny Nose";
            chkRunnyNose.UseVisualStyleBackColor = true;
            chkRunnyNose.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkBodyAches
            // 
            chkBodyAches.AutoSize = true;
            chkBodyAches.Location = new Point(3, 213);
            chkBodyAches.Name = "chkBodyAches";
            chkBodyAches.Size = new Size(138, 29);
            chkBodyAches.TabIndex = 8;
            chkBodyAches.Text = "Body Aches";
            chkBodyAches.UseVisualStyleBackColor = true;
            // 
            // chkNausea
            // 
            chkNausea.AutoSize = true;
            chkNausea.Location = new Point(3, 248);
            chkNausea.Name = "chkNausea";
            chkNausea.Size = new Size(101, 29);
            chkNausea.TabIndex = 9;
            chkNausea.Text = "Nausea";
            chkNausea.UseVisualStyleBackColor = true;
            chkNausea.CheckedChanged += checkBox2_CheckedChanged_1;
            // 
            // chkVomiting
            // 
            chkVomiting.AutoSize = true;
            chkVomiting.Location = new Point(3, 283);
            chkVomiting.Name = "chkVomiting";
            chkVomiting.Size = new Size(115, 29);
            chkVomiting.TabIndex = 11;
            chkVomiting.Text = "Vomiting";
            chkVomiting.UseVisualStyleBackColor = true;
            // 
            // chkDiarrhea
            // 
            chkDiarrhea.AutoSize = true;
            chkDiarrhea.Location = new Point(3, 318);
            chkDiarrhea.Name = "chkDiarrhea";
            chkDiarrhea.Size = new Size(111, 29);
            chkDiarrhea.TabIndex = 12;
            chkDiarrhea.Text = "Diarrhea";
            chkDiarrhea.UseVisualStyleBackColor = true;
            // 
            // chkShortBreath
            // 
            chkShortBreath.AutoSize = true;
            chkShortBreath.Location = new Point(3, 353);
            chkShortBreath.Name = "chkShortBreath";
            chkShortBreath.Size = new Size(207, 29);
            chkShortBreath.TabIndex = 13;
            chkShortBreath.Text = "Shortness of Breath";
            chkShortBreath.UseVisualStyleBackColor = true;
            // 
            // chkChestPain
            // 
            chkChestPain.AutoSize = true;
            chkChestPain.Location = new Point(3, 388);
            chkChestPain.Name = "chkChestPain";
            chkChestPain.Size = new Size(127, 29);
            chkChestPain.TabIndex = 14;
            chkChestPain.Text = "Chest Pain";
            chkChestPain.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(127, 613);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(70, 51);
            label3.Name = "label3";
            label3.Size = new Size(266, 32);
            label3.TabIndex = 0;
            label3.Text = "Select your symptoms";
            label3.Click += label3_Click_3;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.LightGreen;
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.Location = new Point(77, 556);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(223, 34);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Check Diagnosis";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(labelTimestamp);
            panel4.Controls.Add(btnInfo);
            panel4.Controls.Add(panelResult);
            panel4.Controls.Add(label4);
            panel4.Cursor = Cursors.Hand;
            panel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(417, 237);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(1884, 1011);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // labelTimestamp
            // 
            labelTimestamp.AutoSize = true;
            labelTimestamp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTimestamp.ForeColor = SystemColors.ControlText;
            labelTimestamp.Location = new Point(203, 484);
            labelTimestamp.Name = "labelTimestamp";
            labelTimestamp.Size = new Size(134, 25);
            labelTimestamp.TabIndex = 10;
            labelTimestamp.Text = "Last checked: --";
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInfo.ForeColor = Color.DarkSlateGray;
            btnInfo.Location = new Point(765, 178);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(42, 42);
            btnInfo.TabIndex = 9;
            btnInfo.Text = "ℹ️";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // panelResult
            // 
            panelResult.BackColor = Color.Gainsboro;
            panelResult.BorderStyle = BorderStyle.Fixed3D;
            panelResult.Controls.Add(panel7);
            panelResult.Location = new Point(144, 208);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(591, 198);
            panelResult.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(labelOutput);
            panel7.Location = new Point(12, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(562, 170);
            panel7.TabIndex = 9;
            panel7.Paint += panel7_Paint;
            // 
            // labelOutput
            // 
            labelOutput.BackColor = Color.White;
            labelOutput.BorderStyle = BorderStyle.FixedSingle;
            labelOutput.Dock = DockStyle.Fill;
            labelOutput.ForeColor = Color.Black;
            labelOutput.Location = new Point(0, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(562, 170);
            labelOutput.TabIndex = 8;
            labelOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(10, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(341, 96);
            label4.TabIndex = 1;
            label4.Text = "EasyMed";
            label4.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveBorder;
            panel5.Location = new Point(2311, 237);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(409, 1500);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveBorder;
            panel6.Location = new Point(417, 1260);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(1886, 477);
            panel6.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "EasyMed";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EasyMed_Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowSymptoms.ResumeLayout(false);
            flowSymptoms.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelResult.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox EasyMed_Logo;
        private Label label1;
        private Button btnHistory;
        private Panel panel2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label4;
        private Label label3;
        private Button btnCheck;
        private CheckBox chkFatigue;
        private CheckBox chkHeadache;
        private CheckBox chkCough;
        private CheckBox chkFever;
        private Panel panelResult;
        private FlowLayoutPanel flowSymptoms;
        private Button btnClear;
        private CheckBox chkSoreThroat;
        private CheckBox chkRunnyNose;
        private CheckBox chkBodyAches;
        private CheckBox chkNausea;
        private CheckBox chkVomiting;
        private CheckBox chkDiarrhea;
        private CheckBox chkShortBreath;
        private CheckBox chkChestPain;
        private Panel panel7;
        private Label labelOutput;
        private ToolTip toolTipInfo;
        private Button btnInfo;
        private Label labelTimestamp;
    }
}
