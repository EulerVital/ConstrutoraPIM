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
    public partial class frmCadastrarProfissao : Form
    {
        public eProfissao Profissao { get; set; }
        public frmPrincipal frmPrincipal { get; set; }
        public frmCadastrarProfissao()
        {
            InitializeComponent();
        }

        public frmCadastrarProfissao(eProfissao Profissao, frmPrincipal frm)
        {
            InitializeComponent();

            this.MdiParent = frm;
            frmPrincipal = frm;

            txtNome.Text = Profissao.Nome;
            txtDescricao.Text = Profissao.Descricao;
            txtArea.Text = Profissao.Area;

            this.Profissao = new eProfissao();
            this.Profissao.ProfissaoID = Profissao.ProfissaoID;
        }


        #region Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtArea.Text))
            {
                Util.MensagemErro("Por favor, preencha os campos obrigatórios");
            }else
            {
                eProfissao obj = new eProfissao();

                if (Profissao != null)
                {
                    obj.ProfissaoID = Profissao.ProfissaoID;
                }


                obj.Nome = txtNome.Text;
                obj.Area = txtArea.Text;
                obj.Descricao = txtDescricao.Text;

                GravarOrAlterar(obj);
            }
        }

        #endregion

        #region Metodos

        private void LimparCampos()
        {
            txtNome.Clear();
            txtArea.Clear();
            txtDescricao.Clear();
            txtNome.Focus();
        }

        private bool GravarOrAlterar(eProfissao obj)
        {
            bool isValido = false;
            if (nProfissao.Profissao_SET(obj) != "0")
            {
                if (Profissao != null)
                {
                    Util.MensagemSucesso("Alteração efetuada com sucesso.");
                    frmConsultarProfissao frm = new frmConsultarProfissao(frmPrincipal);
                    frm.Show();
                    this.Dispose();
                }
                else
                {
                    Util.MensagemSucesso("Cadastro efetuado com sucesso.");
                }

                isValido = true;
                LimparCampos();
            }
            else
            {

                if (Profissao != null)
                {
                    Util.MensagemErro("Profissão não foi alterada");
                }
                else
                {
                    Util.MensagemErro("Profissão já cadastrada na base de dados");
                }
            }

            return isValido;
        }

        #endregion
    }
}
