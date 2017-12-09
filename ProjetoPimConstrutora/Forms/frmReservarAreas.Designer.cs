namespace ProjetoPimConstrutora.Forms
{
    partial class frmReservarAreas
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
            this.pnSelecionaMorador = new System.Windows.Forms.Panel();
            this.tabControlReservar = new System.Windows.Forms.TabControl();
            this.tbpMorador = new System.Windows.Forms.TabPage();
            this.pnConsultaMorador = new System.Windows.Forms.Panel();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.cmbApartamento = new System.Windows.Forms.ComboBox();
            this.dgvMoradores = new System.Windows.Forms.DataGridView();
            this.MoradorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMorador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AptAndar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdApt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBloco = new System.Windows.Forms.ComboBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPredio = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpReservar = new System.Windows.Forms.TabPage();
            this.pnReservar = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPessoasArea = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemoverPessoa = new System.Windows.Forms.Button();
            this.gbAreaPaga = new System.Windows.Forms.GroupBox();
            this.cmbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddPessoa = new System.Windows.Forms.Button();
            this.cmbResponsavel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ckbPessoaMenorIdade = new System.Windows.Forms.CheckBox();
            this.lstPessoas = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPessoaRg = new System.Windows.Forms.TextBox();
            this.mtxtPessoaCpf = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPessoaNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAreasDisponiveis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnSelecionaMorador.SuspendLayout();
            this.tabControlReservar.SuspendLayout();
            this.tbpMorador.SuspendLayout();
            this.pnConsultaMorador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoradores)).BeginInit();
            this.tbpReservar.SuspendLayout();
            this.pnReservar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPessoasArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAreaPaga.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSelecionaMorador
            // 
            this.pnSelecionaMorador.AutoScroll = true;
            this.pnSelecionaMorador.BackColor = System.Drawing.Color.LightGray;
            this.pnSelecionaMorador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSelecionaMorador.Controls.Add(this.tabControlReservar);
            this.pnSelecionaMorador.Controls.Add(this.lblTitulo);
            this.pnSelecionaMorador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSelecionaMorador.Location = new System.Drawing.Point(0, 0);
            this.pnSelecionaMorador.Name = "pnSelecionaMorador";
            this.pnSelecionaMorador.Size = new System.Drawing.Size(1151, 518);
            this.pnSelecionaMorador.TabIndex = 46;
            // 
            // tabControlReservar
            // 
            this.tabControlReservar.Controls.Add(this.tbpMorador);
            this.tabControlReservar.Controls.Add(this.tbpReservar);
            this.tabControlReservar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReservar.Font = new System.Drawing.Font("Century", 11.25F);
            this.tabControlReservar.Location = new System.Drawing.Point(0, 23);
            this.tabControlReservar.Name = "tabControlReservar";
            this.tabControlReservar.SelectedIndex = 0;
            this.tabControlReservar.Size = new System.Drawing.Size(1149, 493);
            this.tabControlReservar.TabIndex = 157;
            // 
            // tbpMorador
            // 
            this.tbpMorador.BackColor = System.Drawing.Color.LightGray;
            this.tbpMorador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpMorador.Controls.Add(this.pnConsultaMorador);
            this.tbpMorador.Location = new System.Drawing.Point(4, 27);
            this.tbpMorador.Name = "tbpMorador";
            this.tbpMorador.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMorador.Size = new System.Drawing.Size(1141, 462);
            this.tbpMorador.TabIndex = 0;
            this.tbpMorador.Text = "Escolha o Morador";
            // 
            // pnConsultaMorador
            // 
            this.pnConsultaMorador.Controls.Add(this.cmbCondominio);
            this.pnConsultaMorador.Controls.Add(this.cmbApartamento);
            this.pnConsultaMorador.Controls.Add(this.dgvMoradores);
            this.pnConsultaMorador.Controls.Add(this.label13);
            this.pnConsultaMorador.Controls.Add(this.cmbBloco);
            this.pnConsultaMorador.Controls.Add(this.mtxtCpf);
            this.pnConsultaMorador.Controls.Add(this.label12);
            this.pnConsultaMorador.Controls.Add(this.label3);
            this.pnConsultaMorador.Controls.Add(this.cmbPredio);
            this.pnConsultaMorador.Controls.Add(this.txtNome);
            this.pnConsultaMorador.Controls.Add(this.label11);
            this.pnConsultaMorador.Controls.Add(this.label6);
            this.pnConsultaMorador.Controls.Add(this.label4);
            this.pnConsultaMorador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnConsultaMorador.Location = new System.Drawing.Point(3, 3);
            this.pnConsultaMorador.Name = "pnConsultaMorador";
            this.pnConsultaMorador.Size = new System.Drawing.Size(1133, 454);
            this.pnConsultaMorador.TabIndex = 158;
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondominio.Font = new System.Drawing.Font("Century", 11F);
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(192, 18);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(280, 26);
            this.cmbCondominio.TabIndex = 104;
            this.cmbCondominio.SelectionChangeCommitted += new System.EventHandler(this.cmbCondominio_SelectionChangeCommitted);
            // 
            // cmbApartamento
            // 
            this.cmbApartamento.BackColor = System.Drawing.Color.LightGray;
            this.cmbApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbApartamento.Font = new System.Drawing.Font("Century", 11F);
            this.cmbApartamento.FormattingEnabled = true;
            this.cmbApartamento.Location = new System.Drawing.Point(206, 63);
            this.cmbApartamento.Name = "cmbApartamento";
            this.cmbApartamento.Size = new System.Drawing.Size(183, 26);
            this.cmbApartamento.TabIndex = 156;
            this.cmbApartamento.SelectionChangeCommitted += new System.EventHandler(this.cmbApartamento_SelectionChangeCommitted);
            // 
            // dgvMoradores
            // 
            this.dgvMoradores.AllowUserToAddRows = false;
            this.dgvMoradores.AllowUserToOrderColumns = true;
            this.dgvMoradores.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMoradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMoradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MoradorID,
            this.NomeMorador,
            this.Blocos,
            this.AptAndar,
            this.QtdApt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMoradores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMoradores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMoradores.GridColor = System.Drawing.Color.Black;
            this.dgvMoradores.Location = new System.Drawing.Point(0, 112);
            this.dgvMoradores.MultiSelect = false;
            this.dgvMoradores.Name = "dgvMoradores";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoradores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMoradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMoradores.Size = new System.Drawing.Size(1133, 342);
            this.dgvMoradores.TabIndex = 151;
            this.dgvMoradores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoradores_CellClick);
            // 
            // MoradorID
            // 
            this.MoradorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoradorID.HeaderText = "Cod. Morador";
            this.MoradorID.Name = "MoradorID";
            // 
            // NomeMorador
            // 
            this.NomeMorador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMorador.HeaderText = "Moradores";
            this.NomeMorador.Name = "NomeMorador";
            // 
            // Blocos
            // 
            this.Blocos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Blocos.HeaderText = "CPF";
            this.Blocos.Name = "Blocos";
            // 
            // AptAndar
            // 
            this.AptAndar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AptAndar.HeaderText = "Cond. / Bloco / Prédio / Apt - Andar ";
            this.AptAndar.Name = "AptAndar";
            this.AptAndar.Width = 178;
            // 
            // QtdApt
            // 
            this.QtdApt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QtdApt.HeaderText = "Reservar Área";
            this.QtdApt.Name = "QtdApt";
            this.QtdApt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QtdApt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(10, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 18);
            this.label13.TabIndex = 103;
            this.label13.Text = "Selecione o Condomínio: ";
            // 
            // cmbBloco
            // 
            this.cmbBloco.BackColor = System.Drawing.Color.LightGray;
            this.cmbBloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBloco.Font = new System.Drawing.Font("Century", 11F);
            this.cmbBloco.FormattingEnabled = true;
            this.cmbBloco.Location = new System.Drawing.Point(621, 21);
            this.cmbBloco.Name = "cmbBloco";
            this.cmbBloco.Size = new System.Drawing.Size(146, 26);
            this.cmbBloco.TabIndex = 146;
            this.cmbBloco.SelectionChangeCommitted += new System.EventHandler(this.cmbBloco_SelectionChangeCommitted);
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.BackColor = System.Drawing.Color.LightGray;
            this.mtxtCpf.Font = new System.Drawing.Font("Century", 11F);
            this.mtxtCpf.Location = new System.Drawing.Point(941, 63);
            this.mtxtCpf.Mask = "000.000.000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(113, 25);
            this.mtxtCpf.TabIndex = 150;
            this.mtxtCpf.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(12, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 18);
            this.label12.TabIndex = 155;
            this.label12.Text = "Selecione o Apartamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(478, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 145;
            this.label3.Text = "Selecione o Bloco:";
            // 
            // cmbPredio
            // 
            this.cmbPredio.BackColor = System.Drawing.Color.LightGray;
            this.cmbPredio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPredio.Font = new System.Drawing.Font("Century", 11F);
            this.cmbPredio.FormattingEnabled = true;
            this.cmbPredio.Location = new System.Drawing.Point(941, 24);
            this.cmbPredio.Name = "cmbPredio";
            this.cmbPredio.Size = new System.Drawing.Size(173, 26);
            this.cmbPredio.TabIndex = 154;
            this.cmbPredio.SelectionChangeCommitted += new System.EventHandler(this.cmbPredio_SelectionChangeCommitted);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.LightGray;
            this.txtNome.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(584, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(286, 23);
            this.txtNome.TabIndex = 147;
            this.txtNome.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(789, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 18);
            this.label11.TabIndex = 153;
            this.label11.Text = "Selecione o Prédio :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(406, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 18);
            this.label6.TabIndex = 148;
            this.label6.Text = "Nome ou Ultimo Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(881, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 149;
            this.label4.Text = "CPF:";
            // 
            // tbpReservar
            // 
            this.tbpReservar.BackColor = System.Drawing.Color.LightGray;
            this.tbpReservar.Controls.Add(this.pnReservar);
            this.tbpReservar.Location = new System.Drawing.Point(4, 27);
            this.tbpReservar.Name = "tbpReservar";
            this.tbpReservar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReservar.Size = new System.Drawing.Size(1141, 462);
            this.tbpReservar.TabIndex = 1;
            this.tbpReservar.Text = "Reservar Área";
            this.tbpReservar.UseVisualStyleBackColor = true;
            // 
            // pnReservar
            // 
            this.pnReservar.BackColor = System.Drawing.Color.LightGray;
            this.pnReservar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnReservar.Controls.Add(this.label14);
            this.pnReservar.Controls.Add(this.dtpDataReserva);
            this.pnReservar.Controls.Add(this.panel1);
            this.pnReservar.Controls.Add(this.btnCancelar);
            this.pnReservar.Controls.Add(this.btnSalvar);
            this.pnReservar.Controls.Add(this.cmbHorarios);
            this.pnReservar.Controls.Add(this.label5);
            this.pnReservar.Controls.Add(this.cmbTipoArea);
            this.pnReservar.Controls.Add(this.label2);
            this.pnReservar.Controls.Add(this.lstAreasDisponiveis);
            this.pnReservar.Controls.Add(this.label1);
            this.pnReservar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnReservar.Location = new System.Drawing.Point(3, 3);
            this.pnReservar.Name = "pnReservar";
            this.pnReservar.Size = new System.Drawing.Size(1135, 456);
            this.pnReservar.TabIndex = 153;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(9, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 18);
            this.label14.TabIndex = 171;
            this.label14.Text = "Reservar para:";
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDataReserva.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpDataReserva.CalendarTitleForeColor = System.Drawing.Color.LightGray;
            this.dtpDataReserva.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtpDataReserva.Font = new System.Drawing.Font("Century", 9.75F);
            this.dtpDataReserva.Location = new System.Drawing.Point(123, 11);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(255, 23);
            this.dtpDataReserva.TabIndex = 170;
            this.dtpDataReserva.ValueChanged += new System.EventHandler(this.dtpDataReserva_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gbPessoasArea);
            this.panel1.Location = new System.Drawing.Point(259, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 397);
            this.panel1.TabIndex = 169;
            // 
            // gbPessoasArea
            // 
            this.gbPessoasArea.Controls.Add(this.pictureBox1);
            this.gbPessoasArea.Controls.Add(this.btnRemoverPessoa);
            this.gbPessoasArea.Controls.Add(this.gbAreaPaga);
            this.gbPessoasArea.Controls.Add(this.btnAddPessoa);
            this.gbPessoasArea.Controls.Add(this.cmbResponsavel);
            this.gbPessoasArea.Controls.Add(this.label10);
            this.gbPessoasArea.Controls.Add(this.lblInfo);
            this.gbPessoasArea.Controls.Add(this.ckbPessoaMenorIdade);
            this.gbPessoasArea.Controls.Add(this.lstPessoas);
            this.gbPessoasArea.Controls.Add(this.label9);
            this.gbPessoasArea.Controls.Add(this.txtPessoaRg);
            this.gbPessoasArea.Controls.Add(this.mtxtPessoaCpf);
            this.gbPessoasArea.Controls.Add(this.label8);
            this.gbPessoasArea.Controls.Add(this.label7);
            this.gbPessoasArea.Controls.Add(this.txtPessoaNome);
            this.gbPessoasArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPessoasArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPessoasArea.Font = new System.Drawing.Font("Century", 11.75F);
            this.gbPessoasArea.Location = new System.Drawing.Point(0, 0);
            this.gbPessoasArea.Name = "gbPessoasArea";
            this.gbPessoasArea.Size = new System.Drawing.Size(588, 395);
            this.gbPessoasArea.TabIndex = 164;
            this.gbPessoasArea.TabStop = false;
            this.gbPessoasArea.Text = "Pessoas que Utilizaram (Se o morador for maior de idade, ele será o responsável, " +
    "caso contrario é necessario escolher um)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoPimConstrutora.Properties.Resources.pessoas;
            this.pictureBox1.Location = new System.Drawing.Point(435, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemoverPessoa
            // 
            this.btnRemoverPessoa.BackColor = System.Drawing.Color.LightGray;
            this.btnRemoverPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverPessoa.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoverPessoa.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverPessoa.Image = global::ProjetoPimConstrutora.Properties.Resources.edit_remove;
            this.btnRemoverPessoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoverPessoa.Location = new System.Drawing.Point(50, 149);
            this.btnRemoverPessoa.Name = "btnRemoverPessoa";
            this.btnRemoverPessoa.Size = new System.Drawing.Size(30, 28);
            this.btnRemoverPessoa.TabIndex = 48;
            this.btnRemoverPessoa.UseVisualStyleBackColor = false;
            this.btnRemoverPessoa.Click += new System.EventHandler(this.btnRemoverPessoa_Click);
            // 
            // gbAreaPaga
            // 
            this.gbAreaPaga.Controls.Add(this.cmbTipoPagamento);
            this.gbAreaPaga.Controls.Add(this.label17);
            this.gbAreaPaga.Font = new System.Drawing.Font("Century", 11.75F);
            this.gbAreaPaga.Location = new System.Drawing.Point(195, 245);
            this.gbAreaPaga.Name = "gbAreaPaga";
            this.gbAreaPaga.Size = new System.Drawing.Size(237, 120);
            this.gbAreaPaga.TabIndex = 161;
            this.gbAreaPaga.TabStop = false;
            this.gbAreaPaga.Text = "* Para áreas pagas:";
            this.gbAreaPaga.Visible = false;
            // 
            // cmbTipoPagamento
            // 
            this.cmbTipoPagamento.BackColor = System.Drawing.Color.LightGray;
            this.cmbTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoPagamento.Font = new System.Drawing.Font("Century", 11F);
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.Items.AddRange(new object[] {
            "Selecione",
            "Boleto Bancario",
            "Carta de Crédito",
            "Acumulo de Contas"});
            this.cmbTipoPagamento.Location = new System.Drawing.Point(17, 73);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(200, 26);
            this.cmbTipoPagamento.TabIndex = 162;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(15, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 18);
            this.label17.TabIndex = 43;
            this.label17.Text = "Tipo de pagamento:";
            // 
            // btnAddPessoa
            // 
            this.btnAddPessoa.BackColor = System.Drawing.Color.LightGray;
            this.btnAddPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPessoa.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddPessoa.ForeColor = System.Drawing.Color.Black;
            this.btnAddPessoa.Image = global::ProjetoPimConstrutora.Properties.Resources.edit_add;
            this.btnAddPessoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddPessoa.Location = new System.Drawing.Point(14, 149);
            this.btnAddPessoa.Name = "btnAddPessoa";
            this.btnAddPessoa.Size = new System.Drawing.Size(30, 28);
            this.btnAddPessoa.TabIndex = 47;
            this.btnAddPessoa.UseVisualStyleBackColor = false;
            this.btnAddPessoa.Click += new System.EventHandler(this.btnAddPessoa_Click);
            // 
            // cmbResponsavel
            // 
            this.cmbResponsavel.BackColor = System.Drawing.Color.LightGray;
            this.cmbResponsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbResponsavel.Font = new System.Drawing.Font("Century", 11F);
            this.cmbResponsavel.FormattingEnabled = true;
            this.cmbResponsavel.Location = new System.Drawing.Point(209, 201);
            this.cmbResponsavel.Name = "cmbResponsavel";
            this.cmbResponsavel.Size = new System.Drawing.Size(200, 26);
            this.cmbResponsavel.TabIndex = 160;
            this.cmbResponsavel.SelectionChangeCommitted += new System.EventHandler(this.cmbResponsavel_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(206, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 18);
            this.label10.TabIndex = 159;
            this.label10.Text = "* Selecione o Responsável";
            // 
            // lblInfo
            // 
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfo.Image = global::ProjetoPimConstrutora.Properties.Resources.help;
            this.lblInfo.Location = new System.Drawing.Point(268, 125);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(33, 18);
            this.lblInfo.TabIndex = 156;
            // 
            // ckbPessoaMenorIdade
            // 
            this.ckbPessoaMenorIdade.AutoSize = true;
            this.ckbPessoaMenorIdade.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbPessoaMenorIdade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbPessoaMenorIdade.Location = new System.Drawing.Point(18, 123);
            this.ckbPessoaMenorIdade.Name = "ckbPessoaMenorIdade";
            this.ckbPessoaMenorIdade.Size = new System.Drawing.Size(250, 22);
            this.ckbPessoaMenorIdade.TabIndex = 155;
            this.ckbPessoaMenorIdade.Text = "Marca caso sejá menor de Idade";
            this.ckbPessoaMenorIdade.UseVisualStyleBackColor = true;
            // 
            // lstPessoas
            // 
            this.lstPessoas.BackColor = System.Drawing.Color.LightGray;
            this.lstPessoas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPessoas.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.lstPessoas.Font = new System.Drawing.Font("Century", 11F);
            this.lstPessoas.FormattingEnabled = true;
            this.lstPessoas.ItemHeight = 18;
            this.lstPessoas.Location = new System.Drawing.Point(7, 183);
            this.lstPessoas.Name = "lstPessoas";
            this.lstPessoas.Size = new System.Drawing.Size(182, 182);
            this.lstPessoas.TabIndex = 154;
            this.lstPessoas.DoubleClick += new System.EventHandler(this.btnRemoverPessoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(210, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 95;
            this.label9.Text = "Ou       RG:";
            // 
            // txtPessoaRg
            // 
            this.txtPessoaRg.BackColor = System.Drawing.Color.LightGray;
            this.txtPessoaRg.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtPessoaRg.Location = new System.Drawing.Point(294, 90);
            this.txtPessoaRg.Name = "txtPessoaRg";
            this.txtPessoaRg.Size = new System.Drawing.Size(200, 23);
            this.txtPessoaRg.TabIndex = 94;
            this.txtPessoaRg.TextChanged += new System.EventHandler(this.txtPessoaRg_TextChanged);
            // 
            // mtxtPessoaCpf
            // 
            this.mtxtPessoaCpf.BackColor = System.Drawing.Color.LightGray;
            this.mtxtPessoaCpf.Font = new System.Drawing.Font("Century", 11F);
            this.mtxtPessoaCpf.Location = new System.Drawing.Point(72, 87);
            this.mtxtPessoaCpf.Mask = "000.000.000-00";
            this.mtxtPessoaCpf.Name = "mtxtPessoaCpf";
            this.mtxtPessoaCpf.Size = new System.Drawing.Size(117, 25);
            this.mtxtPessoaCpf.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(12, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "CPF: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "* Nome: ";
            // 
            // txtPessoaNome
            // 
            this.txtPessoaNome.BackColor = System.Drawing.Color.LightGray;
            this.txtPessoaNome.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtPessoaNome.Location = new System.Drawing.Point(87, 59);
            this.txtPessoaNome.Name = "txtPessoaNome";
            this.txtPessoaNome.Size = new System.Drawing.Size(407, 23);
            this.txtPessoaNome.TabIndex = 42;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = global::ProjetoPimConstrutora.Properties.Resources.icon_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(120, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 35);
            this.btnCancelar.TabIndex = 168;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = global::ProjetoPimConstrutora.Properties.Resources.Save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(12, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 35);
            this.btnSalvar.TabIndex = 167;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.BackColor = System.Drawing.Color.LightGray;
            this.cmbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHorarios.Font = new System.Drawing.Font("Century", 11F);
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(574, 11);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(200, 26);
            this.cmbHorarios.TabIndex = 166;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(409, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 165;
            this.label5.Text = "Horários Disponíveis";
            // 
            // cmbTipoArea
            // 
            this.cmbTipoArea.BackColor = System.Drawing.Color.LightGray;
            this.cmbTipoArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoArea.Font = new System.Drawing.Font("Century", 11F);
            this.cmbTipoArea.FormattingEnabled = true;
            this.cmbTipoArea.Location = new System.Drawing.Point(12, 73);
            this.cmbTipoArea.Name = "cmbTipoArea";
            this.cmbTipoArea.Size = new System.Drawing.Size(200, 26);
            this.cmbTipoArea.TabIndex = 163;
            this.cmbTipoArea.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoArea_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 162;
            this.label2.Text = "Esolha o Tipo de Área: ";
            // 
            // lstAreasDisponiveis
            // 
            this.lstAreasDisponiveis.BackColor = System.Drawing.Color.LightGray;
            this.lstAreasDisponiveis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAreasDisponiveis.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.lstAreasDisponiveis.Font = new System.Drawing.Font("Century", 11F);
            this.lstAreasDisponiveis.FormattingEnabled = true;
            this.lstAreasDisponiveis.ItemHeight = 18;
            this.lstAreasDisponiveis.Location = new System.Drawing.Point(12, 148);
            this.lstAreasDisponiveis.Name = "lstAreasDisponiveis";
            this.lstAreasDisponiveis.Size = new System.Drawing.Size(222, 218);
            this.lstAreasDisponiveis.TabIndex = 161;
            this.lstAreasDisponiveis.SelectedIndexChanged += new System.EventHandler(this.lstAreasDisponiveis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 18);
            this.label1.TabIndex = 160;
            this.label1.Text = "Selecione a Área para reservar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 23);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Reservar Áreas";
            // 
            // frmReservarAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 518);
            this.Controls.Add(this.pnSelecionaMorador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReservarAreas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar Áreas";
            this.pnSelecionaMorador.ResumeLayout(false);
            this.pnSelecionaMorador.PerformLayout();
            this.tabControlReservar.ResumeLayout(false);
            this.tbpMorador.ResumeLayout(false);
            this.pnConsultaMorador.ResumeLayout(false);
            this.pnConsultaMorador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoradores)).EndInit();
            this.tbpReservar.ResumeLayout(false);
            this.pnReservar.ResumeLayout(false);
            this.pnReservar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbPessoasArea.ResumeLayout(false);
            this.gbPessoasArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAreaPaga.ResumeLayout(false);
            this.gbAreaPaga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSelecionaMorador;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControlReservar;
        private System.Windows.Forms.TabPage tbpMorador;
        private System.Windows.Forms.Panel pnConsultaMorador;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.ComboBox cmbApartamento;
        private System.Windows.Forms.DataGridView dgvMoradores;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBloco;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPredio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tbpReservar;
        private System.Windows.Forms.Panel pnReservar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPessoasArea;
        private System.Windows.Forms.Button btnRemoverPessoa;
        private System.Windows.Forms.GroupBox gbAreaPaga;
        private System.Windows.Forms.ComboBox cmbTipoPagamento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAddPessoa;
        private System.Windows.Forms.ComboBox cmbResponsavel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox ckbPessoaMenorIdade;
        private System.Windows.Forms.ListBox lstPessoas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPessoaRg;
        private System.Windows.Forms.MaskedTextBox mtxtPessoaCpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPessoaNome;
        private System.Windows.Forms.ComboBox cmbTipoArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstAreasDisponiveis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDataReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoradorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMorador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AptAndar;
        private System.Windows.Forms.DataGridViewButtonColumn QtdApt;
    }
}