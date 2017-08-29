using ENT;
using NEG;
using NEG.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPimConstrutora.Forms
{
    public partial class frmCadastrarPredios : Form
    {
        #region Propriedades & Atributos

        nBloco obj = null;

        #endregion

        public frmCadastrarPredios()
        {
            InitializeComponent();
            obj = new nBloco();
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Util.MensagemInformacao("Preencha o campo nome do Prédio");
            }else
            {
                ePredio obj = new ePredio();

                obj.Nome = txtNome.Text;
            }   
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text = obj.RetornaNumeros(txtNome.Text).Trim();
            txtNome.Select(txtNome.TextLength, 0);
        }
    }
}
