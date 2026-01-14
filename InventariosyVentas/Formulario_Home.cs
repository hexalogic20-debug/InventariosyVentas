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
            // Llamada directa al método estático
            panelredondo.DibujarBordeRedondeado(panel2, 20, Color.FromArgb(178, 178, 179), 2);

            panel2.BackColor = Color.White;


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

        private void panel9_Paint(object sender, PaintEventArgs e)
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
                    panel9.Width - sombra,
                    panel9.Height - sombra
                );
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxinventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioInventario inventario = new FormularioInventario();
            inventario.ShowDialog();
            this.Show();
        }

        private void labelinventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioInventario inventario = new FormularioInventario();
            inventario.ShowDialog();
            this.Show();
        }

        private void pictureBoxfacturacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioFacturacion facturacion = new FormularioFacturacion();
            facturacion.ShowDialog();
            this.Show();
        }

        private void labelfacturacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioFacturacion facturacion = new FormularioFacturacion();
            facturacion.ShowDialog();
            this.Show();
        }

        private void pictureBoxconsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioConsultas consultas = new FormularioConsultas();
            consultas.ShowDialog();
            this.Show();
        }

        private void labelconsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioConsultas consultas = new FormularioConsultas();
            consultas.ShowDialog();
            this.Show();
        }

        private void pictureBoxproductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioProductos productos = new FormularioProductos();
            productos.ShowDialog();
            this.Show();
        }

        private void labelproductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioProductos productos = new FormularioProductos();
            productos.ShowDialog();
            this.Show();
        }
    }
    }
