namespace ProjetoPimConstrutora.Forms
{
    partial class frmIncluirVisitantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirVisitantes));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.btnIncluirPredio = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(352, 34);
            this.lblTitulo.TabIndex = 98;
            this.lblTitulo.Text = "Incluir visitante rapido";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(14, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 102;
            this.label6.Text = "*Nome Completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 103;
            this.label1.Text = "*CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(184, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 104;
            this.label2.Text = "RG (opcional): ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(153, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 23);
            this.textBox1.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(413, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 123;
            this.label4.Text = "Tempo de permanência";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox1.Font = new System.Drawing.Font("Century", 10F);
            this.maskedTextBox1.Location = new System.Drawing.Point(296, 129);
            this.maskedTextBox1.Mask = "000-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(89, 24);
            this.maskedTextBox1.TabIndex = 127;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox2.Font = new System.Drawing.Font("Century", 10F);
            this.maskedTextBox2.Location = new System.Drawing.Point(71, 130);
            this.maskedTextBox2.Mask = "000-00-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(89, 24);
            this.maskedTextBox2.TabIndex = 128;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(690, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 129;
            this.label8.Text = "dias";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(603, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 24);
            this.comboBox1.TabIndex = 131;
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
            this.btnSalvar.Location = new System.Drawing.Point(346, 267);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 30);
            this.btnSalvar.TabIndex = 130;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 132;
            this.label3.Text = "Data e hora de entrada";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox6.Font = new System.Drawing.Font("Century", 10F);
            this.maskedTextBox6.Location = new System.Drawing.Point(187, 166);
            this.maskedTextBox6.Mask = "00/00/0000 90:00";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(87, 24);
            this.maskedTextBox6.TabIndex = 133;
            this.maskedTextBox6.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(293, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 134;
            this.label7.Text = "Saida";
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBox7.Font = new System.Drawing.Font("Century", 10F);
            this.maskedTextBox7.Location = new System.Drawing.Point(346, 171);
            this.maskedTextBox7.Mask = "90:00";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(44, 24);
            this.maskedTextBox7.TabIndex = 135;
            this.maskedTextBox7.ValidatingType = typeof(System.DateTime);
            // 
            // btnIncluirPredio
            // 
            this.btnIncluirPredio.BackColor = System.Drawing.Color.LightGray;
            this.btnIncluirPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirPredio.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnIncluirPredio.ForeColor = System.Drawing.Color.Black;
            this.btnIncluirPredio.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirPredio.Image")));
            this.btnIncluirPredio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirPredio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIncluirPredio.Location = new System.Drawing.Point(17, 205);
            this.btnIncluirPredio.Name = "btnIncluirPredio";
            this.btnIncluirPredio.Size = new System.Drawing.Size(241, 29);
            this.btnIncluirPredio.TabIndex = 154;
            this.btnIncluirPredio.Text = "Incluir vaga de estacionamento";
            this.btnIncluirPredio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirPredio.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(12, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 18);
            this.label9.TabIndex = 155;
            this.label9.Text = "*Nome do Morador";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century", 9.75F);
            this.textBox2.Location = new System.Drawing.Point(161, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 23);
            this.textBox2.TabIndex = 156;
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
            this.btnAjuda.Location = new System.Drawing.Point(473, 47);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(46, 33);
            this.btnAjuda.TabIndex = 157;
            this.btnAjuda.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(541, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 49);
            this.label5.TabIndex = 158;
            this.label5.Text = "Clique em \"?\" para obter mais informações sobre o cadastro.";
            // 
            // frmIncluirVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(765, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIncluirPredio);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIncluirVisitantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Visitantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.Button btnIncluirPredio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label label5;
    }
}