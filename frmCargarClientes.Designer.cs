namespace pryManasseroRegistroVectores
{
    partial class frmCargarClientes
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
            this.grpCarga = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.grpCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCarga
            // 
            this.grpCarga.Controls.Add(this.btnGenerar);
            this.grpCarga.Controls.Add(this.btnOrdenar);
            this.grpCarga.Controls.Add(this.btnCargar);
            this.grpCarga.Controls.Add(this.txtNombre);
            this.grpCarga.Controls.Add(this.txtCodigo);
            this.grpCarga.Controls.Add(this.txtDeuda);
            this.grpCarga.Controls.Add(this.txtLimite);
            this.grpCarga.Controls.Add(this.lblNombre);
            this.grpCarga.Controls.Add(this.lblDeuda);
            this.grpCarga.Controls.Add(this.lblLimite);
            this.grpCarga.Controls.Add(this.lblCodigo);
            this.grpCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarga.Location = new System.Drawing.Point(8, 8);
            this.grpCarga.Margin = new System.Windows.Forms.Padding(2);
            this.grpCarga.Name = "grpCarga";
            this.grpCarga.Padding = new System.Windows.Forms.Padding(2);
            this.grpCarga.Size = new System.Drawing.Size(493, 191);
            this.grpCarga.TabIndex = 0;
            this.grpCarga.TabStop = false;
            this.grpCarga.Text = "Carga de datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(373, 151);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(88, 26);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(329, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 21);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 21);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(97, 95);
            this.txtDeuda.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(68, 21);
            this.txtDeuda.TabIndex = 5;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(329, 97);
            this.txtLimite.Margin = new System.Windows.Forms.Padding(2);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 21);
            this.txtLimite.TabIndex = 4;
            this.txtLimite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(221, 36);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre y apellido";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(30, 97);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(44, 15);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(221, 99);
            this.lblLimite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(98, 15);
            this.lblLimite.TabIndex = 1;
            this.lblLimite.Text = "Límite de crédito";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(30, 34);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(253, 153);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 9;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(90, 154);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGenerar.Size = new System.Drawing.Size(115, 23);
            this.btnGenerar.TabIndex = 10;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // frmCargarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 227);
            this.Controls.Add(this.grpCarga);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCargarClientes";
            this.Text = "Carga de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCarga.ResumeLayout(false);
            this.grpCarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCarga;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

