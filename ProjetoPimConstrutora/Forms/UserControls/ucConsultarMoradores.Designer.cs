namespace ProjetoPimConstrutora.Forms.UserControls
{
    partial class ucConsultarMoradores
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnderecoCondominio = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.dgvCondominios = new System.Windows.Forms.DataGridView();
            this.NomeCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondominios)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(2, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Pesquisar Moradores:";
            // 
            // txtEnderecoCondominio
            // 
            this.txtEnderecoCondominio.BackColor = System.Drawing.Color.LightGray;
            this.txtEnderecoCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtEnderecoCondominio.Location = new System.Drawing.Point(169, 55);
            this.txtEnderecoCondominio.Name = "txtEnderecoCondominio";
            this.txtEnderecoCondominio.Size = new System.Drawing.Size(556, 23);
            this.txtEnderecoCondominio.TabIndex = 51;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(319, 34);
            this.lblTitulo.TabIndex = 52;
            this.lblTitulo.Text = "Consultar moradores";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century", 11.25F);
            this.checkBox1.Location = new System.Drawing.Point(746, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 22);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Status Ativos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(186, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(363, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Telefone:";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox5.Font = new System.Drawing.Font("Century", 10F);
            this.maskedTextBox5.Location = new System.Drawing.Point(52, 105);
            this.maskedTextBox5.Mask = "000-00-0000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(111, 24);
            this.maskedTextBox5.TabIndex = 81;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox1.Font = new System.Drawing.Font("Century", 10F);
            this.maskedTextBox1.Location = new System.Drawing.Point(227, 106);
            this.maskedTextBox1.Mask = "000-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(108, 24);
            this.maskedTextBox1.TabIndex = 82;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox2.Font = new System.Drawing.Font("Century", 10F);
            this.maskedTextBox2.Location = new System.Drawing.Point(442, 107);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(110, 24);
            this.maskedTextBox2.TabIndex = 83;
            // 
            // dgvCondominios
            // 
            this.dgvCondominios.AllowUserToAddRows = false;
            this.dgvCondominios.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCondominios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondominios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCondominios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondominios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCondominio,
            this.EstadoCondominio,
            this.CidadeCondominio,
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCondominios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCondominios.GridColor = System.Drawing.Color.Black;
            this.dgvCondominios.Location = new System.Drawing.Point(-4, 154);
            this.dgvCondominios.MultiSelect = false;
            this.dgvCondominios.Name = "dgvCondominios";
            this.dgvCondominios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondominios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCondominios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCondominios.Size = new System.Drawing.Size(908, 270);
            this.dgvCondominios.TabIndex = 132;
            this.dgvCondominios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCondominios_CellContentClick);
            // 
            // NomeCondominio
            // 
            this.NomeCondominio.HeaderText = "Nome";
            this.NomeCondominio.Name = "NomeCondominio";
            this.NomeCondominio.ReadOnly = true;
            this.NomeCondominio.Width = 180;
            // 
            // EstadoCondominio
            // 
            this.EstadoCondominio.HeaderText = "CPF";
            this.EstadoCondominio.Name = "EstadoCondominio";
            this.EstadoCondominio.ReadOnly = true;
            this.EstadoCondominio.Width = 120;
            // 
            // CidadeCondominio
            // 
            this.CidadeCondominio.HeaderText = "RG";
            this.CidadeCondominio.Name = "CidadeCondominio";
            this.CidadeCondominio.ReadOnly = true;
            this.CidadeCondominio.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Incluir visitante";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Incluir correspondência";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // ucConsultarMoradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(903, 420);
            this.Controls.Add(this.dgvCondominios);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtEnderecoCondominio);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ucConsultarMoradores";
            this.Text = "Consulta de Moradores";
            this.Load += new System.EventHandler(this.ucConsultarMoradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondominios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEnderecoCondominio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DataGridView dgvCondominios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}