using System;
using System.Collections.Generic;
using ENT;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class dArea : DBase.DBase
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Euler Vital
        /// Motivo: Classe Area de Conexao com a base de dados
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

        public List<eArea> Area_GET(eArea obj)
        {
            List<eArea> retorno = new List<eArea>();
            cmd = new SqlCommand();
            param = new SqlParameter[3];

            try
            {

              
                dr = ExecReader("", cmd, param);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        retorno.Add(Area(dr));
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

        private eArea Area(IDataReader dr)
        {
            eArea obj = new eArea();

            try
            {
                obj.AreaID = GetInt32("AreaID", dr).ToString();
                obj.NomeArea = GetString("NomeAea", dr);
                obj.TipoArea = GetString("TipoArea", dr);
                obj.IsAreaPaga = GetBoolean("IsAreaPaga", dr);
                obj.ValorArea = GetInt32("ValorArea", dr);
                obj.ListaHorarios = GetString("ListaHorarios", dr);
                obj.StatusAtivo = GetBoolean("StatusAtvio", dr);
                obj.Condominio.CondominioID = GetInt32("CondominioID", dr).ToString();
            
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Area_SET(eArea obj)
        {
            string retorno = string.Empty;
            try
            {
                cmd = new SqlCommand();
                param = new SqlParameter[7];

                if (string.IsNullOrEmpty(obj.AreaID))
                    obj.AreaID = "0";

                
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


