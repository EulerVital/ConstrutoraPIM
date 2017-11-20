using System;
using System.Windows.Forms;
using ProjetoPimConstrutora.Forms.UserControls;
using System.Threading;
using ENT;

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
            //ucCadastrarCondominio ucCadCond = new ucCadastrarCondominio();
            //lblTitulo.Text = "Cadastro de Condomínios";
            //ucCadCond.Dock = DockStyle.Fill;
            //pnPrincipal.Visible = true;
            //pnPrincipal.Controls.Clear();
            //pnPrincipal.Controls.Add(ucCadCond);

            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarCondominio frm = new frmCadastrarCondominio(this);
            frm.MdiParent = this;
            frm.Show();
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
            ucConsultarCondominio ucConsCond = new ucConsultarCondominio(this);
            lblTitulo.Text = "Consultar Condomínios";
            ucConsCond.Dock = DockStyle.Fill;
            pnPrincipal.Visible = true;
            pnPrincipal.Controls.Clear();
            pnPrincipal.Controls.Add(ucConsCond);
        }

        private void msAdmCondBlocoCad_Click(object sender, EventArgs e)
        {
            //lblTitulo.Visible = true;
            //ucCadastrarBlocos ucCadBlocos = new ucCadastrarBlocos();
            //lblTitulo.Text = "Cadastrar Blocos";
            //ucCadBlocos.Dock = DockStyle.Fill;
            //pnPrincipal.Visible = true;
            //pnPrincipal.Controls.Clear();
            //pnPrincipal.Controls.Add(ucCadBlocos);

            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarBloco frm = new frmCadastrarBloco(this);
            frm.Show();
        }

        private void msAdmCondPredioCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarPredios frm = new frmCadastrarPredios(this, null);
            frm.Show();
        }

        private void msAdmCondPredioCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarPredios frm = new frmConsultarPredios(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void msCondBlocoCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarBlocos frm = new frmConsultarBlocos(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmCondApartCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarApartamento frm = new frmCadastrarApartamento(this, null);
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmCondApartCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarApartamentos frm = new frmConsultarApartamentos(this);
            frm.Show();
        }

        private void msAdmCondApartCadTipoEstadia_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarTipoEstadia frm = new frmCadastrarTipoEstadia(this, null);
            frm.MdiParent = this;
            frm.Show();
        }

        private void msAdmCondApartConsTipoEstadia_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarTipoEstadia frm = new frmConsultarTipoEstadia(this);
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
            new frmCadastrarAreas(this);
            
        }

        private void msGcReservarAreas_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            new frmReservarAreas(this);
        }

        private void msAdmAreaCondCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            new frmConsultarAreas(this);

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
            new frmCadastrarEstacionamento(this);
        }

        private void msAdmCondEstaCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            new frmConsultarEstacionamento(this);
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

        private void UtilTipoTelCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmCadastrarTipoTelefone frm = new frmCadastrarTipoTelefone(this);
        }

        private void UtilTipoTelCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            frmConsultarTipoTelefone frm = new frmConsultarTipoTelefone(this);
        }

        private void msAdmMoradoresCad_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            new frmCadastrarMoradores(this);
        }

        private void msAdmMoradoresCons_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            new frmConsultarMoradores(this);
        }

        private void consultarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pnPrincipal.Visible = false;
            new frmConsultarReserva(this);
        }

        #endregion

        #region Metodos

        #endregion
    }
}
