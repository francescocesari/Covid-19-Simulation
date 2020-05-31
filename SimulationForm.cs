using System;
using System.Drawing;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class SimulationForm : Form
    {
        private Person[] People;
        private readonly int MinSpeed = -1;
        private readonly int MaxSpeed = 1;
        public int AliveNumber { get; private set; } = Settings.PeopleNum;
        public int InfectedNumber { get; private set; } = 0;
        public int SymptomlessNumber { get; private set; } = 0;
        public int QuarantineNumber { get; private set; } = 0;
        public int DeathNumber { get; private set; } = 0;
        public int CuredNumber { get; private set; } = 0;
        private int Day = 0;
        private ChartThread ChartThread;

        public SimulationForm()
        {
            InitializeComponent();
            Location = new Point(615, 226);
        }

        public void Reload()
        {
            SimulationTimer.Stop();
            DayTimer.Stop();
            Day = 0;
            RefreshLabels();
            SimulationTimer.Interval = Settings.SimulationTime;
            Console.WriteLine($"Percentuale contagio: {Settings.SpreadProbability}%");
            People = new Person[Settings.PeopleNum];
            Random rand = new Random();
            for (int i = 0; i < People.Length; i++)
            {
                int diameter = 7;
                int x = rand.Next(SimulationPanel.Width - diameter);
                int y = rand.Next(SimulationPanel.Height - diameter);
                Point point = new Point(x, y);
                int speedX;
                do
                {
                    speedX = rand.Next(MinSpeed, MaxSpeed + 1);
                } while (speedX == 0);
                int speedY;
                do
                {
                    speedY = rand.Next(MinSpeed, MaxSpeed + 1);
                } while (speedY == 0);
                People[i] = new Person(point, diameter, speedX, speedY, rand);
            }
            int j = rand.Next(Settings.PeopleNum);
            People[j].Infect();
            RefreshLabels();
            ChartThread = new ChartThread(this);
            SimulationTimer.Enabled = true;
            DayTimer.Enabled = true;
            SimulationTimer.Start();
            DayTimer.Start();
        }

        private void SimulationPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (People is Person[])
            {
                foreach (Person person in People)
                {
                    person.Draw(e.Graphics);
                }
            }
        }

        private void SimulationTimer_Tick(object sender, EventArgs e)
        {
            PeopleInteract();
            RefreshLabels();
            SimulationPanel.Invalidate();
        }

        private void PeopleInteract()
        {
            Random rand = new Random();
            foreach (Person person in People)
            {
                int x = person.X;
                int y = person.Y;
                person.MoveIn(SimulationPanel);
                foreach (Person person2 in People)
                {
                    if (person.CanInfect() && person2.CanBeInfected())
                    {
                        int x2 = person2.X;
                        int y2 = person2.Y;
                        int SpreadRay = person.SpreadRay;
                        if (x >= x2 - SpreadRay && x <= x2 + SpreadRay && y >= y2 - SpreadRay && y <= y2 + SpreadRay)
                        {
                            if (rand.Next(100) < Settings.SpreadProbability)
                            {
                                person2.Infect();
                            }
                        }
                    }
                }
            }
        }

        private void RefreshLabels()
        {
            AliveNumber = 0;
            InfectedNumber = 0;
            SymptomlessNumber = 0;
            QuarantineNumber = 0;
            DeathNumber = 0;
            CuredNumber = 0;
            if (People is Person[])
            {
                foreach (Person person in People)
                {
                    if (person.IsAlive) AliveNumber++;
                    else DeathNumber++;
                    if (person.IsInfected && person.IsSymptomless) SymptomlessNumber++;
                    else if (person.IsInfected) InfectedNumber++;
                    if (person.IsIsolated) QuarantineNumber++;
                    if (person.IsImmune) CuredNumber++;
                }
            }
            LblPeopleAlive.Text = $"Persone in vita: {AliveNumber}";
            LblInfected.Text = $"Infetti sintomatici: {InfectedNumber}";
            LblSympomless.Text = $"Infetti asintomatici: {SymptomlessNumber}";
            LblCured.Text = $"Curati: {CuredNumber}";
            LblQuarantine.Text = $"Persone in quarantena: {QuarantineNumber}";
            LblDeath.Text = $"Deceduti: {DeathNumber}";
        }

        private void DayTimer_Tick(object sender, EventArgs e)
        {
            Day++;
            LblDay.Text = $"Giorno: {Day}";
        }

        private void SimulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PctPlayPlause_Click(object sender, EventArgs e)
        {
            if(SimulationTimer.Enabled)
            {
                SimulationTimer.Enabled = false;
                DayTimer.Enabled = false;
                ChartThread.Stop();
            } else
            {
                SimulationTimer.Enabled = true;
                DayTimer.Enabled = true;
                ChartThread.Start();
            }
        }
    }
}
