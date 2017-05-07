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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCondominio = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNomeCondominio);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 135);
            this.panel2.TabIndex = 6;
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
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(666, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 22);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Status Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(8, 89);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 33);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "FILTRAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.LightGray;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Century", 9.75F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(415, 55);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(192, 24);
            this.comboBox3.TabIndex = 23;
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
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LightGray;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century", 9.75F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 24);
            this.comboBox2.TabIndex = 21;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(913, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 17;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Font = new System.Drawing.Font("Century", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(729, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 23);
            this.textBox1.TabIndex = 15;
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
            this.pnTabelaConsulta.Location = new System.Drawing.Point(0, 135);
            this.pnTabelaConsulta.Name = "pnTabelaConsulta";
            this.pnTabelaConsulta.Size = new System.Drawing.Size(1174, 325);
            this.pnTabelaConsulta.TabIndex = 7;
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
            this.BairroCondominio,
            this.EnderecoCondominio,
            this.CepCondominio,
            this.BlocosCondominio,
            this.AlterarCondominio,
            this.StatusCondominio});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCondominios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCondominios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCondominios.GridColor = System.Drawing.Color.Black;
            this.dgvCondominios.Location = new System.Drawing.Point(0, 0);
            this.dgvCondominios.MultiSelect = false;
            this.dgvCondominios.Name = "dgvCondominios";
            this.dgvCondominios.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondominios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCondominios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCondominios.Size = new System.Drawing.Size(1174, 325);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.BlocosCondominio.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.AlterarCondominio.DefaultCellStyle = dataGridViewCellStyle3;
            this.AlterarCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlterarCondominio.HeaderText = "Alterar Dados";
            this.AlterarCondominio.Name = "AlterarCondominio";
            this.AlterarCondominio.ReadOnly = true;
            this.AlterarCondominio.Width = 70;
            // 
            // StatusCondominio
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.StatusCondominio.DefaultCellStyle = dataGridViewCellStyle4;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}
