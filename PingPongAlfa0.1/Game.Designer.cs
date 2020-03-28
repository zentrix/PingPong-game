namespace PingPongAlfa0._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barra = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playground = new System.Windows.Forms.Panel();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbGame = new System.Windows.Forms.Label();
            this.lbPoints = new System.Windows.Forms.Label();
            this.lblvelocidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.SlateGray;
            this.barra.Location = new System.Drawing.Point(163, 298);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(200, 20);
            this.barra.TabIndex = 0;
            this.barra.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(254, 277);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // playground
            // 
            this.playground.Controls.Add(this.lblvelocidad);
            this.playground.Controls.Add(this.lbEnd);
            this.playground.Controls.Add(this.lbGame);
            this.playground.Controls.Add(this.lbPoints);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.barra);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(534, 330);
            this.playground.TabIndex = 2;
            // 
            // lbEnd
            // 
            this.lbEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(157, 92);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(148, 128);
            this.lbEnd.TabIndex = 5;
            this.lbEnd.Text = "GAME OVER\r\n\r\nR - Restaurar\r\nEspacio - Cerrar";
            this.lbEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEnd.Visible = false;
            // 
            // lbGame
            // 
            this.lbGame.AutoSize = true;
            this.lbGame.Location = new System.Drawing.Point(87, 9);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(0, 32);
            this.lbGame.TabIndex = 4;
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.Location = new System.Drawing.Point(12, 9);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(74, 32);
            this.lbPoints.TabIndex = 3;
            this.lbPoints.Text = "Puntos:";
            // 
            // lblvelocidad
            // 
            this.lblvelocidad.AutoSize = true;
            this.lblvelocidad.Location = new System.Drawing.Point(363, 9);
            this.lblvelocidad.Name = "lblvelocidad";
            this.lblvelocidad.Size = new System.Drawing.Size(92, 32);
            this.lblvelocidad.TabIndex = 6;
            this.lblvelocidad.Text = "Velocidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 330);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox barra;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label lbGame;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lblvelocidad;
    }
}

