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
            EasyMed_Logo = new PictureBox();
            btnHistory = new Button();
            label1 = new Label();
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
            panel5 = new Panel();
            toolTipInfo = new ToolTip(components);
            panel6 = new Panel();
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
            panel1.BackgroundImage = Properties.Resources.medical_infographic_banner_background_clinic_pharmacy_laboratory_test_and_research_healthcare_concept_backdrop_illustration_vector;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(EasyMed_Logo);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.ForeColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1644, 102);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // EasyMed_Logo
            // 
            EasyMed_Logo.AccessibleRole = AccessibleRole.None;
            EasyMed_Logo.Anchor = AnchorStyles.Left;
            EasyMed_Logo.BackColor = Color.Transparent;
            EasyMed_Logo.BorderStyle = BorderStyle.FixedSingle;
            EasyMed_Logo.Enabled = false;
            EasyMed_Logo.Image = Properties.Resources._65_653888_plus_symbol_png_green_plus_sign_clipart_transparent__1_1;
            EasyMed_Logo.Location = new Point(46, 8);
            EasyMed_Logo.Name = "EasyMed_Logo";
            EasyMed_Logo.Size = new Size(32, 33);
            EasyMed_Logo.SizeMode = PictureBoxSizeMode.CenterImage;
            EasyMed_Logo.TabIndex = 0;
            EasyMed_Logo.TabStop = false;
            EasyMed_Logo.Click += EasyMed_Logo_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = SystemColors.ButtonHighlight;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.ForeColor = SystemColors.WindowText;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.Location = new Point(7, 7);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(33, 33);
            btnHistory.TabIndex = 2;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(78, -1);
            label1.Name = "label1";
            label1.Size = new Size(167, 47);
            label1.TabIndex = 1;
            label1.Text = "EasyMed";
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(37, 150, 190);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(1845, 31);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(268, 3);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(957, 21);
            label2.TabIndex = 0;
            label2.Text = "D I S C L A I M E R !  T H I S   A P P   I S   N O T   A C C U R A T E   A N D   G U A R A N T E E D .   U S E   A T   Y O U R   O W N   R I S K \r\n";
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
            panel3.AutoSize = true;
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(flowSymptoms);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnCheck);
            panel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel3.Location = new Point(0, 142);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(7, 6, 7, 6);
            panel3.Size = new Size(287, 902);
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
            flowSymptoms.Location = new Point(29, 57);
            flowSymptoms.Margin = new Padding(2);
            flowSymptoms.Name = "flowSymptoms";
            flowSymptoms.Size = new Size(211, 298);
            flowSymptoms.TabIndex = 10;
            flowSymptoms.WrapContents = false;
            // 
            // chkFever
            // 
            chkFever.AccessibleName = "";
            chkFever.AutoSize = true;
            chkFever.Location = new Point(2, 2);
            chkFever.Margin = new Padding(2);
            chkFever.Name = "chkFever";
            chkFever.Size = new Size(58, 19);
            chkFever.TabIndex = 2;
            chkFever.Text = "Fever";
            chkFever.UseVisualStyleBackColor = true;
            chkFever.CheckedChanged += chkFever_CheckedChanged;
            // 
            // chkCough
            // 
            chkCough.AutoSize = true;
            chkCough.Location = new Point(2, 25);
            chkCough.Margin = new Padding(2);
            chkCough.Name = "chkCough";
            chkCough.Size = new Size(61, 19);
            chkCough.TabIndex = 3;
            chkCough.Text = "Cough";
            chkCough.UseVisualStyleBackColor = true;
            chkCough.CheckedChanged += chkCough_CheckedChanged;
            // 
            // chkHeadache
            // 
            chkHeadache.AutoSize = true;
            chkHeadache.Location = new Point(2, 48);
            chkHeadache.Margin = new Padding(2);
            chkHeadache.Name = "chkHeadache";
            chkHeadache.Size = new Size(81, 19);
            chkHeadache.TabIndex = 4;
            chkHeadache.Text = "Headache";
            chkHeadache.UseVisualStyleBackColor = true;
            // 
            // chkFatigue
            // 
            chkFatigue.AutoSize = true;
            chkFatigue.Location = new Point(2, 71);
            chkFatigue.Margin = new Padding(2);
            chkFatigue.Name = "chkFatigue";
            chkFatigue.Size = new Size(67, 19);
            chkFatigue.TabIndex = 5;
            chkFatigue.Text = "Fatigue";
            chkFatigue.UseVisualStyleBackColor = true;
            chkFatigue.CheckedChanged += chkFatigue_CheckedChanged;
            // 
            // chkSoreThroat
            // 
            chkSoreThroat.AutoSize = true;
            chkSoreThroat.Location = new Point(2, 94);
            chkSoreThroat.Margin = new Padding(2);
            chkSoreThroat.Name = "chkSoreThroat";
            chkSoreThroat.Size = new Size(92, 19);
            chkSoreThroat.TabIndex = 6;
            chkSoreThroat.Text = "Sore Throat";
            chkSoreThroat.UseVisualStyleBackColor = true;
            // 
            // chkRunnyNose
            // 
            chkRunnyNose.AutoSize = true;
            chkRunnyNose.Location = new Point(2, 117);
            chkRunnyNose.Margin = new Padding(2);
            chkRunnyNose.Name = "chkRunnyNose";
            chkRunnyNose.Size = new Size(92, 19);
            chkRunnyNose.TabIndex = 7;
            chkRunnyNose.Text = "Runny Nose";
            chkRunnyNose.UseVisualStyleBackColor = true;
            chkRunnyNose.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkBodyAches
            // 
            chkBodyAches.AutoSize = true;
            chkBodyAches.Location = new Point(2, 140);
            chkBodyAches.Margin = new Padding(2);
            chkBodyAches.Name = "chkBodyAches";
            chkBodyAches.Size = new Size(90, 19);
            chkBodyAches.TabIndex = 8;
            chkBodyAches.Text = "Body Aches";
            chkBodyAches.UseVisualStyleBackColor = true;
            // 
            // chkNausea
            // 
            chkNausea.AutoSize = true;
            chkNausea.Location = new Point(2, 163);
            chkNausea.Margin = new Padding(2);
            chkNausea.Name = "chkNausea";
            chkNausea.Size = new Size(66, 19);
            chkNausea.TabIndex = 9;
            chkNausea.Text = "Nausea";
            chkNausea.UseVisualStyleBackColor = true;
            chkNausea.CheckedChanged += checkBox2_CheckedChanged_1;
            // 
            // chkVomiting
            // 
            chkVomiting.AutoSize = true;
            chkVomiting.Location = new Point(2, 186);
            chkVomiting.Margin = new Padding(2);
            chkVomiting.Name = "chkVomiting";
            chkVomiting.Size = new Size(76, 19);
            chkVomiting.TabIndex = 11;
            chkVomiting.Text = "Vomiting";
            chkVomiting.UseVisualStyleBackColor = true;
            // 
            // chkDiarrhea
            // 
            chkDiarrhea.AutoSize = true;
            chkDiarrhea.Location = new Point(2, 209);
            chkDiarrhea.Margin = new Padding(2);
            chkDiarrhea.Name = "chkDiarrhea";
            chkDiarrhea.Size = new Size(74, 19);
            chkDiarrhea.TabIndex = 12;
            chkDiarrhea.Text = "Diarrhea";
            chkDiarrhea.UseVisualStyleBackColor = true;
            // 
            // chkShortBreath
            // 
            chkShortBreath.AutoSize = true;
            chkShortBreath.Location = new Point(2, 232);
            chkShortBreath.Margin = new Padding(2);
            chkShortBreath.Name = "chkShortBreath";
            chkShortBreath.Size = new Size(137, 19);
            chkShortBreath.TabIndex = 13;
            chkShortBreath.Text = "Shortness of Breath";
            chkShortBreath.UseVisualStyleBackColor = true;
            // 
            // chkChestPain
            // 
            chkChestPain.AutoSize = true;
            chkChestPain.Location = new Point(2, 255);
            chkChestPain.Margin = new Padding(2);
            chkChestPain.Name = "chkChestPain";
            chkChestPain.Size = new Size(83, 19);
            chkChestPain.TabIndex = 14;
            chkChestPain.Text = "Chest Pain";
            chkChestPain.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(91, 411);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 20);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(47, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 21);
            label3.TabIndex = 0;
            label3.Text = "Select your symptoms";
            label3.Click += label3_Click_3;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.LightGreen;
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.Location = new Point(52, 374);
            btnCheck.Margin = new Padding(2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(156, 20);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Check Diagnosis";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = SystemColors.Window;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(labelTimestamp);
            panel4.Controls.Add(btnInfo);
            panel4.Controls.Add(panelResult);
            panel4.Cursor = Cursors.Hand;
            panel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(292, 142);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(7, 6, 7, 6);
            panel4.Size = new Size(1320, 608);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // labelTimestamp
            // 
            labelTimestamp.AutoSize = true;
            labelTimestamp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTimestamp.ForeColor = SystemColors.ControlText;
            labelTimestamp.Location = new Point(142, 290);
            labelTimestamp.Margin = new Padding(2, 0, 2, 0);
            labelTimestamp.Name = "labelTimestamp";
            labelTimestamp.Size = new Size(90, 15);
            labelTimestamp.TabIndex = 10;
            labelTimestamp.Text = "Last checked: --";
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInfo.ForeColor = Color.DarkSlateGray;
            btnInfo.Location = new Point(-2, -1);
            btnInfo.Margin = new Padding(2);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(29, 25);
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
            panelResult.Location = new Point(101, 125);
            panelResult.Margin = new Padding(2);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(415, 120);
            panelResult.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(labelOutput);
            panel7.Location = new Point(8, 6);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(393, 102);
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
            labelOutput.Margin = new Padding(2, 0, 2, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(393, 102);
            labelOutput.TabIndex = 8;
            labelOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveBorder;
            panel5.Location = new Point(1618, 142);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 900);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.BackgroundImage = Properties.Resources.Blue_and_White_Clean_and_Geometric_Safety_and_Direction_General_Health_Banner__3_1;
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Location = new Point(292, 756);
            panel6.Name = "panel6";
            panel6.RightToLeft = RightToLeft.No;
            panel6.Size = new Size(1320, 880);
            panel6.TabIndex = 5;
            //panel6.Paint += panel6_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1644, 812);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label5;
        private Button btnHistory;
        private Panel panel2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Button btnCheck;
        private FlowLayoutPanel flowSymptoms;
        private Panel panelResult;
        private Button btnClear;
        private CheckBox chkFatigue; // changed how they are listed. why are they seperated in the first pplace? >:(
        private CheckBox chkHeadache; // to make future modifications easier. try to make them listed in order of use thanks - franz
        private CheckBox chkCough;
        private CheckBox chkFever;
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
        private Panel panel6;
    }
}
