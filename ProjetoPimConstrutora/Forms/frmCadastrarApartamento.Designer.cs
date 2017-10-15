namespace ProjetoPimConstrutora.Forms
{
    partial class frmCadastrarApartamento
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lstApartamentos = new System.Windows.Forms.ListBox();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.lblValorApt = new System.Windows.Forms.Label();
            this.txtValorApt = new System.Windows.Forms.TextBox();
            this.ckbCadastroAutomatico = new System.Windows.Forms.CheckBox();
            this.nudQtdAptAndar = new System.Windows.Forms.NumericUpDown();
            this.lblQtdAptAndar = new System.Windows.Forms.Label();
            this.nudAndarPredio = new System.Windows.Forms.NumericUpDown();
            this.lblAndarQtPredio = new System.Windows.Forms.Label();
            this.cmbTipoEstadia = new System.Windows.Forms.ComboBox();
            this.lblTipoEstadia = new System.Windows.Forms.Label();
            this.txtNumeroAndar = new System.Windows.Forms.TextBox();
            this.lblNumQtdApt = new System.Windows.Forms.Label();
            this.cmbBloco = new System.Windows.Forms.ComboBox();
            this.cmbCondominio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPredios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdAptAndar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAndarPredio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.LightGray;
            this.pnTop.Controls.Add(this.label3);
            this.pnTop.Controls.Add(this.lstApartamentos);
            this.pnTop.Controls.Add(this.pnCadastro);
            this.pnTop.Controls.Add(this.cmbBloco);
            this.pnTop.Controls.Add(this.cmbCondominio);
            this.pnTop.Controls.Add(this.label5);
            this.pnTop.Controls.Add(this.label4);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.lstPredios);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.btnAjuda);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(736, 466);
            this.pnTop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(181, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 43);
            this.label3.TabIndex = 39;
            this.label3.Text = "Apartamentos  Apt/Andar";
            // 
            // lstApartamentos
            // 
            this.lstApartamentos.BackColor = System.Drawing.Color.LightGray;
            this.lstApartamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstApartamentos.Font = new System.Drawing.Font("Century", 11.25F);
            this.lstApartamentos.FormattingEnabled = true;
            this.lstApartamentos.ItemHeight = 18;
            this.lstApartamentos.Location = new System.Drawing.Point(184, 179);
            this.lstApartamentos.Name = "lstApartamentos";
            this.lstApartamentos.Size = new System.Drawing.Size(155, 272);
            this.lstApartamentos.TabIndex = 38;
            // 
            // pnCadastro
            // 
            this.pnCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCadastro.Controls.Add(this.btnFinalizar);
            this.pnCadastro.Controls.Add(this.lblValorApt);
            this.pnCadastro.Controls.Add(this.txtValorApt);
            this.pnCadastro.Controls.Add(this.ckbCadastroAutomatico);
            this.pnCadastro.Controls.Add(this.btnSalvar);
            this.pnCadastro.Controls.Add(this.nudQtdAptAndar);
            this.pnCadastro.Controls.Add(this.lblQtdAptAndar);
            this.pnCadastro.Controls.Add(this.nudAndarPredio);
            this.pnCadastro.Controls.Add(this.lblAndarQtPredio);
            this.pnCadastro.Controls.Add(this.cmbTipoEstadia);
            this.pnCadastro.Controls.Add(this.lblTipoEstadia);
            this.pnCadastro.Controls.Add(this.txtNumeroAndar);
            this.pnCadastro.Controls.Add(this.lblNumQtdApt);
            this.pnCadastro.Location = new System.Drawing.Point(356, 129);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(371, 331);
            this.pnCadastro.TabIndex = 37;
            // 
            // lblValorApt
            // 
            this.lblValorApt.AutoSize = true;
            this.lblValorApt.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblValorApt.ForeColor = System.Drawing.Color.Black;
            this.lblValorApt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblValorApt.Location = new System.Drawing.Point(214, 202);
            this.lblValorApt.Name = "lblValorApt";
            this.lblValorApt.Size = new System.Drawing.Size(110, 18);
            this.lblValorApt.TabIndex = 57;
            this.lblValorApt.Text = "Valor Apt (R$)";
            // 
            // txtValorApt
            // 
            this.txtValorApt.BackColor = System.Drawing.Color.LightGray;
            this.txtValorApt.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtValorApt.Location = new System.Drawing.Point(213, 233);
            this.txtValorApt.Name = "txtValorApt";
            this.txtValorApt.Size = new System.Drawing.Size(149, 23);
            this.txtValorApt.TabIndex = 56;
            // 
            // ckbCadastroAutomatico
            // 
            this.ckbCadastroAutomatico.AutoSize = true;
            this.ckbCadastroAutomatico.Font = new System.Drawing.Font("Century", 11.25F);
            this.ckbCadastroAutomatico.Location = new System.Drawing.Point(7, 12);
            this.ckbCadastroAutomatico.Name = "ckbCadastroAutomatico";
            this.ckbCadastroAutomatico.Size = new System.Drawing.Size(245, 22);
            this.ckbCadastroAutomatico.TabIndex = 55;
            this.ckbCadastroAutomatico.Text = "Habilitar Cadastro Automático";
            this.ckbCadastroAutomatico.UseVisualStyleBackColor = true;
            this.ckbCadastroAutomatico.CheckedChanged += new System.EventHandler(this.ckbCadastroAutomatico_CheckedChanged);
            // 
            // nudQtdAptAndar
            // 
            this.nudQtdAptAndar.BackColor = System.Drawing.Color.LightGray;
            this.nudQtdAptAndar.Font = new System.Drawing.Font("Century", 9.75F);
            this.nudQtdAptAndar.Location = new System.Drawing.Point(194, 92);
            this.nudQtdAptAndar.Name = "nudQtdAptAndar";
            this.nudQtdAptAndar.Size = new System.Drawing.Size(137, 23);
            this.nudQtdAptAndar.TabIndex = 5;
            this.nudQtdAptAndar.ValueChanged += new System.EventHandler(this.nudQtdAptAndar_ValueChanged);
            // 
            // lblQtdAptAndar
            // 
            this.lblQtdAptAndar.AutoSize = true;
            this.lblQtdAptAndar.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblQtdAptAndar.ForeColor = System.Drawing.Color.Black;
            this.lblQtdAptAndar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblQtdAptAndar.Location = new System.Drawing.Point(182, 52);
            this.lblQtdAptAndar.Name = "lblQtdAptAndar";
            this.lblQtdAptAndar.Size = new System.Drawing.Size(184, 18);
            this.lblQtdAptAndar.TabIndex = 53;
            this.lblQtdAptAndar.Text = "Qtd de Apts nos Andares";
            // 
            // nudAndarPredio
            // 
            this.nudAndarPredio.BackColor = System.Drawing.Color.LightGray;
            this.nudAndarPredio.Font = new System.Drawing.Font("Century", 9.75F);
            this.nudAndarPredio.Location = new System.Drawing.Point(6, 92);
            this.nudAndarPredio.Name = "nudAndarPredio";
            this.nudAndarPredio.Size = new System.Drawing.Size(137, 23);
            this.nudAndarPredio.TabIndex = 4;
            this.nudAndarPredio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAndarPredio.ValueChanged += new System.EventHandler(this.nudQtdAptAndar_ValueChanged);
            // 
            // lblAndarQtPredio
            // 
            this.lblAndarQtPredio.AutoSize = true;
            this.lblAndarQtPredio.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblAndarQtPredio.ForeColor = System.Drawing.Color.Black;
            this.lblAndarQtPredio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAndarQtPredio.Location = new System.Drawing.Point(4, 52);
            this.lblAndarQtPredio.Name = "lblAndarQtPredio";
            this.lblAndarQtPredio.Size = new System.Drawing.Size(155, 18);
            this.lblAndarQtPredio.TabIndex = 52;
            this.lblAndarQtPredio.Text = "Qtd Andar no Prédio";
            // 
            // cmbTipoEstadia
            // 
            this.cmbTipoEstadia.BackColor = System.Drawing.Color.LightGray;
            this.cmbTipoEstadia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEstadia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoEstadia.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbTipoEstadia.FormattingEnabled = true;
            this.cmbTipoEstadia.Location = new System.Drawing.Point(9, 233);
            this.cmbTipoEstadia.Name = "cmbTipoEstadia";
            this.cmbTipoEstadia.Size = new System.Drawing.Size(182, 24);
            this.cmbTipoEstadia.TabIndex = 8;
            this.cmbTipoEstadia.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEstadia_SelectedIndexChanged);
            // 
            // lblTipoEstadia
            // 
            this.lblTipoEstadia.AutoSize = true;
            this.lblTipoEstadia.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblTipoEstadia.ForeColor = System.Drawing.Color.Black;
            this.lblTipoEstadia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipoEstadia.Location = new System.Drawing.Point(7, 201);
            this.lblTipoEstadia.Name = "lblTipoEstadia";
            this.lblTipoEstadia.Size = new System.Drawing.Size(98, 18);
            this.lblTipoEstadia.TabIndex = 51;
            this.lblTipoEstadia.Text = "Tipo Estadia";
            // 
            // txtNumeroAndar
            // 
            this.txtNumeroAndar.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroAndar.Font = new System.Drawing.Font("Century", 9.75F);
            this.txtNumeroAndar.Location = new System.Drawing.Point(6, 165);
            this.txtNumeroAndar.MaxLength = 3;
            this.txtNumeroAndar.Name = "txtNumeroAndar";
            this.txtNumeroAndar.Size = new System.Drawing.Size(185, 23);
            this.txtNumeroAndar.TabIndex = 6;
            this.txtNumeroAndar.TextChanged += new System.EventHandler(this.txtNumeroAndar_TextChanged);
            // 
            // lblNumQtdApt
            // 
            this.lblNumQtdApt.AutoSize = true;
            this.lblNumQtdApt.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblNumQtdApt.ForeColor = System.Drawing.Color.Black;
            this.lblNumQtdApt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumQtdApt.Location = new System.Drawing.Point(4, 130);
            this.lblNumQtdApt.Name = "lblNumQtdApt";
            this.lblNumQtdApt.Size = new System.Drawing.Size(187, 18);
            this.lblNumQtdApt.TabIndex = 50;
            this.lblNumQtdApt.Text = "Número do Apartamento:";
            // 
            // cmbBloco
            // 
            this.cmbBloco.BackColor = System.Drawing.Color.LightGray;
            this.cmbBloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBloco.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbBloco.FormattingEnabled = true;
            this.cmbBloco.Location = new System.Drawing.Point(297, 89);
            this.cmbBloco.Name = "cmbBloco";
            this.cmbBloco.Size = new System.Drawing.Size(210, 24);
            this.cmbBloco.TabIndex = 1;
            this.cmbBloco.SelectedIndexChanged += new System.EventHandler(this.cmbBloco_SelectedIndexChanged);
            // 
            // cmbCondominio
            // 
            this.cmbCondominio.BackColor = System.Drawing.Color.LightGray;
            this.cmbCondominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondominio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondominio.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbCondominio.FormattingEnabled = true;
            this.cmbCondominio.Location = new System.Drawing.Point(24, 90);
            this.cmbCondominio.Name = "cmbCondominio";
            this.cmbCondominio.Size = new System.Drawing.Size(242, 24);
            this.cmbCondominio.TabIndex = 0;
            this.cmbCondominio.SelectedIndexChanged += new System.EventHandler(this.cmbCondominio_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(20, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Condominio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(294, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Bloco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Selecione o prédio: ";
            // 
            // lstPredios
            // 
            this.lstPredios.BackColor = System.Drawing.Color.LightGray;
            this.lstPredios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPredios.Font = new System.Drawing.Font("Century", 11.25F);
            this.lstPredios.FormattingEnabled = true;
            this.lstPredios.ItemHeight = 18;
            this.lstPredios.Location = new System.Drawing.Point(14, 177);
            this.lstPredios.Name = "lstPredios";
            this.lstPredios.Size = new System.Drawing.Size(155, 272);
            this.lstPredios.TabIndex = 3;
            this.lstPredios.SelectedIndexChanged += new System.EventHandler(this.lstPredios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(64, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 33);
            this.label1.TabIndex = 29;
            this.label1.Text = "Clique em \"?\" para obter mais informações sobre o cadastro.";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.LightGray;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Image = global::ProjetoPimConstrutora.Properties.Resources.enviar;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFinalizar.Location = new System.Drawing.Point(252, 288);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(110, 25);
            this.btnFinalizar.TabIndex = 58;
            this.btnFinalizar.Text = "Finalizar Operacao";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(10, 281);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 36);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.LightGray;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnAjuda.ForeColor = System.Drawing.Color.Black;
            this.btnAjuda.Image = global::ProjetoPimConstrutora.Properties.Resources._4927_32x32;
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjuda.Location = new System.Drawing.Point(15, 11);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(43, 33);
            this.btnAjuda.TabIndex = 10;
            this.btnAjuda.UseVisualStyleBackColor = false;
            // 
            // frmCadastrarApartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 466);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastrarApartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Apartamento";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdAptAndar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAndarPredio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPredios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBloco;
        private System.Windows.Forms.ComboBox cmbCondominio;
        private System.Windows.Forms.Panel pnCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown nudQtdAptAndar;
        private System.Windows.Forms.Label lblQtdAptAndar;
        private System.Windows.Forms.NumericUpDown nudAndarPredio;
        private System.Windows.Forms.Label lblAndarQtPredio;
        private System.Windows.Forms.ComboBox cmbTipoEstadia;
        private System.Windows.Forms.Label lblTipoEstadia;
        private System.Windows.Forms.TextBox txtNumeroAndar;
        private System.Windows.Forms.Label lblNumQtdApt;
        private System.Windows.Forms.CheckBox ckbCadastroAutomatico;
        private System.Windows.Forms.Label lblValorApt;
        private System.Windows.Forms.TextBox txtValorApt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstApartamentos;
        private System.Windows.Forms.Button btnFinalizar;
    }
}