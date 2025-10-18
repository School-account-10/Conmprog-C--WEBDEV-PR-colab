﻿namespace iLS
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set tooltip text for info button
            toolTipInfo.SetToolTip(btnInfo,
                "🩺 Quick Check-Up App\n\nSelect your symptoms and click 'Check'.\nYou’ll get a possible illness suggestion.\n\n⚠️ Note: This is not a medical diagnosis. Consult a doctor for confirmation.");
        }

        // KEEP ONLY ONE Form1_Load METHOD - REMOVE THE DUPLICATE!
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up timer
            timer1.Interval = 20;
            timer1.Enabled = true;

            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Move label left
            label2.Left -= 2;

            // Reset when completely off-screen
            if (label2.Right < 0)
            {
                label2.Left = this.ClientSize.Width;
            }
        }



        // Keep your other event handlers (remove any duplicates)
        private void EasyMed_Logo_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // 1️⃣ Collect all selected symptoms
            List<string> symptoms = new List<string>();
            foreach (CheckBox chk in flowSymptoms.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                    symptoms.Add(chk.Text);

                labelTimestamp.Text = "Last checked: " + DateTime.Now.ToString("MMM dd, yyyy  hh:mm tt");

            }

            // 2️⃣ Diagnosis output and severity level
            string diagnosis = "";
            string severity = "Low";

            // 3️⃣ Match common illnesses (simple logic)
            if (symptoms.Contains("Fever") && symptoms.Contains("Cough") && symptoms.Contains("Body Aches") && symptoms.Contains("Fatigue"))
            {
                diagnosis = "You may have Influenza (Flu)";
                severity = "Medium";
            }
            else if (symptoms.Contains("Fever") && symptoms.Contains("Cough") && symptoms.Contains("Shortness of Breath") && symptoms.Contains("Chest Pain"))
            {
                diagnosis = "Possible Pneumonia or COVID-19";
                severity = "High";
            }
            else if (symptoms.Contains("Headache") && symptoms.Contains("Fatigue"))
            {
                diagnosis = "You may be experiencing Migraine or Stress-related Fatigue";
                severity = "Low";
            }
            else if (symptoms.Contains("Nausea") && symptoms.Contains("Vomiting") && symptoms.Contains("Diarrhea"))
            {
                diagnosis = "You may have Food Poisoning or Gastroenteritis";
                severity = "Medium";
            }
            else if (symptoms.Contains("Sore Throat") && symptoms.Contains("Runny Nose") && symptoms.Contains("Cough"))
            {
                diagnosis = "You may have the Common Cold";
                severity = "Low";
            }
            else
            {
                diagnosis = "No clear match. Please consult a doctor for a professional diagnosis.";
                severity = "Low";
            }

            // 4️⃣ Display the output
            labelOutput.Text = diagnosis;

            // 5️⃣ Change result panel color based on severity
            if (severity == "Low")
                panelResult.BackColor = Color.LightGreen;
            else if (severity == "Medium")
                panelResult.BackColor = Color.Khaki;
            else if (severity == "High")
                panelResult.BackColor = Color.LightCoral;

            // Save result to log file
            string filePath = Path.Combine(Application.StartupPath, "CheckupHistory.txt");
            string entry = $"[{DateTime.Now:MMM dd, yyyy hh:mm tt}] - Symptoms: {string.Join(", ", symptoms)} - Result: {labelOutput.Text}";
            File.AppendAllText(filePath, entry + Environment.NewLine);

            // Save the result to global history
            AppData.History.Add($"{DateTime.Now}: {labelOutput.Text}");


        }




        private void chkCough_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFever_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Uncheck all symptom checkboxes
            foreach (CheckBox chk in flowSymptoms.Controls.OfType<CheckBox>())
            {
                chk.Checked = false;
            }

            // Reset result text and panel color
            labelOutput.Text = "Diagnosis will appear here...";
            panelResult.BackColor = Color.WhiteSmoke;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Style btnInfo
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.BackColor = Color.Transparent;
            btnInfo.ForeColor = Color.DarkSlateBlue;
            btnInfo.Font = new Font("Segoe UI Symbol", 14, FontStyle.Bold);
        }

        private void btnCheck_MouseEnter(object sender, EventArgs e)
        {
            btnCheck.BackColor = Color.RoyalBlue;
        }
        private void btnCheck_MouseLeave(object sender, EventArgs e)
        {
            btnCheck.BackColor = ColorTranslator.FromHtml("#3A8DFF");
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Silver;
        }
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = ColorTranslator.FromHtml("#DDDDDD");
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory historyForm = new FormHistory();
            historyForm.ShowDialog();
        }

    }
}