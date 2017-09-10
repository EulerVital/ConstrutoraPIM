using ENT;
using NEG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoPimConstrutora.Forms
{
    public partial class frmConsultarPredios : Form
    {
        public List<ePredio> ListaPredio { get; set; }
        public frmConsultarPredios(frmPrincipal frm)
        {
            InitializeComponent();
            CarregarComboCondominio(true, null);
            CarregarTabelaPredio(false);
        }

        public frmConsultarPredios(frmPrincipal frm, eBloco bloco)
        {
            InitializeComponent();

            var lista = nPredio.Predio_GET(new ePredio() { Bloco = bloco });
            ListaPredio = lista;
            this.MdiParent = frm;
            CarregarComboCondominio(false, lista);
            CarregarTabelaPredio(false);
        }

        #region Eventos
        private void ckbExcluidos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarTabelaPredio(false);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            CarregarTabelaPredio(false);
        }

        private void cmbCondominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTabelaPredio(false);
        }

        private void cmbBlocos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCondominio.SelectedIndex > 0)
                CarregarTabelaPredio(false);
            else
                CarregarTabelaPredio(true);
        }

        #endregion

        #region Metódos

        private void CarregarComboCondominio(bool isCarregarBase, List<ePredio> lista)
        {
            if (isCarregarBase)
            {
                ListaPredio = nPredio.Predio_GET(new ePredio());
            }

            cmbCondominio.DataSource = null;
            if (lista == null)
            {
                lista = ListaPredio;
            }

            var listaAux = new List<eCondominio>();

            foreach (var item in lista)
            {
                if (!item.Bloco.Condominio.CondominioID.Equals("0") && !listaAux.Exists(c=>c.CondominioID == item.Bloco.Condominio.CondominioID))
                {
                    listaAux.Add(item.Bloco.Condominio);
                    cmbCondominio.Items.Add(item.Bloco.Condominio);
                    cmbCondominio.DisplayMember = "Nome";
                    cmbCondominio.ValueMember = "CondominioID";
                }
            }

            cmbCondominio.Items.Insert(0, "Selecione");
            cmbCondominio.SelectedIndex = 0;

            CarregarComboBloco(lista);
        }

        private void CarregarComboBloco(List<ePredio> lista)
        {
            var listaAux = new List<eBloco>();
            cmbBlocos.DataSource = null;

            foreach (var item in lista)
            {
                if (!item.Bloco.BlocoID.Equals("0") && !listaAux.Exists(c => c.BlocoID == item.Bloco.BlocoID))
                {
                    listaAux.Add(item.Bloco);
                    cmbBlocos.Items.Add(item.Bloco);
                    cmbBlocos.DisplayMember = "Nome";
                    cmbBlocos.ValueMember = "BlocoID";
                }
            }

            cmbBlocos.Items.Insert(0, "Selecione");
        }

        private void CarregarTabelaPredio(bool isCarregarBase)
        {
            dgvPredios.Rows.Clear();

            if (isCarregarBase)
            {
                ListaPredio = nPredio.Predio_GET(new ePredio());
            }

            var lista = ValidandoFiltros();

            foreach (var item in lista)
            {
                if (item.Excluido)
                {
                    dgvPredios.Rows.Add(item.Bloco.Nome, item.Nome, item.QtdApartamentos, "Visualizar", "Alterar", "Restaurar");
                }
                else
                {
                    dgvPredios.Rows.Add(item.Bloco.Nome, item.Nome, item.QtdApartamentos, "Visualizar", "Alterar", "Excluir");
                }
            }

            txtNome.Focus();
        }

        private List<ePredio> ValidandoFiltros()
        {
            var lista = ListaPredio;

            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                lista = (from c in ListaPredio
                         where c.Nome.Contains(txtNome.Text)
                         select c).ToList();
            }
            else
            {
                lista = lista.Where(c => c.Excluido == ckbExcluidos.Checked).ToList();

                if (cmbCondominio.SelectedIndex > 0)
                {
                    lista = lista.Where(c => c.Bloco.Condominio.CondominioID == ((eCondominio)cmbCondominio.SelectedItem).CondominioID).ToList();
                    CarregarComboBloco(lista);
                }

                if (cmbBlocos.SelectedIndex > 0)
                {
                    lista = lista.Where(c => c.Bloco.BlocoID == ((eBloco)cmbBlocos.SelectedItem).BlocoID).ToList();
                }

            }

            return lista.OrderBy(c => c.PredioID).ToList();
        }

        #endregion
    }
}
