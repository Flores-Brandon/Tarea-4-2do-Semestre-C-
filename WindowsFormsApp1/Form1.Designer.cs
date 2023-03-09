namespace WindowsFormsApp1
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
            this.BTIngresar = new System.Windows.Forms.Button();
            this.LBLcantidad = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.LBLfecha = new System.Windows.Forms.Label();
            this.LBLtelefono = new System.Windows.Forms.Label();
            this.LBLcorreo = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.Label();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.TXTcorreo = new System.Windows.Forms.TextBox();
            this.TXTtelefono = new System.Windows.Forms.TextBox();
            this.DTfecha = new System.Windows.Forms.DateTimePicker();
            this.NUDcantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BTIngresar
            // 
            this.BTIngresar.Location = new System.Drawing.Point(533, 110);
            this.BTIngresar.Name = "BTIngresar";
            this.BTIngresar.Size = new System.Drawing.Size(230, 129);
            this.BTIngresar.TabIndex = 0;
            this.BTIngresar.Text = "Ingresar";
            this.BTIngresar.UseVisualStyleBackColor = true;
            this.BTIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLcantidad
            // 
            this.LBLcantidad.AutoSize = true;
            this.LBLcantidad.Location = new System.Drawing.Point(28, 31);
            this.LBLcantidad.Name = "LBLcantidad";
            this.LBLcantidad.Size = new System.Drawing.Size(143, 16);
            this.LBLcantidad.TabIndex = 1;
            this.LBLcantidad.Text = "Cantidad De Personas";
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(28, 110);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(56, 16);
            this.LBLnombre.TabIndex = 2;
            this.LBLnombre.Text = "Nombre";
            this.LBLnombre.Click += new System.EventHandler(this.LBLnombre_Click);
            // 
            // LBLfecha
            // 
            this.LBLfecha.AutoSize = true;
            this.LBLfecha.Location = new System.Drawing.Point(28, 147);
            this.LBLfecha.Name = "LBLfecha";
            this.LBLfecha.Size = new System.Drawing.Size(45, 16);
            this.LBLfecha.TabIndex = 3;
            this.LBLfecha.Text = "Fecha";
            this.LBLfecha.Click += new System.EventHandler(this.label3_Click);
            // 
            // LBLtelefono
            // 
            this.LBLtelefono.AutoSize = true;
            this.LBLtelefono.Location = new System.Drawing.Point(28, 182);
            this.LBLtelefono.Name = "LBLtelefono";
            this.LBLtelefono.Size = new System.Drawing.Size(61, 16);
            this.LBLtelefono.TabIndex = 4;
            this.LBLtelefono.Text = "Telefono";
            this.LBLtelefono.Click += new System.EventHandler(this.LBLtelefono_Click);
            // 
            // LBLcorreo
            // 
            this.LBLcorreo.AutoSize = true;
            this.LBLcorreo.Location = new System.Drawing.Point(28, 217);
            this.LBLcorreo.Name = "LBLcorreo";
            this.LBLcorreo.Size = new System.Drawing.Size(48, 16);
            this.LBLcorreo.TabIndex = 5;
            this.LBLcorreo.Text = "Correo";
            // 
            // Datos
            // 
            this.Datos.Location = new System.Drawing.Point(62, 296);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(624, 185);
            this.Datos.TabIndex = 6;
            this.Datos.Click += new System.EventHandler(this.label6_Click);
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(146, 110);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(200, 22);
            this.TXTnombre.TabIndex = 7;
            // 
            // TXTcorreo
            // 
            this.TXTcorreo.Location = new System.Drawing.Point(146, 217);
            this.TXTcorreo.Name = "TXTcorreo";
            this.TXTcorreo.Size = new System.Drawing.Size(200, 22);
            this.TXTcorreo.TabIndex = 8;
            this.TXTcorreo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TXTtelefono
            // 
            this.TXTtelefono.Location = new System.Drawing.Point(146, 182);
            this.TXTtelefono.Name = "TXTtelefono";
            this.TXTtelefono.Size = new System.Drawing.Size(200, 22);
            this.TXTtelefono.TabIndex = 9;
            // 
            // DTfecha
            // 
            this.DTfecha.Location = new System.Drawing.Point(146, 147);
            this.DTfecha.Name = "DTfecha";
            this.DTfecha.Size = new System.Drawing.Size(249, 22);
            this.DTfecha.TabIndex = 10;
            // 
            // NUDcantidad
            // 
            this.NUDcantidad.Location = new System.Drawing.Point(192, 29);
            this.NUDcantidad.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDcantidad.Name = "NUDcantidad";
            this.NUDcantidad.Size = new System.Drawing.Size(120, 22);
            this.NUDcantidad.TabIndex = 11;
            this.NUDcantidad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDcantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NUDcantidad);
            this.Controls.Add(this.DTfecha);
            this.Controls.Add(this.TXTtelefono);
            this.Controls.Add(this.TXTcorreo);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.LBLcorreo);
            this.Controls.Add(this.LBLtelefono);
            this.Controls.Add(this.LBLfecha);
            this.Controls.Add(this.LBLnombre);
            this.Controls.Add(this.LBLcantidad);
            this.Controls.Add(this.BTIngresar);
            this.Name = "Form1";
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTIngresar;
        private System.Windows.Forms.Label LBLcantidad;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Label LBLfecha;
        private System.Windows.Forms.Label LBLtelefono;
        private System.Windows.Forms.Label LBLcorreo;
        private System.Windows.Forms.Label Datos;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.TextBox TXTcorreo;
        private System.Windows.Forms.TextBox TXTtelefono;
        private System.Windows.Forms.DateTimePicker DTfecha;
        private System.Windows.Forms.NumericUpDown NUDcantidad;
    }
}

