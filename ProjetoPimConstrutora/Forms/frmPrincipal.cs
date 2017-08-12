using System;
using System.Windows.Forms;
using ProjetoPimConstrutora.Forms.UserControls;
using System.Threading;

namespace ProjetoPimConstrutora.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Visible = false;
            Thread.Sleep(2000);
            this.Show();
            cmbTipoUsuario.SelectedIndex = 0;
        }

        #region Eventos

        private void msAdmCondCondCad_Click(object sender, EventArgs e)
        {
            ucCadastrarCondominio ucCadCond = new ucCadastrarCondominio();
            lblTitulo.Text = "Cadastro de Condomínios";
            ucCadCond.Dock = DockStyle.Fill;
            pnPrincipal.Controls.Clear();
            pnPrincipal.Controls.Add(ucCadCond);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            msMenuPrincipal.Visible = true;
            pnLogin.Visible = false;
            lblTitulo.Text = "Bem vindo ao sistema.....";
        }

        private void msAdmCondCondCons_Click(object sender, EventArgs e)
        {
            ucConsultarCondominio ucConsCond = new ucConsultarCondominio();
            lblTitulo.Text = "Consultar Condomínios";
            ucConsCond.Dock = DockStyle.Fill;
            pnPrincipal.Controls.Clear();
            pnPrincipal.Controls.Add(ucConsCond);
        }

        private void msAdmCondBlocoCad_Click(object sender, EventArgs e)
        {
            ucCadastrarBlocos ucCadBlocos = new ucCadastrarBlocos();
            lblTitulo.Text = "Cadastrar Blocos";
            ucCadBlocos.Dock = DockStyle.Fill;
            pnPrincipal.Controls.Clear();
            pnPrincipal.Controls.Add(ucCadBlocos);
        }

        private void msAdmCondPredioCad_Click(object sender, EventArgs e)
        {
            frmCadastrarPredios frm = new frmCadastrarPredios();
            frm.Show();
        }

        private void msAdmCondPredioCons_Click(object sender, EventArgs e)
        {
            frmConsultarPredios frm = new frmConsultarPredios();
            frm.Show();
        }

        private void msCondBlocoCons_Click(object sender, EventArgs e)
        {
            frmConsultarBlocos frm = new frmConsultarBlocos();
            frm.Show();
        }

        private void msAdmCondApartCad_Click(object sender, EventArgs e)
        {
            frmCadastrarApartamento frm = new frmCadastrarApartamento();
            frm.Show();
        }

        private void msAdmCondApartCons_Click(object sender, EventArgs e)
        {
            frmConsultarApartamentos frm = new frmConsultarApartamentos();
            frm.Show();
        }

        private void msAdmUserSysCad_Click(object sender, EventArgs e)
        {
            frmEscolherTipoUsuario frm = new frmEscolherTipoUsuario();
            frm.Show();
        }

        private void msAdmFuncionarioCadFunc_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionarios frm = new frmCadastrarFuncionarios();
            frm.Show();
        }

        private void msAdmFuncionarioCadProf_Click(object sender, EventArgs e)
        {
            frmCadastrarProfissao frm = new frmCadastrarProfissao();
            frm.Show();
        }

        private void msAdmAreaCondCad_Click(object sender, EventArgs e)
        {
            frmCadastrarAreas frm = new frmCadastrarAreas();
            frm.Show();
        }

        private void msGcReservarAreas_Click(object sender, EventArgs e)
        {
            frmReservarAreas frm = new frmReservarAreas();
            frm.Show();
        }

        private void msAdmAreaCondCons_Click(object sender, EventArgs e)
        {
            frmConsultarAreas frm = new frmConsultarAreas();
            frm.Show();
        }

        private void msAdmFuncionarioConsFunc_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario frm = new frmConsultarFuncionario();
            frm.Show();
        }

        private void msAdmUserSysCons_Click(object sender, EventArgs e)
        {
            frmConsultarUsuario frm = new frmConsultarUsuario();
            frm.Show();
        }

        private void msAdmCondEstaCad_Click(object sender, EventArgs e)
        {
            frmCadastrarVagaEstacionamento frm = new frmCadastrarVagaEstacionamento();
            frm.Show();
        }

        private void msAdmCondEstaCons_Click(object sender, EventArgs e)
        {
            frmConsultarEstacionamento frm = new frmConsultarEstacionamento();
            frm.Show();
        }

        private void controleDeVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluguelEstacionamento frm = new frmAluguelEstacionamento();
            frm.Show();
        }

        private void controleDeVigilânciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControleVigilancia frm = new frmControleVigilancia();
            frm.Show();
        }

        private void relatórioDeVigilânciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioVigilancia frm = new frmRelatorioVigilancia();
            frm.Show();
        }

        #endregion

        #region Metodos

        #endregion

    }
}
