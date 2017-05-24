namespace ProjetoPimConstrutora.Forms
{
    partial class frmAcessoCameras
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
            this.cmbescolhalocaldesejado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbescolhalocaldesejado
            // 
            this.cmbescolhalocaldesejado.BackColor = System.Drawing.Color.LightGray;
            this.cmbescolhalocaldesejado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbescolhalocaldesejado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbescolhalocaldesejado.Font = new System.Drawing.Font("Century", 9.75F);
            this.cmbescolhalocaldesejado.FormattingEnabled = true;
            this.cmbescolhalocaldesejado.Items.AddRange(new object[] {
            "Condominio",
            "Bloco",
            "Predios",
            "Estacionamento",
            "Lazer",
            "Salão de festas",
            "",
            " "});
            this.cmbescolhalocaldesejado.Location = new System.Drawing.Point(69, 88);
            this.cmbescolhalocaldesejado.Name = "cmbescolhalocaldesejado";
            this.cmbescolhalocaldesejado.Size = new System.Drawing.Size(246, 24);
            this.cmbescolhalocaldesejado.TabIndex = 78;
            this.cmbescolhalocaldesejado.SelectedIndexChanged += new System.EventHandler(this.cmbBairroCondominio_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(88, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 18);
            this.label9.TabIndex = 80;
            this.label9.Text = "Escolha Local Desejado:";
            // 
            // frmAcessoCameras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(390, 185);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbescolhalocaldesejado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAcessoCameras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscolhaVigilancia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbescolhalocaldesejado;
        private System.Windows.Forms.Label label9;
    }
}