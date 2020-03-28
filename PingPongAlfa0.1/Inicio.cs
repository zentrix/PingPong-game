using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongAlfa0._1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            //Cursor.Show();
        }

        private void btnInico_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.ShowDialog();
        }
    }
}
