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
            pnPrincipal.Visible = true;
            pnPrincipal.Controls.Clear();
            pnPrincipal.Controls.Add(ucCadCond);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            msMenuPrincipal.Visible = true;
            pnLogin.Visible = false;
            lblTitulo.Text = "Bem vindo ao sistema.....";
            lblTitulo.Visible = true;
        }

        private void msAdmCondCondCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = true;
            ucConsultarCondominio ucConsCond = new ucConsultarCondominio();
            lblTitulo.Text = "Consultar Condomínios";
            ucConsCond.Dock = DockStyle.Fill;
            pnPrincipal.Visible = true;
            pnPrincipal.Controls.Clear();
            pnPrincipal.Controls.Add(ucConsCond);
        }

        private void msAdmCondBlocoCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = true;
            ucCadastrarBlocos ucCadBlocos = new ucCadastrarBlocos();
            lblTitulo.Text = "Cadastrar Blocos";
            ucCadBlocos.Dock = DockStyle.Fill;
            pnPrincipal.Visible = true;
            pnPrincipal.Controls.Clear();
            pnPrincipal.Controls.Add(ucCadBlocos);
        }

        private void msAdmCondPredioCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarPredios frm = new frmCadastrarPredios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmCondPredioCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarPredios frm = new frmConsultarPredios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msCondBlocoCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarBlocos frm = new frmConsultarBlocos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmCondApartCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarApartamento frm = new frmCadastrarApartamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmCondApartCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarApartamentos frm = new frmConsultarApartamentos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmUserSysCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmEscolherTipoUsuario frm = new frmEscolherTipoUsuario(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmFuncionarioCadFunc_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarFuncionarios frm = new frmCadastrarFuncionarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmFuncionarioCadProf_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarProfissao frm = new frmCadastrarProfissao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmAreaCondCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarAreas frm = new frmCadastrarAreas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msGcReservarAreas_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmReservarAreas frm = new frmReservarAreas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmAreaCondCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarAreas frm = new frmConsultarAreas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmFuncionarioConsFunc_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarFuncionario frm = new frmConsultarFuncionario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmUserSysCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarUsuario frm = new frmConsultarUsuario();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void msAdmCondEstaCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarVagaEstacionamento frm = new frmCadastrarVagaEstacionamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmCondEstaCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarEstacionamento frm = new frmConsultarEstacionamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void controleDeVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmAluguelEstacionamento frm = new frmAluguelEstacionamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void controleDeVigilânciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmControleVigilancia frm = new frmControleVigilancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relatórioDeVigilânciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmRelatorioVigilancia frm = new frmRelatorioVigilancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarProfissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarProfissao frm = new frmConsultarProfissao(this);
            frm.Show();
        }

        #endregion

        #region Metodos

        #endregion

    }
}
