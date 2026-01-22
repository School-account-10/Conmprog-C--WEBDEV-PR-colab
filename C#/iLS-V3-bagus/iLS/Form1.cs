using System.Text.Json;

namespace iLS
{



    public partial class Form1 : Form
    {

        public class Symptomsdb()
        {
            public string name { get; set; }
           
            public string severity { get; set; }
            
            public List<string> symptoms { get; set; }
                      
            public double CalculateMatch(List<string> selectedSymptoms)
            {
                if (symptoms == null || symptoms.Count == 0)
                    return 0;

                var userSymptoms = selectedSymptoms.Select(s => s.ToLower().Trim()).ToList();
                int matched = symptoms.Count(s => userSymptoms.Contains(s.ToLower().Trim()));

                return (double)matched / symptoms.Count;
            }

        }
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
        { // changed the logic to not make this as long cuz this used too many if-else statements 
            // looks like yanderedev's source code lol

            string diagnosis = "";
            string severity = "Low";

            Symptomsdb bestMatch = null;
            double bestScore = 0;
            // 1️⃣ Collect all selected symptoms
            List<string> symptoms = new List<string>();

            foreach (CheckBox chk in flowSymptoms.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                    symptoms.Add(chk.Text);

                labelTimestamp.Text = "Last checked: " + DateTime.Now.ToString("MMM dd, yyyy  hh:mm tt");

            }

            try
            {
                
                string fullPath = Path.GetFullPath("C:\\Users\\Franzoli\\Desktop\\Coding\\Vscode\\Computer-ils\\gr12-ils\\Conmprog-C--WEBDEV-PR-colab\\C#\\iLS-V3-bagus\\iLS\\Resources\\symptomsDB\\symptoms.json");

                if (File.Exists(fullPath))
                {
                    string jsonContent = File.ReadAllText(fullPath);
                    List<Symptomsdb> diseaseDB = JsonSerializer.Deserialize<List<Symptomsdb>>(jsonContent);

                    // THIS IS THE LOGIC LOOP YOU WERE MISSING
                    if (diseaseDB != null)
                    {
                        foreach (var disease in diseaseDB)
                        {
                            // CalculateMatch is the method inside your Symptomsdb class
                            double score = disease.CalculateMatch(symptoms);

                            // If this disease has a higher score than the current best, save it
                            if (score > bestScore)
                            {
                                bestScore = score;
                                bestMatch = disease;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading database: " + ex.Message);
            }

            // --- 4. Determine Final Result ---
            // If no match found or match is very weak (less than 30%)
            if (bestMatch == null || bestScore < 0.3)
            {
                diagnosis = "No clear match. Please consult a doctor for a professional diagnosis.";
                severity = "Low";
            }
            else
            {
                int percent = (int)(bestScore * 100);
                // Using bestMatch.name (lowercase n) as defined in your class
                diagnosis = $"Possible diagnosis: {bestMatch.name} ({percent}% match)";
                severity = bestMatch.severity;
            }
            // Display the output
            labelOutput.Text = diagnosis;

            // Change result panel color based on severity
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

        private void chkFatigue_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}