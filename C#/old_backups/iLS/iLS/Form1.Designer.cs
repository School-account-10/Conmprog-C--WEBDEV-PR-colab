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
            button1 = new Button();
            label1 = new Label();
            EasyMed_Logo = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EasyMed_Logo).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EasyMed_Logo);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 101);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(7, 8);
            button1.Name = "button1";
            button1.Size = new Size(33, 33);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 1;
            label1.Text = "EasyMed";
            label1.Click += label1_Click;
            // 
            // EasyMed_Logo
            // 
            EasyMed_Logo.Image = (Image)resources.GetObject("EasyMed_Logo.Image");
            EasyMed_Logo.Location = new Point(46, 8);
            EasyMed_Logo.Name = "EasyMed_Logo";
            EasyMed_Logo.Size = new Size(33, 33);
            EasyMed_Logo.TabIndex = 0;
            EasyMed_Logo.TabStop = false;
            EasyMed_Logo.Click += EasyMed_Logo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(1880, 29);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 4);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(626, 21);
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
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(0, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 900);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(292, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(1320, 608);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(229, 65);
            label4.TabIndex = 1;
            label4.Text = "EasyMed";
            label4.Click += label4_Click;
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
            panel6.BackColor = SystemColors.ActiveBorder;
            panel6.Location = new Point(292, 756);
            panel6.Name = "panel6";
            panel6.Size = new Size(1320, 286);
            panel6.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EasyMed";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EasyMed_Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox EasyMed_Logo;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label4;
    }
}
