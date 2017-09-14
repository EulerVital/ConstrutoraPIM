namespace ProjetoPimConstrutora.Forms.UserControls
{
    partial class ucConsultarCondominio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCondominio = new System.Windows.Forms.TextBox();
            this.ckbExcluido = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnTabelaConsulta = new System.Windows.Forms.Panel();
            this.dgvCondominios = new System.Windows.Forms.DataGridView();
            this.NomeCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BairroCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CepCondominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlocosCondominio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AlterarCondominio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StatusCondominio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.pnTabelaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondominios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBairro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNomeCondominio);
            this.panel2.Controls.Add(this.ckbExcluido);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbCidade);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbEstado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 105);
            this.panel2.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.LightGray;
            this.txtBairro.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtBairro.Location = new System.Drawing.Point(403, 58);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(212, 23);
            this.txtBairro.TabIndex = 25;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Condomino:";
            // 
            // txtNomeCondominio
            // 
            this.txtNomeCondominio.BackColor = System.Drawing.Color.LightGray;
            this.txtNomeCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtNomeCondominio.Location = new System.Drawing.Point(187, 17);
            this.txtNomeCondominio.Name = "txtNomeCondominio";
            this.txtNomeCondominio.Size = new System.Drawing.Size(444, 23);
            this.txtNomeCondominio.TabIndex = 9;
            this.txtNomeCondominio.TextChanged += new System.EventHandler(this.txtNomeCondominio_TextChanged);
            // 
            // ckbExcluido
            // 
            this.ckbExcluido.AutoSize = true;
            this.ckbExcluido.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.ckbExcluido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbExcluido.Location = new System.Drawing.Point(666, 18);
            this.ckbExcluido.Name = "ckbExcluido";
            this.ckbExcluido.Size = new System.Drawing.Size(97, 22);
            this.ckbExcluido.TabIndex = 24;
            this.ckbExcluido.Text = "Excluido";
            this.ckbExcluido.UseVisualStyleBackColor = true;
            this.ckbExcluido.CheckedChanged += new System.EventHandler(this.ckbExcluido_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(332, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bairro:";
            // 
            // cmbCidade
            // 
            this.cmbCidade.BackColor = System.Drawing.Color.LightGray;
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCidade.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(80, 55);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(220, 24);
            this.cmbCidade.TabIndex = 21;
            this.cmbCidade.SelectedIndexChanged += new System.EventHandler(this.cmbCidade_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(5, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cidade:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.LightGray;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(913, 18);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(217, 24);
            this.cmbEstado.TabIndex = 17;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(822, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.LightGray;
            this.txtEndereco.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtEndereco.Location = new System.Drawing.Point(729, 56);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(427, 23);
            this.txtEndereco.TabIndex = 15;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(624, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Endereço:";
            // 
            // pnTabelaConsulta
            // 
            this.pnTabelaConsulta.Controls.Add(this.dgvCondominios);
            this.pnTabelaConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTabelaConsulta.Location = new System.Drawing.Point(0, 105);
            this.pnTabelaConsulta.Name = "pnTabelaConsulta";
            this.pnTabelaConsulta.Size = new System.Drawing.Size(1174, 355);
            this.pnTabelaConsulta.TabIndex = 7;
            // 
            // dgvCondominios
            // 
            this.dgvCondominios.AllowUserToAddRows = false;
            this.dgvCondominios.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCondominios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondominios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvCondominios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondominios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCondominio,
            this.EstadoCondominio,
            this.CidadeCondominio,
            this.BairroCondominio,
            this.EnderecoCondominio,
            this.CepCondominio,
            this.BlocosCondominio,
            this.AlterarCondominio,
            this.StatusCondominio});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCondominios.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvCondominios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCondominios.GridColor = System.Drawing.Color.Black;
            this.dgvCondominios.Location = new System.Drawing.Point(0, 0);
            this.dgvCondominios.MultiSelect = false;
            this.dgvCondominios.Name = "dgvCondominios";
            this.dgvCondominios.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondominios.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvCondominios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCondominios.Size = new System.Drawing.Size(1174, 355);
            this.dgvCondominios.TabIndex = 0;
            this.dgvCondominios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCondominios_CellClick);
            // 
            // NomeCondominio
            // 
            this.NomeCondominio.HeaderText = "Nome";
            this.NomeCondominio.Name = "NomeCondominio";
            this.NomeCondominio.ReadOnly = true;
            this.NomeCondominio.Width = 220;
            // 
            // EstadoCondominio
            // 
            this.EstadoCondominio.HeaderText = "Estado";
            this.EstadoCondominio.Name = "EstadoCondominio";
            this.EstadoCondominio.ReadOnly = true;
            this.EstadoCondominio.Width = 70;
            // 
            // CidadeCondominio
            // 
            this.CidadeCondominio.HeaderText = "Cidade";
            this.CidadeCondominio.Name = "CidadeCondominio";
            this.CidadeCondominio.ReadOnly = true;
            this.CidadeCondominio.Width = 140;
            // 
            // BairroCondominio
            // 
            this.BairroCondominio.HeaderText = "Bairro";
            this.BairroCondominio.Name = "BairroCondominio";
            this.BairroCondominio.ReadOnly = true;
            this.BairroCondominio.Width = 140;
            // 
            // EnderecoCondominio
            // 
            this.EnderecoCondominio.HeaderText = "Endereço";
            this.EnderecoCondominio.Name = "EnderecoCondominio";
            this.EnderecoCondominio.ReadOnly = true;
            this.EnderecoCondominio.Width = 250;
            // 
            // CepCondominio
            // 
            this.CepCondominio.HeaderText = "CEP";
            this.CepCondominio.Name = "CepCondominio";
            this.CepCondominio.ReadOnly = true;
            // 
            // BlocosCondominio
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.BlocosCondominio.DefaultCellStyle = dataGridViewCellStyle26;
            this.BlocosCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlocosCondominio.HeaderText = "Ver Blocos";
            this.BlocosCondominio.Name = "BlocosCondominio";
            this.BlocosCondominio.ReadOnly = true;
            this.BlocosCondominio.Text = "VER";
            this.BlocosCondominio.UseColumnTextForButtonValue = true;
            this.BlocosCondominio.Width = 55;
            // 
            // AlterarCondominio
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.AlterarCondominio.DefaultCellStyle = dataGridViewCellStyle27;
            this.AlterarCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlterarCondominio.HeaderText = "Alterar Dados";
            this.AlterarCondominio.Name = "AlterarCondominio";
            this.AlterarCondominio.ReadOnly = true;
            this.AlterarCondominio.Width = 70;
            // 
            // StatusCondominio
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.StatusCondominio.DefaultCellStyle = dataGridViewCellStyle28;
            this.StatusCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusCondominio.HeaderText = "Status";
            this.StatusCondominio.Name = "StatusCondominio";
            this.StatusCondominio.ReadOnly = true;
            this.StatusCondominio.Width = 70;
            // 
            // ucConsultarCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.pnTabelaConsulta);
            this.Controls.Add(this.panel2);
            this.Name = "ucConsultarCondominio";
            this.Size = new System.Drawing.Size(1174, 460);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnTabelaConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondominios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCondominio;
        private System.Windows.Forms.CheckBox ckbExcluido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnTabelaConsulta;
        private System.Windows.Forms.DataGridView dgvCondominios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn BairroCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CepCondominio;
        private System.Windows.Forms.DataGridViewButtonColumn BlocosCondominio;
        private System.Windows.Forms.DataGridViewButtonColumn AlterarCondominio;
        private System.Windows.Forms.DataGridViewButtonColumn StatusCondominio;
        private System.Windows.Forms.TextBox txtBairro;
    }
}
