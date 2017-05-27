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
    public partial class frmEscolherTipoUsuario : Form
    {
        public frmEscolherTipoUsuario()
        {
            InitializeComponent();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if(rdbPerfilAdm.Checked)
            {
                frmCadastrarUserAdm frm = new frmCadastrarUserAdm();
                frm.Show();
                this.Dispose();
            }
        }
    }
}
