using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosyVentas
{
    public class panelredondo
    {
        public static void DibujarBordeRedondeado(Panel panel, int radio, Color color, int grosor = 2)
        {
            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, radio, radio, 180, 90);
                    path.AddArc(panel.Width - radio - 1, 0, radio, radio, 270, 90);
                    path.AddArc(panel.Width - radio - 1, panel.Height - radio - 1, radio, radio, 0, 90); path.AddArc(0, panel.Height - radio - 1, radio, radio, 90, 90); path.CloseFigure();
                    using (Pen pen = new Pen(color, grosor))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
            panel.Invalidate(); // fuerza repintado
        }

    }
}
