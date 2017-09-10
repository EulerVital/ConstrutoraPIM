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
        public ePredio Predio { get; set; }

        #endregion

        public frmCadastrarPredios()
        {
            InitializeComponent();
            obj = new nBloco();
            txtNome.Focus();
        }

        #region Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarPredio();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text = obj.RetornaNumeros(txtNome.Text).Trim();
            txtNome.Select(txtNome.TextLength, 0);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                SalvarPredio();
            }
        }

        #endregion

        #region Metodos

        private void SalvarPredio()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Util.MensagemInformacao("Preencha o campo nome do Prédio");
            }
            else
            {
                Predio = new ePredio();

                Predio.Nome = txtNome.Text;
                Predio.Excluido = ckbExcluido.Checked;
                Predio.PredioID = nPredio.Predio_SET(Predio);

                if (!Predio.PredioID.Equals("0"))
                {
                    Util.MensagemSucesso("Cadastro Efetuado com sucessso");
                    txtNome.Clear();
                    txtNome.Focus();
                    ckbExcluido.Checked = false;
                }
                else
                {
                    Util.MensagemErro();
                }
            }
        }

        #endregion
    }
}
