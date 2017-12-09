using System;
using System.Collections.Generic;
using ENT;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{

    public class dFuncionalidade : DBase.DBase
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Rafael Marques
        /// Motivo: Classe Funcionalidade de Conexao com a base de dados
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

        public List<eFuncionalidade>Funcionalidade_GET(eFuncionalidade obj)
        {
            List<eFuncionalidade> retorno = new List<eFuncionalidade>();
            cmd = new SqlCommand();
            param = new SqlParameter[3];

            try
            {
                MontarParametro(0, param, ParameterDirection.Input, "@FuncionalidadeID", obj.FuncionalidadeID, SqlDbType.Int);
                MontarParametro(1, param, ParameterDirection.Input, "@AreaFuncionalidade", obj.AreaFuncionalidade, SqlDbType.VarChar);
                MontarParametro(2, param, ParameterDirection.Input, "@Codigo", obj.Codigo_, SqlDbType.Int);

                dr = ExecReader("USP_FUNCIONALIDADE_GET", cmd, param);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        retorno.Add(Funcionalidade(dr));
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

        private eFuncionalidade Funcionalidade(IDataReader dr)
        {
            eFuncionalidade obj = new eFuncionalidade();

            try
            {
                obj.FuncionalidadeID = GetInt32("FuncionalidadeID", dr).ToString();
                obj.Descricao = GetString("Descricao", dr);
                obj.AreaFuncionalidade = GetString("AreaFuncionalidade", dr);
                obj.Codigo_ = GetInt32("Codigo", dr).ToString();
                obj.Excluido = GetBoolean("Excluido", dr);
                   
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

