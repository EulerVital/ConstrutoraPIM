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
        private eApartamento objApartamento { get; set; }
        private List<eApartamento> ListaApartamentosSalvos { get; set; }
        private List<eApartamento> ListaApartamento { get; set; } 
        
        public frmCadastrarApartamento(frmPrincipal frm, eApartamento obj)
        {
            InitializeComponent();

            ListaCondominio = new List<eCondominio>();
            ListaBloco = new List<eBloco>();
            ListaApartamentosSalvos = new List<eApartamento>();

            CarregarComboCondominioPrincipal(true);
        }

        #region Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarApartamento();
        }
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

                    if (ListaApartamentosSalvos.Exists(c => c.Predio.PredioID == ((ePredio)lstPredios.SelectedItem).PredioID))
                    {
                        CarregarApartamentos(ListaApartamentosSalvos);
                    }

                }
                else
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

        private void cmbTipoEstadia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoEstadia.SelectedIndex > 0)
            {
                var tipoestadia = (eTipoEstadia)cmbTipoEstadia.SelectedItem;
                if (tipoestadia.ValorFixo != null)
                {
                    txtValorApt.Text = tipoestadia.ValorFixo.ToString();
                }
            }else
            {
                txtValorApt.Clear();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            CarregarComboCondominioPrincipal(true);
            IsBloquearControles(false);
            ListaApartamentosSalvos = new List<eApartamento>();
        }

        #endregion

        #region Metodos

        private void CarregarApartamentos(List<eApartamento> listaApartamentosSalvos)
        {
            lstApartamentos.DataSource = null;
            lstApartamentos.DataSource = listaApartamentosSalvos;
            lstApartamentos.DisplayMember = "AptAndar";
            lstApartamentos.ValueMember = "ApartamentoID";
        }

        private void SalvarApartamento()
        {
            if (Validando())
            {
                if (ckbCadastroAutomatico.Checked)
                {
                    SalvandoAllApt();   
                }
                else
                {
                    try
                    {
                        int qtdApartamento = Convert.ToInt32(nudAndarPredio.Value * nudQtdAptAndar.Value);

                        if (ListaApartamentosSalvos.Count < qtdApartamento)
                        {
                            ValidandoAndarApartamento();

                            objApartamento.ApartamentoID = nApartamento.Apartamento_SET(objApartamento);
                            if (objApartamento.Equals("0"))
                            {
                                Util.MensagemErro("Erro ao cadastrar apartamento.");
                            }
                            else
                            {
                                ListaApartamento = nApartamento.Apartamento_GET(new eApartamento() { Predio = objApartamento.Predio });
                                ListaApartamentosSalvos = ListaApartamento;
                                Util.MensagemSucesso("Apartamento " + objApartamento.NumeroApartamento + "-" + objApartamento.AndarPredio + " cadastrado com sucesso");
                                CarregarApartamentos(ListaApartamento);
                                IsBloquearControles(true);
                            }
                        }else
                        {
                            Util.MensagemInformacao("Limite de cadastro excedido para esse prédio");
                        }
                        
                    }
                    catch
                    {
                        Util.MensagemErro("Houve um problema ao caadastrar o apartamento, por gentileza contate o Desenvolvedor do sistema");
                    }
                }
            }
        }

        private void IsBloquearControles(bool IsBloquear)
        {
            if (IsBloquear)
            {
                cmbCondominio.Enabled = false;
                cmbBloco.Enabled = false;
                lstPredios.Enabled = false;
                nudAndarPredio.Enabled = false;
                nudQtdAptAndar.Enabled = false;
                ckbCadastroAutomatico.Enabled = false;
                txtNumeroAndar.Clear();
                txtNumeroAndar.Focus();
                btnFinalizar.Visible = true;
            }
            else
            {
                cmbCondominio.Enabled = true;
                cmbBloco.Enabled = true;
                lstPredios.Enabled = true;
                nudAndarPredio.Enabled = true;
                nudQtdAptAndar.Enabled = true;
                ckbCadastroAutomatico.Enabled = true;
                btnFinalizar.Visible = false;
                lstApartamentos.DataSource = null;
            }
        }

        private void ValidandoAndarApartamento()
        {
            if (ListaApartamentosSalvos.Count > 0)
            {
                //pegando o valor maximo do campo Andar
                int ultimoAndar = ListaApartamentosSalvos.Max(c => c.AndarPredio);
                if (ListaApartamentosSalvos.Count(c => c.AndarPredio == ultimoAndar) < nudQtdAptAndar.Value)
                {
                    objApartamento.AndarPredio = ultimoAndar;
                }
                else
                {
                    objApartamento.AndarPredio = ultimoAndar + 1;
                }

                objApartamento.AptAndar = "APT. " + objApartamento.NumeroApartamento + "-" + objApartamento.AndarPredio;
            }
            else
            {
                objApartamento.AndarPredio = 1;
                objApartamento.AptAndar = "APT. " + objApartamento.NumeroApartamento + "-" + objApartamento.AndarPredio;
            }
        }

        private bool Validando()
        {
            objApartamento = new eApartamento();
            bool valido = false;

            if(!string.IsNullOrEmpty(txtNumeroAndar.Text) && cmbTipoEstadia.SelectedIndex > 0
                && !string.IsNullOrEmpty(txtValorApt.Text) && lstPredios.SelectedIndex > -1)
            {
                objApartamento.Predio = (ePredio)lstPredios.SelectedItem;
                objApartamento.TipoEstadia = (eTipoEstadia)cmbTipoEstadia.SelectedItem;
                objApartamento.ValorApartamento = decimal.Parse(txtValorApt.Text);
                objApartamento.NumeroApartamento = int.Parse(txtNumeroAndar.Text);
                objApartamento.IsCadAutomatico = ckbCadastroAutomatico.Checked;
                valido = true;
            }


            return valido;
        }

        private int SalvandoAllApt()
        {
            int andar = 1;
            int numApt = 1;

            for (int i = 1; i <= nudAndarPredio.Value; i++)
            {
                for (int j = 0; j < nudQtdAptAndar.Value; j++)
                {
                    objApartamento.ApartamentoID = null;
                    objApartamento.NumeroApartamento = numApt;
                    objApartamento.AndarPredio = andar;
                    objApartamento.ApartamentoID = nApartamento.Apartamento_SET(objApartamento);

                    if (objApartamento.Equals("0"))
                    {
                        Util.MensagemErro("Houve um erro no precesso atual");
                        numApt--;
                    }

                    numApt++;
                }
                andar++;
            }

            ListaApartamentosSalvos = nApartamento.Apartamento_GET(new eApartamento() { Predio = objApartamento.Predio });

            if ((numApt-1) == int.Parse(txtNumeroAndar.Text))
            {
                Util.MensagemSucesso("Cadastro Automatico efetuado com sucesso, quantidade cadastrada: " + (numApt-1));
                CarregarApartamentos(ListaApartamentosSalvos);
            }

            CarregarComboCondominioPrincipal(true);

            return numApt;
        }

        private void HabilitarCadastroAutomatico(bool isHabilitar)
        {
            if(isHabilitar)
            {
                lblNumQtdApt.Text = "Qtd de Apts a serem cadastrados:";
                nudAndarPredio.Value = 1;
                nudQtdAptAndar.Value = 1;
                txtNumeroAndar.Enabled = false;
                nudQtdAptAndar.Minimum = 1;
                nudAndarPredio.Minimum = 1;
                txtNumeroAndar.Text = "1";
            }
            else
            {
                lblNumQtdApt.Text = "Número do Apartamento:";
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
            txtValorApt.Clear();

            if (((List<eTipoEstadia>)cmbTipoEstadia.DataSource).Count > 1)
            {
                cmbTipoEstadia.SelectedIndex = 0;
            }
        }

        private void CarregarComboCondominioPrincipal(bool isCarregarBase)
        {
            if (isCarregarBase)
            {
                ListaApartamento = nApartamento.Apartamento_GET(new eApartamento());
                ListaPredio = nPredio.Predio_GET(new ePredio()).Where(c => c.Bloco.BlocoID != "0").ToList();
                var listaAux = new List<ePredio>();

                foreach (var item in ListaPredio)
                {
                    if (ListaApartamento.Exists(c => c.Predio.PredioID == item.PredioID))
                    {
                        listaAux.Add(item);   
                    }
                }

                foreach(var item in listaAux)
                {
                    ListaPredio.Remove(item);
                }

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

        private void txtNumeroAndar_TextChanged(object sender, EventArgs e)
        {
            txtNumeroAndar.Text = Util.RemoveLetras(txtNumeroAndar.Text).ToUpper();
            txtNumeroAndar.Select(txtNumeroAndar.TextLength, 0);
        }
    }
}
