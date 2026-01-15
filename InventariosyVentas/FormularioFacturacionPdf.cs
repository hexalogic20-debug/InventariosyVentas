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
    public partial class FormularioFacturacionPdf : Form
    {
        public FormularioFacturacionPdf()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioFacturacionPdf_Load(object sender, EventArgs e)
        {
            // Llamada directa al método estático
            panelredondo.DibujarBordeRedondeado(panel2, 20, Color.FromArgb(178, 178, 179), 2);

            panel2.BackColor = Color.White;

           checkBoxFacturacionInterna.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxFacturacionElec_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
