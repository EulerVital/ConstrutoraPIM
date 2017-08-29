namespace ProjetoPimConstrutora.Forms
{
    partial class frmConsultarBlocos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.ckbAtivos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbAmbas = new System.Windows.Forms.CheckBox();
            this.ckbLetras = new System.Windows.Forms.CheckBox();
            this.ckbNumeros = new System.Windows.Forms.CheckBox();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBlocos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BlocoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdApt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartamentos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.ckbAtivos);
            this.pnTop.Controls.Add(this.groupBox1);
            this.pnTop.Controls.Add(this.cmbCondominio);
            this.pnTop.Controls.Add(this.label8);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(769, 135);
            this.pnTop.TabIndex = 2;
            // 
            // ckbAtivos
            // 
            this.ckbAtivos.AutoSize = true;
            this.ckbAtivos.Checked = true;
            this.ckbAtivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAtivos.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbAtivos.Location = new System.Drawing.Point(435, 14);
            this.ckbAtivos.Name = "ckbAtivos";
            this.ckbAtivos.Size = new System.Drawing.Size(72, 22);
            this.ckbAtivos.TabIndex = 29;
            this.ckbAtivos.Text = "Ativos";
            this.ckbAtivos.UseVisualStyleBackColor = true;
            this.ckbAtivos.CheckedChanged += new System.EventHandler(this.FiltrarChecksBoks);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbAmbas);
            this.groupBox1.Controls.Add(this.ckbLetras);
            this.groupBox1.Controls.Add(this.ckbNumeros);
            this.groupBox1.Font = new System.Drawing.Font("Century", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 72);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por Tipo Bloco";
            // 
            // ckbAmbas
            // 
            this.ckbAmbas.AutoSize = true;
            this.ckbAmbas.Checked = true;
            this.ckbAmbas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAmbas.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbAmbas.Location = new System.Drawing.Point(346, 32);
            this.ckbAmbas.Name = "ckbAmbas";
            this.ckbAmbas.Size = new System.Drawing.Size(103, 22);
            this.ckbAmbas.TabIndex = 28;
            this.ckbAmbas.Text = "Por Ambas";
            this.ckbAmbas.UseVisualStyleBackColor = true;
            this.ckbAmbas.CheckedChanged += new System.EventHandler(this.FiltrarChecksBoks);
            // 
            // ckbLetras
            // 
            this.ckbLetras.AutoSize = true;
            this.ckbLetras.Checked = true;
            this.ckbLetras.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLetras.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbLetras.Location = new System.Drawing.Point(184, 32);
            this.ckbLetras.Name = "ckbLetras";
            this.ckbLetras.Size = new System.Drawing.Size(102, 22);
            this.ckbLetras.TabIndex = 27;
            this.ckbLetras.Text = "Por Letras";
            this.ckbLetras.UseVisualStyleBackColor = true;
            this.ckbLetras.CheckedChanged += new System.EventHandler(this.FiltrarChecksBoks);
            // 
            // ckbNumeros
            // 
            this.ckbNumeros.AutoSize = true;
            this.ckbNumeros.Checked = true;
            this.ckbNumeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNumeros.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbNumeros.Location = new System.Drawing.Point(26, 32);
            this.ckbNumeros.Name = "ckbNumeros";
            this.ckbNumeros.Size = new System.Drawing.Size(120, 22);
            this.ckbNumeros.TabIndex = 26;
            this.ckbNumeros.Text = "Por Numeros";
            this.ckbNumeros.UseVisualStyleBackColor = true;
            this.ckbNumeros.CheckedChanged += new System.EventHandler(this.FiltrarChecksBoks);
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(129, 12);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(249, 24);
            this.cmbCondominio.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Condomínios";
            // 
            // dgvBlocos
            // 
            this.dgvBlocos.AllowUserToAddRows = false;
            this.dgvBlocos.AllowUserToOrderColumns = true;
            this.dgvBlocos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvBlocos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlocos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBlocos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlocos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlocoID,
            this.Blocos,
            this.QtdApt,
            this.NomePredio,
            this.TipoBloco,
            this.Apartamentos,
            this.Excluir});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBlocos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBlocos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBlocos.GridColor = System.Drawing.Color.Black;
            this.dgvBlocos.Location = new System.Drawing.Point(0, 135);
            this.dgvBlocos.MultiSelect = false;
            this.dgvBlocos.Name = "dgvBlocos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlocos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBlocos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlocos.Size = new System.Drawing.Size(769, 270);
            this.dgvBlocos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(560, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 98);
            this.label1.TabIndex = 30;
            this.label1.Text = "OBS: O dado Tipo é o tipo de bloco\r\n\r\nPN = Por Números\r\nPL = Por Letras\r\nA = Amba" +
    "s";
            // 
            // BlocoID
            // 
            this.BlocoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BlocoID.HeaderText = "Cod. Bloco";
            this.BlocoID.Name = "BlocoID";
            this.BlocoID.Width = 104;
            // 
            // Blocos
            // 
            this.Blocos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Blocos.HeaderText = "Condomínio";
            this.Blocos.Name = "Blocos";
            this.Blocos.Width = 113;
            // 
            // QtdApt
            // 
            this.QtdApt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QtdApt.HeaderText = "Nome";
            this.QtdApt.Name = "QtdApt";
            this.QtdApt.ToolTipText = "Quantidade de apartamentos.";
            this.QtdApt.Width = 72;
            // 
            // NomePredio
            // 
            this.NomePredio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NomePredio.HeaderText = "Qtd Prédios";
            this.NomePredio.Name = "NomePredio";
            this.NomePredio.ToolTipText = "Nome do Prédio";
            this.NomePredio.Width = 114;
            // 
            // TipoBloco
            // 
            this.TipoBloco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipoBloco.HeaderText = "Tipo";
            this.TipoBloco.Name = "TipoBloco";
            this.TipoBloco.Width = 63;
            // 
            // Apartamentos
            // 
            this.Apartamentos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Apartamentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Apartamentos.HeaderText = "";
            this.Apartamentos.Name = "Apartamentos";
            this.Apartamentos.Width = 5;
            // 
            // Excluir
            // 
            this.Excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Excluir.DefaultCellStyle = dataGridViewCellStyle3;
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 5;
            // 
            // frmConsultarBlocos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(769, 405);
            this.Controls.Add(this.dgvBlocos);
            this.Controls.Add(this.pnTop);
            this.MaximizeBox = false;
            this.Name = "frmConsultarBlocos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Blocos";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvBlocos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbAmbas;
        private System.Windows.Forms.CheckBox ckbLetras;
        private System.Windows.Forms.CheckBox ckbNumeros;
        private System.Windows.Forms.CheckBox ckbAtivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlocoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocos;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdApt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBloco;
        private System.Windows.Forms.DataGridViewButtonColumn Apartamentos;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}