namespace ProjetoPimConstrutora.Forms
{
    partial class frmConsultarApartamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.cmbPredio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvApartamento = new System.Windows.Forms.DataGridView();
            this.cmbBloco = new System.Windows.Forms.ComboBox();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Blocos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdApt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartamentos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DisvincularMoradores = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.LightGray;
            this.pnTop.Controls.Add(this.cmbPredio);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.dgvApartamento);
            this.pnTop.Controls.Add(this.cmbBloco);
            this.pnTop.Controls.Add(this.cmbCondominio);
            this.pnTop.Controls.Add(this.label5);
            this.pnTop.Controls.Add(this.label4);
            this.pnTop.Controls.Add(this.txtNumero);
            this.pnTop.Controls.Add(this.label8);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(773, 462);
            this.pnTop.TabIndex = 4;
            // 
            // cmbPredio
            // 
            this.cmbPredio.BackColor = System.Drawing.Color.LightGray;
            this.cmbPredio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPredio.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbPredio.FormattingEnabled = true;
            this.cmbPredio.Location = new System.Drawing.Point(506, 40);
            this.cmbPredio.Name = "cmbPredio";
            this.cmbPredio.Size = new System.Drawing.Size(213, 24);
            this.cmbPredio.TabIndex = 41;
            this.cmbPredio.SelectedIndexChanged += new System.EventHandler(this.cmbPredio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Prédios";
            // 
            // dgvApartamento
            // 
            this.dgvApartamento.AllowUserToAddRows = false;
            this.dgvApartamento.AllowUserToOrderColumns = true;
            this.dgvApartamento.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvApartamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApartamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Blocos,
            this.QtdApt,
            this.Apartamentos,
            this.Alterar,
            this.DisvincularMoradores,
            this.Excluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApartamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApartamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvApartamento.GridColor = System.Drawing.Color.Black;
            this.dgvApartamento.Location = new System.Drawing.Point(0, 121);
            this.dgvApartamento.MultiSelect = false;
            this.dgvApartamento.Name = "dgvApartamento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApartamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApartamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartamento.Size = new System.Drawing.Size(773, 341);
            this.dgvApartamento.TabIndex = 39;
            // 
            // cmbBloco
            // 
            this.cmbBloco.BackColor = System.Drawing.Color.LightGray;
            this.cmbBloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBloco.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbBloco.FormattingEnabled = true;
            this.cmbBloco.Location = new System.Drawing.Point(274, 40);
            this.cmbBloco.Name = "cmbBloco";
            this.cmbBloco.Size = new System.Drawing.Size(213, 24);
            this.cmbBloco.TabIndex = 38;
            this.cmbBloco.SelectedIndexChanged += new System.EventHandler(this.cmbBloco_SelectedIndexChanged);
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(12, 40);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(221, 24);
            this.cmbCondominio.TabIndex = 37;
            this.cmbCondominio.SelectedIndexChanged += new System.EventHandler(this.cmbCondominio_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Condomínios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(271, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Blocos";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.LightGray;
            this.txtNumero.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtNumero.Location = new System.Drawing.Point(227, 74);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(206, 23);
            this.txtNumero.TabIndex = 25;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(9, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Numero do Apartamento:";
            // 
            // Blocos
            // 
            this.Blocos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Blocos.HeaderText = "Nº Apartamento";
            this.Blocos.Name = "Blocos";
            // 
            // QtdApt
            // 
            this.QtdApt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QtdApt.HeaderText = "Tipo Estadia";
            this.QtdApt.Name = "QtdApt";
            this.QtdApt.ToolTipText = "Quantidade de apartamentos.";
            // 
            // Apartamentos
            // 
            this.Apartamentos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apartamentos.HeaderText = "Ver Moradores";
            this.Apartamentos.Name = "Apartamentos";
            // 
            // Alterar
            // 
            this.Alterar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            // 
            // DisvincularMoradores
            // 
            this.DisvincularMoradores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DisvincularMoradores.HeaderText = "Disvincular Moradores";
            this.DisvincularMoradores.Name = "DisvincularMoradores";
            // 
            // Excluir
            // 
            this.Excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            // 
            // frmConsultarApartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(773, 462);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultarApartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Apartamentos";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBloco;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.DataGridView dgvApartamento;
        private System.Windows.Forms.ComboBox cmbPredio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocos;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdApt;
        private System.Windows.Forms.DataGridViewButtonColumn Apartamentos;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn DisvincularMoradores;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}