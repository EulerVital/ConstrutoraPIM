namespace ProjetoPimConstrutora.Forms
{
    partial class frmCadastrarAreas
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
            this.pnCenter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lstAreas = new System.Windows.Forms.ListBox();
            this.ckbStaus = new System.Windows.Forms.CheckBox();
            this.btnRemoverHora = new System.Windows.Forms.Button();
            this.btnAddHora = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtFim = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtInicio = new System.Windows.Forms.MaskedTextBox();
            this.lstHorarios = new System.Windows.Forms.ListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbAreaPaga = new System.Windows.Forms.CheckBox();
            this.gbModoUso = new System.Windows.Forms.GroupBox();
            this.rbdUsoPessoal = new System.Windows.Forms.RadioButton();
            this.rbdUsoPublico = new System.Windows.Forms.RadioButton();
            this.cmbTipoArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.pnCenter.SuspendLayout();
            this.gbModoUso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCenter
            // 
            this.pnCenter.AutoScroll = true;
            this.pnCenter.BackColor = System.Drawing.Color.LightGray;
            this.pnCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCenter.Controls.Add(this.label3);
            this.pnCenter.Controls.Add(this.lstAreas);
            this.pnCenter.Controls.Add(this.ckbStaus);
            this.pnCenter.Controls.Add(this.btnRemoverHora);
            this.pnCenter.Controls.Add(this.btnAddHora);
            this.pnCenter.Controls.Add(this.label8);
            this.pnCenter.Controls.Add(this.mtxtFim);
            this.pnCenter.Controls.Add(this.label7);
            this.pnCenter.Controls.Add(this.mtxtInicio);
            this.pnCenter.Controls.Add(this.lstHorarios);
            this.pnCenter.Controls.Add(this.btnSalvar);
            this.pnCenter.Controls.Add(this.txtValorArea);
            this.pnCenter.Controls.Add(this.label2);
            this.pnCenter.Controls.Add(this.ckbAreaPaga);
            this.pnCenter.Controls.Add(this.gbModoUso);
            this.pnCenter.Controls.Add(this.cmbTipoArea);
            this.pnCenter.Controls.Add(this.label1);
            this.pnCenter.Controls.Add(this.cmbCondominio);
            this.pnCenter.Controls.Add(this.label13);
            this.pnCenter.Controls.Add(this.lblTitulo);
            this.pnCenter.Controls.Add(this.label5);
            this.pnCenter.Controls.Add(this.txtArea);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(633, 448);
            this.pnCenter.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(474, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 56);
            this.label3.TabIndex = 153;
            this.label3.Text = "Áreas do Condominio Selecionado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstAreas
            // 
            this.lstAreas.BackColor = System.Drawing.Color.LightGray;
            this.lstAreas.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.lstAreas.Enabled = false;
            this.lstAreas.Font = new System.Drawing.Font("Century", 9.75F);
            this.lstAreas.FormattingEnabled = true;
            this.lstAreas.ItemHeight = 16;
            this.lstAreas.Location = new System.Drawing.Point(476, 74);
            this.lstAreas.Name = "lstAreas";
            this.lstAreas.Size = new System.Drawing.Size(144, 340);
            this.lstAreas.TabIndex = 152;
            // 
            // ckbStaus
            // 
            this.ckbStaus.AutoSize = true;
            this.ckbStaus.Checked = true;
            this.ckbStaus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStaus.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbStaus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbStaus.Location = new System.Drawing.Point(323, 270);
            this.ckbStaus.Name = "ckbStaus";
            this.ckbStaus.Size = new System.Drawing.Size(103, 22);
            this.ckbStaus.TabIndex = 151;
            this.ckbStaus.Text = "Área Ativa";
            this.ckbStaus.UseVisualStyleBackColor = true;
            // 
            // btnRemoverHora
            // 
            this.btnRemoverHora.BackColor = System.Drawing.Color.LightGray;
            this.btnRemoverHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverHora.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoverHora.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverHora.Image = global::ProjetoPimConstrutora.Properties.Resources.edit_remove;
            this.btnRemoverHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoverHora.Location = new System.Drawing.Point(188, 357);
            this.btnRemoverHora.Name = "btnRemoverHora";
            this.btnRemoverHora.Size = new System.Drawing.Size(30, 28);
            this.btnRemoverHora.TabIndex = 150;
            this.btnRemoverHora.UseVisualStyleBackColor = false;
            this.btnRemoverHora.Click += new System.EventHandler(this.btnRemoverHora_Click);
            // 
            // btnAddHora
            // 
            this.btnAddHora.BackColor = System.Drawing.Color.LightGray;
            this.btnAddHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHora.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddHora.ForeColor = System.Drawing.Color.Black;
            this.btnAddHora.Image = global::ProjetoPimConstrutora.Properties.Resources.edit_add;
            this.btnAddHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddHora.Location = new System.Drawing.Point(146, 357);
            this.btnAddHora.Name = "btnAddHora";
            this.btnAddHora.Size = new System.Drawing.Size(30, 28);
            this.btnAddHora.TabIndex = 149;
            this.btnAddHora.UseVisualStyleBackColor = false;
            this.btnAddHora.Click += new System.EventHandler(this.btnAddHora_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(290, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 148;
            this.label8.Text = "Ás";
            // 
            // mtxtFim
            // 
            this.mtxtFim.BackColor = System.Drawing.Color.LightGray;
            this.mtxtFim.Font = new System.Drawing.Font("Century", 11F);
            this.mtxtFim.Location = new System.Drawing.Point(323, 318);
            this.mtxtFim.Mask = "00:00";
            this.mtxtFim.Name = "mtxtFim";
            this.mtxtFim.Size = new System.Drawing.Size(62, 25);
            this.mtxtFim.TabIndex = 147;
            this.mtxtFim.ValidatingType = typeof(System.DateTime);
            this.mtxtFim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtHoraio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(138, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 146;
            this.label7.Text = "*Horarío: ";
            // 
            // mtxtInicio
            // 
            this.mtxtInicio.BackColor = System.Drawing.Color.LightGray;
            this.mtxtInicio.Font = new System.Drawing.Font("Century", 11F);
            this.mtxtInicio.Location = new System.Drawing.Point(222, 317);
            this.mtxtInicio.Mask = "00:00";
            this.mtxtInicio.Name = "mtxtInicio";
            this.mtxtInicio.Size = new System.Drawing.Size(62, 25);
            this.mtxtInicio.TabIndex = 145;
            this.mtxtInicio.ValidatingType = typeof(System.DateTime);
            this.mtxtInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtHoraio_KeyPress);
            // 
            // lstHorarios
            // 
            this.lstHorarios.BackColor = System.Drawing.Color.LightGray;
            this.lstHorarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHorarios.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.lstHorarios.Font = new System.Drawing.Font("Century", 9.75F);
            this.lstHorarios.FormattingEnabled = true;
            this.lstHorarios.ItemHeight = 16;
            this.lstHorarios.Location = new System.Drawing.Point(9, 308);
            this.lstHorarios.Name = "lstHorarios";
            this.lstHorarios.Size = new System.Drawing.Size(120, 130);
            this.lstHorarios.TabIndex = 46;
            this.lstHorarios.SelectedIndexChanged += new System.EventHandler(this.lstHorarios_SelectedIndexChanged);
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
            this.btnSalvar.Location = new System.Drawing.Point(144, 400);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 35);
            this.btnSalvar.TabIndex = 46;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorArea
            // 
            this.txtValorArea.BackColor = System.Drawing.Color.LightGray;
            this.txtValorArea.Enabled = false;
            this.txtValorArea.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtValorArea.Location = new System.Drawing.Point(81, 271);
            this.txtValorArea.Name = "txtValorArea";
            this.txtValorArea.Size = new System.Drawing.Size(142, 23);
            this.txtValorArea.TabIndex = 144;
            this.txtValorArea.TextChanged += new System.EventHandler(this.txtValorArea_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(23, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 143;
            this.label2.Text = "R$: ";
            // 
            // ckbAreaPaga
            // 
            this.ckbAreaPaga.AutoSize = true;
            this.ckbAreaPaga.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbAreaPaga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbAreaPaga.Location = new System.Drawing.Point(17, 242);
            this.ckbAreaPaga.Name = "ckbAreaPaga";
            this.ckbAreaPaga.Size = new System.Drawing.Size(99, 22);
            this.ckbAreaPaga.TabIndex = 141;
            this.ckbAreaPaga.Text = "Área Paga";
            this.ckbAreaPaga.UseVisualStyleBackColor = true;
            this.ckbAreaPaga.CheckedChanged += new System.EventHandler(this.ckbAreaPaga_CheckedChanged);
            // 
            // gbModoUso
            // 
            this.gbModoUso.Controls.Add(this.rbdUsoPessoal);
            this.gbModoUso.Controls.Add(this.rbdUsoPublico);
            this.gbModoUso.Font = new System.Drawing.Font("Century", 11F);
            this.gbModoUso.Location = new System.Drawing.Point(14, 175);
            this.gbModoUso.Name = "gbModoUso";
            this.gbModoUso.Size = new System.Drawing.Size(330, 61);
            this.gbModoUso.TabIndex = 107;
            this.gbModoUso.TabStop = false;
            this.gbModoUso.Text = "* Esolha o modo de uso:";
            // 
            // rbdUsoPessoal
            // 
            this.rbdUsoPessoal.AutoSize = true;
            this.rbdUsoPessoal.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdUsoPessoal.Location = new System.Drawing.Point(127, 26);
            this.rbdUsoPessoal.Name = "rbdUsoPessoal";
            this.rbdUsoPessoal.Size = new System.Drawing.Size(110, 22);
            this.rbdUsoPessoal.TabIndex = 47;
            this.rbdUsoPessoal.Text = "Uso Pessoal";
            this.rbdUsoPessoal.UseVisualStyleBackColor = true;
            // 
            // rbdUsoPublico
            // 
            this.rbdUsoPublico.AutoSize = true;
            this.rbdUsoPublico.Checked = true;
            this.rbdUsoPublico.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdUsoPublico.Location = new System.Drawing.Point(14, 26);
            this.rbdUsoPublico.Name = "rbdUsoPublico";
            this.rbdUsoPublico.Size = new System.Drawing.Size(109, 22);
            this.rbdUsoPublico.TabIndex = 46;
            this.rbdUsoPublico.TabStop = true;
            this.rbdUsoPublico.Text = "Uso Publico";
            this.rbdUsoPublico.UseVisualStyleBackColor = true;
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
            this.cmbTipoArea.Location = new System.Drawing.Point(136, 130);
            this.cmbTipoArea.Name = "cmbTipoArea";
            this.cmbTipoArea.Size = new System.Drawing.Size(232, 26);
            this.cmbTipoArea.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 105;
            this.label1.Text = "* Tipo de Área:";
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondominio.Font = new System.Drawing.Font("Century", 11F);
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(206, 40);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(252, 26);
            this.cmbCondominio.TabIndex = 104;
            this.cmbCondominio.SelectionChangeCommitted += new System.EventHandler(this.cmbCondominio_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(11, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 18);
            this.label13.TabIndex = 103;
            this.label13.Text = "* Selecione o Condomínio: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(325, 23);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Cadastrar Áreas do Condominio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(14, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "* Nome da Area: ";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.LightGray;
            this.txtArea.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtArea.Location = new System.Drawing.Point(146, 86);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(262, 23);
            this.txtArea.TabIndex = 40;
            // 
            // frmCadastrarAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 448);
            this.Controls.Add(this.pnCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastrarAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Áreas";
            this.pnCenter.ResumeLayout(false);
            this.pnCenter.PerformLayout();
            this.gbModoUso.ResumeLayout(false);
            this.gbModoUso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.ComboBox cmbTipoArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbModoUso;
        private System.Windows.Forms.RadioButton rbdUsoPessoal;
        private System.Windows.Forms.RadioButton rbdUsoPublico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbAreaPaga;
        private System.Windows.Forms.TextBox txtValorArea;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox lstHorarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtFim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtInicio;
        private System.Windows.Forms.Button btnRemoverHora;
        private System.Windows.Forms.Button btnAddHora;
        private System.Windows.Forms.CheckBox ckbStaus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstAreas;
    }
}