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
    public partial class frmConsultarPredios : Form
    {
        public List<ePredio> ListaPredio { get; set; }
        public frmConsultarPredios()
        {
            InitializeComponent();
            CarregarComboCondominio(true, null);
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
            CarregarTabelaPredio(false);
        }

        #endregion

        #region Metódos

        private void CarregarComboCondominio(bool isCarregarBase, List<ePredio> lista)
        {
            if (lista == null)
            {
                if (isCarregarBase)
                {
                    ListaPredio = nPredio.Predio_GET(new ePredio());
                }

                lista = ListaPredio;
            }

            foreach (var item in lista)
            {
                if (!item.Bloco.Condominio.CondominioID.Equals("0"))
                {
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
            foreach(var item in lista)
            {
                if (!item.Bloco.BlocoID.Equals("0"))
                {
                    cmbCondominio.Items.Add(item.Bloco);
                    cmbCondominio.DisplayMember = "Nome";
                    cmbCondominio.ValueMember = "BlocoID";
                }
            }

            cmbBlocos.Items.Insert(0, "Selecione");
            cmbBlocos.SelectedIndex = 0;
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
                    lista = lista.Where(c => c.Bloco.Condominio.CondominioID == cmbCondominio.SelectedValue.ToString()).ToList();
                    CarregarComboBloco(lista);
                }

                if (cmbBlocos.SelectedIndex > 0)
                {
                    lista = lista.Where(c => c.Bloco.BlocoID == cmbBlocos.SelectedValue.ToString()).ToList();
                }

            }

            return lista.OrderBy(c => c.PredioID).ToList();
        }

        #endregion
    }
}
