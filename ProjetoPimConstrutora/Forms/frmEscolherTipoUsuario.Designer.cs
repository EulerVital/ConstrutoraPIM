namespace ProjetoPimConstrutora.Forms
{
    partial class frmEscolherTipoUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbPerfilFunc = new System.Windows.Forms.RadioButton();
            this.rdbPerfilSindico = new System.Windows.Forms.RadioButton();
            this.rdbPerfilAdm = new System.Windows.Forms.RadioButton();
            this.pnTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.LightGray;
            this.pnTop.Controls.Add(this.groupBox1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(311, 205);
            this.pnTop.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProsseguir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbPerfilFunc);
            this.groupBox1.Controls.Add(this.rdbPerfilSindico);
            this.groupBox1.Controls.Add(this.rdbPerfilAdm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolher Tipo de Usuário ";
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.LightGray;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProsseguir.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.btnProsseguir.ForeColor = System.Drawing.Color.Black;
            this.btnProsseguir.Image = global::ProjetoPimConstrutora.Properties.Resources._178;
            this.btnProsseguir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProsseguir.Location = new System.Drawing.Point(12, 163);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(40, 30);
            this.btnProsseguir.TabIndex = 28;
            this.btnProsseguir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Image = global::ProjetoPimConstrutora.Properties.Resources.help;
            this.label3.Location = new System.Drawing.Point(231, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = global::ProjetoPimConstrutora.Properties.Resources.help;
            this.label2.Location = new System.Drawing.Point(190, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = global::ProjetoPimConstrutora.Properties.Resources.help;
            this.label1.Location = new System.Drawing.Point(252, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 3;
            // 
            // rdbPerfilFunc
            // 
            this.rdbPerfilFunc.AutoSize = true;
            this.rdbPerfilFunc.Location = new System.Drawing.Point(12, 122);
            this.rdbPerfilFunc.Name = "rdbPerfilFunc";
            this.rdbPerfilFunc.Size = new System.Drawing.Size(213, 22);
            this.rdbPerfilFunc.TabIndex = 2;
            this.rdbPerfilFunc.TabStop = true;
            this.rdbPerfilFunc.Text = "Com Perfil Funcionário";
            this.rdbPerfilFunc.UseVisualStyleBackColor = true;
            // 
            // rdbPerfilSindico
            // 
            this.rdbPerfilSindico.AutoSize = true;
            this.rdbPerfilSindico.Location = new System.Drawing.Point(12, 86);
            this.rdbPerfilSindico.Name = "rdbPerfilSindico";
            this.rdbPerfilSindico.Size = new System.Drawing.Size(176, 22);
            this.rdbPerfilSindico.TabIndex = 1;
            this.rdbPerfilSindico.TabStop = true;
            this.rdbPerfilSindico.Text = "Com Perfil Sindico";
            this.rdbPerfilSindico.UseVisualStyleBackColor = true;
            // 
            // rdbPerfilAdm
            // 
            this.rdbPerfilAdm.AutoSize = true;
            this.rdbPerfilAdm.Checked = true;
            this.rdbPerfilAdm.Location = new System.Drawing.Point(12, 53);
            this.rdbPerfilAdm.Name = "rdbPerfilAdm";
            this.rdbPerfilAdm.Size = new System.Drawing.Size(234, 22);
            this.rdbPerfilAdm.TabIndex = 0;
            this.rdbPerfilAdm.TabStop = true;
            this.rdbPerfilAdm.Text = "Com Perfil Administrador";
            this.rdbPerfilAdm.UseVisualStyleBackColor = true;
            // 
            // frmEscolherTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 205);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEscolherTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolher Usuário";
            this.pnTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPerfilFunc;
        private System.Windows.Forms.RadioButton rdbPerfilSindico;
        private System.Windows.Forms.RadioButton rdbPerfilAdm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProsseguir;
    }
}