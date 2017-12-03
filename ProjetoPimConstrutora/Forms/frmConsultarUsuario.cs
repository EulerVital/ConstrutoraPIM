using ENT;
using NEG;
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
    public partial class frmConsultarUsuario : Form
    {
        private frmPrincipal frmPrincipal { get; set; }
        private List<eCondominio> ListaCondominio { get; set; }
        private List<eBloco> ListaBloco { get; set; }
        private List<ePredio> ListaPredio { get; set; }
        private List<eUsuario> ListaUsuario { get; set; }
        public frmConsultarUsuario(frmPrincipal frm)
        {
            InitializeComponent();
            frmPrincipal = frm;
            this.MdiParent = frm;
            CarregarCombos(true);
            CarregarUsuarios();
            this.Show();
        }

        #region Metodos
        private void CarregarCombos(bool isCarregarBase)
        {
            if (isCarregarBase)
            {
                ListaUsuario = nUsuario.Usuario_GET(new eUsuario());
                ListaCondominio = new List<eCondominio>();
                ListaBloco = new List<eBloco>();
                ListaPredio = new List<ePredio>();

                ListaCondominio.Add(new eCondominio() { Nome = "Selecione", CondominioID = "0" });
                ListaBloco.Add(new eBloco() { Nome = "Selecione", BlocoID = "0" });
                ListaPredio.Add(new ePredio() { Nome = "Selecione", PredioID = "0" });

                foreach(var item in ListaUsuario)
                {
                    if(!item.Predio.PredioID.Equals("0"))
                    {
                        ListaPredio.Add(item.Predio);
                    }else if(!item.Bloco.BlocoID.Equals("0"))
                    {
                        ListaBloco.Add(item.Bloco);
                    }else if(!item.Condominio.CondominioID.Equals("0"))
                    {
                        ListaCondominio.Add(item.Condominio);
                    }
                }
            }

            //Condominio
            cmbCondominio.DataSource = null;
            cmbCondominio.DataSource = ListaCondominio;
            cmbCondominio.DisplayMember = "Nome";
            cmbCondominio.ValueMember = "CondominioID";

            //Bloco
            cmbBloco.DataSource = null;
            cmbBloco.DataSource = ListaBloco;
            cmbBloco.DisplayMember = "Nome";
            cmbBloco.ValueMember = "BlocoID";

            //Predio
            cmbPredio.DataSource = null;
            cmbPredio.DataSource = ListaPredio;
            cmbPredio.DisplayMember = "Nome";
            cmbPredio.ValueMember = "PredioID";

            cmbCondominio.SelectedIndex = 0;
            cmbBloco.SelectedIndex = 0;
            cmbPredio.SelectedIndex = 0;
        }

        private void CarregarUsuarios()
        {
            var listaUser = ValidandoFiltros();

            dgvUsuario.Rows.Clear();
            var tipoUser = string.Empty;
            foreach (var item in listaUser)
            {
                if (item.TipoUsuario.Equals("A"))
                    tipoUser = "Administrativo";
                else if (item.TipoUsuario.Equals("S"))
                    tipoUser = "Sindico";
                else
                    tipoUser = "Funcionário";

                dgvUsuario.Rows.Add(item.UsuarioID ,item.NomeUser, tipoUser, item.Email, item.Condominio.Nome, item.Bloco.Nome, item.Predio.Nome, "Alterar", "Excluir");
            }
        }

        private List<eUsuario> ValidandoFiltros()
        {
            List<eUsuario> lista = new List<eUsuario>();
            lista = ListaUsuario;

            #region Validando Filtro Tipo User

            if (!ckbAdm.Checked || !ckbSindico.Checked || !ckbFuncionario.Checked)
            {
                if (!ckbAdm.Checked)
                {
                    if (!ckbSindico.Checked)
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("F")).ToList();
                    }
                    else if (!ckbFuncionario.Checked)
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("S")).ToList();
                    }
                    else
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("S") || c.TipoUsuario.Equals("F")).ToList();
                    }
                }
                else if (!ckbSindico.Checked)
                {
                    if (!ckbAdm.Checked)
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("F")).ToList();
                    }
                    else if (!ckbFuncionario.Checked)
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("A")).ToList();
                    }
                    else
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("A") || c.TipoUsuario.Equals("F")).ToList();
                    }
                }
                else if (!ckbFuncionario.Checked)
                {
                    if (!ckbSindico.Checked)
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("A")).ToList();
                    }
                    else if (!ckbAdm.Checked)
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("S")).ToList();
                    }
                    else
                    {
                        lista = lista.Where(c => c.TipoUsuario.Equals("S") || c.TipoUsuario.Equals("A")).ToList();
                    }
                }
            }

            #endregion

            if (string.IsNullOrEmpty(txtNomeUser.Text))
            {
                if(cmbCondominio.SelectedIndex > 0)
                {
                    lista = lista.Where(c => c.Condominio.CondominioID == cmbCondominio.SelectedValue.ToString()).ToList();
                }

                if (cmbBloco.SelectedIndex > 0)
                {
                    lista = lista.Where(c => c.Bloco.BlocoID == cmbBloco.SelectedValue.ToString()).ToList();
                }

                if (cmbPredio.SelectedIndex > 0)
                {
                    lista = lista.Where(c => c.Predio.PredioID == cmbPredio.SelectedValue.ToString()).ToList();
                }

            }else
            {
                cmbCondominio.SelectedIndex = 0;
                cmbBloco.SelectedIndex = 0;
                cmbPredio.SelectedIndex = 0;

                lista = (from p in lista
                         where p.NomeUser.ToLower().Contains(txtNomeUser.Text.ToLower())
                         select p).ToList();
            }

            return lista;
        }

        #endregion

        #region Eventos

        private void cmbCombos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void ckbTipoUsuario_CheckedChanged(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void txtNomeUser_TextChanged(object sender, EventArgs e)
        {
            txtNomeUser.Text = txtNomeUser.Text.Trim();
            txtNomeUser.Select(txtNomeUser.TextLength, 0);
            CarregarUsuarios();
        }

        #endregion
    }
}
