namespace iLS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // KEEP ONLY ONE Form1_Load METHOD - REMOVE THE DUPLICATE!
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up timer
            timer1.Interval = 20;
            timer1.Enabled = true;
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
        private void button1_Click(object sender, EventArgs e) { }
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
    }
}