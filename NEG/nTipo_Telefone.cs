using DAO;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEG
{
    public class nTipo_Telefone
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Euler Vital
        /// Motivo: Classe Negocio de Tipo_Telefone
        /// Data Criação: 21/10/2017
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

        public nTipo_Telefone()
        {

        }
        public static List<eTipo_Telefone> TIPO_TELEFONE_GET(eTipo_Telefone obj)
        {
            try
            {
                dTipo_Telefone db = new dTipo_Telefone();
                return db.TIPO_TELEFONE_GET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string TIPO_TELEFONE_SET(eTipo_Telefone obj)
        {
            try
            {
                dTipo_Telefone db = new dTipo_Telefone();
                return db.TIPO_TELEFONE_SET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
