using DAO;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEG
{
    public class nFuncionalidadeUsuario
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Euler Vital
        /// Motivo: Classe Negocio de FuncionalidadeUsuario
        /// Data Criação: 09/12/2017
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

        public nFuncionalidadeUsuario()
        {

        }
        public static List<eFuncionalidadeUsuario> FuncionalidadeUsuario_GET(eFuncionalidadeUsuario obj)
        {
            try
            {
                dFuncionalidadeUsuario db = new dFuncionalidadeUsuario();
                return db.FuncionalidadeUsuario_GET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string FuncionalidadeUsuario_SET(eFuncionalidadeUsuario obj)
        {
            try
            {
                dFuncionalidadeUsuario db = new dFuncionalidadeUsuario();
                return db.FuncionalidadeUsuario_SET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
