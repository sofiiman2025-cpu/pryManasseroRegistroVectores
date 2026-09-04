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
            this.grpCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCarga
            // 
            this.grpCarga.Controls.Add(this.btnCargar);
            this.grpCarga.Controls.Add(this.txtNombre);
            this.grpCarga.Controls.Add(this.txtCodigo);
            this.grpCarga.Controls.Add(this.txtDeuda);
            this.grpCarga.Controls.Add(this.txtLimite);
            this.grpCarga.Controls.Add(this.lblNombre);
            this.grpCarga.Controls.Add(this.lblDeuda);
            this.grpCarga.Controls.Add(this.lblLimite);
            this.grpCarga.Controls.Add(this.lblCodigo);
            this.grpCarga.Location = new System.Drawing.Point(12, 12);
            this.grpCarga.Name = "grpCarga";
            this.grpCarga.Size = new System.Drawing.Size(739, 294);
            this.grpCarga.TabIndex = 0;
            this.grpCarga.TabStop = false;
            this.grpCarga.Text = "Carga de datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(566, 238);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 35);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(493, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(145, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(145, 146);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 26);
            this.txtDeuda.TabIndex = 5;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(493, 149);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(148, 26);
            this.txtLimite.TabIndex = 4;
            this.txtLimite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(331, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre y apellido";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(45, 149);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(57, 20);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(331, 152);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(125, 20);
            this.lblLimite.TabIndex = 1;
            this.lblLimite.Text = "Límite de crédito";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(45, 52);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(760, 349);
            this.Controls.Add(this.grpCarga);
            this.Name = "Form1";
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
    }
}

