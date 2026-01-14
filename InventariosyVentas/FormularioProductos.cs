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
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();
        }

        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            // Llamada directa al método estático
            panelredondo.DibujarBordeRedondeado(panel2, 20, Color.FromArgb(178, 178, 179), 2);

            panel2.BackColor = Color.White;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
