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
    public partial class Formulario_usuarios : Form
    {
        public Formulario_usuarios()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formulario_usuarios_Load(object sender, EventArgs e)
        {
            panelredondo.DibujarBordeRedondeado(panel2, 20, Color.FromArgb(178, 178, 179), 2);

            panel2.BackColor = Color.White;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioAgregarUsuarios nuevoUsuarioForm = new FormularioAgregarUsuarios();
            nuevoUsuarioForm.ShowDialog();
            this.Show();
        }
    }
}
