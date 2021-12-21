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
            //emitter.X = e.X; //следование за мышью
            //emitter.Y = e.Y;
            pointC.X = e.X;    
            pointC.Y = e.Y;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emitter.impactPoints.Add(pointC);
        }

    }
}
