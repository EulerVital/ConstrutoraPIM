using DAO;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEG
{
    public class nReservar_Area
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Rafael Marques
        /// Motivo: Classe Negocio de Reserva de Area
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

        public nReservar_Area()
        {

        }
        public static List<eReservar_Area> Apartamento_GET(eReservar_Area obj)
        {
            try
            {
                dReservar_Area db = new dReservar_Area();
                return db.Reservar_Area_GET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Reservar_Area_SET(eReservar_Area obj)
        {
            try
            {
                dReservar_Area db = new dReservar_Area();
                return db.Reservar_Area_SET(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


