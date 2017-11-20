using DAO;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEG
{
    public class nArea
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Rafael Marques
        /// Motivo: Classe Negocio de Area
        /// Data Criação: 30/10/2017
        /// ********Alteração************
        /// Autor: 
        /// Motivo:
        /// Data Criação:
        /// ********Alteração************
        /// Autor: 
        /// Motivo:
        /// Data Criação:
        /// ********Alteração************
        /// Autor: 
        /// Motivo:
        /// Data Criação:
        /// </summary>
        #endregion

        public nArea()
        {

        }
        public static List<eArea> Area_GET(eArea obj)
        {
            try
            {
                dArea db = new dArea();
                return db.Area_GET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Area_SET(eArea obj)
        {
            try
            {
                dArea db = new dArea();
                return db.Area_SET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EnviarInformativoArea(eArea obj)
        {
            StringBuilder sbEnviar = new StringBuilder();

            sbEnviar.Append("<div width='600px' align='center'>");
            sbEnviar.Append("<div style='font-family:Arial; font-size:16px;'>");
            sbEnviar.Append("<p><b>Olá caro Morador: [Morador]</b></p>");
            sbEnviar.Append("<p>Eis o seguinte lembrete,</p></div><br />");
            sbEnviar.Append("<div style='width:410px;'>");
            sbEnviar.Append("<img width='120px' height='80px' src='https://uploaddeimagens.com.br/images/001/170/915/original/logo.png?1510512558' alt='Sem Imagem' />");
            sbEnviar.Append("<p style='background-color:#000000; color:white; font-family:Arial; font-size:15px; width:220px; height:50px; float:right; padding:2%;'>INFORMATIVO CONDOMINIO <br /> [DATA]</p></div><br />");
            sbEnviar.Append("<div style='width:500px;' align='center'>");
            sbEnviar.Append("<table style='border:1px solid #000;' align='center' width='400px'>");
            sbEnviar.Append("<tr style='background-color:aliceblue; font-family:Arial; font-size:12px; font-weight:bold;' align='center'>");
            sbEnviar.Append("<th>Condominio</th><th>Área</th><th>Mensagem</th></tr>");
            sbEnviar.Append("<tr style='background-color:lightgray; font-family:Arial; font-size:12px' align='center'>");
            sbEnviar.Append("<td width='100px'>[Condominio]</td><td width='100px'>[Area]</td><td width='300px'>[Mensagem]</td></tr></table></div></div>");

            sbEnviar.Replace("[Condominio]", obj.Condominio.Nome);
            sbEnviar.Replace("[Area]", obj.NomeArea);
            sbEnviar.Replace("[Mensagem]", obj.DescricaoStatus);
            sbEnviar.Replace("[DATA]", DateTime.Now.Date.ToString("dd/MM/yyyy"));

            var lista = nMorador.MORADOR_GET(new eMorador() { Apartamento = new eApartamento() { Predio = new ePredio() { Bloco = new eBloco() { Condominio = obj.Condominio } } } });

            nEmail objEmail = new nEmail();
            List<string> ListaDestinatariosNaoenviados = new List<string>();

            if (obj.Status)
            {

                foreach (var item in lista)
                {
                    if (!string.IsNullOrEmpty(item.Email))
                    {
                        sbEnviar.Replace("[Morador]", item.Nome);
                        if (!objEmail.EnviarEmail(sbEnviar.ToString(), string.Format("Área do condominio {0} ativada", obj.Condominio.Nome), item.Email, null, null, null))
                        {
                            ListaDestinatariosNaoenviados.Add(item.Nome);
                        }
                    }
                }
            }else
            {
                foreach (var item in lista)
                {
                    if (!string.IsNullOrEmpty(item.Email))
                    {
                        sbEnviar.Replace("[Morador]", item.Nome);
                        if(!objEmail.EnviarEmail(sbEnviar.ToString(), string.Format("Área do condominio {0} desativada", obj.Condominio.Nome), item.Email, null, null, null))
                        {
                            ListaDestinatariosNaoenviados.Add(item.Nome);
                        }
                    }
                }
            }

            if(ListaDestinatariosNaoenviados.Count > 0)
            {
                string msg = "Não foi enviado e-mais para os destinatários abaixo \n\n";

                foreach(var item in ListaDestinatariosNaoenviados)
                {
                    msg += item + "\n";
                }

                Util.Util.MensagemInformacao(msg);
            }else
            {
                Util.Util.MensagemSucesso("Os e-mails foram enviados com sucesso para os destinatários");
            }
        }
    }
}


