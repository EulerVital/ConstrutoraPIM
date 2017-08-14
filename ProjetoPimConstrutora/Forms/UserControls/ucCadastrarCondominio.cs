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
        #region Propriedades
        public List<eEstado> ListaEstados { get; set; }
        public List<eCidade> ListaCidades { get; set; }
        public string CondominioID { get; set; }
        #endregion
        public ucCadastrarCondominio()
        {
            InitializeComponent();
            txtNomeCondominio.Focus();
            visualizarCamposBlocos(false);
            visualizarCamposPredios(false);
            visualizarCamposEstacionamento(false);
            CarregarCombosCondominio();
        }

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            eCondominio obj = null;
            obj = ValidaCamposCondominio();

            if(obj != null)
            {
                CondominioID = nCondominio.Condominio_SET(obj);
                if (CondominioID.Equals("0"))
                {
                    Util.MensagemErro("Condominio já existe");
                }
                else
                {
                    Util.MensagemSucesso("Dados gravado com sucesso");
                    IsBloquearCamposCondominio(true);
                }
            }else
            {
                Util.MensagemErro("Dados de condominio invalido");
            }
        }

        private void btnIncluirBlocos_Click(object sender, EventArgs e)
        {
            pnIncluirBlocos.Enabled = true;
            lblQtdBlocos.Visible = true;
            lblQtdBlocos.Text = "Nº Blocos " + nudQtdBlocos.Value;
            visualizarCamposBlocos(true);
        }

        private void btnIncluiEstacionamento_Click(object sender, EventArgs e)
        {
            pnIncluirEstacionamento.Enabled = true;
            visualizarCamposEstacionamento(true);
        }

        private void btnIncluirPredio_Click(object sender, EventArgs e)
        {
            pnPredios.Enabled = true;
            lblQtdPredios.Visible = true;
            lblQtdPredios.Text = "Nº Prédios " + nudQtdPredios.Value;
            visualizarCamposPredios(true);
        }

        private void btnAddBloco_Click(object sender, EventArgs e)
        {
            if(cmbEscolhaBloco.Items.Count > 0 && cmbEscolhaBloco.SelectedItem != null)
            {
                lstBlocos.Items.Add(cmbEscolhaBloco.SelectedItem);
                cmbEscolhaBloco.Items.RemoveAt(cmbEscolhaBloco.SelectedIndex);
            }
        }

        private void btnExcluirListaBloco_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBlocos.Items.Count; i++)
            {
                if (lstBlocos.GetSelected(i))
                {
                    cmbEscolhaBloco.Items.Insert(lstBlocos.SelectedIndex, lstBlocos.SelectedItem);
                    lstBlocos.Items.RemoveAt(lstBlocos.SelectedIndex);
                }
            }
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
                txtBairro.Enabled = false;
                txtEnderecoCondominio.Enabled = false;
                txtNomePredio.Enabled = false;
                btnIncluirBlocos.Enabled = true;
                btnIncluiEstacionamento.Enabled = true;
                btnSalvar.Enabled = false;
            }
            else
            {
                txtNomeCondominio.Enabled = true;
                txtBairro.Enabled = true;
                txtEnderecoCondominio.Enabled = true;
                txtNomePredio.Enabled = true;
                btnIncluirBlocos.Enabled = false;
                btnIncluiEstacionamento.Enabled = false;
                btnSalvar.Enabled = true;
            }
        } 

        #endregion

    }
}
