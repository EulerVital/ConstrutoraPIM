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
    public partial class frmReservarAreas : Form
    {
        public frmPrincipal frmPrincipal { get; set; }
        public List<eCondominio> ListaCondominio { get; set; }
        public List<eBloco> ListaBloco { get; set; }
        public List<ePredio> ListaPredio { get; set; }
        public List<eApartamento> ListaApartamento { get; set; }
        public List<eMorador> ListaMorador { get; set; }
        public eMorador objMorador { get; set; }
        public List<eArea> ListaArea { get; set; }
        public List<ePessoaReserva> ListaPessoas { get; set; }
        public List<ePessoaReserva> ListaPessoasResponsavel { get; set; }
        public frmReservarAreas(frmPrincipal frm)
        {
            InitializeComponent();
            frmPrincipal = frm;
            this.MdiParent = frm;
            this.Show();
            CarregarCombos(true);
            CarregarMoradores();
            dtpDataReserva.Value = DateTime.Now.Date.AddDays(1);
        }

        #region Metodos

        #region Metodos para consulta morador

        public void CarregarCombos(bool isCarregarBase)
        {
            if (isCarregarBase)
            {
                ListaMorador = nMorador.MORADOR_GET(new eMorador(), frmPrincipal.objUserLogado).Where(c=>c.Excluido == false).ToList();
                ListaCondominio = new List<eCondominio>();
                ListaBloco = new List<eBloco>();
                ListaPredio = new List<ePredio>();
                ListaApartamento = new List<eApartamento>();
            }

            if(ListaCondominio.Count <= 0)
            {
                foreach(var item in ListaMorador)
                {
                    if (!ListaCondominio.Exists(e => e.CondominioID == item.Apartamento.Predio.Bloco.Condominio.CondominioID))
                    {
                        ListaCondominio.Add(item.Apartamento.Predio.Bloco.Condominio);
                    }

                    if(!ListaBloco.Exists(e => e.BlocoID == item.Apartamento.Predio.Bloco.BlocoID))
                    {
                        ListaBloco.Add(item.Apartamento.Predio.Bloco);
                    }

                    if(!ListaPredio.Exists(e => e.PredioID == item.Apartamento.Predio.PredioID))
                    {
                        ListaPredio.Add(item.Apartamento.Predio);
                    }

                    if (!ListaApartamento.Exists(e => e.ApartamentoID == item.Apartamento.ApartamentoID))
                    {
                        ListaApartamento.Add(item.Apartamento);
                    }
                }

                ListaCondominio.Insert(0, new eCondominio() { Nome = "Selecione", CondominioID = "0" });
                ListaPredio.Insert(0, new ePredio() { Nome = "Selecione", PredioID = "0" });
                ListaApartamento.Insert(0, new eApartamento() { AptAndar = "Selecione", ApartamentoID = "0" });
            }

            if (pnReservar.Enabled)
            {
                pnReservar.Enabled = false;
                LimparCamposReserva();
            }

            CarregarComboCondominio();
            CarregarComboBloco(new List<eBloco>());
            CarregarComboPredio(new List<ePredio>());
            CarregarComboApartamento(new List<eApartamento>());
        }

        private void CarregarComboCondominio()
        {
            cmbCondominio.DataSource = null;
            cmbCondominio.DataSource = ListaCondominio;
            cmbCondominio.DisplayMember = "Nome";
            cmbCondominio.ValueMember = "CondominioID";
            cmbCondominio.SelectedIndex = 0;
        }

        private void CarregarComboBloco(List<eBloco> lista)
        {

            if (lista != null)
            {
                lista.Insert(0, new eBloco() { Nome = "Selecione", BlocoID = "0" });

                cmbBloco.DataSource = null;
                cmbBloco.DataSource = lista;
                cmbBloco.DisplayMember = "Nome";
                cmbBloco.ValueMember = "BlocoID";
                cmbBloco.SelectedIndex = 0;
            }
        }

        private void CarregarComboPredio(List<ePredio> lista)
        {

            if (lista != null)
            {
                lista.Insert(0, new ePredio() { Nome = "Selecione", PredioID = "0" });

                cmbPredio.DataSource = null;
                cmbPredio.DataSource = lista;
                cmbPredio.DisplayMember = "Nome";
                cmbPredio.ValueMember = "PredioID";
                cmbPredio.SelectedIndex = 0;
            }
        }

        private void CarregarComboApartamento(List<eApartamento> lista)
        {

            if (lista != null)
            {
                lista.Insert(0, new eApartamento() { AptAndar = "Selecione", ApartamentoID = "0" });

                cmbApartamento.DataSource = null;
                cmbApartamento.DataSource = lista;
                cmbApartamento.DisplayMember = "AptAndar";
                cmbApartamento.ValueMember = "ApartamentoID";
                cmbApartamento.SelectedIndex = 0;
            }
        }

        private void CarregarMoradores()
        {
            var listaMorador = ValidandoFiltros();

            if(listaMorador != null)
            {
                dgvMoradores.Rows.Clear();
                string EnderecoCond = string.Empty;
                foreach(var item in listaMorador)
                {
                    EnderecoCond = item.Apartamento.Predio.Bloco.Condominio.Nome + " / " + item.Apartamento.Predio.Bloco.Nome + " / " + item.Apartamento.Predio.Nome + " / " + item.Apartamento.AptAndar;
                    dgvMoradores.Rows.Add(item.MoradorID, item.Nome, item.CPF, EnderecoCond, "Reservar");
                }
            }
        }

        private List<eMorador> ValidandoFiltros()
        {
            var lista = ListaMorador;

            if (lista != null)
            {
                if (ListaMorador.Count > 0)
                {
                    #region Validando filtro combos

                    if (cmbCondominio.SelectedIndex > 0)
                    {
                        lista = lista.Where(c => c.Apartamento.Predio.Bloco.Condominio.CondominioID == cmbCondominio.SelectedValue.ToString()).ToList();

                        if(cmbBloco.SelectedIndex > 0)
                        {
                            lista = lista.Where(c => c.Apartamento.Predio.Bloco.BlocoID == cmbBloco.SelectedValue.ToString()).ToList();

                            if (cmbPredio.SelectedIndex > 0)
                            {
                                lista = lista.Where(c => c.Apartamento.Predio.PredioID == cmbPredio.SelectedValue.ToString()).ToList();

                                if (cmbApartamento.SelectedIndex > 0)
                                {
                                    lista = lista.Where(c => c.Apartamento.ApartamentoID == cmbApartamento.SelectedValue.ToString()).ToList();
                                }
                            }
                        }
                    }

                    #endregion

                    if (!string.IsNullOrEmpty(txtNome.Text))
                    {
                        lista = (from m in lista
                                 where m.Nome.ToLower().Contains(txtNome.Text.ToLower()) || m.UltimoNome.ToLower().Contains(txtNome.Text.ToLower())
                                 select m).ToList();
                    }

                    if (!string.IsNullOrEmpty(mtxtCpf.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim()))
                    {
                        lista = (from m in lista
                                 where m.CPF.Contains(mtxtCpf.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim())
                                 select m).ToList();
                    }
                }
            }

            return lista;
        }

        #endregion

        #region Metodos para reserva da area

        private void CarregarAreaReserva(eMorador obj)
        {
            if(obj != null)
            {
                objMorador = obj;

                CarregarListaAreas(ListaArea);

                if(lstAreasDisponiveis.SelectedIndex != -1)
                {
                    if ((bool)((eArea)lstAreasDisponiveis.SelectedItem).IsAreaPaga)
                    {
                        gbAreaPaga.Visible = true;
                    }
                }

                cmbTipoPagamento.SelectedIndex = 0;
                CarregarHorarios();

                pnReservar.Enabled = true;
                pnConsultaMorador.Enabled = false;

                var listaArea = new List<eArea>();

                if(ListaArea.Count > 0)
                {
                    foreach(var item in ListaArea)
                    {
                        if(!listaArea.Exists(c=>c.TipoArea == item.TipoArea))
                        {
                            listaArea.Add(item);
                        }
                    }

                    listaArea.Insert(0, new eArea() { TipoArea = "Selecione" });

                    cmbTipoArea.DataSource = null;
                    cmbTipoArea.DataSource = listaArea;
                    cmbTipoArea.DisplayMember = "TipoArea";
                    cmbTipoArea.ValueMember = "TipoArea";
                }
            }
        }

        private void AddPessoas(bool isMorador)
        {
            ePessoaReserva obj = new ePessoaReserva();

            if (isMorador)
            {
                obj.CPF = objMorador.CPF;
                objMorador.RG = objMorador.RG;
                obj.IsMenorIdade = true;

                #region Is Menor Idade

                int diferenca = DateTime.Now.Year - objMorador.DataNascimento.Year; 
                if(diferenca > 18)
                {
                    obj.IsMenorIdade = false;
                }else if(diferenca == 18)
                {
                    if(DateTime.Now.Month > objMorador.DataNascimento.Month)
                    {
                        obj.IsMenorIdade = false;
                    }else if(DateTime.Now.Month == objMorador.DataNascimento.Month)
                    {
                        if(DateTime.Now.Day >= objMorador.DataNascimento.Day)
                        {
                            obj.IsMenorIdade = false;
                        }
                    }
                }

                #endregion

                obj.Nome = objMorador.Nome + " " + objMorador.UltimoNome;

                if (!obj.IsMenorIdade)
                {
                    ListaPessoasResponsavel = new List<ePessoaReserva>();
                    ListaPessoasResponsavel.Add(obj);
                    CarregarResponsavel(obj);
                }

            }
            else
            {
                obj = ValidandoCamposPessoa();
            }

            if (obj != null)
            {
                if (cmbResponsavel.Enabled)
                {
                    if (!obj.IsMenorIdade)
                    {
                        ListaPessoasResponsavel.Add(obj);
                    }

                    CarregarResponsavel(null);
                }

                if(ListaPessoas == null)
                {
                    ListaPessoas = new List<ePessoaReserva>();
                }

                ListaPessoas.Add(obj);
                CarregarListaPessoas();

                LimparCamposPessoa();
            }
        }

        private void CarregarListaPessoas()
        {
            if(ListaPessoas != null)
            {
                if(ListaPessoas.Count > 0)
                {
                    lstPessoas.DataSource = null;
                    lstPessoas.DataSource = ListaPessoas;
                    lstPessoas.DisplayMember = "Nome";
                    lstPessoas.ValueMember = "PessoaReservaID";
                    lstPessoas.SelectedIndex = -1;
                }
            }
        }

        private ePessoaReserva ValidandoCamposPessoa()
        {
            ePessoaReserva obj = null;

            if(ListaPessoas == null)
            {
                ListaPessoas = new List<ePessoaReserva>();
            }

            if (string.IsNullOrEmpty(txtPessoaNome.Text) || (string.IsNullOrEmpty(mtxtPessoaCpf.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim()) && string.IsNullOrEmpty(txtPessoaRg.Text.Trim()) && ckbPessoaMenorIdade.Checked))
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    Util.MensagemInformacao("Preencha o campo Nome antes de adicionar");
                    txtNome.Focus();
                } else
                {
                    Util.MensagemInformacao("Preencha o CPF ou RG para adicionar");
                    mtxtCpf.Focus();
                }
            }else
            {
                if (ListaPessoas.Exists(c => c.CPF == mtxtPessoaCpf.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim() || c.RG == txtPessoaRg.Text.Trim()) && !ckbPessoaMenorIdade.Checked)
                {
                    Util.MensagemInformacao("Pessoa já existe na lista");
                }
                else
                {
                    obj = new ePessoaReserva();

                    obj.Nome = txtPessoaNome.Text;
                    obj.IsMenorIdade = ckbPessoaMenorIdade.Checked;

                    if (obj.IsMenorIdade && cmbResponsavel.Enabled)
                    {
                        var objResponsavel = (ePessoaReserva)cmbResponsavel.SelectedItem;
                        cmbResponsavel.SelectedItem = objResponsavel;
                    }

                    obj.RG = txtPessoaRg.Text;
                    obj.CPF = mtxtPessoaCpf.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim();
                    if (!Util.ValidaCPF(obj.CPF))
                    {
                        Util.MensagemInformacao("CPF invalído !!!");
                        obj = null;
                    }
                }
            }

            return obj;

        }

        private void LimparCamposReserva()
        {
            lstAreasDisponiveis.DataSource = null;
            lstPessoas.DataSource = null;
            if (cmbTipoArea.SelectedIndex > -1)
            {
                cmbTipoArea.SelectedIndex = 0;
            }

            if (cmbTipoPagamento.SelectedIndex > -1)
            {
                cmbTipoPagamento.SelectedIndex = 0;
            }

            cmbHorarios.DataSource = null;
            txtPessoaNome.Clear();
            txtPessoaRg.Clear();
            mtxtPessoaCpf.Clear();
            pnReservar.Enabled = false;
        }

        private void CarregarListaAreas(List<eArea> listaArea)
        {
            if (listaArea.Count > 0)
            {
                lstAreasDisponiveis.DataSource = null;
                lstAreasDisponiveis.DataSource = listaArea;
                lstAreasDisponiveis.DisplayMember = "NomeArea";
                lstAreasDisponiveis.ValueMember = "AreaID";
                lstAreasDisponiveis.SelectedIndex = 0;
            }
        }

        private void CarregarHorarios()
        {
            if(lstAreasDisponiveis.SelectedIndex > -1)
            {
                var listaHorario = nHorario.HORARIO_GET(new eHorario() { Area = (eArea)lstAreasDisponiveis.SelectedItem });

                listaHorario.Insert(0, new eHorario() { Horario = "Selecione", HorarioID = "0" });

                cmbHorarios.DataSource = null;
                cmbHorarios.DataSource = listaHorario;
                cmbHorarios.DisplayMember = "Horario";
                cmbHorarios.ValueMember = "HorarioID";
                cmbHorarios.SelectedIndex = 0;
            }
        }

        private void CarregarResponsavel(ePessoaReserva obj)
        {
            if (ListaPessoasResponsavel != null)
            {
                if (ListaPessoasResponsavel.Count > 0)
                {
                    if (!ListaPessoasResponsavel.Exists(c => c.CPF == "0"))
                    {
                        if (obj == null)
                        {
                            ListaPessoasResponsavel.Insert(0, new ePessoaReserva() { Nome = "Selecione", CPF = "0" });
                        }
                    }

                    cmbResponsavel.DataSource = null;
                    cmbResponsavel.DataSource = ListaPessoasResponsavel;
                    cmbResponsavel.DisplayMember = "Nome";
                    cmbResponsavel.ValueMember = "CPF";

                    if (obj != null)
                    {
                        if (!obj.IsMenorIdade)
                        {
                            cmbResponsavel.SelectedValue = obj.CPF;
                            cmbResponsavel.Enabled = false;
                            cmbResponsavel.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void RemoverPessoa()
        {
            if(lstPessoas.SelectedItem != null)
            {
                if(cmbResponsavel.SelectedIndex > 0)
                {
                    if (((ePessoaReserva)cmbResponsavel.SelectedItem).CPF.Equals(((ePessoaReserva)lstPessoas.SelectedItem).CPF))
                    {
                        Util.MensagemInformacao("Não é possivel remover o Responsavel da lista");
                    }else
                    {
                        ListaPessoas.Remove((ePessoaReserva)lstPessoas.SelectedItem);
                    }
                }else
                {
                    ListaPessoas.Remove((ePessoaReserva)lstPessoas.SelectedItem);
                }

                CarregarListaPessoas();

            }else
            {
                Util.MensagemInformacao("Selecione uma pessoa na lista para remove-la");
            }
        }

        private void LimparCamposPessoa()
        {
            txtPessoaNome.Clear();
            txtPessoaRg.Clear();
            mtxtPessoaCpf.Clear();
            ckbPessoaMenorIdade.Checked = false;
            txtPessoaNome.Focus();
            cmbTipoPagamento.SelectedIndex = 0;
        }

        private void Salvar()
        {
            var objReserva = ValidaDados();

            if(objReserva != null)
            {
                bool gravouReserva = true;

                objReserva.ReservaAreaID = nReservarArea.ReservarArea_SET(objReserva);

                if (objReserva.ReservaAreaID != "0")
                {
                    var obj = (eHorario)cmbHorarios.SelectedItem;
                    obj.Reservado = true;

                    if (!nHorario.HORARIO_SET(obj).Equals("0"))
                    {
                        if(ListaPessoas.Count > 0)
                        {
                            string ResponsavelID = string.Empty;

                            foreach(var item in ListaPessoasResponsavel)
                            {
                                if (item.CPF == ((ePessoaReserva)cmbResponsavel.SelectedItem).CPF)
                                {
                                    item.ReservaArea.ReservaAreaID = objReserva.ReservaAreaID;
                                    item.TipoPagamento = cmbTipoPagamento.SelectedItem.ToString();
                                    ResponsavelID = nPessoaReserva.PessoaReserva_SET(item);

                                    if (ResponsavelID.Equals("0"))
                                    {
                                        gravouReserva = false;
                                    }
                                }
                            }

                            ListaPessoas.Remove((ePessoaReserva)cmbResponsavel.SelectedItem);

                            if (ResponsavelID != "0")
                            {
                                foreach(var item in ListaPessoas)
                                {
                                    item.ResponsavelID = ResponsavelID;
                                    item.TipoPagamento = cmbTipoPagamento.SelectedItem.ToString();
                                    item.ReservaArea.ReservaAreaID = objReserva.ReservaAreaID;
                                    if (nPessoaReserva.PessoaReserva_SET(item).Equals("0"))
                                    {
                                        gravouReserva = false;
                                    }
                                    
                                }
                            }
                        }
                    }else
                    {
                        gravouReserva = false;
                    }
                }else
                {
                    gravouReserva = false;
                }

                if (gravouReserva)
                {
                    Util.MensagemSucesso("Reserva cadastrada com sucesso");
                    LimparCamposReserva();
                    tabControlReservar.SelectedTab = tbpMorador;
                    //pnSelecionaMorador.Enabled = true;
                    pnConsultaMorador.Enabled = true;
                }
                else
                {
                    Util.MensagemErro("Algo de errado aconteceu ao cadastrar a reserva, contate o desenvolvedor do sistema");
                }
            }
        }

        private eReservarArea ValidaDados()
        {
            eReservarArea objRetorno = null;

            if(lstAreasDisponiveis.SelectedItem != null)
            {
                objRetorno = new eReservarArea();

                objRetorno.Area = (eArea)lstAreasDisponiveis.SelectedItem;
                objRetorno.DataReserva = dtpDataReserva.Value;

                if(objMorador == null)
                {
                    Util.MensagemInformacao("Morador Nulo, por favor contate o desenvolvedor");
                    return null;
                }

                objRetorno.Morador = objMorador;

                if (cmbHorarios.SelectedIndex > 0)
                {
                    var obj = (eHorario)cmbHorarios.SelectedItem;

                    if(nReservarArea.VerificarDataHoraReserva(obj.Area.AreaID, obj.HorarioID, objRetorno.DataReserva))
                    {
                        Util.MensagemInformacao("Esse horario não está disponível nessa data");
                        return null;
                    }
                }else
                {
                    Util.MensagemInformacao("Selecione um horario de reserva");
                    return null;
                }

                if ((bool)objRetorno.Area.IsAreaPaga)
                {
                    if(cmbTipoPagamento.SelectedIndex <= 0)
                    {
                        Util.MensagemInformacao("Selecione o tipo de pagamneto para essa área, pois trata-se de uma área paga");
                        return null;
                    }
                }
            }

            return objRetorno; 
        }

        #endregion

        #endregion

        #region Eventos

        #region Eventos para consultar morador

        private void cmbCondominio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var lista = new List<eBloco>();

            if(cmbCondominio.SelectedIndex > 0)
            {
                lista = ListaBloco.Where(c => c.Condominio.CondominioID == cmbCondominio.SelectedValue.ToString()).ToList();
            }

            CarregarComboBloco(lista);
            CarregarMoradores();
        }

        private void cmbBloco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var lista = new List<ePredio>();

            if (cmbBloco.SelectedIndex > 0)
            {
                lista = ListaPredio.Where(c => c.Bloco.BlocoID == cmbBloco.SelectedValue.ToString()).ToList();
            }

            CarregarComboPredio(lista);
            CarregarMoradores();
        }

        private void cmbPredio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var lista = new List<eApartamento>();

            if (cmbPredio.SelectedIndex > 0)
            {
                lista = ListaApartamento.Where(c => c.Predio.PredioID == cmbPredio.SelectedValue.ToString()).ToList();
            }

            CarregarComboApartamento(lista);
            CarregarMoradores();
        }

        private void cmbApartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarMoradores();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            CarregarMoradores();
        }

        private void dgvMoradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                var obj = ListaMorador.Where(c => c.MoradorID == dgvMoradores.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();

                if(e.ColumnIndex == 4)
                {
                    ListaArea = nArea.Area_GET(new eArea() { Condominio = obj.Apartamento.Predio.Bloco.Condominio }, frmPrincipal.objUserLogado).Where(c=>c.Status == true).ToList();

                    if (ListaArea.Count > 0)
                    {
                        CarregarAreaReserva(obj);
                        AddPessoas(true);
                        tabControlReservar.SelectTab(1);
                        tbpReservar.Show();
                    }
                    else
                    {
                        Util.MensagemInformacao("Não á áreas disponíveis nesse condominio");
                    }
                }
            }
        }

        #endregion

        #region Eventos para reservar

        private void cmbTipoArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTipoArea.SelectedIndex > 0)
            {
                var lista = ListaArea.Where(c=>c.TipoArea == cmbTipoArea.SelectedValue.ToString()).ToList();
                CarregarListaAreas(lista);
            }
        }

        private void lstAreasDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstAreasDisponiveis.SelectedIndex > -1)
            {
                gbPessoasArea.Enabled = true;
                CarregarHorarios();

                if ((bool)((eArea)lstAreasDisponiveis.SelectedItem).IsAreaPaga)
                {
                    gbAreaPaga.Visible = true;
                }else
                {
                    gbAreaPaga.Visible = false;
                }

                txtPessoaNome.Focus();             
            }else
            {
                gbPessoasArea.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCamposReserva();
            ListaArea = null;
            ListaPessoas = null;
            pnConsultaMorador.Enabled = true;
            CarregarCombos(true);
            tabControlReservar.SelectTab(0);
            tbpMorador.Show();
        }

        private void btnAddPessoa_Click(object sender, EventArgs e)
        {
            AddPessoas(false);
        }

        private void btnRemoverPessoa_Click(object sender, EventArgs e)
        {
            RemoverPessoa();
        }

        private void txtPessoaRg_TextChanged(object sender, EventArgs e)
        {
            txtPessoaRg.Text = Util.RemoveLetras(txtPessoaRg.Text).Trim();
            txtPessoaRg.Select(txtPessoaRg.TextLength, 0);
        }

        private void dtpDataReserva_ValueChanged(object sender, EventArgs e)
        {
            if(dtpDataReserva.Value <= DateTime.Now.Date)
            {
                Util.MensagemInformacao("A data da reserva deve ser superior a data atual");
                dtpDataReserva.Value = DateTime.Now.Date.AddDays(1);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void cmbResponsavel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (((ePessoaReserva)cmbResponsavel.SelectedItem).IsMenorIdade)
            {
                cmbResponsavel.SelectedIndex = 0;
            }
        }

        #endregion

        #endregion
    }
}
