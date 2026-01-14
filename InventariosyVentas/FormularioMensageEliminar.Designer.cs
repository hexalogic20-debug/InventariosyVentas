namespace InventariosyVentas
{
    partial class FormularioMensageEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMensageEliminar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.labeleliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.Red;
            this.buttoneliminar.ForeColor = System.Drawing.Color.White;
            this.buttoneliminar.Location = new System.Drawing.Point(434, 295);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(172, 56);
            this.buttoneliminar.TabIndex = 6;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttoncancelar.ForeColor = System.Drawing.Color.White;
            this.buttoncancelar.Location = new System.Drawing.Point(216, 295);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(174, 56);
            this.buttoncancelar.TabIndex = 5;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            // 
            // labeleliminar
            // 
            this.labeleliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleliminar.Location = new System.Drawing.Point(0, 100);
            this.labeleliminar.Name = "labeleliminar";
            this.labeleliminar.Size = new System.Drawing.Size(801, 71);
            this.labeleliminar.TabIndex = 4;
            this.labeleliminar.Text = "m";
            this.labeleliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormularioMensageEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.labeleliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioMensageEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioMensageEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttoncancelar;
        public System.Windows.Forms.Label labeleliminar;
    }
}