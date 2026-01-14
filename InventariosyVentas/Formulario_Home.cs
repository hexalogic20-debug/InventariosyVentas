using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosyVentas
{
    public partial class Formulario_Home : Form
    {
        public string rol = "";
        string nombreAdmin = "Juan Carlos";
        string nombreUser = "Camila Suarez";
        public Formulario_Home()
        {
            InitializeComponent();
        }

        private void Formulario_Home_Load(object sender, EventArgs e)
        {
            DibujarBordeRedondeado(panel2, 20, Color.FromArgb(178, 178, 179), 2);
            panel2.BackColor = Color.White;



        }

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

        public static void PanelCircular(Panel panel)
        {
            panel.Resize += (s, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                { // Crea una elipse que ocupa todo el panel
                    path.AddEllipse(0, 0, panel.Width, panel.Height);
                    panel.Region = new Region(path);
                }
            }; // Forzar la primera aplicación
            panel.Invalidate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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
                    panel3.Width - sombra,
                    panel3.Height - sombra
                );
            }

            // dibuja el borde del panel
            //using (Pen pen = new Pen(Color.FromArgb(178, 178, 179), 2))
            //{
            //    e.Graphics.DrawRectangle(pen, 0, 0, panel3.Width - 1, panel3.Height - 1);
            //}
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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
                    panel5.Width - sombra,
                    panel5.Height - sombra
                );
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
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
                    panel6.Width - sombra,
                    panel6.Height - sombra
                );
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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
                    panel4.Width - sombra,
                    panel4.Height - sombra
                );
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
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
                    panel7.Width - sombra,
                    panel7.Height - sombra
                );
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
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
                    panel8.Width - sombra,
                    panel8.Height - sombra
                );
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Cierra toda la aplicación
                Application.Exit();
            }
            // Si elige "No", simplemente no hace nada
        }
    }
    }
