namespace CountDown_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int timeleft = 60;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;

                Timerlabel.Text = timeleft + " seconds";
            }
            else
            {
                timer.Stop();
                Timerlabel.Text = "Time is up!";
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 60;
            Timerlabel.Text = timeleft + " seconds";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            timeleft += 1;
            Timerlabel.Text = timeleft + " seconds";
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            timeleft -= 1;
            Timerlabel.Text = timeleft + " seconds";

        }
    }
}