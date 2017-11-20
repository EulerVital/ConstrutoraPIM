namespace ProjetoPimConstrutora.Forms
{
    partial class frmConsultarAreas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbUsoPessoal = new System.Windows.Forms.CheckBox();
            this.ckbUsoPublico = new System.Windows.Forms.CheckBox();
            this.cmbTipoArea = new System.Windows.Forms.ComboBox();
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.ckbAreaGratuita = new System.Windows.Forms.CheckBox();
            this.ckbAreaPaga = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AreaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdApt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horarios = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtArea);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ckbUsoPessoal);
            this.panel1.Controls.Add(this.ckbUsoPublico);
            this.panel1.Controls.Add(this.cmbTipoArea);
            this.panel1.Controls.Add(this.dgvAreas);
            this.panel1.Controls.Add(this.ckbAreaGratuita);
            this.panel1.Controls.Add(this.ckbAreaPaga);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCondominio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 416);
            this.panel1.TabIndex = 0;
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.LightGray;
            this.txtArea.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtArea.Location = new System.Drawing.Point(497, 72);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(194, 23);
            this.txtArea.TabIndex = 149;
            this.txtArea.TextChanged += new System.EventHandler(this.CarregarAreas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(379, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 148;
            this.label2.Text = "Nome da Área:";
            // 
            // ckbUsoPessoal
            // 
            this.ckbUsoPessoal.AutoSize = true;
            this.ckbUsoPessoal.Checked = true;
            this.ckbUsoPessoal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUsoPessoal.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbUsoPessoal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbUsoPessoal.Location = new System.Drawing.Point(840, 29);
            this.ckbUsoPessoal.Name = "ckbUsoPessoal";
            this.ckbUsoPessoal.Size = new System.Drawing.Size(111, 22);
            this.ckbUsoPessoal.TabIndex = 147;
            this.ckbUsoPessoal.Text = "Uso Pessoal";
            this.ckbUsoPessoal.UseVisualStyleBackColor = true;
            this.ckbUsoPessoal.CheckedChanged += new System.EventHandler(this.CarregarAreas);
            // 
            // ckbUsoPublico
            // 
            this.ckbUsoPublico.AutoSize = true;
            this.ckbUsoPublico.Checked = true;
            this.ckbUsoPublico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUsoPublico.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbUsoPublico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbUsoPublico.Location = new System.Drawing.Point(706, 29);
            this.ckbUsoPublico.Name = "ckbUsoPublico";
            this.ckbUsoPublico.Size = new System.Drawing.Size(110, 22);
            this.ckbUsoPublico.TabIndex = 146;
            this.ckbUsoPublico.Text = "Uso Público";
            this.ckbUsoPublico.UseVisualStyleBackColor = true;
            this.ckbUsoPublico.CheckedChanged += new System.EventHandler(this.CarregarAreas);
            // 
            // cmbTipoArea
            // 
            this.cmbTipoArea.BackColor = System.Drawing.Color.LightGray;
            this.cmbTipoArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoArea.Font = new System.Drawing.Font("Century", 11F);
            this.cmbTipoArea.FormattingEnabled = true;
            this.cmbTipoArea.Items.AddRange(new object[] {
            "Selecione",
            "Lazer",
            "Entretenimento",
            "Esporte",
            "Cultural",
            "Ambiental"});
            this.cmbTipoArea.Location = new System.Drawing.Point(136, 68);
            this.cmbTipoArea.Name = "cmbTipoArea";
            this.cmbTipoArea.Size = new System.Drawing.Size(232, 26);
            this.cmbTipoArea.TabIndex = 145;
            this.cmbTipoArea.SelectionChangeCommitted += new System.EventHandler(this.CarregarAreas);
            // 
            // dgvAreas
            // 
            this.dgvAreas.AllowUserToAddRows = false;
            this.dgvAreas.AllowUserToOrderColumns = true;
            this.dgvAreas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAreas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAreas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AreaID,
            this.Blocos,
            this.QtdApt,
            this.NomePredio,
            this.ValorArea,
            this.Horarios,
            this.Alterar,
            this.Status,
            this.Reservar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAreas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAreas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAreas.GridColor = System.Drawing.Color.Black;
            this.dgvAreas.Location = new System.Drawing.Point(0, 123);
            this.dgvAreas.MultiSelect = false;
            this.dgvAreas.Name = "dgvAreas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAreas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreas.Size = new System.Drawing.Size(982, 293);
            this.dgvAreas.TabIndex = 144;
            this.dgvAreas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAreas_CellClick);
            // 
            // ckbAreaGratuita
            // 
            this.ckbAreaGratuita.AutoSize = true;
            this.ckbAreaGratuita.Checked = true;
            this.ckbAreaGratuita.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAreaGratuita.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbAreaGratuita.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbAreaGratuita.Location = new System.Drawing.Point(840, 69);
            this.ckbAreaGratuita.Name = "ckbAreaGratuita";
            this.ckbAreaGratuita.Size = new System.Drawing.Size(136, 22);
            this.ckbAreaGratuita.TabIndex = 142;
            this.ckbAreaGratuita.Text = "Áreas gratuitas";
            this.ckbAreaGratuita.UseVisualStyleBackColor = true;
            this.ckbAreaGratuita.CheckedChanged += new System.EventHandler(this.CarregarAreas);
            // 
            // ckbAreaPaga
            // 
            this.ckbAreaPaga.AutoSize = true;
            this.ckbAreaPaga.Checked = true;
            this.ckbAreaPaga.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAreaPaga.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbAreaPaga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbAreaPaga.Location = new System.Drawing.Point(708, 69);
            this.ckbAreaPaga.Name = "ckbAreaPaga";
            this.ckbAreaPaga.Size = new System.Drawing.Size(112, 22);
            this.ckbAreaPaga.TabIndex = 141;
            this.ckbAreaPaga.Text = "Áreas pagas";
            this.ckbAreaPaga.UseVisualStyleBackColor = true;
            this.ckbAreaPaga.CheckedChanged += new System.EventHandler(this.CarregarAreas);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo de Área";
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(220, 26);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(361, 24);
            this.cmbCondominio.TabIndex = 27;
            this.cmbCondominio.SelectionChangeCommitted += new System.EventHandler(this.CarregarAreas);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(22, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Selecione o Condomínio: ";
            // 
            // AreaID
            // 
            this.AreaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AreaID.HeaderText = "Cod. Área";
            this.AreaID.Name = "AreaID";
            // 
            // Blocos
            // 
            this.Blocos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Blocos.HeaderText = "Nome da Área";
            this.Blocos.Name = "Blocos";
            // 
            // QtdApt
            // 
            this.QtdApt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QtdApt.HeaderText = "Tipo da Área";
            this.QtdApt.Name = "QtdApt";
            // 
            // NomePredio
            // 
            this.NomePredio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomePredio.HeaderText = "Modo de Uso";
            this.NomePredio.Name = "NomePredio";
            this.NomePredio.ToolTipText = "Nome do Prédio";
            // 
            // ValorArea
            // 
            this.ValorArea.HeaderText = "Valor da Área";
            this.ValorArea.Name = "ValorArea";
            // 
            // Horarios
            // 
            this.Horarios.HeaderText = "Horaríos Disponíveis ";
            this.Horarios.Name = "Horarios";
            this.Horarios.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Horarios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 80;
            // 
            // Reservar
            // 
            this.Reservar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reservar.HeaderText = "Reservar Area";
            this.Reservar.Name = "Reservar";
            // 
            // frmConsultarAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 416);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmConsultarAreas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Áreas Cadastradas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbAreaPaga;
        private System.Windows.Forms.CheckBox ckbAreaGratuita;
        private System.Windows.Forms.DataGridView dgvAreas;
        private System.Windows.Forms.ComboBox cmbTipoArea;
        private System.Windows.Forms.CheckBox ckbUsoPessoal;
        private System.Windows.Forms.CheckBox ckbUsoPublico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocos;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdApt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorArea;
        private System.Windows.Forms.DataGridViewButtonColumn Horarios;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Reservar;
    }
}