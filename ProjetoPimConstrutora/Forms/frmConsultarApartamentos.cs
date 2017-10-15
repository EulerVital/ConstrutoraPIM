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
    public partial class frmConsultarApartamentos : Form
    {
        private frmPrincipal frmPrincipal { get; set; }
        private List<eApartamento> ListaApartamento { get; set; }
        private List<eCondominio> ListaCondominio { get; set; }
        private List<eBloco> ListaBloco { get; set; }
        private List<ePredio> ListaPredio { get; set; }

        public frmConsultarApartamentos(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            this.MdiParent = frmPrincipal;
            InitializeComponent();
            CarregarCondominio(true);
        }

        #region Metodos
        private void CarregarTabela()
        {
            var listaAux = ValidandoFiltros();

            dgvApartamento.Rows.Clear();
            foreach(var item in listaAux)
            {
                dgvApartamento.Rows.Add(item.NumeroApartamento, item.TipoEstadia.Nome, "Visualizar", "Alterar", "Disvincular", "Excluir");
            }
        }

        private List<eApartamento> ValidandoFiltros()
        {
            var listaAux = ListaApartamento;

        
            if (cmbCondominio.SelectedIndex > 0)
            {
                listaAux = listaAux.Where(c => c.Predio.Bloco.Condominio.CondominioID == ((eCondominio)cmbCondominio.SelectedItem).CondominioID).ToList();
            }

            if (cmbBloco.SelectedIndex > 0)
            {
                listaAux = listaAux.Where(c => c.Predio.Bloco.BlocoID == ((eBloco)cmbBloco.SelectedItem).BlocoID).ToList();
            }

            if (cmbPredio.SelectedIndex > 0)
            {
                listaAux = listaAux.Where(c => c.Predio.PredioID == ((ePredio)cmbPredio.SelectedItem).PredioID).ToList();
            }

            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                listaAux = (from c in listaAux
                            where c.NumeroApartamento.ToString().Contains(txtNumero.Text)
                            select c).ToList();
            }

            return listaAux;
        }

        private void CarregarCondominio(bool isCarregarBase)
        {
            if (isCarregarBase)
            {
                ListaApartamento = nApartamento.Apartamento_GET(new eApartamento());
            }

            if (ListaCondominio == null)
            {
                PreenchendoListasCombos();
            }

            if (!ListaCondominio.Exists(c => c.CondominioID == "0"))
            {
                ListaCondominio.Insert(0, new eCondominio() { CondominioID = "0", Nome = "Selecione" });
            }

            cmbCondominio.DataSource = null;
            cmbCondominio.DataSource = ListaCondominio;
            cmbCondominio.DisplayMember = "Nome";
            cmbCondominio.ValueMember = "CondominioID";
            cmbCondominio.SelectedIndex = 0;
        }

        private void PreenchendoListasCombos()
        {
            ListaCondominio = new List<eCondominio>();
            ListaPredio = new List<ePredio>();
            ListaBloco = new List<eBloco>();

            foreach (var item in ListaApartamento)
            {
                if (!ListaCondominio.Exists(c => c.CondominioID == item.Predio.Bloco.Condominio.CondominioID))
                {
                    ListaCondominio.Add(item.Predio.Bloco.Condominio);
                }

                if (!ListaBloco.Exists(c => c.BlocoID == item.Predio.Bloco.BlocoID))
                {
                    ListaBloco.Add(item.Predio.Bloco);
                }

                if (!ListaPredio.Exists(c => c.PredioID == item.Predio.PredioID))
                {
                    ListaPredio.Add(item.Predio);
                }
            }
        }

        private void CarregarBloco()
        {
            if (cmbCondominio.DataSource != null)
            {
                var listaAux = new List<eBloco>();

                if (cmbCondominio.SelectedIndex > 0)
                {
                    listaAux = ListaBloco.Where(c => c.Condominio.CondominioID == ((eCondominio)cmbCondominio.SelectedItem).CondominioID).ToList();
                }

                listaAux.Insert(0, new eBloco() { BlocoID = "0", Nome = "Selecione" });

                cmbBloco.DataSource = null;
                cmbBloco.DataSource = listaAux;
                cmbBloco.DisplayMember = "Nome";
                cmbBloco.ValueMember = "BlocoID";
                cmbBloco.SelectedIndex = 0;
            }
        }

        private void CarregarPredio()
        {
            var listaAux = new List<ePredio>();

            if (cmbCondominio.DataSource != null)
            {
                if (cmbCondominio.SelectedIndex > 0)
                {
                    listaAux = ListaPredio.Where(c => c.Bloco.Condominio.CondominioID == ((eCondominio)cmbCondominio.SelectedItem).CondominioID).ToList();
                }
            }

            if(cmbBloco.DataSource != null)
            {
                if (cmbBloco.SelectedIndex > 0)
                {
                    listaAux = ListaPredio.Where(c => c.Bloco.BlocoID == ((eBloco)cmbBloco.SelectedItem).BlocoID).ToList();
                }                
            }

            listaAux.Insert(0, new ePredio() { PredioID = "0", Nome = "Selecione" });

            cmbPredio.DataSource = null;
            cmbPredio.DataSource = listaAux;
            cmbPredio.DisplayMember = "Nome";
            cmbPredio.ValueMember = "PredioID";
            cmbPredio.SelectedIndex = 0;
        }

        #endregion

        #region Evento
        private void cmbCondominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarBloco();
        }

        private void cmbBloco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarPredio();            
        }

        private void cmbPredio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.Text = Util.RemoveLetras(txtNumero.Text);
            txtNumero.Select(txtNumero.TextLength, 0);
            CarregarTabela();
        }

        #endregion
    }
}
