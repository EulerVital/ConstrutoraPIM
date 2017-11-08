using System;
using System.Collections.Generic;
using ENT;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class dUsuario : DBase.DBase
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Rafael Marques
        /// Motivo: Classe Usuario de Conexao com a base de dados
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

        public List<eUsuario> Usuario_GET(eUsuario obj)
        {
            List<eUsuario> retorno = new List<eUsuario>();
            //cmd = new SqlCommand();
            //param = new SqlParameter[3];

            try
            {

               // MontarParametro(0, param, ParameterDirection.Input, "@ApartamentoID", obj.ApartamentoID, SqlDbType.Int);

                dr = ExecReader("", cmd, param);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        retorno.Add(Usuario(dr));
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

        private eUsuario Usuario(IDataReader dr)
        {
            eUsuario obj = new eUsuario();

            try
            {
                obj.UsuarioID = GetInt32("UsuarioId", dr).ToString();
                obj.NomeUser = GetString("NomeUser", dr);
                obj.Senha = GetInt32("Senha", dr).ToString();
                obj.Sexo = GetString("Sexo", dr);
                obj.Condominio.CondominioID = GetInt32("CondominioID", dr).ToString();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Usuario_SET(eUsuario obj)
        {
            string retorno = string.Empty;
            try
            {
                cmd = new SqlCommand();
                param = new SqlParameter[7];

                if (string.IsNullOrEmpty(obj.UsuarioID))
                    obj.UsuarioID = "0";

               // MontarParametro(0, param, ParameterDirection.Input, "@ApartamentoID", obj.ApartamentoID, SqlDbType.Int);
                
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


