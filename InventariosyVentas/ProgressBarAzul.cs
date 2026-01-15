using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventariosyVentas
{
    public class ProgressBarAzul : ProgressBar
    {
        public ProgressBarAzul()
        {
            // Habilitamos el dibujado manual (UserPaint)
            // Y el doble búfer para que no parpadee al moverse
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = e.Graphics;

            // 1. Dibujar el fondo de la barra (Gris claro)
            g.FillRectangle(Brushes.LightGray, rect);

            // 2. Dibujar el progreso (Azul)
            if (this.Value > 0)
            {
                // Calculamos el ancho de la parte azul basado en el porcentaje
                int anchoProgreso = (int)(rect.Width * ((double)this.Value / this.Maximum));
                g.FillRectangle(Brushes.Blue, 0, 0, anchoProgreso, rect.Height);
            }

            // 3. (Opcional) Dibujar el borde
            ControlPaint.DrawBorder(g, rect, Color.DarkGray, ButtonBorderStyle.Solid);
        }
    }
}