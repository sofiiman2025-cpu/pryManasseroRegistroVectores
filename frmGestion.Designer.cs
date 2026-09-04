namespace pryManasseroRegistroVectores
{
    partial class frmGestion
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
            this.grpMostrar = new System.Windows.Forms.GroupBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.grpMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMostrar
            // 
            this.grpMostrar.Controls.Add(this.btnListar);
            this.grpMostrar.Controls.Add(this.dgvListado);
            this.grpMostrar.Controls.Add(this.cmbModo);
            this.grpMostrar.Controls.Add(this.lblModo);
            this.grpMostrar.Controls.Add(this.cmbCampo);
            this.grpMostrar.Controls.Add(this.lblCampo);
            this.grpMostrar.Location = new System.Drawing.Point(41, 23);
            this.grpMostrar.Name = "grpMostrar";
            this.grpMostrar.Size = new System.Drawing.Size(710, 529);
            this.grpMostrar.TabIndex = 0;
            this.grpMostrar.TabStop = false;
            this.grpMostrar.Text = ".";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(32, 45);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(60, 20);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            // 
            // cmbCampo
            // 
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(138, 42);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 28);
            this.cmbCampo.TabIndex = 1;
            // 
            // cmbModo
            // 
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Location = new System.Drawing.Point(485, 45);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(121, 28);
            this.cmbModo.TabIndex = 3;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(372, 45);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(49, 20);
            this.lblModo.TabIndex = 2;
            this.lblModo.Text = "Modo";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Limite,
            this.Deuda});
            this.dgvListado.Location = new System.Drawing.Point(17, 108);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 62;
            this.dgvListado.RowTemplate.Height = 28;
            this.dgvListado.Size = new System.Drawing.Size(672, 349);
            this.dgvListado.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
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
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(518, 485);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(110, 38);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.grpMostrar);
            this.Name = "frmGestion";
            this.Text = "Listado de clientes ordenado";
            this.grpMostrar.ResumeLayout(false);
            this.grpMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMostrar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnListar;
    }
}