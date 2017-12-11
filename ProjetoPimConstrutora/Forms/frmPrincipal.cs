using System;
using System.Windows.Forms;
using ProjetoPimConstrutora.Forms.UserControls;
using System.Threading;
using ENT;
using System.Collections.Generic;
using NEG;
using System.Linq;
using NEG.Util;

namespace ProjetoPimConstrutora.Forms
{
    public partial class frmPrincipal : Form
    {
        public static eUsuario objUserLogado { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
            this.Visible = false;
            this.Show();
            new frmLogin(this);
        }

        #region Eventos

        private void msAdmCondCondCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondCondCad_1))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmCadastrarCondominio frm = new frmCadastrarCondominio(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }        

        private void msAdmCondCondCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondCondCons_2))
            {
                lblTitulo.Visible = true;
                ucConsultarCondominio ucConsCond = new ucConsultarCondominio(this);
                lblTitulo.Text = "Consultar Condomínios";
                ucConsCond.Dock = DockStyle.Fill;
                pnPrincipal.Visible = true;
                pnPrincipal.Controls.Clear();
                pnPrincipal.Controls.Add(ucConsCond);
            }
        }

        private void msAdmCondBlocoCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondBlocoCad_3))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmCadastrarBloco frm = new frmCadastrarBloco(this);
                frm.Show();
            }
        }

        private void msAdmCondPredioCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondBlocoCons_4))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmCadastrarPredios frm = new frmCadastrarPredios(this, null);
                frm.Show();
            }
        }

        private void msAdmCondPredioCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondPredioCad_5))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmConsultarPredios frm = new frmConsultarPredios(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void msCondBlocoCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondPredioCons_6))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmConsultarBlocos frm = new frmConsultarBlocos(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void msAdmCondApartCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondApartCad_7))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmCadastrarApartamento frm = new frmCadastrarApartamento(this, null);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void msAdmCondApartCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondApartCons_8))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmConsultarApartamentos frm = new frmConsultarApartamentos(this);
                frm.Show();
            }
        }

        private void msAdmCondApartCadTipoEstadia_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondApartCadTipoEstadia_9))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmCadastrarTipoEstadia frm = new frmCadastrarTipoEstadia(this, null);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void msAdmCondApartConsTipoEstadia_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondApartConsTipoEstadia_10))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmConsultarTipoEstadia frm = new frmConsultarTipoEstadia(this);
                frm.Show();
            }
        }

        private void msAdmUserSysCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmUserSysCad_13))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmCadastrarUsuario(this);
            }
        }

        private void msAdmFuncionarioCadFunc_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmFuncionario))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmCadastrarFuncionarios frm = new frmCadastrarFuncionarios();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void msAdmFuncionarioCadProf_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmFuncionarioCadProf_19))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmCadastrarProfissao frm = new frmCadastrarProfissao();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void msAdmAreaCondCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmAreaCondCad_15))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmCadastrarAreas(this);
            }
            
        }

        private void msAdmAreaCondCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmAreaCondCons_16))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmConsultarAreas(this);
            }

        }

        private void msAdmFuncionarioConsFunc_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmFuncionarioConsFunc))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmConsultarFuncionario frm = new frmConsultarFuncionario();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void msAdmUserSysCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmUserSysCons_14))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmConsultarUsuario frm = new frmConsultarUsuario(this);
            }            
        }

        private void msAdmCondEstaCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondEstaCad_11))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmCadastrarEstacionamento(this);
            }
        }

        private void msAdmCondEstaCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmCondEstaCons_12))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmConsultarEstacionamento(this);
            }
        }

        private void controleDeVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(controleDeVagasToolStripMenuItem))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmAluguelEstacionamento frm = new frmAluguelEstacionamento();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void controleDeVigilânciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(controleDeVigilânciaToolStripMenuItem))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmControleVigilancia frm = new frmControleVigilancia();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void relatórioDeVigilânciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(relatórioDeVigilânciaToolStripMenuItem))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmRelatorioVigilancia frm = new frmRelatorioVigilancia();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void consultarProfissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(consultarProfissãoToolStripMenuItem_20))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmConsultarProfissao frm = new frmConsultarProfissao(this);
                frm.Show();
            }
        }

        private void UtilTipoTelCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(UtilTipoTelCad_23))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmCadastrarTipoTelefone frm = new frmCadastrarTipoTelefone(this);
            }
        }

        private void UtilTipoTelCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(UtilTipoTelCons_24))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                frmConsultarTipoTelefone frm = new frmConsultarTipoTelefone(this);
            }
        }

        private void msAdmMoradoresCad_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmMoradoresCad_17))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmCadastrarMoradores(this);
            }
        }

        private void msAdmMoradoresCons_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msAdmMoradoresCons_18))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmConsultarMoradores(this);
            }
        }

        private void consultarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msGcReservarAreasCons_22))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmConsultarReserva(this);
            }
        }

        private void msGcReservarAreas_21_Click(object sender, EventArgs e)
        {
            if (CarregarFuncionalidade(msGcReservarAreas_21))
            {
                lblTitulo.Visible = false;
                pnPrincipal.Visible = false;
                new frmReservarAreas(this);
            }
        }

        #endregion

        #region Metodos

        private bool CarregarFuncionalidade(ToolStripMenuItem menuItem)
        {
            bool acesso = false;

            if (objUserLogado != null)
            {

                if (objUserLogado.TipoUsuario.Equals("F"))
                {
                    var listaFuncionalidade = nFuncionalidadeUsuario.FuncionalidadeUsuario_GET(new eFuncionalidadeUsuario() { Usuario = objUserLogado });
                    string[] codigoMenu = menuItem.Name.Split('_');

                    if (codigoMenu.Length == 2)
                    {
                        foreach (var item in listaFuncionalidade)
                        {
                            var objFunc = nFuncionalidade.Funcionalidade_GET(new eFuncionalidade() { FuncionalidadeID = item.Funcionalidade.FuncionalidadeID }).FirstOrDefault();

                            if (objFunc != null)
                            {
                                if (codigoMenu[1].Contains(objFunc.Codigo_))
                                {
                                    acesso = true;
                                }
                            }
                        }
                    }
                }else
                {
                    acesso = true;
                }
            }

            if (!acesso)
            {
                Util.MensagemInformacao("Você não tem permissão para acessar está area do sistema, por favor contate seu administrador responsável caso encontre algo de errado.");
            }

            return acesso;

        }

        public void CarregarUsuario()
        {
            string[] user = lblUsuario.Text.Trim().Split('/');

            if (user[0] != null && objUserLogado == null)
            {
                objUserLogado = nUsuario.Usuario_GET(new eUsuario() { UsuarioID = user[0] }).FirstOrDefault();
            }
        }

        #endregion
    }
}
