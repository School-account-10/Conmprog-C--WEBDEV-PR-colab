using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLS
{
    public partial class FormHistory : Form
    {


        private void InitializeComponent()
        {
            labelTitle = new Label();
            listHistory = new ListBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(460, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(340, 38);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Health Check-Up History";
            // 
            // listHistory
            // 
            listHistory.Font = new Font("Segoe UI", 10F);
            listHistory.FormattingEnabled = true;
            listHistory.ItemHeight = 28;
            listHistory.Location = new Point(0, 52);
            listHistory.Name = "listHistory";
            listHistory.ScrollAlwaysVisible = true;
            listHistory.Size = new Size(1277, 396);
            listHistory.TabIndex = 1;
            // 
            // FormHistory
            // 
            ClientSize = new Size(1278, 443);
            Controls.Add(listHistory);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormHistory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Check-Up History";
            Load += FormHistory_Load_1;
            ResumeLayout(false);
            PerformLayout();

        }

        private void FormHistory_Load_1(object sender, EventArgs e)
        {
            listHistory.Items.Clear();

            foreach (string entry in AppData.History)
            {
                listHistory.Items.Add(entry);
            }

            if (AppData.History.Count == 0)
            {
                listHistory.Items.Add("No history yet.");
            }
        }

    }
}
