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
    public partial class frmCadastrarAreas : Form
    {
        public frmPrincipal frmPrincipal { get; set; }
        public eArea ObjArea { get; set; }
        public List<eHorario> ListaHorario { get; set; }
        public frmCadastrarAreas(frmPrincipal frm)
        {
            InitializeComponent();
            frmPrincipal = frm;
            this.MdiParent = frm;
            this.Show();
            CarregarCondominio();
        }

        public frmCadastrarAreas(frmPrincipal frm, eArea obj)
        {
            InitializeComponent();
            frmPrincipal = frm;
            this.MdiParent = frm;
            this.Show();
            ObjArea = obj;
            CarregarCondominio();
            PreencherCampos();
        }

        #region Metodos

        private void PreencherCampos()
        {
            if(ObjArea != null)
            {
                cmbCondominio.SelectedValue = ObjArea.Condominio.CondominioID;
                PreencherAreaCondominio(ObjArea.Condominio);
                txtArea.Text = ObjArea.NomeArea;
                cmbTipoArea.SelectedItem = ObjArea.TipoArea;
                
                if(ObjArea.ModoUso == "PV")
                {
                    rbdUsoPessoal.Checked = true;
                    rbdUsoPublico.Checked = false;
                }
                else
                {
                    rbdUsoPessoal.Checked = false;
                    rbdUsoPublico.Checked = true;
                }

                ckbAreaPaga.Checked = (bool)ObjArea.IsAreaPaga;
                if ((bool)ObjArea.IsAreaPaga)
                {
                    txtValorArea.Text = ObjArea.ValorArea.ToString("0.00");
                }

                ListaHorario = nHorario.HORARIO_GET(new eHorario() { Area = ObjArea });
                PreencherListaHorario();
                txtArea.Focus();
            }
        }

        private void PreencherAreaCondominio(eCondominio obj)
        {
            lstAreas.DataSource = null;

            var lista = nArea.Area_GET(new eArea() { Condominio = obj });

            if(lista.Count > 0)
            {
                lstAreas.DataSource = lista;
                lstAreas.DisplayMember = "NomeArea";
                lstAreas.ValueMember = "AreaID";
                lstAreas.SelectedIndex = -1;
            }
        }

        private void CarregarCondominio()
        {
            var listaCondominio = nCondominio.Condominio_GET(new eCondominio()).Where(c => c.Excluido == false).ToList();
            listaCondominio.Insert(0, new eCondominio() { Nome = "Selecione", CondominioID = "0" });

            cmbCondominio.DataSource = null;
            cmbCondominio.DataSource = listaCondominio;
            cmbCondominio.DisplayMember = "Nome";
            cmbCondominio.ValueMember = "CondominioID";

            cmbTipoArea.SelectedIndex = 0;
        }

        private void PreencherListaHorario()
        {
            if(ListaHorario.Count > 0)
            {
                lstHorarios.DataSource = null;
                lstHorarios.DataSource = ListaHorario;
                lstHorarios.DisplayMember = "Horario";
                lstHorarios.ValueMember = "HorarioID";
                lstHorarios.SelectedIndex = -1;
            }
        }

        private void AddHorario()
        {
            if (string.IsNullOrEmpty(mtxtFim.Text.Replace(":", "")) || string.IsNullOrEmpty(mtxtInicio.Text.Replace(":", "")))
            {
                Util.MensagemInformacao("Por gentileza Informe o horario de funcionamento dessa Area");
            }
            else
            {

                if (ListaHorario == null)
                {
                    ListaHorario = new List<eHorario>();
                }

                if (ListaHorario.Exists(c => c.HoraInicio == mtxtInicio.Text && c.HoraFim == mtxtFim.Text))
                {
                    Util.MensagemInformacao("Horario já informado");
                }
                else
                {

                    eHorario horario = new eHorario();
                    int indice = -1;

                    if (lstHorarios.SelectedItem != null)
                    {
                        indice = lstHorarios.SelectedIndex;
                        horario = (eHorario)lstHorarios.SelectedItem;
                    }

                    horario.HoraInicio = mtxtInicio.Text;
                    horario.HoraFim = mtxtFim.Text;
                    horario.Horario = horario.HoraInicio + " ás " + horario.HoraFim;

                    if (indice > -1)
                    {
                        ListaHorario.Insert(indice, horario);
                    }
                    else
                    {
                        ListaHorario.Add(horario);
                    }

                    PreencherListaHorario();

                    mtxtInicio.Clear();
                    mtxtFim.Clear();
                    mtxtInicio.Focus();
                }
            }
        }

        private void RemoverHorario()
        {
            if(lstHorarios.SelectedItem != null)
            {
                var obj = (eHorario)lstHorarios.SelectedItem;

                ListaHorario.Remove(obj);
                PreencherListaHorario();
            }
        }

        private void Salvar()
        {
            bool isalteracao = false;
            var objArea = Validando(out isalteracao);

            if(objArea != null)
            {
                objArea.AreaID = nArea.Area_SET(objArea);
                if (objArea.AreaID.Equals("0"))
                {
                    Util.MensagemErro();
                }else
                {
                    int Error = 0;
                    foreach(var item in ListaHorario)
                    {
                        item.Area.AreaID = objArea.AreaID;
                        if (nHorario.HORARIO_SET(item).Equals("0"))
                        {
                            Error++;
                        }
                    }

                    if(Error > 0)
                    {
                        if (isalteracao)
                        {
                            Util.MensagemErro("Alguns horarios podem não ter sidos alterados, Qtd não alterada: " + Error);
                        }else
                        {
                            Util.MensagemErro("Alguns horarios podem não ter sidos cadastrados, Qtd não cadastradas: " + Error);
                        }
                    }else
                    {
                        if (isalteracao)
                        {
                            Util.MensagemSucesso("Alteração efetuado com sucesso");
                            new frmConsultarAreas(frmPrincipal);
                            this.Dispose();
                        }
                        else
                        {
                            Util.MensagemSucesso("Cadastro efetuada com sucesso");
                        }

                        LimparDados();
                    }
                }
            }
        }

        private void LimparDados()
        {
            cmbCondominio.SelectedIndex = 0;
            cmbTipoArea.SelectedIndex = 0;
            txtArea.Clear();
            ckbAreaPaga.Checked = false;
            txtValorArea.Clear();
            ListaHorario = new List<eHorario>();
            mtxtInicio.Clear();
            mtxtFim.Clear();
            txtArea.Focus();
            PreencherListaHorario();
        }

        private eArea Validando(out bool isAlteracao)
        {
            eArea obj = new eArea();

            if(ObjArea != null)
            {
                obj.AreaID = ObjArea.AreaID;
                isAlteracao = true;
            }else
            {
                isAlteracao = false;
            }

            if (ListaHorario != null)
            {
                if (ListaHorario.Count > 0)
                {

                    if (cmbCondominio.SelectedIndex > 0 && cmbTipoArea.SelectedIndex > 0)
                    {
                        obj.Condominio = (eCondominio)cmbCondominio.SelectedItem;
                        obj.TipoArea = cmbTipoArea.SelectedItem.ToString();

                        if (string.IsNullOrEmpty(txtArea.Text))
                        {
                            Util.MensagemInformacao("Por favor, preencha o Nome da Area");
                            txtArea.Focus();
                            return null;
                        }
                        else
                        {
                            obj.NomeArea = txtArea.Text;
                            obj.IsAreaPaga = ckbAreaPaga.Checked;
                            if ((bool)obj.IsAreaPaga)
                            {
                                if (string.IsNullOrEmpty(txtValorArea.Text))
                                {
                                    Util.MensagemInformacao("Por favor, preencha o valor da Área");
                                    txtValorArea.Focus();
                                    return null;
                                }
                                else
                                {
                                    obj.ValorArea = decimal.Parse(txtValorArea.Text);
                                }
                            }

                            if (rbdUsoPessoal.Checked)
                            {
                                obj.ModoUso = "PV";
                            }
                            else
                            {
                                obj.ModoUso = "PU";
                            }

                            obj.Status = ckbStaus.Checked;

                            return obj;
                        }
                    }
                    else
                    {
                        if (cmbCondominio.SelectedIndex > 0)
                        {
                            Util.MensagemInformacao("Por favor, selecione o Tipo de Área");
                        }
                        else
                        {
                            Util.MensagemInformacao("Por favor, selecione o Condomínio");
                        }

                        return null;
                    }
                }else
                {
                    Util.MensagemInformacao("Por favor, Informe pelo menos um horario de funcionamento");
                    mtxtInicio.Focus();
                    return null;
                }
            }else
            {
                Util.MensagemInformacao("Por favor, Informe pelo menos um horario de funcionamento");
                mtxtInicio.Focus();
                return null;
            }
        }

        #endregion

        #region Eventos
        private void btnAddHora_Click(object sender, EventArgs e)
        {
            AddHorario();
        }

        private void mtxtHoraio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddHorario();
            }
        }

        private void btnRemoverHora_Click(object sender, EventArgs e)
        {
            RemoverHorario();
        }

        private void ckbAreaPaga_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAreaPaga.Checked)
            {
                txtValorArea.Enabled = true;
                txtValorArea.Focus();

            }else
            {
                txtValorArea.Enabled = false;
                txtValorArea.Clear();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtValorArea_TextChanged(object sender, EventArgs e)
        {
            txtValorArea.Text = Util.FormatandoMoeda(txtValorArea.Text);
            txtValorArea.Select(txtValorArea.TextLength, 0);
        }

        private void lstHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstHorarios.SelectedItem != null)
            {
                var obj = (eHorario)lstHorarios.SelectedItem;

                mtxtInicio.Text = obj.HoraInicio;
                mtxtFim.Text = obj.HoraFim;
            }
        }

        #endregion

        private void cmbCondominio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbCondominio.SelectedIndex > 0)
            {
                PreencherAreaCondominio((eCondominio)cmbCondominio.SelectedItem);
            }
        }
    }
 }
