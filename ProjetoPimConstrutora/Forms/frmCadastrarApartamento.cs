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
    public partial class frmCadastrarApartamento : Form
    {
        private List<ePredio> ListaPredio { get; set; }
        private List<eCondominio> ListaCondominio { get; set; }
        private List<eBloco> ListaBloco { get; set; }
        public frmCadastrarApartamento(frmPrincipal frm, eApartamento obj)
        {
            InitializeComponent();

            ListaCondominio = new List<eCondominio>();
            ListaBloco = new List<eBloco>();

            CarregarComboCondominioPrincipal(true);
        }

        #region Eventos

        private void cmbCondominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCondominio.SelectedIndex > 0)
            {
                AtualizarComboBloco((eCondominio)cmbCondominio.SelectedItem);
            }else
            {
                CarregarComboBloco(new List<eBloco>());
            }
        }

        private void cmbBloco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBloco.SelectedIndex > 0)
            {
                AtualizarListaPredio((eBloco)cmbBloco.SelectedItem);
            }else
            {
                lstPredios.DataSource = null;
                pnCadastro.Enabled = false;
            }
        }

        private void lstPredios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((List<eTipoEstadia>)cmbTipoEstadia.DataSource).Count > 1)
            {
                if (lstPredios.DataSource != null)
                {
                    pnCadastro.Enabled = true;
                }else
                {
                    pnCadastro.Enabled = false;
                }

                LimparCamposApartamento();
            }
            else
            {
                Util.MensagemInformacao("É necessario cadastrar/Ativar os tipos de estadias para o cadastro de apartamentos");
            }
        }

        private void ckbCadastroAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCadastroAutomatico(ckbCadastroAutomatico.Checked);
        }

        private void nudQtdAptAndar_ValueChanged(object sender, EventArgs e)
        {
            if (ckbCadastroAutomatico.Checked)
            {
                try
                {
                    int QtdApartamentos = 0;
                    QtdApartamentos = (int)nudQtdAptAndar.Value * (int)nudAndarPredio.Value;
                    txtNumeroAndar.Text = QtdApartamentos.ToString();
                }
                catch
                {
                    Util.MensagemErro("Desculpe houve um problema, contate o Desenvovedor do sistema");
                }
            }
        }

        #endregion

        #region Metodos

        private void HabilitarCadastroAutomatico(bool isHabilitar)
        {
            if(isHabilitar)
            {
                lblNumQtdApt.Text = "Qtd de Apts a serem cadastrados:";
                lblQtdAptAndar.Text = "Qtd de Apts nos Andares:";
                lblAndarQtPredio.Text = "Qtd de Andar no Prédio";
                nudAndarPredio.Value = 1;
                nudQtdAptAndar.Value = 1;
                txtNumeroAndar.Enabled = false;
                nudQtdAptAndar.Minimum = 1;
                nudAndarPredio.Minimum = 1;
                txtNumeroAndar.Text = "1";
            }
            else
            {
                lblQtdAptAndar.Text = "Qtd Apt no Andar:";
                lblNumQtdApt.Text = "Número do Apartamento:";
                lblAndarQtPredio.Text = "Andar no Prédio";
                nudAndarPredio.Value = 1;
                nudQtdAptAndar.Value = 1;
                txtNumeroAndar.Enabled = true;
                nudQtdAptAndar.Minimum = 0;
                nudAndarPredio.Minimum = 0;
                txtNumeroAndar.Clear();
            }
        }

        private void LimparCamposApartamento()
        {
            ckbCadastroAutomatico.Checked = false;
            nudAndarPredio.Value = 1;
            nudQtdAptAndar.Value = 0;
            txtNumeroAndar.Clear();

            if (((List<eTipoEstadia>)cmbTipoEstadia.DataSource).Count > 1)
            {
                cmbTipoEstadia.SelectedIndex = 0;
            }
        }

        private void CarregarComboCondominioPrincipal(bool isCarregarBase)
        {
            if (isCarregarBase)
            {
                ListaPredio = nPredio.Predio_GET(new ePredio()).Where(c => c.Bloco.BlocoID != "0").ToList();

                foreach (var item in ListaPredio)
                {
                    if (!ListaCondominio.Exists(c => c.CondominioID == item.Bloco.Condominio.CondominioID) 
                        && item.Bloco.Condominio.CondominioID != "0" && item.Bloco.Condominio.Excluido == false)
                    {
                        ListaCondominio.Add(item.Bloco.Condominio);

                        if (!ListaBloco.Exists(c => c.BlocoID == item.Bloco.BlocoID) && item.Bloco.BlocoID != "0" 
                            && item.Bloco.StatusAtivo == true)
                        {
                            ListaBloco.Add(item.Bloco);
                        }
                    }
                }

                var lista = nTipoEstadia.TipoEstadia_GET(new eTipoEstadia()).Where(c => c.Excluido == false).ToList();
                lista.Insert(0, new eTipoEstadia() { TipoEstadiaID = "0", Nome = "Selecione" });

                cmbTipoEstadia.DataSource = lista;
                cmbTipoEstadia.DisplayMember = "Nome";
                cmbTipoEstadia.ValueMember = "TipoEstadiaID";
                cmbTipoEstadia.SelectedIndex = 0;
            }

            ListaCondominio = ListaCondominio.Where(c => c.CondominioID != "0").ToList();
            ListaBloco = ListaBloco.Where(c => c.BlocoID != "0").Distinct().ToList();

            ListaCondominio.Insert(0, new eCondominio() { CondominioID = "0", Nome = "Selecione" });

            cmbCondominio.DataSource = null;

            cmbCondominio.DataSource = ListaCondominio;
            cmbCondominio.DisplayMember = "Nome";
            cmbCondominio.ValueMember = "CondominioID";

            cmbCondominio.SelectedIndex = 0;
        }

        private void AtualizarComboBloco(eCondominio objCond)
        {
            var lista = ListaBloco.Where(c => c.Condominio.CondominioID == objCond.CondominioID).ToList();
            CarregarComboBloco(lista);
        }

        private void CarregarComboBloco(List<eBloco> lista)
        {
            if(lista != null)
            {
                lista.Insert(0, new eBloco() { BlocoID = "0", Nome = "Selecione" });

                cmbBloco.DataSource = lista;
                cmbBloco.DisplayMember = "Nome";
                cmbBloco.ValueMember = "BlocoID";
                cmbBloco.SelectedIndex = 0;
            }
        }

        private void AtualizarListaPredio(eBloco objBloco)
        {
            var lista = ListaPredio.Where(c => c.Bloco.BlocoID == objBloco.BlocoID).ToList();

            lstPredios.DataSource = null;
            lstPredios.DataSource = lista;
            lstPredios.DisplayMember = "Nome";
            lstPredios.ValueMember = "PredioID";
        }

        #endregion
    }
}
