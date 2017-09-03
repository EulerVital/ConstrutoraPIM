﻿using ENT;
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
    public partial class frmConsultarBlocos : Form
    {
        public List<eBloco> ListaBlocos { get; set; }
        private frmPrincipal frmPrinc { get; set; }
        public frmConsultarBlocos(frmPrincipal frm)
        {
            InitializeComponent();
            ListaBlocos = new List<eBloco>();
            CarregarBlocos(true);
            frmPrinc = frm;
        }

        #region Eventos

        protected void FiltrarChecksBoks(object sender, EventArgs e)
        {
            CarregarBlocos(false);
        }

        private void dgvBlocos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 5)
                {
                    if ((int)dgvBlocos.Rows[e.RowIndex].Cells[3].Value > 0)
                    {
                        var obj = ListaBlocos.FirstOrDefault(c => c.BlocoID == dgvBlocos.Rows[e.RowIndex].Cells[0].Value.ToString());
                        frmConsultarPredios frm = new frmConsultarPredios(frmPrinc, obj);
                        frm.Show();
                        this.Dispose();
                    }
                    else
                    {
                        Util.MensagemInformacao("Não a Prédios para esse bloco.");
                    }
                }
                else if (e.ColumnIndex == 6)
                {
                    var obj = ListaBlocos.FirstOrDefault(c => c.BlocoID == dgvBlocos.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void cmbCondominio_SelectedIndexChanged(object sender, EventArgs e)
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
                lista.Clear();
                listaAux = ListaBlocos.Where(c => c.Condominio.CondominioID == ((eCondominio)cmbCondominio.SelectedItem).CondominioID).ToList();
                lista.AddRange(listaAux);
            }

            return lista.OrderBy(c=>int.Parse(c.BlocoID)).ToList();
        }

        private void CarregarComboCondominio()
        {
            var listaComboCondominio = new List<eCondominio>();

            foreach(var item in ListaBlocos)
            {


                if (!item.Condominio.CondominioID.Equals("0") && !listaComboCondominio.Exists(c=>c.CondominioID == item.Condominio.CondominioID))
                {
                    listaComboCondominio.Add(item.Condominio);
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
