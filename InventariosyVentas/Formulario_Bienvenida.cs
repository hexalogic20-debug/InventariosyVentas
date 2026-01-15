using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventariosyVentas
{
    public partial class Formulario_Bienvenida : Form
    {
        public Formulario_Bienvenida()
        {
            InitializeComponent();

            // Estilo continuo (no crea otro control)
            progressBar1.Style = ProgressBarStyle.Continuous;

            // Pintar en azul el avance del progressBar existente
            progressBar1.Paint += progressBar1_Paint;
        }

        private void Formulario_Bienvenida_Load_1(object sender, EventArgs e)
        {
            // Elimina cualquier otro método Load duplicado (como Formulario_Bienvenida_Load_1)
            this.Opacity = 0;
            timer1.Interval = 15;
            timer1.Start();

            // Configuración del ProgressBar existente
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Conectar el Tick del timer2 al método correcto (sin crear otro control)
            timer2.Interval = 50;
            timer2.Tick -= timer2_Tick; // por si estaba conectado dos veces
            timer2.Tick += timer2_Tick;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
                timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                lblValue.Text = progressBar1.Value + "%";

                // Forzar repintado para ver el azul en cada avance
                progressBar1.Invalidate();
            }
            else
            {
                timer2.Stop();
                AbrirFormularioPrincipal();
            }
        }

        private void progressBar1_Paint(object sender, PaintEventArgs e)
        {
            // Fondo gris
            e.Graphics.FillRectangle(Brushes.LightGray, progressBar1.ClientRectangle);
            // Avance azul
            int ancho = (int)(progressBar1.ClientRectangle.Width * ((double)progressBar1.Value / progressBar1.Maximum));
            e.Graphics.FillRectangle(Brushes.Blue, 0, 0, ancho, progressBar1.ClientRectangle.Height);
        }

        private void AbrirFormularioPrincipal()
        {
            this.Hide();
            using (Form1 login = new Form1())
            {
                login.ShowDialog();
            }
            this.Close();
        }
    }
}
