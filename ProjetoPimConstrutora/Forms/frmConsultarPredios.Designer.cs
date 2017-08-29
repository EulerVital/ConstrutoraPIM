namespace ProjetoPimConstrutora.Forms
{
    partial class frmConsultarPredios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBlocos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPredios = new System.Windows.Forms.DataGridView();
            this.Blocos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdApt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartamentos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ckbExcluidos = new System.Windows.Forms.CheckBox();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.ckbExcluidos);
            this.pnTop.Controls.Add(this.txtNome);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.cmbBlocos);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.cmbCondominio);
            this.pnTop.Controls.Add(this.label8);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(546, 161);
            this.pnTop.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.LightGray;
            this.txtNome.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(158, 121);
            this.txtNome.MaxLength = 3;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 23);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome do Prédio:";
            // 
            // cmbBlocos
            // 
            this.cmbBlocos.BackColor = System.Drawing.Color.LightGray;
            this.cmbBlocos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlocos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBlocos.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbBlocos.FormattingEnabled = true;
            this.cmbBlocos.Location = new System.Drawing.Point(88, 71);
            this.cmbBlocos.Name = "cmbBlocos";
            this.cmbBlocos.Size = new System.Drawing.Size(176, 24);
            this.cmbBlocos.TabIndex = 2;
            this.cmbBlocos.SelectedIndexChanged += new System.EventHandler(this.cmbBlocos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Blocos: ";
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(129, 22);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(249, 24);
            this.cmbCondominio.TabIndex = 0;
            this.cmbCondominio.SelectedIndexChanged += new System.EventHandler(this.cmbCondominio_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(12, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Condomínios";
            // 
            // dgvPredios
            // 
            this.dgvPredios.AllowUserToAddRows = false;
            this.dgvPredios.AllowUserToOrderColumns = true;
            this.dgvPredios.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPredios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPredios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPredios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Blocos,
            this.NomePredio,
            this.QtdApt,
            this.Apartamentos,
            this.Alterar,
            this.Excluir});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPredios.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPredios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPredios.GridColor = System.Drawing.Color.Black;
            this.dgvPredios.Location = new System.Drawing.Point(0, 161);
            this.dgvPredios.MultiSelect = false;
            this.dgvPredios.Name = "dgvPredios";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPredios.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPredios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredios.Size = new System.Drawing.Size(546, 267);
            this.dgvPredios.TabIndex = 4;
            // 
            // Blocos
            // 
            this.Blocos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Blocos.HeaderText = "Blocos";
            this.Blocos.Name = "Blocos";
            // 
            // NomePredio
            // 
            this.NomePredio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NomePredio.HeaderText = "Prédio";
            this.NomePredio.Name = "NomePredio";
            this.NomePredio.ToolTipText = "Nome do Prédio";
            this.NomePredio.Width = 77;
            // 
            // QtdApt
            // 
            this.QtdApt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QtdApt.HeaderText = "Qtd Apt.";
            this.QtdApt.Name = "QtdApt";
            this.QtdApt.ToolTipText = "Quantidade de apartamentos.";
            this.QtdApt.Width = 92;
            // 
            // Apartamentos
            // 
            this.Apartamentos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Apartamentos.HeaderText = "";
            this.Apartamentos.Name = "Apartamentos";
            this.Apartamentos.Width = 5;
            // 
            // Alterar
            // 
            this.Alterar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Alterar.HeaderText = "";
            this.Alterar.Name = "Alterar";
            this.Alterar.Width = 5;
            // 
            // Excluir
            // 
            this.Excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 5;
            // 
            // ckbExcluidos
            // 
            this.ckbExcluidos.AutoSize = true;
            this.ckbExcluidos.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbExcluidos.Location = new System.Drawing.Point(387, 71);
            this.ckbExcluidos.Name = "ckbExcluidos";
            this.ckbExcluidos.Size = new System.Drawing.Size(96, 22);
            this.ckbExcluidos.TabIndex = 30;
            this.ckbExcluidos.Text = "Excluídos";
            this.ckbExcluidos.UseVisualStyleBackColor = true;
            this.ckbExcluidos.CheckedChanged += new System.EventHandler(this.ckbExcluidos_CheckedChanged);
            // 
            // frmConsultarPredios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(546, 428);
            this.Controls.Add(this.dgvPredios);
            this.Controls.Add(this.pnTop);
            this.MaximizeBox = false;
            this.Name = "frmConsultarPredios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar de Predios";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.DataGridView dgvPredios;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBlocos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdApt;
        private System.Windows.Forms.DataGridViewButtonColumn Apartamentos;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbExcluidos;
    }
}