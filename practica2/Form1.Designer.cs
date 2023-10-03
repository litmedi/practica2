namespace practica2
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
            this.texNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.texApellido = new System.Windows.Forms.TextBox();
            this.texTelefono = new System.Windows.Forms.TextBox();
            this.texEstatura = new System.Windows.Forms.TextBox();
            this.texEdad = new System.Windows.Forms.TextBox();
            this.btguardar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.rbhombre = new System.Windows.Forms.RadioButton();
            this.rbmujer = new System.Windows.Forms.RadioButton();
            this.genero = new System.Windows.Forms.GroupBox();
            this.genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(220, 38);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(139, 20);
            this.texNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(85, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(85, 76);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(85, 111);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(85, 144);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(46, 13);
            this.lblEstatura.TabIndex = 4;
            this.lblEstatura.Text = "Estatura";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(85, 178);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // texApellido
            // 
            this.texApellido.Location = new System.Drawing.Point(220, 69);
            this.texApellido.Name = "texApellido";
            this.texApellido.Size = new System.Drawing.Size(139, 20);
            this.texApellido.TabIndex = 6;
            // 
            // texTelefono
            // 
            this.texTelefono.Location = new System.Drawing.Point(220, 104);
            this.texTelefono.Name = "texTelefono";
            this.texTelefono.Size = new System.Drawing.Size(139, 20);
            this.texTelefono.TabIndex = 7;
            // 
            // texEstatura
            // 
            this.texEstatura.Location = new System.Drawing.Point(220, 137);
            this.texEstatura.Name = "texEstatura";
            this.texEstatura.Size = new System.Drawing.Size(140, 20);
            this.texEstatura.TabIndex = 8;
            // 
            // texEdad
            // 
            this.texEdad.Location = new System.Drawing.Point(220, 171);
            this.texEdad.Name = "texEdad";
            this.texEdad.Size = new System.Drawing.Size(140, 20);
            this.texEdad.TabIndex = 9;
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(219, 319);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(161, 42);
            this.btguardar.TabIndex = 11;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(219, 383);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(161, 38);
            this.btcancelar.TabIndex = 12;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // rbhombre
            // 
            this.rbhombre.AutoSize = true;
            this.rbhombre.Location = new System.Drawing.Point(0, 32);
            this.rbhombre.Name = "rbhombre";
            this.rbhombre.Size = new System.Drawing.Size(62, 17);
            this.rbhombre.TabIndex = 13;
            this.rbhombre.TabStop = true;
            this.rbhombre.Text = "Hombre";
            this.rbhombre.UseVisualStyleBackColor = true;
            // 
            // rbmujer
            // 
            this.rbmujer.AutoSize = true;
            this.rbmujer.Location = new System.Drawing.Point(149, 32);
            this.rbmujer.Name = "rbmujer";
            this.rbmujer.Size = new System.Drawing.Size(51, 17);
            this.rbmujer.TabIndex = 14;
            this.rbmujer.TabStop = true;
            this.rbmujer.Text = "Mujer";
            this.rbmujer.UseVisualStyleBackColor = true;
            // 
            // genero
            // 
            this.genero.Controls.Add(this.rbhombre);
            this.genero.Controls.Add(this.rbmujer);
            this.genero.Location = new System.Drawing.Point(158, 213);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(200, 100);
            this.genero.TabIndex = 15;
            this.genero.TabStop = false;
            this.genero.Text = "Genero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 433);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.texEdad);
            this.Controls.Add(this.texEstatura);
            this.Controls.Add(this.texTelefono);
            this.Controls.Add(this.texApellido);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.texNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.genero.ResumeLayout(false);
            this.genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox texApellido;
        private System.Windows.Forms.TextBox texTelefono;
        private System.Windows.Forms.TextBox texEstatura;
        private System.Windows.Forms.TextBox texEdad;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.RadioButton rbhombre;
        private System.Windows.Forms.RadioButton rbmujer;
        private System.Windows.Forms.GroupBox genero;
    }
}

