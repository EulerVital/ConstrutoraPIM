using DAO;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEG
{
    public class nUsuario
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Rafael Marques
        /// Motivo: Classe Negocio de Apartamento
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

        public nUsuario()
        {

        }
        public static List<eUsuario> Usuario_GET(eUsuario obj)
        {
            try
            {
                dUsuario db = new dUsuario();
                return db.Usuario_GET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Usuario_SET(eUsuario obj)
        {
            try
            {
                dUsuario db = new dUsuario();
                return db.Usuario_SET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


