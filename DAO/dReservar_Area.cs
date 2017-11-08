using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class dReservar_Area : DBase.DBase
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Rafael Marques
        /// Motivo: Classe Reserva de Area de Conexao com a base de dados
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

        #region Atributos
        IDataReader dr = null;
        SqlParameter[] param = null;
        #endregion

        public List<eReservar_Area> Reservar_Area_GET(eReservar_Area obj)
        {
            List<eReservar_Area> retorno = new List<eReservar_Area>();
            cmd = new SqlCommand();
            param = new SqlParameter[3];

            try
            {

               // MontarParametro(0, param, ParameterDirection.Input, "@ReservarAreaID", obj.ReservaAreaID, SqlDbType.Int);
                //MontarParametro(0, param, ParameterDirection.Input, "@ReservarAreaID", obj.ReservaAreaID, SqlDbType.Int);
                //MontarParametro(0, param, ParameterDirection.Input, "@ReservarAreaID", obj.ReservaAreaID, SqlDbType.Int);

                dr = ExecReader("", cmd, param);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        retorno.Add(Reservar_Area(dr));
                    }
                }

                return retorno;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { CloseConnection(); }
        }

        private eReservar_Area Reservar_Area(IDataReader dr)
        {
            eReservar_Area obj = new eReservar_Area();

            try
            {
                obj.ReservaAreaID = GetInt32("ReservaAreaID", dr).ToString();
                obj.DataHora = (DateTime)GetDateTimeNullable("DataHora", dr);
                obj.Morador.MoradorID = GetString("Morador", dr);
                obj.Area.AreaID = GetInt32("AreaID", dr).ToString();
                
                
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Reservar_Area_SET(eReservar_Area obj)
        {
            string retorno = string.Empty;
            try
            {
                cmd = new SqlCommand();
                param = new SqlParameter[7];

                if (string.IsNullOrEmpty(obj.ReservaAreaID))
                    obj.ReservaAreaID = "0";

                //MontarParametro(0, param, ParameterDirection.Input, "@ApartamentoID", obj.ApartamentoID, SqlDbType.Int);

                retorno = Convert.ToString(ExecScalar("", cmd, param));
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { CloseConnection(); }

            return retorno;
        }
    }
}

