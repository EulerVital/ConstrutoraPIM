using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPimConstrutora.Forms.UserControls;

namespace ProjetoPimConstrutora.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
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

        #endregion

        #region Metodos

        #endregion
    }
}
