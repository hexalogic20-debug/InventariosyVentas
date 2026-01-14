using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosyVentas
{
    public partial class Formulario_Ajustes : Form
    {
        public Formulario_Ajustes()
        {
            InitializeComponent();
        }

        private void Formulario_Ajustes_Load(object sender, EventArgs e)
        {
            panelredondo.DibujarBordeRedondeado(panel2, 20, Color.FromArgb(178, 178, 179), 2);

            panel2.BackColor = Color.White;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int sombra = 4; // tamaño del desplazamiento de la sombra

            // dibuja la sombra detrás del panel, desplazada
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0))) // negro semitransparente
            {
                e.Graphics.FillRectangle(
                    shadowBrush,
                    sombra,
                    sombra,
                    panel11.Width - sombra,
                    panel11.Height - sombra
                );
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int sombra = 4; // tamaño del desplazamiento de la sombra

            // dibuja la sombra detrás del panel, desplazada
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0))) // negro semitransparente
            {
                e.Graphics.FillRectangle(
                    shadowBrush,
                    sombra,
                    sombra,
                    panel10.Width - sombra,
                    panel10.Height - sombra
                );
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
