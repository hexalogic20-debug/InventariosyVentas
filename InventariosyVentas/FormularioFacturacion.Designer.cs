namespace InventariosyVentas
{
    partial class FormularioFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioFacturacion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonAgregarFactura = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.buttonGenerarFactura = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.textBoxProducto = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.textBoxCantidad = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.textBoxCodigo = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAgregarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGenerarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(575, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 39);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1010, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.panel1.Location = new System.Drawing.Point(-3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 5);
            this.panel1.TabIndex = 11;
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(884, 15);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(80, 65);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 15;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo Producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1017, 411);
            this.dataGridView1.TabIndex = 23;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(880, 652);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(55, 23);
            this.labelTotal.TabIndex = 24;
            this.labelTotal.Text = "Total";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // buttonAgregarFactura
            // 
            this.buttonAgregarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregarFactura.BackgroundStyle.GradientAngle = 0F;
            this.buttonAgregarFactura.BackgroundStyle.GradientEndColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgregarFactura.BackgroundStyle.GradientStartColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgregarFactura.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.buttonAgregarFactura.BackgroundStyle.SolidColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgregarFactura.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.buttonAgregarFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAgregarFactura.DropDownArrowColor = System.Drawing.Color.White;
            this.buttonAgregarFactura.EnableThemes = false;
            this.buttonAgregarFactura.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAgregarFactura.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAgregarFactura.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.buttonAgregarFactura.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.buttonAgregarFactura.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarFactura.Location = new System.Drawing.Point(857, 171);
            this.buttonAgregarFactura.Name = "buttonAgregarFactura";
            this.buttonAgregarFactura.Size = new System.Drawing.Size(137, 33);
            this.buttonAgregarFactura.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAgregarFactura.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAgregarFactura.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAgregarFactura.StateStyles.HoverStyle.BorderBorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.buttonAgregarFactura.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAgregarFactura.TabIndex = 459;
            this.buttonAgregarFactura.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAgregarFactura.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarFactura.TextStyle.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarFactura.TextStyle.Text = "Agregar";
            this.buttonAgregarFactura.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAgregarFactura.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // buttonGenerarFactura
            // 
            this.buttonGenerarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerarFactura.BackgroundStyle.GradientAngle = 0F;
            this.buttonGenerarFactura.BackgroundStyle.GradientEndColor = System.Drawing.Color.DodgerBlue;
            this.buttonGenerarFactura.BackgroundStyle.GradientStartColor = System.Drawing.Color.DodgerBlue;
            this.buttonGenerarFactura.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.buttonGenerarFactura.BackgroundStyle.SolidColor = System.Drawing.Color.DodgerBlue;
            this.buttonGenerarFactura.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.buttonGenerarFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonGenerarFactura.DropDownArrowColor = System.Drawing.Color.White;
            this.buttonGenerarFactura.EnableThemes = false;
            this.buttonGenerarFactura.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonGenerarFactura.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonGenerarFactura.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.buttonGenerarFactura.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.buttonGenerarFactura.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerarFactura.Location = new System.Drawing.Point(461, 645);
            this.buttonGenerarFactura.Name = "buttonGenerarFactura";
            this.buttonGenerarFactura.Size = new System.Drawing.Size(182, 33);
            this.buttonGenerarFactura.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.LightSteelBlue;
            this.buttonGenerarFactura.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.LightSteelBlue;
            this.buttonGenerarFactura.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.LightSteelBlue;
            this.buttonGenerarFactura.StateStyles.HoverStyle.BorderBorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.buttonGenerarFactura.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.LightSteelBlue;
            this.buttonGenerarFactura.TabIndex = 460;
            this.buttonGenerarFactura.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGenerarFactura.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarFactura.TextStyle.ForeColor = System.Drawing.Color.White;
            this.buttonGenerarFactura.TextStyle.Text = "Generar Factura";
            this.buttonGenerarFactura.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonGenerarFactura.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.AutoSize = false;
            this.textBoxProducto.CaptionStyle.CaptionSize = 0;
            this.textBoxProducto.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.textBoxProducto.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.textBoxProducto.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.textBoxProducto.CaptionStyle.StateStyles.DisabledStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxProducto.CaptionStyle.StateStyles.FocusStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxProducto.CaptionStyle.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxProducto.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.textBoxProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxProducto.EditBoxStyle.BackColor = System.Drawing.Color.White;
            this.textBoxProducto.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.textBoxProducto.EditBoxStyle.BorderStyle.EdgeRadius = 10;
            this.textBoxProducto.EditBoxStyle.FlashBackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxProducto.EditBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProducto.EditBoxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxProducto.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.textBoxProducto.EditBoxStyle.StateStyles.DisabledStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxProducto.EditBoxStyle.StateStyles.FocusStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxProducto.EditBoxStyle.StateStyles.HoverStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxProducto.Location = new System.Drawing.Point(362, 169);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(219, 38);
            this.textBoxProducto.TabIndex = 461;
            this.textBoxProducto.ValidationStyle.PasswordChar = '\0';
            this.textBoxProducto.Value = "";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.AutoSize = false;
            this.textBoxCantidad.CaptionStyle.CaptionSize = 0;
            this.textBoxCantidad.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.textBoxCantidad.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.textBoxCantidad.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.textBoxCantidad.CaptionStyle.StateStyles.DisabledStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCantidad.CaptionStyle.StateStyles.FocusStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCantidad.CaptionStyle.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCantidad.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.textBoxCantidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCantidad.EditBoxStyle.BackColor = System.Drawing.Color.White;
            this.textBoxCantidad.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.textBoxCantidad.EditBoxStyle.BorderStyle.EdgeRadius = 10;
            this.textBoxCantidad.EditBoxStyle.FlashBackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxCantidad.EditBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.EditBoxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCantidad.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.textBoxCantidad.EditBoxStyle.StateStyles.DisabledStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCantidad.EditBoxStyle.StateStyles.FocusStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCantidad.EditBoxStyle.StateStyles.HoverStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCantidad.Location = new System.Drawing.Point(587, 169);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(219, 38);
            this.textBoxCantidad.TabIndex = 462;
            this.textBoxCantidad.ValidationStyle.PasswordChar = '\0';
            this.textBoxCantidad.Value = "";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.AutoSize = false;
            this.textBoxCodigo.CaptionStyle.CaptionSize = 0;
            this.textBoxCodigo.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.textBoxCodigo.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.textBoxCodigo.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.textBoxCodigo.CaptionStyle.StateStyles.DisabledStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCodigo.CaptionStyle.StateStyles.FocusStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCodigo.CaptionStyle.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCodigo.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.textBoxCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCodigo.EditBoxStyle.BackColor = System.Drawing.Color.White;
            this.textBoxCodigo.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.textBoxCodigo.EditBoxStyle.BorderStyle.EdgeRadius = 10;
            this.textBoxCodigo.EditBoxStyle.FlashBackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxCodigo.EditBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.EditBoxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCodigo.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.textBoxCodigo.EditBoxStyle.StateStyles.DisabledStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCodigo.EditBoxStyle.StateStyles.FocusStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCodigo.EditBoxStyle.StateStyles.HoverStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxCodigo.Location = new System.Drawing.Point(137, 169);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(219, 38);
            this.textBoxCodigo.TabIndex = 463;
            this.textBoxCodigo.ValidationStyle.PasswordChar = '\0';
            this.textBoxCodigo.Value = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 464;
            this.label2.Text = "Producto:";
            // 
            // FormularioFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxProducto);
            this.Controls.Add(this.buttonGenerarFactura);
            this.Controls.Add(this.buttonAgregarFactura);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioFacturacion";
            this.Load += new System.EventHandler(this.FormularioFacturacion_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAgregarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGenerarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTotal;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton buttonAgregarFactura;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton buttonGenerarFactura;
        internal Klik.Windows.Forms.v1.EntryLib.ELEntryBox textBoxProducto;
        internal Klik.Windows.Forms.v1.EntryLib.ELEntryBox textBoxCantidad;
        internal Klik.Windows.Forms.v1.EntryLib.ELEntryBox textBoxCodigo;
        private System.Windows.Forms.Label label2;
    }
}