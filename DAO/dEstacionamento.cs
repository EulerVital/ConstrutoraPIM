﻿using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class dEstacionamento : DBase.DBase
    {

        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Rafael Marques
        /// Motivo: Classe Estacionamento de Conexao com a base de dados
        /// Data Criação: 15/09/2017
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

        public List<eEstacionamento> Estacionamento_GET(eEstacionamento obj)
        {
            List<eEstacionamento> retorno = new List<eEstacionamento>();
            cmd = new SqlCommand();
            param = new SqlParameter[6];

            try
            {

                MontarParametro(0, param, ParameterDirection.Input, "@EstacionamentoID", obj.EstacionamentoID, SqlDbType.Int);
                MontarParametro(1, param, ParameterDirection.Input, "@Nome", obj.Nome, SqlDbType.VarChar);
                MontarParametro(2, param, ParameterDirection.Input, "@QtdVagas", obj.QtdVagas, SqlDbType.Int);
                MontarParametro(3, param, ParameterDirection.Input, "@TipoEstacionamento", obj.TipoEstacionamento, SqlDbType.Char);
                MontarParametro(4, param, ParameterDirection.Input, "@CondominioID", obj.Condominio.CondominioID, SqlDbType.Bit);
                MontarParametro(5, param, ParameterDirection.Input, "@BlocoID", obj.Bloco.BlocoID, SqlDbType.Int);

                dr = ExecReader("USP_ESTACIONAMENTO_GET", cmd, param);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        retorno.Add(Estacionamento(dr));
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

        private eEstacionamento Estacionamento(IDataReader dr)
        {
            eEstacionamento obj = new eEstacionamento();
            
            try
            {
                obj.EstacionamentoID =  GetInt32("EstacionamentoID", dr).ToString();
                obj.Nome = GetString("Nome", dr);
                obj.QtdVagas = GetInt32("QtdVagas", dr);
                obj.TipoEstacionamento = GetString("TipoEstacionamento", dr);
                obj.Bloco.BlocoID = GetInt32("BlocoID", dr).ToString();
                obj.Bloco.Nome = GetString("NomeBloco", dr);
                obj.Bloco.QtdPredios = GetInt32("QtdPredios", dr);
                obj.Bloco.TipoBloco = GetString("TipoBloco", dr);
                obj.Bloco.StatusAtivo = GetBoolean("StatusAtivo", dr);
                obj.Condominio.CondominioID = GetInt32("CondominioID", dr).ToString();
                obj.Condominio.Nome = GetString("NomeCondominio", dr);
                obj.Condominio.QtdBlocos = GetInt32("QtdBlocos", dr);
                obj.Condominio.Endereco = GetString("Endereco", dr);
                obj.Condominio.CEP = GetString("CEP", dr);
                obj.Condominio.Bairro = GetString("Bairro", dr);
                obj.Condominio.Cidade.CidadeID = GetInt32("CidadeID", dr).ToString();
                obj.Condominio.Cidade.Nome = GetString("CidadeNome", dr);
                obj.Condominio.Excluido = GetBoolean("CondominioExcluido", dr);
               
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Estacionamento_SET(eBloco obj)
        {
            string retorno = string.Empty;
            try
            {
                cmd = new SqlCommand();
                param = new SqlParameter[6];

                if (string.IsNullOrEmpty(obj.BlocoID))
                    obj.BlocoID = "0";

                MontarParametro(0, param, ParameterDirection.Input, "@BlocoID", obj.BlocoID, SqlDbType.Int);
                MontarParametro(1, param, ParameterDirection.Input, "@Nome", obj.Nome, SqlDbType.VarChar);
                MontarParametro(2, param, ParameterDirection.Input, "@QtdPredios", obj.QtdPredios, SqlDbType.Int);
                MontarParametro(3, param, ParameterDirection.Input, "@TipoBloco", obj.TipoBloco, SqlDbType.Char);
                MontarParametro(4, param, ParameterDirection.Input, "@StatusAtivo", obj.StatusAtivo, SqlDbType.Bit);
                MontarParametro(5, param, ParameterDirection.Input, "@CondominioID", obj.Condominio.CondominioID, SqlDbType.Int);

                retorno = Convert.ToString(ExecScalar("USP_BLOCO_SET", cmd, param));
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
