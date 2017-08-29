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
    public partial class frmConsultarBlocos : Form
    {
        public List<eBloco> ListaBlocos { get; set; }
        public frmConsultarBlocos()
        {
            InitializeComponent();
            ListaBlocos = new List<eBloco>();
            CarregarBlocos(true);
        }

        #region Eventos

        protected void FiltrarChecksBoks(object sender, EventArgs e)
        {
            CarregarBlocos(false);
        }

        #endregion

        #region Metodos

        private void CarregarBlocos(bool isCarregarBase)
        {
            if (isCarregarBase)
            {
                ListaBlocos = nBloco.Bloco_GET(new eBloco());
                CarregarComboCondominio();
            }

            dgvBlocos.Rows.Clear();
            var listaBlocos =  ValidandoFiltros();

            foreach(var item in listaBlocos)
            {
                if (item.StatusAtivo)
                {
                    dgvBlocos.Rows.Add(item.BlocoID, item.Condominio.Nome, item.Nome, item.QtdPredios, item.TipoBloco, "Visualizar", "Desativar");
                }
                else
                {
                    dgvBlocos.Rows.Add(item.BlocoID, item.Condominio.Nome, item.Nome, item.QtdPredios, item.TipoBloco, "Visualizar", "Ativar");
                }
            }
        }

        private List<eBloco> ValidandoFiltros()
        {
            List<eBloco> lista = new List<eBloco>();
            var listaAux = ListaBlocos;

            if (ckbNumeros.Checked)
            {
                listaAux = ListaBlocos.Where(c => c.TipoBloco == "PN" && c.StatusAtivo == ckbAtivos.Checked).ToList();
                lista.AddRange(listaAux);
            }

            if (ckbAmbas.Checked)
            {
                listaAux = ListaBlocos.Where(c => c.TipoBloco == "A" && c.StatusAtivo == ckbAtivos.Checked).ToList();
                lista.AddRange(listaAux);
            }

            if (ckbLetras.Checked)
            {
                listaAux = ListaBlocos.Where(c => c.TipoBloco == "PL" && c.StatusAtivo == ckbAtivos.Checked).ToList();
                lista.AddRange(listaAux);
            }
            
            if(cmbCondominio.SelectedIndex != 0)
            {
                listaAux = ListaBlocos.Where(c => c.Condominio.CondominioID == cmbCondominio.SelectedValue.ToString()).ToList();
                lista.AddRange(listaAux);
            }

            return lista.OrderBy(c=>int.Parse(c.BlocoID)).ToList();
        }

        private void CarregarComboCondominio()
        {
            foreach(var item in ListaBlocos)
            {
                if (!item.Condominio.CondominioID.Equals("0"))
                {
                    cmbCondominio.Items.Add(item.Condominio);
                    cmbCondominio.DisplayMember = "Nome";
                    cmbCondominio.ValueMember = "CondominioID";
                }
            }

            cmbCondominio.Items.Insert(0, "Selecione");
            cmbCondominio.SelectedIndex = 0;
        }

        #endregion
    }
}
