using System;
using System.IO;
using System.Windows.Forms;

namespace iLS
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent(); // leave this line!
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "CheckupHistory.txt");

            listHistory.Items.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    listHistory.Items.Add(line);
                }
            }
            else
            {
                listHistory.Items.Add("No history records found yet.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Label labelTitle;
        private ListBox listHistory;
    }
}
