namespace WinForms_Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblTime2.Text = DateTime.Now.ToString("tt");
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblTime2_Click(object sender, EventArgs e)
        {

        }
    }
}