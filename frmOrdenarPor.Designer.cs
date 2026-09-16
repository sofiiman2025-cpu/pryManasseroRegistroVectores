namespace pryManasseroRegistroVectores
{
    partial class frmOrdenarPor
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
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.gprConsulta = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gprConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(30, 45);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(47, 15);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            this.lblCampo.Click += new System.EventHandler(this.lblCampo_Click);
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(240, 45);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(39, 15);
            this.lblModo.TabIndex = 1;
            this.lblModo.Text = "Modo";
            this.lblModo.Click += new System.EventHandler(this.lblModo_Click);
            // 
            // gprConsulta
            // 
            this.gprConsulta.Controls.Add(this.dataGridView1);
            this.gprConsulta.Controls.Add(this.comboBox2);
            this.gprConsulta.Controls.Add(this.comboBox1);
            this.gprConsulta.Controls.Add(this.lblCampo);
            this.gprConsulta.Controls.Add(this.lblModo);
            this.gprConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gprConsulta.Location = new System.Drawing.Point(12, 21);
            this.gprConsulta.Name = "gprConsulta";
            this.gprConsulta.Size = new System.Drawing.Size(482, 298);
            this.gprConsulta.TabIndex = 2;
            this.gprConsulta.TabStop = false;
            this.gprConsulta.Text = "Consulta de datos";
            this.gprConsulta.Enter += new System.EventHandler(this.gprConsulta_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(285, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Limite,
            this.Deuda});
            this.dataGridView1.Location = new System.Drawing.Point(17, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 164);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Codigo";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Límite de crédito";
            this.Limite.Name = "Limite";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // frmOrdenarPor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 341);
            this.Controls.Add(this.gprConsulta);
            this.Name = "frmOrdenarPor";
            this.Text = "frmOrdenarPor";
            this.Load += new System.EventHandler(this.frmOrdenarPor_Load);
            this.gprConsulta.ResumeLayout(false);
            this.gprConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.GroupBox gprConsulta;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
    }
}