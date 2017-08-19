using ProjetoPimConstrutora.Forms.UserControls;
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
    public partial class frmCadastrarUserAdm : Form
    {
        public frmCadastrarUserAdm(frmPrincipal frm)
        {
            InitializeComponent();

            this.MdiParent = frm;
            ucDadosPessoaisCad ucCad = new ucDadosPessoaisCad();
            ucCad.Dock = DockStyle.Fill;

            pnCenter.Controls.Add(ucCad);
        }
    }
}
