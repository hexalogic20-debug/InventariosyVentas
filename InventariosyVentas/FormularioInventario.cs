using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventariosyVentas
{
    public partial class FormularioInventario : Form
    {
        // ✅ Lista de productos de prueba (solo nombres de archivo)
        private List<Producto> productosDemo = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Peluches Oso", Valor = 20000, Stock = 15, ImagenRuta = "oso.png" },
            new Producto { Id = 2, Nombre = "Caja de Palomitas", Valor = 10000, Stock = 20, ImagenRuta = "palomitas.png" },
            new Producto { Id = 3, Nombre = "Carrito de Juguete", Valor = 35000, Stock = 8, ImagenRuta = "carrito.png" },
            new Producto { Id = 4, Nombre = "Muñeca Clásica", Valor = 45000, Stock = 12, ImagenRuta = "muneca.png" },
            new Producto { Id = 5, Nombre = "Rompecabezas 500 piezas", Valor = 30000, Stock = 5, ImagenRuta = "rompecabezas.png" },
            new Producto { Id = 6, Nombre = "Peluches Oso1", Valor = 20000, Stock = 15, ImagenRuta = "oso.png" },
            new Producto { Id = 7, Nombre = "Caja de Palomitas1", Valor = 10000, Stock = 20, ImagenRuta = "palomitas.png" },
            new Producto { Id = 8, Nombre = "Carrito de Juguete", Valor = 35000, Stock = 8, ImagenRuta = "carrito.png" },
            new Producto { Id = 9, Nombre = "Muñeca Clásica", Valor = 45000, Stock = 12, ImagenRuta = "muneca.png" },
            new Producto { Id = 10, Nombre = "Rompecabezas 500 piezas", Valor = 30000, Stock = 5, ImagenRuta = "rompecabezas.png" }
        };

        public FormularioInventario()
        {
            InitializeComponent();
            this.textBoxBuscar.AutoSize = false;
            this.textBoxBuscar.Height = 20;

        }

        private void FormularioInventario_Load(object sender, EventArgs e)
        {
            // Dibujar borde redondeado en panel2 (si tienes esa clase utilitaria)
            panelredondo.DibujarBordeRedondeado(panel2, 20, Color.FromArgb(178, 178, 179), 2);
            panel2.BackColor = Color.White;

            panelredondo.DibujarBordeRedondeado(panelBuscar, 20, Color.FromArgb(178, 178, 179), 2);
            panelBuscar.BackColor = Color.White;

            // Cargar productos de prueba en el FlowLayoutPanel
            flpInventario.Controls.Clear();
            foreach (var p in productosDemo)
            {
                var card = CrearCardProducto(p.Nombre, p.Valor, p.Stock, p.ImagenRuta);
                flpInventario.Controls.Add(card);
            }

            

        }

        private Panel CrearCardProducto(string nombre, decimal valor, int stock, string imagenArchivo)
        {
            Panel card = new Panel
            {
                Width = 170,   // antes 110 (+20)
                Height = 200,  // antes 140 (+20)
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                BackColor = Color.White
            };

            // 🔹 Construir ruta completa a la carpeta "Imagenes Productos"
            string ruta = Path.Combine(Application.StartupPath, "Imagenes", imagenArchivo);

            PictureBox pic = new PictureBox
            {
                Width = 80,   // antes 60 (+20)
                Height = 80,  // antes 60 (+20)
                SizeMode = PictureBoxSizeMode.Zoom,
                Top = 8,
                Left = 25
            };

            if (File.Exists(ruta))
                pic.ImageLocation = ruta;

            Label lblNombre = new Label
            {
                Text = nombre,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold), // aumenté un poco la fuente
                AutoSize = false,
                Width = 110,   // antes 90 (+20)
                Top = 92,      // ajustado
                Left = 10
            };

            Label lblValor = new Label
            {
                Text = $"Valor: ${valor:N0}",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI",10),
                AutoSize = false,
                Width = 110,   // antes 90 (+20)
                Top = 110,
                Left = 10
            };

            Label lblStock = new Label
            {
                Text = $"Stock: {stock} unidades",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI",10),
                AutoSize = false,
                Width = 110,   // antes 90 (+20)
                Top = 130,
                Left = 10
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                BackColor = Color.LightBlue,
                Width = 65,   // antes 45 (+20)
                Top = 160,
                Left = 10
            };

            Button btnEliminar = new Button
            {
                Text = "Eliminar",
                BackColor = Color.LightCoral,
                Width = 65,   // antes 45 (+20)
                Top = 160,
                Left = 75     // antes 55 (+20)
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblNombre);
            card.Controls.Add(lblValor);
            card.Controls.Add(lblStock);
            card.Controls.Add(btnEditar);
            card.Controls.Add(btnEliminar);

            return card;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flpInventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       

        

       

        

       

        private void pictureBoxBuscar_Click(object sender, EventArgs e)
        {
            pictureBoxBuscar.Visible = false;
        }

        

      

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

            if (pictureBoxBuscar.Visible == true)
            {
                pictureBoxBuscar.Visible = false;
            }
        

       
        }
    }
}
