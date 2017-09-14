using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT;
using NEG;
using NEG.Util;

namespace ProjetoPimConstrutora.Forms.UserControls
{
    public partial class ucConsultarCondominio : UserControl
    {
        private List<eEstado> ListaEstado { get; set; }
        private List<eCidade> ListaCidade { get; set; }
        private List<eCondominio> ListaCondominio { get; set; }
        private frmPrincipal frmPrinc { get; set; }

        public ucConsultarCondominio(frmPrincipal frm)
        {
            InitializeComponent();
            CarregarCondominio(true);
            CarregarComboEstado();
            frmPrinc = frm;
        }

        #region Eventos
        private void dgvCondominios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                var objCond = ListaCondominio.Where(c => c.Nome == dgvCondominios.Rows[e.RowIndex].Cells[0].Value.ToString() && c.CEP == dgvCondominios.Rows[e.RowIndex].Cells[5].Value.ToString()).FirstOrDefault();

                var valor = nBloco.Bloco_GET(new eBloco() { Condominio = objCond });

                if (valor.Count > 0)
                {
                    frmConsultarBlocos frm = new frmConsultarBlocos(frmPrinc, objCond);
                    frm.Show();
                    this.Dispose();
                }else
                {
                    Util.MensagemInformacao("Não há blocos incluídos para esse condomínio.");
                }
            }
            else if (e.ColumnIndex == 7)
            {
                var objCond = ListaCondominio.Where(c => c.Nome == dgvCondominios.Rows[e.RowIndex].Cells[0].Value.ToString() && c.CEP == dgvCondominios.Rows[e.RowIndex].Cells[5].Value.ToString()).FirstOrDefault();

                if(objCond != null)
                {
                    frmCadastrarCondominio frm = new frmCadastrarCondominio(frmPrinc, objCond);
                    frm.Show();
                    frmPrinc.pnPrincipal.Visible = false;
                }
            }
            else if(e.ColumnIndex == 8)
            {
                MessageBox.Show("Cliquei em status na linha " + e.RowIndex);
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex > 0)
            {
                var lista = ListaCidade.Where(c => c.Estado.EstadoID == cmbEstado.SelectedValue.ToString()).ToList();
                lista.Insert(0, ListaCidade.Find(c => c.CidadeID == "0"));
                CarragarComboCidade(lista);
            }else
            {
                cmbCidade.DataSource = null;
            }

            CarregarCondominio(false);
        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCondominio(false);
        }

        private void txtNomeCondominio_TextChanged(object sender, EventArgs e)
        {
            CarregarCondominio(false);
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            CarregarCondominio(false);
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            CarregarCondominio(false);
        }

        private void ckbExcluido_CheckedChanged(object sender, EventArgs e)
        {
            CarregarCondominio(false);
        }

        #endregion

        #region Metodos

        private void CarregarCondominio(bool isCarregarBase)
        {
            dgvCondominios.Rows.Clear();

            if (isCarregarBase)
            {
                ListaCondominio = nCondominio.Condominio_GET(new eCondominio());
            }

            var lista = ValidandoFiltros();

            if(lista.Count > 0)
            {
                foreach(var item in lista)
                {
                    if (item.Excluido)
                    {
                        dgvCondominios.Rows.Add(item.Nome, item.Cidade.Estado.Nome, item.Cidade.Nome, item.Bairro, item.Endereco, item.CEP, "Visualizar", "Altera", "Recuperar");
                    }else
                    {
                        dgvCondominios.Rows.Add(item.Nome, item.Cidade.Estado.Nome, item.Cidade.Nome, item.Bairro, item.Endereco, item.CEP, "Visualizar", "Altera", "Excluir");
                    }
                }
            }
        }

        private List<eCondominio> ValidandoFiltros()
        {
            var listaAux = ListaCondominio;

            if ((!string.IsNullOrEmpty(txtNomeCondominio.Text)) || (!string.IsNullOrEmpty(txtEndereco.Text)) || (!string.IsNullOrEmpty(txtBairro.Text)))
            {

                if (!string.IsNullOrEmpty(txtNomeCondominio.Text))
                {
                    listaAux = (from c in ListaCondominio
                                where c.Nome.Contains(txtNomeCondominio.Text)
                                select c).ToList();

                }
                else if (!string.IsNullOrEmpty(txtBairro.Text))
                {
                    listaAux = (from c in ListaCondominio
                                where c.Bairro.Contains(txtBairro.Text)
                                select c).ToList();

                }
                else if (!string.IsNullOrEmpty(txtEndereco.Text))
                {
                    listaAux = (from c in ListaCondominio
                                where c.Endereco.Contains(txtEndereco.Text)
                                select c).ToList();
                }
            }
            else
            {
                listaAux = listaAux.Where(c => c.Excluido == ckbExcluido.Checked).ToList();

                if (cmbEstado.SelectedIndex > 0)
                {
                    listaAux = listaAux.Where(c => c.Cidade.Estado.EstadoID == cmbEstado.SelectedValue.ToString()).ToList();
                }

                if (cmbCidade.SelectedIndex > 0)
                {
                    listaAux = listaAux.Where(c => c.Cidade.CidadeID == cmbCidade.SelectedValue.ToString()).ToList();
                }
            }

            return listaAux;
        }

        private void CarregarComboEstado()
        {
            ListaEstado = nEstado.Estado_GET(new eEstado());
            ListaCidade = nCidade.Cidade_GET(new eCidade());

            ListaEstado.Insert(0,new eEstado() { EstadoID = "0", Nome = "Selecione" });
            ListaCidade.Insert(0,new eCidade() { CidadeID = "0", Nome = "Selecione" });

            cmbEstado.DataSource = ListaEstado;
            cmbEstado.DisplayMember = "Nome";
            cmbEstado.ValueMember = "EstadoID";

            if (cmbEstado.DataSource != null)
            {
                cmbEstado.SelectedIndex = 0;
            }
        }

        private void CarragarComboCidade(List<eCidade> lista)
        {
            cmbCidade.DataSource = null;
            cmbCidade.DataSource = lista;
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "CidadeID";
            if (cmbCidade.DataSource != null)
            {
                cmbCidade.SelectedIndex = 0;
            }
        }

        #endregion
    }
}
