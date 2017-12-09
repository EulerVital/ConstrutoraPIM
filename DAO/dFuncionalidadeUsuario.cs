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
    public class dFuncionalidadeUsuario : DBase.DBase
    {
        #region Assinaturas
        /// <summary>
        /// *********Criação*************
        /// Autor: Euler Vital
        /// Motivo: Classe Funcionalidade Usuario de Conexao com a base de dados
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

        #region Atributos
        IDataReader dr = null;
        SqlParameter[] param = null;
        #endregion

        public List<eFuncionalidadeUsuario> FuncionalidadeUsuario_GET(eFuncionalidadeUsuario obj, bool? IsFuncionalidadeUsuarioSemMorador = null)
        {
            List<eFuncionalidadeUsuario> retorno = new List<eFuncionalidadeUsuario>();
            cmd = new SqlCommand();
            param = new SqlParameter[4];

            try
            {

                MontarParametro(0, param, ParameterDirection.Input, "@FuncionalidadeUserID", obj.@FuncionalidadeUserID, SqlDbType.Int);
                MontarParametro(1, param, ParameterDirection.Input, "@FuncionalidadeID", obj.Funcionalidade.FuncionalidadeID, SqlDbType.Int);
                MontarParametro(2, param, ParameterDirection.Input, "@UsuarioID", obj.Usuario.UsuarioID, SqlDbType.Int);
                MontarParametro(3, param, ParameterDirection.Input, "@Codigo", obj.Funcionalidade.Codigo_, SqlDbType.Int);

                dr = ExecReader("USP_FUNCIONALIDADE_USUARIO_GET", cmd, param);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        retorno.Add(FuncionalidadeUsuario(dr));
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

        private eFuncionalidadeUsuario FuncionalidadeUsuario(IDataReader dr)
        {
            eFuncionalidadeUsuario obj = new eFuncionalidadeUsuario();

            try
            {
                obj.FuncionalidadeUserID = GetInt32("FuncionalidadeUserID", dr).ToString();
                obj.Excluido = GetBoolean("Excluido", dr);
                obj.Funcionalidade.FuncionalidadeID = GetInt32("FuncinalidadeID", dr).ToString();
                obj.Funcionalidade.Descricao = GetString("Descricao", dr);
                obj.Funcionalidade.AreaFuncionalidade = GetString("AreaFuncionalidade", dr);
                obj.Funcionalidade.Excluido = GetBoolean("ExcluidoFuncionalidade", dr);
                obj.Funcionalidade.Codigo_ = GetInt32("Codigo", dr).ToString();
                obj.Usuario.UsuarioID = GetInt32("UsuarioID", dr).ToString();
                obj.Usuario.NomeUser = GetString("NomeUser", dr);
                obj.Usuario.Senha = GetString("Senha", dr);
                obj.Usuario.TipoUsuario = GetString("TipoUsuario", dr);
                obj.Usuario.Excluido = GetBoolean("Excluido", dr);
                obj.Usuario.Email = GetString("Email", dr);
                obj.Usuario.Condominio.CondominioID = GetInt32("CondominioID", dr).ToString();
                obj.Usuario.Condominio.Nome = GetString("NomeCondominio", dr);
                obj.Usuario.Condominio.QtdBlocos = GetInt32("QtdBlocos", dr);
                obj.Usuario.Condominio.Endereco = GetString("Endereco", dr);
                obj.Usuario.Condominio.CEP = GetString("CEP", dr);
                obj.Usuario.Condominio.Bairro = GetString("Bairro", dr);
                obj.Usuario.Condominio.Cidade.CidadeID = GetInt32("CidadeID", dr).ToString();
                obj.Usuario.Condominio.Cidade.Nome = GetString("CidadeNome", dr);
                obj.Usuario.Condominio.Cidade.Estado.EstadoID = GetInt32("EstadoID", dr).ToString();
                obj.Usuario.Condominio.Cidade.Estado.Nome = GetString("EstadoNome", dr);
                obj.Usuario.Condominio.Cidade.Estado.UF = GetString("UF", dr);
                obj.Usuario.Condominio.Excluido = GetBoolean("ExcluidoCondominio", dr);
                obj.Usuario.Condominio.DataFundacao = GetDateTimeNullable("DataFundacao", dr);
                obj.Usuario.Bloco.BlocoID = GetInt32("BlocoID", dr).ToString();
                obj.Usuario.Bloco.Nome = GetString("NomeBloco", dr);
                obj.Usuario.Bloco.QtdPredios = GetInt32("QtdPredios", dr);
                obj.Usuario.Bloco.TipoBloco = GetString("TipoBloco", dr);
                obj.Usuario.Bloco.StatusAtivo = GetBoolean("StatusAtivo", dr);

                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FuncionalidadeUsuario_SET(eFuncionalidadeUsuario obj)
        {
            string retorno = string.Empty;
            try
            {
                cmd = new SqlCommand();
                param = new SqlParameter[4];

                if (string.IsNullOrEmpty(obj.FuncionalidadeUserID))
                    obj.FuncionalidadeUserID = "0";

                MontarParametro(0, param, ParameterDirection.Input, "@FuncionalidadeUserID", obj.FuncionalidadeUserID, SqlDbType.Int);
                MontarParametro(1, param, ParameterDirection.Input, "@FuncionalidadeID", obj.Funcionalidade.FuncionalidadeID, SqlDbType.Int);
                MontarParametro(2, param, ParameterDirection.Input, "@UsuarioID", obj.Usuario.UsuarioID, SqlDbType.Int);
                MontarParametro(3, param, ParameterDirection.Input, "@Excluido", obj.Excluido, SqlDbType.Bit);

                retorno = Convert.ToString(ExecScalar("USP_FUNCIONALIDADE_USUARIO_SET", cmd, param));
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
