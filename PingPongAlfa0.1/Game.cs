using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPongAlfa0._1
{
    public partial class Form1 : Form
    {
        private float velocidad_left = 4; // Velocidad left de la pelota
        private float velocidad_top = 4;  // Velocidad Derecha de la pelota
        private int puntos = 0;         // contador de los puntos

        public Form1()
        {
            InitializeComponent();
            
            timer1.Enabled = true;  // inicia el timer
            Cursor.Hide();          // desaparese el mouse
            
            this.FormBorderStyle = FormBorderStyle.None;    //quita los bordes 
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;      // se ejecuta en pantalla compreta 
            
            barra.Top = playground.Bottom - (playground.Bottom / 10);
            
            lbEnd.Left = (playground.Width / 2) - (lbEnd.Width / 2);
            lbEnd.Top = (playground.Height / 2) - (lbEnd.Height / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             barra.Left = Cursor.Position.X - (barra.Width / 2);     //moviento de la barra
            
            // movimiento de la pelota
            ball.Left += (int) velocidad_left;
            ball.Top += (int) velocidad_top;

            

            // detecta las colisiones 
            if(ball.Bottom >= barra.Top && ball.Bottom <= barra.Bottom && ball.Left >= barra.Left && ball.Right <= barra.Right) 
            {
                Random r= new Random();
                
                velocidad_left += Convert.ToSingle(r.Next(0,1) + r.NextDouble());
                if (velocidad_top <=29)
                velocidad_top += Convert.ToSingle(r.NextDouble());

                lblvelocidad.Text = "Velocidad Left: "+ velocidad_left + ", Velocidad Top: "+ velocidad_top;
                velocidad_top = -velocidad_top;
                puntos += 1;
                lbGame.Text = puntos.ToString();

                playground.BackColor = Color.FromArgb(r.Next(155,255),r.Next(155,255),r.Next(155,255));

            }

            if (ball.Left <= playground.Left)
            {
                velocidad_left = -velocidad_left;
            }

            if (ball.Right >= playground.Right)
            {
                velocidad_left = -velocidad_left;
            }

            if (ball.Top <= playground.Top)
            {
                velocidad_top = -velocidad_top;
            }

            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                lbEnd.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { this.Close(); Cursor.Show();  }  // evento para salir
            if (e.KeyCode == Keys.R) // evento para reiniciar
            {
                velocidad_left = 4;
                velocidad_top = 4;
                ball.Location = new System.Drawing.Point(254, 277);

                puntos = 0;
                lbGame.Text = "0";
                lbEnd.Visible = false;
                
                timer1.Enabled = true; 
            }
        }

    }
}
