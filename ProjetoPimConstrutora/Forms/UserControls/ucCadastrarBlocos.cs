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
    public partial class ucCadastrarBlocos : UserControl
    {
        public ucCadastrarBlocos()
        {
            InitializeComponent();
            popularListaBlocosCadastrados(1);
        }

        #region Metodos

        private void popularListaBlocosCadastrados(int tipoNomeBloco) //Tipo do nome do bloco
        {
            switch (tipoNomeBloco)
            {
                case 1:

                    lstBlocos.Items.Clear();

                    for(int i = 0; i < 15; i++)
                    {
                        if (i < 10)
                            lstBlocos.Items.Add("00" + i);
                        else
                            lstBlocos.Items.Add("0" + i);
                    }
                    break;
                case 2:

                    lstBlocos.Items.Clear();

                    lstBlocos.Items.Add("A");
                    lstBlocos.Items.Add("B");
                    lstBlocos.Items.Add("C");
                    lstBlocos.Items.Add("D");
                    lstBlocos.Items.Add("E");
                    lstBlocos.Items.Add("F");
                    lstBlocos.Items.Add("G");
                    lstBlocos.Items.Add("E");

                    break;
                case 3:

                    lstBlocos.Items.Clear();

                    lstBlocos.Items.Add("A1");
                    lstBlocos.Items.Add("A2");
                    lstBlocos.Items.Add("A3");
                    lstBlocos.Items.Add("A4");
                    lstBlocos.Items.Add("A5");
                    lstBlocos.Items.Add("A6");
                    lstBlocos.Items.Add("A7");
                    lstBlocos.Items.Add("A8");

                    break;
            }
        }

        #endregion
    }
}
