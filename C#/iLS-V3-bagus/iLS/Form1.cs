using System.Diagnostics.Eventing.Reader;
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

            public double CalculateMatch(List<string> userSelectedSymptoms)
            {
                
                var diseaseSymptoms = this.symptoms.Select(s => s.ToLower().Trim()).ToHashSet();
                var userSymptoms = userSelectedSymptoms.Select(s => s.ToLower().Trim()).ToHashSet();

                if (diseaseSymptoms.Count == 0 || userSymptoms.Count == 0) return 0;

               
                double matches = diseaseSymptoms.Intersect(userSymptoms).Count();

               
                double totalUnique = diseaseSymptoms.Union(userSymptoms).Count();

               
                return matches / totalUnique;
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
            double bestScore =  0;
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

                   
                    if (diseaseDB != null)
                    {
                        foreach (var disease in diseaseDB)
                        {
                            
                            double score = disease.CalculateMatch(symptoms);

                            
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
           

            if (bestMatch == null || bestScore < 0.5)
            {
                diagnosis = "No clear match. Please consult a doctor for a professional diagnosis.";
                severity = "Low";
            }
            else if(bestScore >= 0.5 && bestScore < 0.65)
            {
                int percent = (int)(bestScore * 100);

                diagnosis = $"Possible diagnosis: {bestMatch.name} ({percent}% match)";
                severity = bestMatch.severity;
            } // TODO: make a else-if statement to check if theres 1 or 2 missmatches if so it will go back to no clear match - done
            else
            {
                int percent = (int)(bestScore * 100);
                diagnosis = $"High probability: {bestMatch.name} ({percent}% match)";
                severity = bestMatch.severity;
            }


          // to the peep thats modifying this this part is what displys the content
            labelOutput.Text = diagnosis;

            // Change result panel color based on severity
            if (severity == "Low")
                panelResult.BackColor = Color.LightGreen;
            else if (severity == "Medium")
                panelResult.BackColor = Color.Khaki;
            else if (severity == "High")
                panelResult.BackColor = Color.LightCoral;
            else if (severity == "Very high!!")
                panelResult.BackColor = Color.Black;

            // Saving result to log file (useful for the sql stuff)
            string filePath = Path.Combine(Application.StartupPath, "CheckupHistory.txt");
            string entry = $"[{DateTime.Now:MMM dd, yyyy hh:mm tt}] - Symptoms: {string.Join(", ", symptoms)} - Result: {labelOutput.Text}";
            File.AppendAllText(filePath, entry + Environment.NewLine); //todo reporpose to a protected only

            // Saving the result to global history (sql stuffs)
            AppData.History.Add($"{DateTime.Now}: {labelOutput.Text}"); //todo reporpose to a protected only


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