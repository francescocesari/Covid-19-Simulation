using System;
using System.Drawing;
using System.Windows.Forms;

namespace Covid_19
{
    class Person
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int Diameter { get; private set; }
        public int Radius { get; private set; }
        public int SpeedX { get; private set; }
        public int SpeedY { get; private set; }
        public bool IsInfected { get; private set; } = false;
        public int SpreadRay { get; private set; } = Settings.SpreadRay;
        public Color Color = Color.LightBlue;
        public bool IsIsolated { get; private set; } = false;
        private readonly Timer DayTimer = new Timer();
        private int DayTimerElapsed = 0;
        private int Days = 15000;
        private int DayTime = 15000;
        public bool IsAlive { get; private set; } = true;
        public bool IsImmune { get; private set; } = false;
        public bool IsSymptomless { get; private set; } = false;
        private readonly Random Rand;

        public Person(Point Point, int Diameter, int SpeedX, int SpeedY, Random Rand)
        {
            X = Point.X;
            StartX = Point.X;
            Y = Point.Y;
            StartY = Point.Y;
            this.Diameter = Diameter;
            Radius = Diameter / 2;
            this.SpeedX = SpeedX;
            this.SpeedY = SpeedY;
            this.Rand = Rand;
        }

        public void Draw(Graphics g)
        {
            Rectangle rect = new Rectangle(X, Y, Diameter, Diameter);
            SolidBrush solidBrush = new SolidBrush(Color);
            Pen grayPen = new Pen(Color.Gray);
            g.DrawEllipse(grayPen, rect);
            g.FillEllipse(solidBrush, rect);
            grayPen.Dispose();
            solidBrush.Dispose();
            if (SpreadRay != 0)
            {
                Rectangle spreadRect = new Rectangle(X - SpreadRay / 2, Y - SpreadRay / 2, Diameter + SpreadRay, Diameter + SpreadRay);
                Pen darkRedPen = new Pen(Color.DarkRed);
                g.DrawEllipse(darkRedPen, spreadRect);
                darkRedPen.Dispose();
            }
        }

        public void MoveIn(Panel container)
        {
            if (!IsIsolated && IsAlive)
            {
                X += SpeedX;
                if (X < 0)
                {
                    SpeedX = -SpeedX;
                }
                else if (X > container.Width - Diameter)
                {
                    SpeedX = -SpeedX;
                }

                Y += SpeedY;
                if (Y < 0)
                {
                    SpeedY = -SpeedY;
                }
                else if (Y > container.Height - Diameter)
                {
                    SpeedY = -SpeedY;
                }
            }
        }

        public void Infect()
        {
            IsInfected = true;
            Random rand = new Random();
            if (rand.Next(100) < Settings.SymptomlessProbability)
            {
                IsSymptomless = true;
                Color = Color.Magenta;
            }
            else
            {
                Color = Color.Red;
            }
            DayTimer.Interval = 1000;
            DayTimer.Enabled = false;
            DayTimer.Tick += new EventHandler(DayTimer_Tick);
            DayTimer.Enabled = true;
        }

        public void Isolate()
        {
            IsIsolated = true;
            Color = Color.Gray;
        }

        private void Die()
        {
            IsIsolated = false;
            IsAlive = false;
            IsInfected = false;
            Color = Color.Black;
            DayTimer.Dispose();
        }

        private void Cure()
        {
            IsIsolated = false;
            IsInfected = false;
            IsSymptomless = false;
            IsImmune = true;
            Color = Color.Yellow;
        }

        public bool CanInfect()
        {
            return IsAlive && IsInfected && !IsIsolated;
        }

        public bool CanBeInfected()
        {
            return IsAlive && !IsInfected && !IsIsolated && !IsImmune;
        }

        private void DayTimer_Tick(object sender, System.EventArgs e)
        {
            //15000ms = 15 giorni
            if (DayTimerElapsed == Days)
            {
                if (IsInfected && !IsSymptomless && !IsIsolated)
                {
                    Isolate();
                }
                else if (IsIsolated)
                {
                    if (Rand.Next(100) < Settings.DeathProbability) Die();
                    else Cure();
                }
                else if(IsSymptomless && Days % (DayTime * 2) == 0)
                {
                    Cure();
                }
                Days += DayTime;
            }
            DayTimerElapsed += DayTimer.Interval;
        }
    }
}
