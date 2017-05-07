using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPimConstrutora.Forms.UserControls
{
    public partial class ucConsultarCondominio : UserControl
    {
        public ucConsultarCondominio()
        {
            InitializeComponent();

            int valor = 0;

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {

                valor = rand.Next(100);
                if (valor % 2 == 0)
                {
                    dgvCondominios.Rows.Add("Condominio_0" + i, "SP", "São Paulo", "JD Pery", "Rua Ciriônos, 10", "02651-020", "VER", "Alterar", "Ativar");
                }
                else
                {
                    dgvCondominios.Rows.Add("Condominio_0" + i, "SP", "São Paulo", "JD Pery", "Rua Ciriônos, 10", "02651-020", "VER", "Alterar", "Desativar");
                }
            }
        }

        private void dgvCondominios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            { 
                 MessageBox.Show("Cliquei em ver blocos na linha " + e.RowIndex);
            }
            else if (e.ColumnIndex == 7)
            {
                MessageBox.Show("Cliquei em alterar na linha " + e.RowIndex);
            }
            else if(e.ColumnIndex == 8)
            {
                MessageBox.Show("Cliquei em status na linha " + e.RowIndex);
            }
        }
    }
}
