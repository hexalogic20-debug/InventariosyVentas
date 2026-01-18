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
    public partial class Form1 : Form
    {
        string usuarioAdmin = "Admin";
        string passwordAdmin = "123456";

        string usuarioUser = "User";
        string passwordUser = "123456";
        public Form1()
        {
            InitializeComponent();

            //textBox1.Multiline = true;
            //textBox1.Size = new Size(200, 30);
            //textBox1.UseSystemPasswordChar = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

          //  DibujarBordeRedondeado(panelPassword, 20, Color.FromArgb(178, 178, 179), 2);
           // DibujarBordeRedondeado(panelUsuario, 20, Color.FromArgb(178, 178, 179), 2);

        }

        public static void DibujarBordeRedondeado(Panel panel, int radio, Color color, int grosor = 2)
        {
            panel.Paint += (s, e) => {
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

        private void pictureBoxOculo_Click(object sender, EventArgs e)
        {
            pictureBoxOculo.Visible = false;
            pictureBoxVisible.Visible = true;
         //   if (textBoxPassword != null) textBoxPassword.UseSystemPasswordChar = false;
        }

        private void pictureBoxVisible_Click(object sender, EventArgs e)
        {
            pictureBoxVisible.Visible = false;
            pictureBoxOculo.Visible = true;
         //  if (textBoxPassword != null) textBoxPassword.UseSystemPasswordChar = true;
           
          
             // <-- ocultar
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == usuarioAdmin && textBoxUsuario.Text == passwordAdmin)
            {
                Formulario_Home home = new Formulario_Home();
                home.rol = "Admin";
                home.ShowDialog();
                this.Hide();
            }
            else if (textBoxUsuario.Text == usuarioUser && textBoxPassword.Text == passwordUser)
            {
                Formulario_Home home = new Formulario_Home();
                home.rol = "User";
                home.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBoxOculo_Click_1(object sender, EventArgs e)
        {
           textBox1.Text = textBoxPassword.Text;
            textBox1.Visible = true;
            pictureBoxVisible.Visible = Visible;
            pictureBoxOculo.Visible = false;
        }

        private void pictureBoxVisible_Click_1(object sender, EventArgs e)
        {
            textBoxPassword.Text = textBox1.Text;
            textBox1.Visible = false;
            pictureBoxVisible.Visible = false;
            pictureBoxOculo.Visible = true;
        }
    }
}
    

