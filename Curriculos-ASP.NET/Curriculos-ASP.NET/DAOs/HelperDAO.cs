using Curriculos_ASP.NET.DAOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunoMVC.DAO
{
    public static class HelperDAO
    {
        /// <summary>
        /// Método que executa uma instrução sql no banco de dados.
        /// </summary>
        /// <param name="sql">Objeto string com instrução sql.</param>
        /// <param name="parametros">Vetor de parâmetros  de um currículo</param>
        public static void ExecutaSql(string sql, SqlParameter[] parametros)
        {
            using (var conexao = ConexaoBD.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        /// <summary>
        /// Método que chama ExecutaSql passando null como parâmetro.
        /// </summary>
        /// <param name="sql">Objeto string que contém uma instrução sql.</param>
        public static void ExecutaSql(string sql)
        {
            ExecutaSql(sql, null);
        }

        /// <summary>
        /// Método que executa um select para buscar os currículos do banco.
        /// </summary>
        /// <param name="sql">String que contém uma instrução SQL.</param>
        /// <param name="parametros">Vetor de parâmetros para a instrução SQL.</param>
        /// <returns>Uma tabela com o resultado do select.</returns>
        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    conexao.Close();
                    return tabela;
                }                
            }
        }

        /// <summary>
        /// Método que chama ExecutaSelect passando null como parâmetro
        /// </summary>
        /// <param name="sql">Objeto string que contém uma instrução sql.</param>
        /// <returns>Uma tabela com o resultado do select.</returns>
        public static DataTable ExecutaSelect(string sql)
        {
            return ExecutaSelect(sql, null);
        }

    }
}
