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
    public partial class FormularioAgregarUsuarios : Form
    {
        public FormularioAgregarUsuarios()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioAgregarUsuarios_Load(object sender, EventArgs e)
        {
            panelredondo.DibujarBordeRedondeado(panel2, 20, Color.FromArgb(178, 178, 179), 2);

            panel2.BackColor = Color.White;
        }

        private void labelTelefonoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
