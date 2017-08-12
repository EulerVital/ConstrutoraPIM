using DAO;
using ENT;
using System;
using System.Collections.Generic;

namespace NEG
{
    public class nBloco
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Euler Vital
        /// Motivo: Classe Negocio de Bloco
        /// Data Criação: 12/08/2017
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

        public static IList<eBloco> Bloco_GET(eBloco obj)
        {
            try
            {
                dBloco db = new dBloco();
                return db.Bloco_GET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Bloco_SET(eBloco obj)
        {
            try
            {
                dBloco db = new dBloco();
                return db.Bloco_SET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
