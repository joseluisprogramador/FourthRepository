using System.Diagnostics;

namespace Project_Chronometer
{
    public partial class Form_Chronometer : Form
    {
        /*
             En C#, la clase Stopwatch se utiliza para medir intervalos de tiempo con una alta precisión. 
             Es útil para realizar mediciones de rendimiento o para controlar el tiempo que tarda en ejecutarse
             una determinada parte de un programa. La clase Stopwatch proporciona métodos para 
             iniciar, detener, reiniciar y obtener el tiempo transcurrido desde que se inició el cronómetro.
          */
        private Stopwatch oStopWatch = new Stopwatch();
        public Form_Chronometer()
        {
            InitializeComponent();
        }

        private void Button_Play_Click(object sender, EventArgs e)
        {
            oStopWatch.Start();
            Timer_AnalyzeTimer.Enabled = true;
        }

        private void Timer_AnalyzeTimer_Tick(object sender, EventArgs e)
        {
            int TimerMilliseconds = (int)oStopWatch.ElapsedMilliseconds;
            TimeSpan oTimeSpan = new TimeSpan(0, 0, 0, 0, TimerMilliseconds);

            int Minutes = oTimeSpan.Minutes;
            int Seconds = oTimeSpan.Seconds;
            int MiliSeconds = oTimeSpan.Milliseconds;

            TextBox_Minutes.Text = Minutes.ToString().PadLeft(2, '0');
            TextBox_Seconds.Text = Seconds.ToString().PadLeft(2, '0');
            TextBox_MiliSeconds.Text = MiliSeconds.ToString().PadLeft(3, '0');
        }
        private void Button_Reset_Click(object sender, EventArgs e)
        {
            oStopWatch.Reset();
            TextBox_Minutes.Text = "00";
            TextBox_Seconds.Text = "00";
            TextBox_MiliSeconds.Text = "000";
            Timer_AnalyzeTimer.Enabled = false;
        }

        private void Button_Pause_Click(object sender, EventArgs e)
        {
            oStopWatch.Stop();
        }
    }
}
