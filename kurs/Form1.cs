using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs //сделать 6
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        CounterPoint pointC;
        TeleportPoint pointTIn;
        TeleportPointOut pointTOut;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Red,
                ColorTo = Color.FromArgb(0, Color.Magenta),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);
            
            pointC = new CounterPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2
            };

            emitter.impactPoints.Add(pointC);

            pointTIn = new TeleportPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2+100,
            };

            pointTOut = new TeleportPointOut
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2 - 100,
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); //обновление системы каждый тик

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }
            //emitter.X = e.X; //следование частиц
            //emitter.Y = e.Y;
            pointC.X = e.X;    //следование счетчика
            pointC.Y = e.Y;

            pointTIn.X = e.X;
            pointTIn.Y = e.Y;

            pointTOut.X = e.X;
            pointTOut.Y = e.Y;

        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        //6 задание счетчик
        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            pointC = new CounterPoint
            {
                X = e.X,
                Y = e.Y,
            };

            pointTIn = new TeleportPoint
            {
                X = e.X,
                Y = e.Y,
            };

            pointTOut = new TeleportPointOut
            {
                X = e.X,
                Y = e.Y,
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pointC = new CounterPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2
            };

            emitter.impactPoints.Add(pointC);    
        }

        private void tbPartsInTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick= tbPartsInTick.Value;
            lblPerTick.Text = $"{tbPartsInTick.Value}";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpr.Value;
            lblSpr.Text = $"{tbSpr.Value}";
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            emitter.GravitationY = tbGY.Value;
            lblGY.Text = $"{tbGY.Value}";
        }

        private void trackBar1_Scroll_2(object sender, EventArgs e)
        {
            emitter.GravitationX = tbGX.Value;
            lblGX.Text = $"{tbGX.Value}";
        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            pointTIn = new TeleportPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            //emitter.impactPoints.Remove(pointTOut);
            emitter.impactPoints.Add(pointTIn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             pointTOut = new TeleportPointOut
             {
                 X = picDisplay.Width / 2 + 100,
                 Y = picDisplay.Height / 2,
             };
            emitter.impactPoints.Add(pointTOut);
        }
    }
}
