namespace ProjetoPimConstrutora.Forms
{
    partial class frmAluguelEstacionamento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTipoVaga = new System.Windows.Forms.Label();
            this.dgvCondominios = new System.Windows.Forms.DataGridView();
            this.NomeMorador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolicitarAluguel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbEstadoCondominio = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mtxtCepCondominio = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondominios)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(330, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Bloco:";
            // 
            // LblTipoVaga
            // 
            this.LblTipoVaga.AutoSize = true;
            this.LblTipoVaga.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoVaga.ForeColor = System.Drawing.Color.Black;
            this.LblTipoVaga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTipoVaga.Location = new System.Drawing.Point(330, 65);
            this.LblTipoVaga.Name = "LblTipoVaga";
            this.LblTipoVaga.Size = new System.Drawing.Size(43, 18);
            this.LblTipoVaga.TabIndex = 58;
            this.LblTipoVaga.Text = "CPF:";
            // 
            // dgvCondominios
            // 
            this.dgvCondominios.AllowUserToAddRows = false;
            this.dgvCondominios.AllowUserToOrderColumns = true;
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
            this.NomeMorador,
            this.Condominio,
            this.Bloco,
            this.CPF,
            this.Column1,
            this.SolicitarAluguel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCondominios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCondominios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCondominios.GridColor = System.Drawing.Color.Black;
            this.dgvCondominios.Location = new System.Drawing.Point(0, 117);
            this.dgvCondominios.MultiSelect = false;
            this.dgvCondominios.Name = "dgvCondominios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondominios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCondominios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCondominios.Size = new System.Drawing.Size(704, 211);
            this.dgvCondominios.TabIndex = 63;
            // 
            // NomeMorador
            // 
            this.NomeMorador.HeaderText = "Nome Morador";
            this.NomeMorador.Name = "NomeMorador";
            this.NomeMorador.Width = 140;
            // 
            // Condominio
            // 
            this.Condominio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Condominio.HeaderText = "Condominio";
            this.Condominio.MinimumWidth = 200;
            this.Condominio.Name = "Condominio";
            this.Condominio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Condominio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Bloco
            // 
            this.Bloco.HeaderText = "Bloco";
            this.Bloco.Name = "Bloco";
            this.Bloco.Width = 70;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Vaga";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // SolicitarAluguel
            // 
            this.SolicitarAluguel.HeaderText = "Solicitar";
            this.SolicitarAluguel.Name = "SolicitarAluguel";
            this.SolicitarAluguel.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(34, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 64;
            this.label4.Text = "Condominio:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Location = new System.Drawing.Point(98, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 72;
            // 
            // cmbEstadoCondominio
            // 
            this.cmbEstadoCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbEstadoCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstadoCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbEstadoCondominio.FormattingEnabled = true;
            this.cmbEstadoCondominio.Location = new System.Drawing.Point(393, 21);
            this.cmbEstadoCondominio.Name = "cmbEstadoCondominio";
            this.cmbEstadoCondominio.Size = new System.Drawing.Size(147, 24);
            this.cmbEstadoCondominio.TabIndex = 75;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 76;
            // 
            // mtxtCepCondominio
            // 
            this.mtxtCepCondominio.BackColor = System.Drawing.Color.LightGray;
            this.mtxtCepCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.mtxtCepCondominio.Location = new System.Drawing.Point(388, 64);
            this.mtxtCepCondominio.Mask = "000.000.000-00";
            this.mtxtCepCondominio.Name = "mtxtCepCondominio";
            this.mtxtCepCondominio.Size = new System.Drawing.Size(99, 23);
            this.mtxtCepCondominio.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::ProjetoPimConstrutora.Properties.Resources.Search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(557, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 78;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAluguelEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(704, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtxtCepCondominio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbEstadoCondominio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCondominios);
            this.Controls.Add(this.LblTipoVaga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAluguelEstacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguel Estacionamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondominios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTipoVaga;
        private System.Windows.Forms.DataGridView dgvCondominios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbEstadoCondominio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox mtxtCepCondominio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMorador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn SolicitarAluguel;
    }
}