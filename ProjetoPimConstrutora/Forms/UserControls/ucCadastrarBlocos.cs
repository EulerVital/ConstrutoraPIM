using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEG;
using ENT;
using NEG.Util;

namespace ProjetoPimConstrutora.Forms.UserControls
{
    public partial class ucCadastrarBlocos : UserControl
    {
        public ucCadastrarBlocos()
        {
            InitializeComponent();
            popularListaBlocos();
            cmbTipoNomeBloco.SelectedIndex = 0;
        }

        #region Metodos

        /// <summary>
        /// Preencha lista de blocos cadastrados de acordo com o tipo dele
        /// </summary>
        private void popularListaBlocos() //Tipo do nome do bloco
        {
            //Siglas
            //A = Ambas
            //PL = Por Letras
            //PN = Por Numeros

            eBloco objBloco = new eBloco();
            objBloco.StatusAtivo = true;

            lstBlocos.DataSource = null;

            if (rdbAmbas.Checked)
            {
                objBloco.TipoBloco = "A";
            }
            else if (rdbPorLetras.Checked)
            {
                objBloco.TipoBloco = "PL";
            }
            else if (rdbPorNumeros.Checked)
            {
                objBloco.TipoBloco = "PN";
            }

            lstBlocos.DataSource = nBloco.Bloco_GET(objBloco);
            lstBlocos.DisplayMember = "Nome";
            lstBlocos.ValueMember = "BlocoID";
        }

        #endregion

        #region Eventos
        private void btnCadastrarBloco_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNomeBloco.Text))
            {
                Util.MensagemErro("Preencha o campo Nome !");
            }else
            {
                eBloco obj = new eBloco();
                obj.Nome = txtNomeBloco.Text;
                obj.StatusAtivo = ckbStatus.Checked;

                //SOMENTE POR NUMEROS(EX: 001, 002)
                //SOMENTE POR LETRAS(EX: A, B)
                //POR LETRA E NUMEROS (EX: A1, A2, B3)
                if(cmbTipoNomeBloco.SelectedIndex == 0)
                {
                    obj.TipoBloco = "PN";
                }

                if (cmbTipoNomeBloco.SelectedIndex == 1)
                {
                    obj.TipoBloco = "PL";
                }

                if (cmbTipoNomeBloco.SelectedIndex == 2)
                {
                    obj.TipoBloco = "A";
                }

                if (!nBloco.Bloco_SET(obj).Equals("0"))
                {
                    Util.MensagemSucesso("Bloco incluido com sucesso");
                    popularListaBlocos();
                }else
                {
                    Util.MensagemErro("Bloco já existe na base");
                }
            }
        }

        private void rdbPorNumeros_CheckedChanged(object sender, EventArgs e)
        {
            popularListaBlocos();
        }

        private void rdbPorLetras_CheckedChanged(object sender, EventArgs e)
        {
            popularListaBlocos();
        }

        private void rdbAmbas_CheckedChanged(object sender, EventArgs e)
        {
            popularListaBlocos();
        }

        private void txtNomeBloco_TextChanged(object sender, EventArgs e)
        {
            nBloco objNeg = new nBloco();

            if (cmbTipoNomeBloco.SelectedIndex == 0)
            {
                txtNomeBloco.Text = objNeg.RetornaNumeros(txtNomeBloco.Text);
            }else if(cmbTipoNomeBloco.SelectedIndex == 1)
            {
                txtNomeBloco.Text =  objNeg.RetornaLetras(txtNomeBloco.Text);
            }else
            {
                txtNomeBloco.Text = objNeg.RetornaNumerosLetras(txtNomeBloco.Text);
            }

            txtNomeBloco.Focus();
        }

        private void cmbTipoNomeBloco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeBloco.Clear();
            txtNomeBloco.Focus();
        }

        #endregion
    }
}
