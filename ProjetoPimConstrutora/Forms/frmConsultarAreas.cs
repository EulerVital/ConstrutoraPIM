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
    public partial class frmConsultarAreas : Form
    {
        public frmPrincipal frmPrincipal { get; set; }
        public List<eCondominio> ListaCondominio { get; set; }
        public List<eArea> ListaArea { get; set; }
        public frmConsultarAreas(frmPrincipal frm)
        {
            InitializeComponent();
            frmPrincipal = frm;
            this.MdiParent = frm;
            this.Show();
            CarregarCondominio(true);
            CarregarAreas();
        }

        #region Metodos

        private void CarregarCondominio(bool isCarregaBase)
        {
            if (isCarregaBase)
            {
                ListaArea = nArea.Area_GET(new eArea());
                ListaCondominio = new List<eCondominio>();

                foreach (var item in ListaArea)
                {
                    if (!ListaCondominio.Exists(c => c.CondominioID == item.Condominio.CondominioID))
                    {
                        ListaCondominio.Add(item.Condominio);
                    }
                }

                ListaCondominio.Insert(0, new eCondominio() { Nome = "Selecione", CondominioID = "0" });
            }

            cmbCondominio.DataSource = null;
            cmbCondominio.DataSource = ListaCondominio;
            cmbCondominio.DisplayMember = "Nome";
            cmbCondominio.ValueMember = "CondominioID";
            cmbTipoArea.SelectedIndex = 0;
        }

        private void CarregarAreas()
        {
            var lista = ValidandoFitros();
            dgvAreas.Rows.Clear();

            foreach(var item in lista)
            {
                if ((bool)item.IsAreaPaga)
                {
                    if (item.ModoUso.Equals("PV"))
                    {
                        if (item.Status)
                        {
                            dgvAreas.Rows.Add(item.AreaID, item.NomeArea, item.TipoArea, "Uso Pessoal", item.ValorArea.ToString("0.00"), "Ver Horaríos", "Alterar", "Desativar", "Reservar");
                        }else
                        {
                            dgvAreas.Rows.Add(item.AreaID, item.NomeArea, item.TipoArea, "Uso Pessoal", item.ValorArea.ToString("0.00"), "Ver Horaríos", "Alterar", "Ativar", "Não é possivel reservar");
                        }
                    }else
                    {
                        if (item.Status)
                        {
                            dgvAreas.Rows.Add(item.AreaID, item.NomeArea, item.TipoArea, "Uso Publico", item.ValorArea.ToString("0.00"), "Ver Horaríos", "Alterar", "Desativar", "Reservar");
                        }
                        else
                        {
                            dgvAreas.Rows.Add(item.AreaID, item.NomeArea, item.TipoArea, "Uso Publico", item.ValorArea.ToString("0.00"), "Ver Horaríos", "Alterar", "Ativar", "Não é possivel reservar");
                        }
                    }
                }else
                {
                    if (item.ModoUso.Equals("PV"))
                    {
                        if (item.Status)
                        {
                            dgvAreas.Rows.Add(item.AreaID, item.NomeArea, item.TipoArea, "Uso Pessoal", "Gratuita", "Ver Horaríos", "Alterar", "Desativar", "Reservar");
                        }
                        else
                        {
                            dgvAreas.Rows.Add(item.AreaID, item.NomeArea, item.TipoArea, "Uso Pessoal", "Gratuita", "Ver Horaríos", "Alterar", "Ativar", "Não é possivel reservar");
                        }
                    }
                    else
                    {
                        if (item.Status)
                        {
                            dgvAreas.Rows.Add(item.AreaID, item.NomeArea, item.TipoArea, "Uso Publico", "Gratuita", "Ver Horaríos", "Alterar", "Desativar", "Reservar");
                        }
                        else
                        {
                            dgvAreas.Rows.Add(item.AreaID, item.NomeArea, item.TipoArea, "Uso Publico", "Gratuita", "Ver Horaríos", "Alterar", "Ativar", "Não é possivel reservar");
                        }
                    }
                }
            }

        }

        private List<eArea> ValidandoFitros()
        {
            var lista = ListaArea;

            if(cmbCondominio.SelectedIndex > 0)
            {
                lista = lista.Where(c => c.Condominio.CondominioID == ((eCondominio)cmbCondominio.SelectedItem).CondominioID).ToList();
            }

            if(cmbTipoArea.SelectedIndex > 0)
            {
                lista = lista.Where(c => c.TipoArea == cmbTipoArea.SelectedItem.ToString()).ToList();
            }

            if (string.IsNullOrEmpty(txtArea.Text))
            {

                if (!ckbAreaGratuita.Checked || !ckbAreaPaga.Checked)
                {
                    if (ckbAreaGratuita.Checked)
                    {
                        lista = lista.Where(c => c.IsAreaPaga == false).ToList();
                    }

                    if (ckbAreaPaga.Checked)
                    {
                        lista = lista.Where(c => c.IsAreaPaga == true).ToList();
                    }
                }

                if (!ckbUsoPessoal.Checked || !ckbUsoPublico.Checked)
                {
                    if (ckbUsoPessoal.Checked)
                    {
                        lista = lista.Where(c => c.ModoUso == "PV").ToList();
                    }

                    if (ckbAreaPaga.Checked)
                    {
                        lista = lista.Where(c => c.ModoUso == "PU").ToList();
                    }
                }
            }else
            {
                lista = (from a in lista
                         where a.NomeArea.ToLower().Contains(txtArea.Text.ToLower())
                         select a).ToList();
            }

            return lista;
        }

        private void VerHorarios(eArea Area)
        {
            var lista = nHorario.HORARIO_GET(new eHorario() { Area = Area });

            if (lista.Count > 0)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("Horarios disponives para a Área: {0} \n\n", Area.NomeArea);

                foreach (var item in lista)
                {
                    msg.AppendLine(item.Horario);
                }

                Util.MensagemInformacao(msg.ToString());
            }
            else
            {
                Util.MensagemInformacao("Não há horaríos disponiveis");
            }
        }

        private void ModificarStatusArea(eArea obj)
        {
            if (obj.Status)
            {
                obj.Status = false;
            }else
            {
                obj.Status = true;
            }

            if (obj.Status)
            {
                if (Util.ConfimacaoOperacaoOkCancel("Deseja realmente ativar essa Área") == DialogResult.OK)
                {
                    obj.DescricaoStatus = Util.ShowDialog("Digite a descição de mensagem E-mail", "Mensagem E-mail");

                    if (nArea.Area_SET(obj).Equals("0"))
                    {
                        Util.MensagemErro();
                    }
                    else
                    {
                        Util.MensagemSucesso("Área ativada, um e-mail será enviado para todos os moradores informando sobre a área"); 
                    }

                    CarregarAreas();
                    nArea.EnviarInformativoArea(obj);
                }
            }else
            {
                if (Util.ConfimacaoOperacaoOkCancel("Deseja realmente desativar essa Área") == DialogResult.OK)
                {
                    obj.DescricaoStatus = Util.ShowDialog("Digite a descição de mensagem E-mail", "Mensagem E-mail");

                    if (nArea.Area_SET(obj).Equals("0"))
                    {
                        Util.MensagemErro();
                    }
                    else
                    {
                        Util.MensagemSucesso("Área desativada, um e-mail será enviado para todos os moradores informando sobre a área");
                    }

                    CarregarAreas();
                    nArea.EnviarInformativoArea(obj);
                }
            }
        }

        #endregion

        private void CarregarAreas(object sender, EventArgs e)
        {
            CarregarAreas();
        }

        private void dgvAreas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                var obj = ListaArea.Where(c => c.AreaID == dgvAreas.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();

                if(e.ColumnIndex == 5)
                {
                    VerHorarios(obj);
                }
                else if(e.ColumnIndex == 6)
                {
                    new frmCadastrarAreas(frmPrincipal, obj);
                    Dispose();
                }
                else if(e.ColumnIndex == 7)
                {
                    ModificarStatusArea(obj);
                }
            }
        }
    }
}
