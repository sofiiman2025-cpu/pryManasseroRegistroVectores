namespace pryManasseroRegistroVectores
{
    partial class frmClientesDeudores
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
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.lblPromD = new System.Windows.Forms.Label();
            this.lblCantCli = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.lblPromedio);
            this.grpConsulta.Controls.Add(this.lblCantidad);
            this.grpConsulta.Controls.Add(this.lblPromD);
            this.grpConsulta.Controls.Add(this.lblCantCli);
            this.grpConsulta.Controls.Add(this.lblTotal);
            this.grpConsulta.Controls.Add(this.lblDeuda);
            this.grpConsulta.Controls.Add(this.dgvDatos);
            this.grpConsulta.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.Location = new System.Drawing.Point(12, 12);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(853, 604);
            this.grpConsulta.TabIndex = 0;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta de datos";
            this.grpConsulta.Enter += new System.EventHandler(this.grpConsulta_Enter);
            // 
            // lblPromD
            // 
            this.lblPromD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromD.Location = new System.Drawing.Point(662, 546);
            this.lblPromD.Name = "lblPromD";
            this.lblPromD.Size = new System.Drawing.Size(148, 29);
            this.lblPromD.TabIndex = 5;
            // 
            // lblCantCli
            // 
            this.lblCantCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantCli.Location = new System.Drawing.Point(662, 490);
            this.lblCantCli.Name = "lblCantCli";
            this.lblCantCli.Size = new System.Drawing.Size(148, 29);
            this.lblCantCli.TabIndex = 4;
            // 
            // lblDeuda
            // 
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeuda.Location = new System.Drawing.Point(662, 423);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(148, 31);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = ".";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Limite,
            this.Deuda});
            this.dgvDatos.Location = new System.Drawing.Point(25, 44);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(785, 298);
            this.dgvDatos.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y apellido";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Límite de crédito";
            this.Limite.MinimumWidth = 8;
            this.Limite.Name = "Limite";
            this.Limite.Width = 150;
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.MinimumWidth = 8;
            this.Deuda.Name = "Deuda";
            this.Deuda.Width = 150;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(455, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 24);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total de deuda";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(455, 551);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(181, 24);
            this.lblPromedio.TabIndex = 2;
            this.lblPromedio.Text = "Promedio de deuda";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(455, 490);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(186, 24);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad de clientes";
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 641);
            this.Controls.Add(this.grpConsulta);
            this.Name = "frmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientesDeudores";
            this.Load += new System.EventHandler(this.frmClientesDeudores_Load);
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPromD;
        private System.Windows.Forms.Label lblCantCli;
        private System.Windows.Forms.Label lblDeuda;
    }
}