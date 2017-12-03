namespace ProjetoPimConstrutora.Forms
{
    partial class frmConsultarUsuario
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
            this.pnCenter = new System.Windows.Forms.Panel();
            this.cmbPredio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.CodUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaPaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenhaExpira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbProfissao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbFuncionario = new System.Windows.Forms.CheckBox();
            this.ckbSindico = new System.Windows.Forms.CheckBox();
            this.ckbAdm = new System.Windows.Forms.CheckBox();
            this.cmbBloco = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.pnCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCenter
            // 
            this.pnCenter.AutoScroll = true;
            this.pnCenter.BackColor = System.Drawing.Color.LightGray;
            this.pnCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCenter.Controls.Add(this.cmbPredio);
            this.pnCenter.Controls.Add(this.label3);
            this.pnCenter.Controls.Add(this.cmbCondominio);
            this.pnCenter.Controls.Add(this.label2);
            this.pnCenter.Controls.Add(this.dgvUsuario);
            this.pnCenter.Controls.Add(this.cmbProfissao);
            this.pnCenter.Controls.Add(this.label1);
            this.pnCenter.Controls.Add(this.ckbFuncionario);
            this.pnCenter.Controls.Add(this.ckbSindico);
            this.pnCenter.Controls.Add(this.ckbAdm);
            this.pnCenter.Controls.Add(this.cmbBloco);
            this.pnCenter.Controls.Add(this.label13);
            this.pnCenter.Controls.Add(this.label5);
            this.pnCenter.Controls.Add(this.txtNomeUser);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1043, 481);
            this.pnCenter.TabIndex = 45;
            // 
            // cmbPredio
            // 
            this.cmbPredio.BackColor = System.Drawing.Color.LightGray;
            this.cmbPredio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPredio.Font = new System.Drawing.Font("Century", 11F);
            this.cmbPredio.FormattingEnabled = true;
            this.cmbPredio.Location = new System.Drawing.Point(476, 61);
            this.cmbPredio.Name = "cmbPredio";
            this.cmbPredio.Size = new System.Drawing.Size(157, 26);
            this.cmbPredio.TabIndex = 155;
            this.cmbPredio.SelectionChangeCommitted += new System.EventHandler(this.cmbCombos_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(332, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 154;
            this.label3.Text = "Selecione o Prédio";
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondominio.Font = new System.Drawing.Font("Century", 11F);
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(839, 18);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(193, 26);
            this.cmbCondominio.TabIndex = 153;
            this.cmbCondominio.SelectionChangeCommitted += new System.EventHandler(this.cmbCombos_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(642, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 152;
            this.label2.Text = "Selecione o Condomínio";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToOrderColumns = true;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 11.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodUser,
            this.Blocos,
            this.NomePredio,
            this.AreaPaga,
            this.ValorArea,
            this.Horarios,
            this.SenhaExpira,
            this.Status,
            this.Alterar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsuario.GridColor = System.Drawing.Color.Black;
            this.dgvUsuario.Location = new System.Drawing.Point(0, 110);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(1041, 369);
            this.dgvUsuario.TabIndex = 151;
            // 
            // CodUser
            // 
            this.CodUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodUser.HeaderText = "Cod. User";
            this.CodUser.Name = "CodUser";
            // 
            // Blocos
            // 
            this.Blocos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Blocos.HeaderText = "Nome de Usuário";
            this.Blocos.MinimumWidth = 150;
            this.Blocos.Name = "Blocos";
            // 
            // NomePredio
            // 
            this.NomePredio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomePredio.HeaderText = "Tipo Usuário";
            this.NomePredio.Name = "NomePredio";
            // 
            // AreaPaga
            // 
            this.AreaPaga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AreaPaga.HeaderText = "E-mail";
            this.AreaPaga.Name = "AreaPaga";
            // 
            // ValorArea
            // 
            this.ValorArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorArea.HeaderText = "Condomínio";
            this.ValorArea.Name = "ValorArea";
            // 
            // Horarios
            // 
            this.Horarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Horarios.HeaderText = "Bloco";
            this.Horarios.Name = "Horarios";
            // 
            // SenhaExpira
            // 
            this.SenhaExpira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SenhaExpira.HeaderText = "Prédio";
            this.SenhaExpira.Name = "SenhaExpira";
            // 
            // Status
            // 
            this.Status.HeaderText = "Alterar";
            this.Status.Name = "Status";
            this.Status.Width = 80;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Excluir";
            this.Alterar.Name = "Alterar";
            // 
            // cmbProfissao
            // 
            this.cmbProfissao.BackColor = System.Drawing.Color.LightGray;
            this.cmbProfissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProfissao.Font = new System.Drawing.Font("Century", 11F);
            this.cmbProfissao.FormattingEnabled = true;
            this.cmbProfissao.Location = new System.Drawing.Point(792, 58);
            this.cmbProfissao.Name = "cmbProfissao";
            this.cmbProfissao.Size = new System.Drawing.Size(242, 26);
            this.cmbProfissao.TabIndex = 147;
            this.cmbProfissao.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(642, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 146;
            this.label1.Text = "Selecione Profissão:";
            this.label1.Visible = false;
            // 
            // ckbFuncionario
            // 
            this.ckbFuncionario.AutoSize = true;
            this.ckbFuncionario.Checked = true;
            this.ckbFuncionario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbFuncionario.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbFuncionario.Location = new System.Drawing.Point(519, 18);
            this.ckbFuncionario.Name = "ckbFuncionario";
            this.ckbFuncionario.Size = new System.Drawing.Size(104, 22);
            this.ckbFuncionario.TabIndex = 145;
            this.ckbFuncionario.Text = "Funcinário";
            this.ckbFuncionario.UseVisualStyleBackColor = true;
            this.ckbFuncionario.CheckedChanged += new System.EventHandler(this.ckbTipoUsuario_CheckedChanged);
            // 
            // ckbSindico
            // 
            this.ckbSindico.AutoSize = true;
            this.ckbSindico.Checked = true;
            this.ckbSindico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSindico.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbSindico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbSindico.Location = new System.Drawing.Point(434, 19);
            this.ckbSindico.Name = "ckbSindico";
            this.ckbSindico.Size = new System.Drawing.Size(79, 22);
            this.ckbSindico.TabIndex = 144;
            this.ckbSindico.Text = "Sindico";
            this.ckbSindico.UseVisualStyleBackColor = true;
            this.ckbSindico.CheckedChanged += new System.EventHandler(this.ckbTipoUsuario_CheckedChanged);
            // 
            // ckbAdm
            // 
            this.ckbAdm.AutoSize = true;
            this.ckbAdm.Checked = true;
            this.ckbAdm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAdm.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbAdm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbAdm.Location = new System.Drawing.Point(368, 18);
            this.ckbAdm.Name = "ckbAdm";
            this.ckbAdm.Size = new System.Drawing.Size(60, 22);
            this.ckbAdm.TabIndex = 143;
            this.ckbAdm.Text = "Adm";
            this.ckbAdm.UseVisualStyleBackColor = true;
            this.ckbAdm.CheckedChanged += new System.EventHandler(this.ckbTipoUsuario_CheckedChanged);
            // 
            // cmbBloco
            // 
            this.cmbBloco.BackColor = System.Drawing.Color.LightGray;
            this.cmbBloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBloco.Font = new System.Drawing.Font("Century", 11F);
            this.cmbBloco.FormattingEnabled = true;
            this.cmbBloco.Location = new System.Drawing.Point(143, 60);
            this.cmbBloco.Name = "cmbBloco";
            this.cmbBloco.Size = new System.Drawing.Size(183, 26);
            this.cmbBloco.TabIndex = 110;
            this.cmbBloco.SelectionChangeCommitted += new System.EventHandler(this.cmbCombos_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(7, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 18);
            this.label13.TabIndex = 109;
            this.label13.Text = "Selecione o Bloco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 108;
            this.label5.Text = "Nome de Usuário: ";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.BackColor = System.Drawing.Color.LightGray;
            this.txtNomeUser.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtNomeUser.Location = new System.Drawing.Point(151, 18);
            this.txtNomeUser.MaxLength = 20;
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(210, 23);
            this.txtNomeUser.TabIndex = 107;
            this.txtNomeUser.TextChanged += new System.EventHandler(this.txtNomeUser_TextChanged);
            // 
            // frmConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 481);
            this.Controls.Add(this.pnCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuário";
            this.pnCenter.ResumeLayout(false);
            this.pnCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.ComboBox cmbBloco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.ComboBox cmbProfissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbFuncionario;
        private System.Windows.Forms.CheckBox ckbSindico;
        private System.Windows.Forms.CheckBox ckbAdm;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.ComboBox cmbPredio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaPaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenhaExpira;
        private System.Windows.Forms.DataGridViewButtonColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
    }
}