namespace ProjetoPimConstrutora.Forms.UserControls
{
    partial class ucCadastrarBlocos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCadastrarBlocos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAmbas = new System.Windows.Forms.RadioButton();
            this.rdbPorLetras = new System.Windows.Forms.RadioButton();
            this.rdbPorNumeros = new System.Windows.Forms.RadioButton();
            this.lstBlocos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeBloco = new System.Windows.Forms.TextBox();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.btnCadastrarBloco = new System.Windows.Forms.Button();
            this.cmbTipoNomeBloco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lstBlocos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNomeBloco);
            this.panel2.Controls.Add(this.ckbStatus);
            this.panel2.Controls.Add(this.btnCadastrarBloco);
            this.panel2.Controls.Add(this.cmbTipoNomeBloco);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 460);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(746, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "LISTA DE CADASTRADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(322, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "IMPORTANTE !!!!!";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(202, 203);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.label2.Size = new System.Drawing.Size(514, 209);
            this.label2.TabIndex = 28;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAmbas);
            this.groupBox1.Controls.Add(this.rdbPorLetras);
            this.groupBox1.Controls.Add(this.rdbPorNumeros);
            this.groupBox1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(740, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 75);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Tipo de Nome do Bloco";
            // 
            // rdbAmbas
            // 
            this.rdbAmbas.AutoSize = true;
            this.rdbAmbas.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAmbas.Location = new System.Drawing.Point(289, 33);
            this.rdbAmbas.Name = "rdbAmbas";
            this.rdbAmbas.Size = new System.Drawing.Size(111, 22);
            this.rdbAmbas.TabIndex = 4;
            this.rdbAmbas.Text = "Por Ambas";
            this.rdbAmbas.UseVisualStyleBackColor = true;
            this.rdbAmbas.CheckedChanged += new System.EventHandler(this.rdbAmbas_CheckedChanged);
            // 
            // rdbPorLetras
            // 
            this.rdbPorLetras.AutoSize = true;
            this.rdbPorLetras.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPorLetras.Location = new System.Drawing.Point(151, 34);
            this.rdbPorLetras.Name = "rdbPorLetras";
            this.rdbPorLetras.Size = new System.Drawing.Size(111, 22);
            this.rdbPorLetras.TabIndex = 3;
            this.rdbPorLetras.Text = "Por Letras";
            this.rdbPorLetras.UseVisualStyleBackColor = true;
            this.rdbPorLetras.CheckedChanged += new System.EventHandler(this.rdbPorLetras_CheckedChanged);
            // 
            // rdbPorNumeros
            // 
            this.rdbPorNumeros.AutoSize = true;
            this.rdbPorNumeros.Checked = true;
            this.rdbPorNumeros.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPorNumeros.Location = new System.Drawing.Point(13, 35);
            this.rdbPorNumeros.Name = "rdbPorNumeros";
            this.rdbPorNumeros.Size = new System.Drawing.Size(130, 22);
            this.rdbPorNumeros.TabIndex = 2;
            this.rdbPorNumeros.TabStop = true;
            this.rdbPorNumeros.Text = "Por Numeros";
            this.rdbPorNumeros.UseVisualStyleBackColor = true;
            this.rdbPorNumeros.CheckedChanged += new System.EventHandler(this.rdbPorNumeros_CheckedChanged);
            // 
            // lstBlocos
            // 
            this.lstBlocos.BackColor = System.Drawing.Color.LightGray;
            this.lstBlocos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBlocos.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBlocos.FormattingEnabled = true;
            this.lstBlocos.ItemHeight = 23;
            this.lstBlocos.Location = new System.Drawing.Point(741, 153);
            this.lstBlocos.Name = "lstBlocos";
            this.lstBlocos.Size = new System.Drawing.Size(420, 278);
            this.lstBlocos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Bloco";
            // 
            // txtNomeBloco
            // 
            this.txtNomeBloco.BackColor = System.Drawing.Color.LightGray;
            this.txtNomeBloco.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBloco.Location = new System.Drawing.Point(193, 76);
            this.txtNomeBloco.MaxLength = 3;
            this.txtNomeBloco.Name = "txtNomeBloco";
            this.txtNomeBloco.Size = new System.Drawing.Size(444, 27);
            this.txtNomeBloco.TabIndex = 1;
            this.txtNomeBloco.TextChanged += new System.EventHandler(this.txtNomeBloco_TextChanged);
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Checked = true;
            this.ckbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStatus.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.ckbStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbStatus.Location = new System.Drawing.Point(17, 141);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(126, 22);
            this.ckbStatus.TabIndex = 7;
            this.ckbStatus.Text = "Status Ativo";
            this.ckbStatus.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarBloco
            // 
            this.btnCadastrarBloco.BackColor = System.Drawing.Color.LightGray;
            this.btnCadastrarBloco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarBloco.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarBloco.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarBloco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarBloco.Location = new System.Drawing.Point(12, 215);
            this.btnCadastrarBloco.Name = "btnCadastrarBloco";
            this.btnCadastrarBloco.Size = new System.Drawing.Size(141, 33);
            this.btnCadastrarBloco.TabIndex = 9;
            this.btnCadastrarBloco.Text = "CADASTRAR";
            this.btnCadastrarBloco.UseVisualStyleBackColor = false;
            this.btnCadastrarBloco.Click += new System.EventHandler(this.btnCadastrarBloco_Click);
            // 
            // cmbTipoNomeBloco
            // 
            this.cmbTipoNomeBloco.BackColor = System.Drawing.Color.LightGray;
            this.cmbTipoNomeBloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoNomeBloco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoNomeBloco.Font = new System.Drawing.Font("Century", 10F);
            this.cmbTipoNomeBloco.FormattingEnabled = true;
            this.cmbTipoNomeBloco.Items.AddRange(new object[] {
            "SOMENTE POR NUMEROS (EX: 001, 002)",
            "SOMENTE POR LETRAS (EX: A, B)",
            "POR LETRA E NUMEROS (EX: A1, A2, B3)"});
            this.cmbTipoNomeBloco.Location = new System.Drawing.Point(325, 21);
            this.cmbTipoNomeBloco.Name = "cmbTipoNomeBloco";
            this.cmbTipoNomeBloco.Size = new System.Drawing.Size(309, 24);
            this.cmbTipoNomeBloco.TabIndex = 0;
            this.cmbTipoNomeBloco.SelectedIndexChanged += new System.EventHandler(this.cmbTipoNomeBloco_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Escolha o Tipo de Nome para  o bloco:";
            // 
            // ucCadastrarBlocos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel2);
            this.Name = "ucCadastrarBlocos";
            this.Size = new System.Drawing.Size(1174, 460);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstBlocos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeBloco;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.Button btnCadastrarBloco;
        private System.Windows.Forms.ComboBox cmbTipoNomeBloco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPorLetras;
        private System.Windows.Forms.RadioButton rdbPorNumeros;
        private System.Windows.Forms.RadioButton rdbAmbas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
