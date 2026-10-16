using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace LostTimeTimer
{
    public partial class Form1 : Form
    {
        private Stopwatch Clock = new Stopwatch();

        private Thread _thread;

        private bool Running = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            Rectangle screenSize = Screen.FromControl(this).Bounds;

            int x = screenSize.Width / 2 - this.Size.Width / 2;
            int y = 0;

            this.Location = new Point((int)x, (int)y);

            Clock.Start();
            Running = true;

            _thread = new Thread(UpdateLabelTimer);

            _thread.Start();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (Running)
                return;

            Clock.Start();
            Running = true;

            _thread = new Thread(UpdateLabelTimer);

            _thread.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Clock.Stop();

            Running = false;
        }

        private void UpdateLabelTimer()
        {
            while (this.Running)
            {
                this.LblTimer.Invoke(InvokeTest);
            }

        }

        private void InvokeTest()
        {
            this.LblTimer.Text = $"" +
                $"{String.Format("{0:D2}", Clock.Elapsed.Hours)}:" +
                $"{String.Format("{0:D2}", Clock.Elapsed.Minutes)}:" +
                $"{String.Format("{0:D2}", Clock.Elapsed.Seconds)}";

        }
    }
}
