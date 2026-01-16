namespace InventariosyVentas
{
    partial class FormularioInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioInventario));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.flpInventario = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxAdicionar = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdicionar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(931, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pictureBoxUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 103);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(505, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 39);
            this.panel2.TabIndex = 13;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.panel1.Location = new System.Drawing.Point(-73, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 5);
            this.panel1.TabIndex = 11;
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(814, 14);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(80, 65);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 14;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // flpInventario
            // 
            this.flpInventario.AutoScroll = true;
            this.flpInventario.Location = new System.Drawing.Point(55, 53);
            this.flpInventario.Name = "flpInventario";
            this.flpInventario.Size = new System.Drawing.Size(949, 533);
            this.flpInventario.TabIndex = 12;
            this.flpInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.flpInventario_Paint);
            this.flpInventario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpInventario_MouseDown);
            // 
            // pictureBoxAdicionar
            // 
            this.pictureBoxAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdicionar.Image")));
            this.pictureBoxAdicionar.Location = new System.Drawing.Point(706, 16);
            this.pictureBoxAdicionar.Name = "pictureBoxAdicionar";
            this.pictureBoxAdicionar.Size = new System.Drawing.Size(30, 29);
            this.pictureBoxAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdicionar.TabIndex = 19;
            this.pictureBoxAdicionar.TabStop = false;
            this.pictureBoxAdicionar.Click += new System.EventHandler(this.pictureBoxAdicionar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.pictureBoxAdicionar);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.flpInventario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 589);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(696, 52);
            this.panel5.TabIndex = 22;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(745, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(769, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "Buscar";
            // 
            // FormularioInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 692);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioInventario";
            this.Load += new System.EventHandler(this.FormularioInventario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormularioInventario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdicionar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.FlowLayoutPanel flpInventario;
        private System.Windows.Forms.PictureBox pictureBoxAdicionar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBox1;
    }
}