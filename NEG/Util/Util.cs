using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEG.Util
{
    public class Util
    {
        private string caracteres = @"qwertyuiopéèúùíìòóaáàsdfghjklçãâôõûêzxcvbnm";
        private string caracteresEspecias = @",.;:~^}º]{[ª+=§-_)(*&¨¬%¢$£#³²@¹!'/\ °?|´`";
        private char aspasDuplas = '"';
        private string numeros = "0123456789";

        public Util()
        {
            caracteresEspecias += aspasDuplas.ToString();
        }

        public string RetornaNumeros(string valor)
        {
            caracteres += caracteresEspecias;

            char[] arrayChar = caracteres.ToCharArray();

            foreach (var caracter in arrayChar)
            {
                valor = valor.ToLower().Replace(caracter.ToString(), "");
            }
            return valor.ToUpper();
        }

        public string RetornaLetras(string valor)
        {
            numeros += caracteresEspecias;

            char[] arrayChar = numeros.ToCharArray();

            foreach (var caracter in arrayChar)
            {
                valor = valor.ToLower().Replace(caracter.ToString(), "");
            }
            return valor.ToUpper();
        }

        public string RetornaNumerosLetras(string valor)
        {
            char[] arrayChar = caracteresEspecias.ToCharArray();

            foreach (var caracter in arrayChar)
            {
                valor = valor.ToLower().Replace(caracter.ToString(), "");
            }
            return valor.ToUpper();
        }

        /// <summary>
        /// Retorna valor passado ou valor nulo se não conter nenhum valor
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string RetornaValueNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                value = null;
            }

            return value;
        }

        /// <summary>
        /// Mensagem de Sucesso
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static DialogResult MensagemSucesso(string valor = "Operação realizada com sucesso !!")
        {
            return MessageBox.Show(valor, "Operação realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Mensagem de Erro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static DialogResult MensagemInformacao(string valor = "Não é possivle realizar essa operação !!")
        {
            return MessageBox.Show(valor, "Operação invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Mensagem de Erro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static DialogResult MensagemErro(string valor = "Algo aconteceu ao realizada essa operação !!")
        {
            return MessageBox.Show(valor, "Operação não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ConfimacaoOperacaoOkCancel(string valor = "Deseja realmente fazer essa operação ?")
        {
            return MessageBox.Show(valor, "Realizar operação ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static DialogResult ConfimacaoOperacaoYesNoCancel(string valor = "Deseja realmente fazer essa operação ?")
        {
            return MessageBox.Show(valor, "Realizar operação ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static string RemoveLetras(string valor)
        {
            string aux = string.Empty;
            int valorAux = 0;

            for (int i = 0; i < valor.Length; i++)
            {
                aux = valor.Substring(i);
                if (!int.TryParse(aux, out valorAux))
                {
                    valor = valor.Replace(aux, "");
                }
            }

            return valor;
        }

        public static string FormatandoMoeda(string valor)
        {
            string valores = "0123456789,.";
            char[] val = valor.ToCharArray();
            int? indiceVirgula = null;
            int countVirgula = 0;

            if (!string.IsNullOrEmpty(valor))
            {
                if (val[0] != ',')
                {
                    if (valor.Contains(","))
                    {
                        indiceVirgula = valor.IndexOf(',');
                    }

                    for (int i = 0; i < val.Length; i++)
                    {
                        if (!valores.Contains(val[i].ToString()))
                        {
                            valor = valor.Replace(val[i].ToString(), "");
                        }
                    }
                }
                else
                {
                    valor = valor.Replace(",", "");
                }
            }

            return valor.ToString();
        }

        /// <summary>
        /// Valida arquivo imagem das seguintes extensões (jpeg, jpg, pnj, gif)
        /// </summary>
        /// <param name="extensao"></param>
        /// <returns></returns>
        public static bool ValidarExtensaoImegens(string extensao)
        {
            bool isValido = false;
            extensao = extensao.Replace(".", "").ToLower();

            switch (extensao)
            {
                case "jpeg":
                    isValido = true;
                    break;
                case "jpg":
                    isValido = true;
                    break;
                case "pnj":
                    isValido = true;
                    break;
                case "gif":
                    isValido = true;
                    break;
            }

            return isValido;
        }

        /// <summary>
        /// Metodo que valida CPF retorna true para CPF valido e falso para CPF invalido
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool ValidaCPF(string cpf)

        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }

        public static bool ExportarTableExcel(DataGridView dgvExportar)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            FolderBrowserDialog save = new FolderBrowserDialog();
            bool isExport = false;

            // este codigo verefica se a grid esta preenchida
            //com um datatable

            if (save.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = save.SelectedPath;

                if (dgvExportar.DataSource is System.Data.DataTable)
                {

                    try
                    {
                        //--- se estiver pega e pass ao teu datatable 
                        dt = ((System.Data.DataTable)dgvExportar.DataSource);

                        dt.TableName = "Set";
                        dt.WriteXml(caminhoArquivo + "\\" + dgvExportar.Name + "_" + DateTime.Now + "_..xls", System.Data.XmlWriteMode.IgnoreSchema);
                        isExport = true;
                    }
                    catch (Exception ex)
                    {

                    }

                }
                else //-este else testa se a informacao no grid vem de um dataset
                {
                    try
                    {
                        dt = ((System.Data.DataTable)dgvExportar.DataSource);

                        dt.TableName = "Set";
                        dt.WriteXml(caminhoArquivo + "\\" + dgvExportar.Name + "_" + DateTime.Now + "_..xls", System.Data.XmlWriteMode.IgnoreSchema);
                        isExport = true;
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return isExport;
        }

        public static void ExportarGridExcel(DataGridView dgvDados)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            if (dgvDados.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvDados.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvDados.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvDados.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvDados.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvDados.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        public static bool ExportarGridPdf(DataGridView dgvDados)
        {
            FolderBrowserDialog save = new FolderBrowserDialog();
            bool isExport = false;

            if (save.ShowDialog() == DialogResult.OK)
            {
                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dgvDados.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in dgvDados.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in dgvDados.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                string caminhoFile = save.SelectedPath + "\\" + dgvDados.Name + "_" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "_" + DateTime.Now.Millisecond + ".pdf";

                using (FileStream stream = new FileStream(caminhoFile, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 5f, 5f, 15f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    isExport = true;
                }
            }

            return isExport;
        }

        public static bool ValidarEmail(string email)
        { 
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            System.Windows.Forms.Label textLabel = new System.Windows.Forms.Label() { Left = 50, Top = 20, Text = text };
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox() { Left = 50, Top = 50, Width = 400, Multiline = true, Height = 100 };
            System.Windows.Forms.Button confirmation = new System.Windows.Forms.Button() { Text = "Ok", Left = 350, Width = 100, Top = 160, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public static string alfanumericoAleatorio(int tamanho)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
