namespace Libreria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonLibreria = new System.Windows.Forms.Button();
            this.buttonPersonal = new System.Windows.Forms.Button();
            this.buttonNomina = new System.Windows.Forms.Button();
            this.buttonProveedor = new System.Windows.Forms.Button();
            this.buttonAlmacen = new System.Windows.Forms.Button();
            this.buttonExtra = new System.Windows.Forms.Button();
            this.buttonLibro = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonVenta = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.buttonSalir);
            this.panelMenu.Controls.Add(this.buttonVenta);
            this.panelMenu.Controls.Add(this.buttonCliente);
            this.panelMenu.Controls.Add(this.buttonLibro);
            this.panelMenu.Controls.Add(this.buttonExtra);
            this.panelMenu.Controls.Add(this.buttonAlmacen);
            this.panelMenu.Controls.Add(this.buttonProveedor);
            this.panelMenu.Controls.Add(this.buttonNomina);
            this.panelMenu.Controls.Add(this.buttonPersonal);
            this.panelMenu.Controls.Add(this.buttonLibreria);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 561);
            this.panelMenu.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonLibreria
            // 
            this.buttonLibreria.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLibreria.FlatAppearance.BorderSize = 0;
            this.buttonLibreria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonLibreria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibreria.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLibreria.Location = new System.Drawing.Point(0, 100);
            this.buttonLibreria.Name = "buttonLibreria";
            this.buttonLibreria.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonLibreria.Size = new System.Drawing.Size(250, 40);
            this.buttonLibreria.TabIndex = 1;
            this.buttonLibreria.Text = "Libreria";
            this.buttonLibreria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibreria.UseVisualStyleBackColor = true;
            this.buttonLibreria.Click += new System.EventHandler(this.buttonLibreria_Click);
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPersonal.FlatAppearance.BorderSize = 0;
            this.buttonPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonal.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPersonal.Location = new System.Drawing.Point(0, 140);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonPersonal.Size = new System.Drawing.Size(250, 40);
            this.buttonPersonal.TabIndex = 2;
            this.buttonPersonal.Text = "Personal";
            this.buttonPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonal.UseVisualStyleBackColor = true;
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // buttonNomina
            // 
            this.buttonNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNomina.FlatAppearance.BorderSize = 0;
            this.buttonNomina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNomina.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNomina.Location = new System.Drawing.Point(0, 180);
            this.buttonNomina.Name = "buttonNomina";
            this.buttonNomina.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonNomina.Size = new System.Drawing.Size(250, 40);
            this.buttonNomina.TabIndex = 3;
            this.buttonNomina.Text = "Nomina";
            this.buttonNomina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNomina.UseVisualStyleBackColor = true;
            this.buttonNomina.Click += new System.EventHandler(this.buttonNomina_Click);
            // 
            // buttonProveedor
            // 
            this.buttonProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProveedor.FlatAppearance.BorderSize = 0;
            this.buttonProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProveedor.Location = new System.Drawing.Point(0, 220);
            this.buttonProveedor.Name = "buttonProveedor";
            this.buttonProveedor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonProveedor.Size = new System.Drawing.Size(250, 40);
            this.buttonProveedor.TabIndex = 4;
            this.buttonProveedor.Text = "Proveedor";
            this.buttonProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProveedor.UseVisualStyleBackColor = true;
            this.buttonProveedor.Click += new System.EventHandler(this.buttonProveedor_Click);
            // 
            // buttonAlmacen
            // 
            this.buttonAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlmacen.FlatAppearance.BorderSize = 0;
            this.buttonAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlmacen.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAlmacen.Location = new System.Drawing.Point(0, 260);
            this.buttonAlmacen.Name = "buttonAlmacen";
            this.buttonAlmacen.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonAlmacen.Size = new System.Drawing.Size(250, 40);
            this.buttonAlmacen.TabIndex = 5;
            this.buttonAlmacen.Text = "Almacen";
            this.buttonAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlmacen.UseVisualStyleBackColor = true;
            this.buttonAlmacen.Click += new System.EventHandler(this.buttonAlmacen_Click);
            // 
            // buttonExtra
            // 
            this.buttonExtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExtra.FlatAppearance.BorderSize = 0;
            this.buttonExtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtra.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonExtra.Location = new System.Drawing.Point(0, 300);
            this.buttonExtra.Name = "buttonExtra";
            this.buttonExtra.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonExtra.Size = new System.Drawing.Size(250, 40);
            this.buttonExtra.TabIndex = 6;
            this.buttonExtra.Text = "Extra";
            this.buttonExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExtra.UseVisualStyleBackColor = true;
            this.buttonExtra.Click += new System.EventHandler(this.buttonExtra_Click);
            // 
            // buttonLibro
            // 
            this.buttonLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLibro.FlatAppearance.BorderSize = 0;
            this.buttonLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibro.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLibro.Location = new System.Drawing.Point(0, 340);
            this.buttonLibro.Name = "buttonLibro";
            this.buttonLibro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonLibro.Size = new System.Drawing.Size(250, 40);
            this.buttonLibro.TabIndex = 7;
            this.buttonLibro.Text = "Libro";
            this.buttonLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibro.UseVisualStyleBackColor = true;
            this.buttonLibro.Click += new System.EventHandler(this.buttonLibro_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCliente.Location = new System.Drawing.Point(0, 380);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonCliente.Size = new System.Drawing.Size(250, 40);
            this.buttonCliente.TabIndex = 8;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonVenta
            // 
            this.buttonVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVenta.FlatAppearance.BorderSize = 0;
            this.buttonVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonVenta.Location = new System.Drawing.Point(0, 420);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonVenta.Size = new System.Drawing.Size(250, 40);
            this.buttonVenta.TabIndex = 9;
            this.buttonVenta.Text = "Venta";
            this.buttonVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVenta.UseVisualStyleBackColor = true;
            this.buttonVenta.Click += new System.EventHandler(this.buttonVenta_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoSize = true;
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 561);
            this.panelContenedor.TabIndex = 3;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSalir.Location = new System.Drawing.Point(0, 521);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonSalir.Size = new System.Drawing.Size(250, 40);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::Libreria.Properties.Resources.Libro_2;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(250, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonVenta;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonLibro;
        private System.Windows.Forms.Button buttonExtra;
        private System.Windows.Forms.Button buttonAlmacen;
        private System.Windows.Forms.Button buttonProveedor;
        private System.Windows.Forms.Button buttonNomina;
        private System.Windows.Forms.Button buttonPersonal;
        private System.Windows.Forms.Button buttonLibreria;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

