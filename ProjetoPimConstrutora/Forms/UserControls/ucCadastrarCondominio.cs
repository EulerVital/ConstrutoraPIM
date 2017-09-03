using ENT;
using NEG;
using NEG.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoPimConstrutora.Forms.UserControls
{
    public partial class ucCadastrarCondominio : UserControl
    {
        #region Propriedades & Atributos
        public List<eEstado> ListaEstados { get; set; }
        public List<eCidade> ListaCidades { get; set; }
        public string CondominioID { get; set; }
        public List<eBloco> ListaBlocos { get; set; }
        public List<eBloco> ListaBlocosIncluidos { get; set; }
        public List<ePredio> ListaPredios { get; set; }
        public List<ePredio> ListaPrediosIncluidos { get; set; }

        eCondominio objCondominio = null;
        #endregion
        public ucCadastrarCondominio()
        {
            InitializeComponent();
            txtNomeCondominio.Focus();
            visualizarCamposBlocos(false);
            visualizarCamposPredios(false);
            visualizarCamposEstacionamento(false);
            CarregarCombosCondominio();

            ListaBlocosIncluidos = new List<eBloco>();
            ListaPrediosIncluidos = new List<ePredio>();
        }

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text.Equals("Salvar"))
            {
                objCondominio = ValidaCamposCondominio();

                if (objCondominio != null)
                {
                    CondominioID = nCondominio.Condominio_SET(objCondominio);
                    if (CondominioID.Equals("0"))
                    {
                        Util.MensagemErro("Condominio já existe");
                    }
                    else
                    {
                        Util.MensagemSucesso("Dados gravado com sucesso");
                        lblTituloBloco.Text = "Inserir blocos para o condomínio \"" + objCondominio.Nome;
                        IsBloquearCamposCondominio(true);
                        CarregarCombosBlocos(null);
                        objCondominio.CondominioID = CondominioID;
                    }
                }
                else
                {
                    Util.MensagemErro("Dados de condominio invalido");
                }
            }else
            {

            }
        }

        private void btnIncluirBlocos_Click(object sender, EventArgs e)
        {
            pnIncluirBlocos.Enabled = true;
            lblQtdBlocos.Text = "Nº Blocos " + nudQtdBlocos.Value;  
            visualizarCamposBlocos(true);
            CarregarCombosBlocos(null);
        }

        private void btnIncluiEstacionamento_Click(object sender, EventArgs e)
        {
            pnIncluirEstacionamento.Enabled = true;
            visualizarCamposEstacionamento(true);
        }

        private void btnIncluirPredio_Click(object sender, EventArgs e)
        {
            if (lstBlocos.SelectedItem != null && nudQtdPredios.Value > 0)
            {
                pnPredios.Enabled = true;
                lblQtdPredios.Visible = true;

                var eBloco = (eBloco)lstBlocos.SelectedItem;
                eBloco.QtdPredios = (int)nudQtdPredios.Value;

                lstPredios.DataSource = null;

                lblQtdPredios.Text = "Nº Prédios " + nudQtdPredios.Value;
                lblTituloPredio.Text = "Add Prédios para o Bloco: " + txtNomeBloco.Text + " do Condôminio: " + txtNomeCondominio.Text;
                IsBloquearCamposBlocos(true);
                visualizarCamposPredios(true);
                IsBloquearCamposPredioSalvando(false);
                CarregarComboPredios(null);

            }else
            {
                Util.MensagemInformacao("Requesistos para inclusão de Prédios. \n\n-Selecionar o Bloco na lista de blocos.\n\n-Definir a quantidade de prédios, sendo maior que 0.");
            }
        }

        private void btnAddBloco_Click(object sender, EventArgs e)
        {
            if(ListaBlocosIncluidos.Count() >= nudQtdBlocos.Value)
            {
                Util.MensagemInformacao("Foi atingido o numero máximo de Blocos para esse Condôminio.");
            }
            else if(cmbEscolhaBloco.Items.Count > 0 && cmbEscolhaBloco.SelectedItem != null)
            {
                //Pega lista da combo de blocos a serem incluidos
                var lista = (List<eBloco>)cmbEscolhaBloco.DataSource;

                //Pega itém selecionado da combo
                var blocoInclue = lista.Find(c => c.BlocoID == cmbEscolhaBloco.SelectedValue.ToString());
                //Remove o item após ser pego
                lista.RemoveAll(c => c.BlocoID == cmbEscolhaBloco.SelectedValue.ToString());

                //Limpa a lista de blocos incluídos: OBS: Necessário pois estva dando bug no sistema.
                lstBlocos.DataSource = null;
                //Incluí item na lista auxílio de blocos incluídos
                ListaBlocosIncluidos.Add(blocoInclue);

                //Passa valor para lista de blocos
                lstBlocos.DataSource = ListaBlocosIncluidos;
                //Define qual propriedade da classe eBloco será apresentada em tela na lista.
                lstBlocos.DisplayMember = "Nome";
                //Define qual a propriedade da classe eBloco será o valor do itém
                lstBlocos.ValueMember = "BlocoID";

                //chamando metódo para polular a combo com a novo lista atualizada
                CarregarCombosBlocos(lista);
            }
        }

        private void btnAddPredio_Click(object sender, EventArgs e)
        {
            if(ListaPrediosIncluidos.Count >= nudQtdBlocos.Value)
            {
                Util.MensagemInformacao("Foi atingido o numero máximo de Prédios para o Bloco: " + txtNomeBloco.Text + ".");
            }
            else if(cmbEscolhaPredios.Items.Count > 0 && cmbEscolhaPredios.SelectedItem != null)
            {
                var lista = (List<ePredio>)cmbEscolhaPredios.DataSource;

                var predioInclue = lista.Find(c => c.PredioID == cmbEscolhaPredios.SelectedValue.ToString());

                lista.RemoveAll(c => c.PredioID == cmbEscolhaPredios.SelectedValue.ToString());

                lstPredios.DataSource = null;

                ListaPrediosIncluidos.Add(predioInclue);

                lstPredios.DataSource = ListaPrediosIncluidos;

                lstPredios.DisplayMember = "Nome";

                lstPredios.ValueMember = "PredioID";

                IsBloquearCamposPredio(false);

                //chamando metódo para polular a combo com a novo lista atualizada
                CarregarComboPredios(lista);
            }
        }

        private void btnExcluirListaBloco_Click(object sender, EventArgs e)
        {
            RemoverBlocoLista();
        }

        private void cmbEstadoCondominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Estado = (eEstado)((ComboBox)sender).SelectedItem;
            var ListCidade = new List<eCidade>();

            cmbCidadeCondominio.DataSource = null;
            ListCidade = ListaCidades.Where(c => c.Estado.EstadoID == Estado.EstadoID).ToList();
            cmbCidadeCondominio.DataSource = ListCidade.OrderBy(c=>c.Nome).ToList();
            cmbCidadeCondominio.DisplayMember = "Nome";
            cmbCidadeCondominio.ValueMember = "CidadeID";
        }

        private void lstBlocos_DoubleClick(object sender, EventArgs e)
        {
            RemoverBlocoLista();
        }

        private void lstBlocos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBlocos.SelectedItem != null)
            {
                var eBloco = (eBloco)lstBlocos.SelectedItem;
                txtNomeBloco.Text = eBloco.Nome;
                nudQtdPredios.Value = eBloco.QtdPredios;
                nudQtdPredios.Focus();
            }else
            {
                txtNomeBloco.Clear();
                nudQtdPredios.Value = 0;
            }
        }

        private void rdbNumeros_CheckedChanged(object sender, EventArgs e)
        {
                cmbEscolhaBloco.DataSource = null;
                CarregarCombosBlocos(ListaBlocos);

        }

        private void rdbLetras_CheckedChanged(object sender, EventArgs e)
        {
            cmbEscolhaBloco.DataSource = null;
            CarregarCombosBlocos(ListaBlocos);
        }

        private void rdbLetrasNumeros_CheckedChanged(object sender, EventArgs e)
        {
            cmbEscolhaBloco.DataSource = null;
            CarregarCombosBlocos(ListaBlocos);
        }


        private void btnExcluirListaPredio_Click(object sender, EventArgs e)
        {
            RemoverPredioLista();
        }

        private void lstPredios_DoubleClick(object sender, EventArgs e)
        {
            RemoverPredioLista();
        }

        private void lstPredios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPredios.SelectedItem != null)
            {
                var ePredio = (ePredio)lstPredios.SelectedItem;
                txtNomePredio.Text = ePredio.Nome;
                nudQtdAparta.Value = ePredio.QtdApartamentos;
                nudQtdAparta.Focus();
            }
            else
            {
                txtNomePredio.Clear();
                nudQtdAparta.Value = 0;
            }
        }

        private void btnSalvarBlocos_Click(object sender, EventArgs e)
        {
            bool gravou = false;
            int count = 0;

            if (btnSalvarBlocos.Text.Equals("Salvar Inclusão"))
            {
                if (ListaBlocosIncluidos != null && ListaBlocosIncluidos.Count > 0)
                {
                    foreach (var item in ListaBlocosIncluidos)
                    {
                        if (nBloco.Bloco_SET(item) != "0")
                        {
                            gravou = true;
                            count++;
                        }
                        else
                        {
                            gravou = false;
                            break;
                        }
                    }

                    if (gravou)
                    {
                        Util.MensagemSucesso("Quantidade de blocos incluidos: " + count + "\nSe a quantidade for direferente do que você incluiu por gentilea contate o Administrador do sistema.\nEm Ajuda>>Contatar Desenvolvedor!");
                        btnSalvarBlocos.Text = "Alterar Inclusão";
                        btnSalvarBlocos.Image = Properties.Resources.Edit;
                        IsBloquearCamposBlocosSalvando(true);
                    }
                    else
                    {
                        Util.MensagemErro("Por gentileza contate o Administrador do sistema, pois a inclusão na foi bem sucedida.\nEm Ajuda>>Contatar Desenvolvedor.");
                    }
                }
            }else
            {
                btnSalvarBlocos.Text = "Salvar Inclusão";
                btnSalvarBlocos.Image = Properties.Resources.Save;
                IsBloquearCamposBlocosSalvando(false);
                
                if(lstBlocos.SelectedIndex > -1)
                {
                    lstBlocos.SelectedIndex = 0;
                }
            }
        }

        private void btnSalvarPredios_Click(object sender, EventArgs e)
        {
            bool gravou = false;
            int count = 0;

            if (btnSalvarPredios.Text.Equals("Salvar Inclusão"))
            {
                if (ListaPrediosIncluidos != null && ListaPrediosIncluidos.Count > 0)
                {
                    foreach (var item in ListaPrediosIncluidos)
                    {
                        if (nPredio.Predio_SET(item) != "0")
                        {
                            gravou = true;
                            count++;
                        }
                        else
                        {
                            gravou = false;
                            break;
                        }
                    }

                    if (gravou)
                    {
                        Util.MensagemSucesso("Quantidade de prédios incluidos: " + count + "\nSe a quantidade for direferente do que você incluiu por gentileza contate o Administrador do sistema.\nEm Ajuda>>Contatar Desenvolvedor!");
                        btnSalvarPredios.Text = "Alterar Inclusão";
                        btnSalvarPredios.Image = Properties.Resources.Edit;
                        IsBloquearCamposPredioSalvando(true);
                        if (btnSalvarBlocos.Text.Equals("Salvar Inclusão"))
                        {
                            IsBloquearCamposBlocos(false);
                        }
                    }
                    else
                    {
                        Util.MensagemErro("Por gentileza contate o Administrador do sistema, pois a inclusão na foi bem sucedida.\nEm Ajuda>>Contatar Desenvolvedor.");
                    }
                }
            }
            else
            {
                btnSalvarPredios.Text = "Salvar Inclusão";
                btnSalvarPredios.Image = Properties.Resources.Save;
                IsBloquearCamposPredioSalvando(false);

                if (lstPredios.SelectedIndex > -1)
                {
                    lstPredios.SelectedIndex = 0;
                }
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo criado para exibir ou esconder 
        /// componentes de inclusão de conteudo 
        /// </summary>
        /// <param name="visualizar"></param>
        private void visualizarCamposBlocos(bool visualizar)
        {
            if (visualizar)
            {
                //Labels
                lblTituloBloco.Visible = true;
                lblQtdBlocos.Visible = true;
                lblNomeBloco.Visible = true;
                lblEscolhaBloco.Visible = true;
                lblQtdApartamento.Visible = true;
                lblQuantPredios.Visible = true;

                //TextBox
                txtNomeBloco.Visible = true;

                //NumericUpDown
                nudQtdPredios.Visible = true;

                //ComboBox
                cmbEscolhaBloco.Visible = true;

                //Buttons
                btnAddBloco.Visible = true;
                btnExcluirListaBloco.Visible = true;
                btnSalvarBlocos.Visible = true;
                btnIncluirPredio.Visible = true;
                btnIncluirEstacioBloco.Visible = true;

                //ListBox
                lstBlocos.Visible = true;

                gpbTipoBloco.Visible = true;

                //Texto aparecer
                lblTextoBloco.Visible = false;
                
                
            }else
            {
                //Labels
                lblTituloBloco.Visible = false;
                lblQtdBlocos.Visible = false;
                lblNomeBloco.Visible = false;
                lblEscolhaBloco.Visible = false;
                lblQtdApartamento.Visible = false;
                lblQuantPredios.Visible = false;

                //TextBox
                txtNomeBloco.Visible = false;

                //NumericUpDown
                nudQtdPredios.Visible = false;

                //ComboBox
                cmbEscolhaBloco.Visible = false;

                //Buttons
                btnAddBloco.Visible = false;
                btnExcluirListaBloco.Visible = false;
                btnSalvarBlocos.Visible = false;
                btnIncluirPredio.Visible = false;
                btnIncluirEstacioBloco.Visible = false;

                //ListBox
                lstBlocos.Visible = false;

                gpbTipoBloco.Visible = false;

                //Texto aparecer
                lblTextoBloco.Visible = true;
                lblTextoBloco.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Metodo criado para exibir ou esconder 
        /// componentes de inclusão de prédios
        /// </summary>
        /// <param name="visualizar"></param>
        private void visualizarCamposPredios(bool visualizar)
        {
            if (visualizar)
            {
                //Labels
                lblTituloPredio.Visible = true;
                lblEscolhaPredio.Visible = true;
                lblNomePredio.Visible = true;
                lblQtdPredios.Visible = true;
                lblTextoPredio.Visible = true;

                //NumericUpDown
                nudQtdAparta.Visible = true;

                //ComboBox
                cmbEscolhaPredios.Visible = true;

                //Buttons
                btnAddPredio.Visible = true;
                btnExcluirListaPredio.Visible = true;
                btnSalvarPredios.Visible = true;

                //TextBox
                txtNomePredio.Visible = true;

                //ListBox
                lstPredios.Visible = true;

                //Texto Aparecer
                lblTextoPredio.Visible = false;
            }else
            {
                //Labels
                lblTituloPredio.Visible = false;
                lblEscolhaPredio.Visible = false;
                lblNomePredio.Visible = false;
                lblQtdPredios.Visible = false;

                //NumericUpDown
                nudQtdAparta.Visible = false;

                //ComboBox
                cmbEscolhaPredios.Visible = false;

                //Buttons
                btnAddPredio.Visible = false;
                btnExcluirListaPredio.Visible = false;
                btnSalvarPredios.Visible = false;

                //TextBox
                txtNomePredio.Visible = false;

                //ListBox
                lstPredios.Visible = false;

                //Texto Aparecer
                lblTextoPredio.Visible = true;
                lblTextoPredio.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Metodo criado para exibir ou esconder 
        /// componentes de inclusão de estacionamento
        /// </summary>
        /// <param name="visualizar"></param>
        private void visualizarCamposEstacionamento(bool visualizar)
        {
            if (visualizar)
            {
                //Labels
                lblTituloEstacionamento.Visible = true;
                lblEscolhaEstacio.Visible = true;
                lblQtdVagas.Visible = true;
                lblTipoEstacionamento.Visible = true;

                //NumericUpDown
                nudQtdVagas.Visible = true;

                //ComboBox
                cmbEstacionamento.Visible = true;
                cmbTipoEstacionamento.Visible = true;

                //Buttons
                btnAddEstacionamento.Visible = true;
                btnExcluirListaEstacionamento.Visible = true;
                btnSalvarEstacionamento.Visible = true;

                //ListBox
                lstEstacionamento.Visible = true;

                //Texto Aparecer
                lblTextoEstacionamento.Visible = false;
            }
            else
            {
                //Labels
                lblTituloEstacionamento.Visible = false;
                lblEscolhaEstacio.Visible = false;
                lblQtdVagas.Visible = false;
                lblTipoEstacionamento.Visible = false;

                //NumericUpDown
                nudQtdVagas.Visible = false;

                //ComboBox
                cmbEstacionamento.Visible = false;
                cmbTipoEstacionamento.Visible = false;

                //Buttons
                btnAddEstacionamento.Visible = false;
                btnExcluirListaEstacionamento.Visible = false;
                btnSalvarEstacionamento.Visible = false;

                //ListBox
                lstEstacionamento.Visible = false;

                //Texto Aparecer
                lblTextoEstacionamento.Visible = true;
                lblTextoEstacionamento.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Carrega Propriedades do formulario
        /// </summary>
        private void CarregarCombosCondominio()
        {
            ListaEstados = nEstado.Estado_GET(new eEstado());
            ListaCidades = nCidade.Cidade_GET(new eCidade());

            cmbEstadoCondominio.DataSource = ListaEstados;
            cmbEstadoCondominio.DisplayMember = "UF";
            cmbEstadoCondominio.ValueMember = "EstadoID";

        }

        /// <summary>
        /// Valida dados de condominio e retorna o objeto
        /// </summary>
        /// <returns></returns>
        private eCondominio ValidaCamposCondominio()
        {
            eCondominio objCond = null;

            try
            {
                if(!string.IsNullOrEmpty(txtNomeCondominio.Text) || nudQtdBlocos.Value > 0)
                {
                    objCond = new eCondominio();

                    objCond.Nome = txtNomeCondominio.Text;
                    objCond.QtdBlocos = (int)nudQtdBlocos.Value;
                    objCond.Endereco = Util.RetornaValueNull(txtEnderecoCondominio.Text);
                    objCond.Bairro = Util.RetornaValueNull(txtBairro.Text);
                    objCond.Cidade.CidadeID = Util.RetornaValueNull(((eCidade)cmbCidadeCondominio.SelectedItem).CidadeID);
                    objCond.CEP = Util.RetornaValueNull(mtxtCepCondominio.Text);
                    objCond.Excluido = ckbStatus.Checked;
                }
            }
            catch { }

            return objCond;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isBloquer"></param>
        private void IsBloquearCamposCondominio(bool isBloquer)
        {
            if (isBloquer)
            {
                txtNomeCondominio.Enabled = false;
                mtxtDataFundacao.Enabled = false;
                mtxtCepCondominio.Enabled = false;
                txtBairro.Enabled = false;
                txtEnderecoCondominio.Enabled = false;
                cmbCidadeCondominio.Enabled = false;
                cmbEstadoCondominio.Enabled = false;
                ckbStatus.Enabled = false;
                nudQtdBlocos.Enabled = false;

                btnIncluirBlocos.Enabled = true;
                btnIncluiEstacionamento.Enabled = true;

                btnSalvar.Text = "Alterar";
                btnSalvar.Image = Properties.Resources.Edit;

                IsBloquearCamposBlocos(false);
                IsBloquearCamposPredio(false);
            }
            else
            {
                txtNomeCondominio.Enabled = true;
                mtxtDataFundacao.Enabled = true;
                mtxtCepCondominio.Enabled = true;
                txtBairro.Enabled = true;
                txtEnderecoCondominio.Enabled = true;
                cmbCidadeCondominio.Enabled = true;
                cmbEstadoCondominio.Enabled = true;
                ckbStatus.Enabled = true;
                nudQtdBlocos.Enabled = true;

                btnIncluirBlocos.Enabled = false;
                btnIncluiEstacionamento.Enabled = false;
                IsBloquearCamposBlocos(false);
                IsBloquearCamposPredio(false);

                btnSalvar.Text = "Salvar";
                btnSalvar.Image = Properties.Resources.Save;

                txtNomeCondominio.Focus();
                txtNomeCondominio.Select(txtNomeCondominio.TextLength, 0);
            }
        } 

        private void IsBloquearCamposBlocos(bool isBloquear)
        {
            if (isBloquear)
            {
                pnIncluirBlocos.Enabled = false;
            }else
            {
                pnIncluirBlocos.Enabled = true;
            }
        }

       private void IsBloquearCamposPredio(bool isBloquear)
       {
            if (isBloquear)
            {
                pnPredios.Enabled = false;
            }
            else
            {
                pnPredios.Enabled = true;
            }
       }

       private void IsBloquearCamposBlocosSalvando(bool isBloquear)
       {
            if (isBloquear)
            {
                gpbTipoBloco.Enabled = false;
                cmbEscolhaBloco.Enabled = false;
                nudQtdPredios.Enabled = false;
                btnAddBloco.Enabled = false;
                btnExcluirListaBloco.Enabled = false;
                lstBlocos.Enabled = false;
                btnIncluirEstacioBloco.Enabled = false;
                btnIncluirPredio.Enabled = false;
            }else
            {
                gpbTipoBloco.Enabled = true;
                cmbEscolhaBloco.Enabled = true;
                nudQtdPredios.Enabled = true;
                btnAddBloco.Enabled = true;
                btnExcluirListaBloco.Enabled = true;
                lstBlocos.Enabled = true;
                btnIncluirEstacioBloco.Enabled = true;
                btnIncluirPredio.Enabled = true;
            }
       }

        private void IsBloquearCamposPredioSalvando(bool isBloquear)
        {
            if (isBloquear)
            {
                cmbEscolhaPredios.Enabled = false;
                nudQtdAparta.Enabled = false;
                btnAddPredio.Enabled = false;
                btnExcluirListaPredio.Enabled = false;
                lstPredios.Enabled = false;
            }
            else
            {
                cmbEscolhaPredios.Enabled = true;
                nudQtdAparta.Enabled = true;
                btnAddPredio.Enabled = true;
                btnExcluirListaPredio.Enabled = true;
                lstPredios.Enabled = true;
            }
        }


        /// <summary>
        /// Carrega combo de blocos para serem inseridos no condominio
        /// </summary>
        private void CarregarCombosBlocos(List<eBloco> lista)
        { 
            cmbEscolhaBloco.DataSource = null;

            if (objCondominio != null)
            {

                var lista_ = nBloco.Bloco_GET(new eBloco() { Condominio = objCondominio });

                if(lista_.Count > 0)
                {
                    ListaBlocosIncluidos.AddRange(lista_);
                    ListaBlocosIncluidos = ListaBlocosIncluidos.OrderBy(c => c.BlocoID).ToList();
                }

                if (ListaBlocosIncluidos.Count() > 0)
                {
                    gpbTipoBloco.Enabled = false;

                    var tipoBloco = ListaBlocosIncluidos.FirstOrDefault().TipoBloco;

                    if (tipoBloco.Equals("PN"))
                    {
                        rdbNumeros.Checked = true;
                    }
                    else if (tipoBloco.Equals("PL"))
                    {
                        rdbLetras.Checked = true;
                    }
                    else if (tipoBloco.Equals("A"))
                    {
                        rdbLetrasNumeros.Checked = true;
                    }
                }
                else
                {
                    gpbTipoBloco.Enabled = true;
                }

                if (lista == null)
                {
                    eBloco obj = new eBloco();
                    obj.Condominio.CondominioID = "0";
                    ListaBlocos = nBloco.Bloco_GET(obj).Where(c=>c.StatusAtivo == true).ToList();
                    lista = ListaBlocos;
                }

                if (rdbNumeros.Checked)
                {
                    lista = lista.Where(c => c.TipoBloco == "PN").ToList();
                }
                else if (rdbLetras.Checked)
                {
                    lista = lista.Where(c => c.TipoBloco == "PL").ToList();
                }
                else
                {
                    lista = lista.Where(c => c.TipoBloco == "A").ToList();
                }

                #region Remover blocos que já estão excluidos

                if (ListaBlocosIncluidos != null)
                {
                    foreach (var item in ListaBlocosIncluidos)
                    {
                        lista.Remove(item);
                    }
                }

                #endregion

                if (lista.Count > 0)
                {
                    var listaAux = new List<eBloco>();

                    foreach (var item in lista)
                    {
                        item.Condominio = objCondominio;
                        listaAux.Add(item);
                    }

                    lista.Clear();
                    lista.AddRange(listaAux);
                    lista = lista.OrderBy(c => c.BlocoID).ToList();

                    cmbEscolhaBloco.DataSource = lista;
                    cmbEscolhaBloco.DisplayMember = "Nome";
                    cmbEscolhaBloco.ValueMember = "BlocoID";
                    cmbEscolhaBloco.SelectedIndex = 0;
                }
            }
        }

        private void RemoverBlocoLista()
        {
            if (lstBlocos.SelectedItem != null)
            {
                try
                {
                    List<eBloco> listaCombo = new List<eBloco>();
                    if (cmbEscolhaBloco.DataSource != null)
                    {
                        listaCombo = (List<eBloco>)cmbEscolhaBloco.DataSource;
                    }
                    var eBloco = (eBloco)lstBlocos.SelectedItem;

                    ListaBlocosIncluidos.Remove(eBloco);

                    listaCombo.Add(eBloco);
                    lstBlocos.DataSource = null;
                    lstBlocos.DataSource = ListaBlocosIncluidos;
                    lstBlocos.DisplayMember = "Nome";
                    lstBlocos.ValueMember = "BlocoID";
                    listaCombo = listaCombo.OrderBy(c => c.BlocoID).ToList();
                    CarregarCombosBlocos(listaCombo);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                Util.MensagemInformacao("É necessario selecionar o bloco da lista para remove-lo");
            }
        }

        private void CarregarComboPredios(List<ePredio> lista)
        {
            eBloco Bloco_ = null;

            if (lstBlocos.SelectedItem != null)
            {
                Bloco_ = (eBloco)lstBlocos.SelectedItem;

                if (ListaPrediosIncluidos.Count <= 0)
                {
                    ListaPrediosIncluidos = nPredio.Predio_GET(new ePredio() { Bloco = Bloco_ });

                    if (ListaPrediosIncluidos.Count > 0)
                    {
                        lstBlocos.DataSource = null;
                        lstBlocos.DataSource = ListaPrediosIncluidos;
                        lstBlocos.DisplayMember = "Nome";
                        lstBlocos.ValueMember = "PredioID";
                    }
                }

                if (lista == null)
                {
                    ePredio obj = new ePredio();
                    obj.Bloco.BlocoID = "0";
                    ListaPredios = nPredio.Predio_GET(obj).Where(c => c.Excluido == false).ToList();
                    lista = ListaPredios;
                }

                var listaAux = new List<ePredio>();

                foreach (var item in lista)
                {
                    item.Bloco = Bloco_;
                    listaAux.Add(item);
                }

                lista.Clear();
                lista = listaAux;

                cmbEscolhaPredios.DataSource = null;
                cmbEscolhaPredios.DataSource = lista;
                cmbEscolhaPredios.DisplayMember = "Nome";
                cmbEscolhaPredios.ValueMember = "PredioID";
                if (lista.Count > 0)
                {
                    cmbEscolhaPredios.SelectedIndex = 0;
                }
            }
        }

        private void RemoverPredioLista()
        {
            if (lstPredios.SelectedItem != null)
            {
                try
                {
                    List<ePredio> listaCombo = new List<ePredio>();

                    if (cmbEscolhaPredios.DataSource != null)
                    {
                        listaCombo = (List<ePredio>)cmbEscolhaPredios.DataSource;
                    }

                    var ePredio = (ePredio)lstPredios.SelectedItem;

                    ListaPrediosIncluidos.Remove(ePredio);

                    listaCombo.Add(ePredio);
                    lstPredios.DataSource = null;
                    lstPredios.DataSource = ListaPrediosIncluidos;
                    lstPredios.DisplayMember = "Nome";
                    lstPredios.ValueMember = "PredioID";
                    listaCombo = listaCombo.OrderBy(c => c.PredioID).ToList();
                    CarregarComboPredios(listaCombo);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                Util.MensagemInformacao("É necessario selecionar o prédio da lista para remove-lo");
            }
        }

        #endregion

    }
}
