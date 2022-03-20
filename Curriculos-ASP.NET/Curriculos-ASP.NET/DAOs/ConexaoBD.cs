using System.Data.SqlClient;
using System.Data;

namespace Curriculos_ASP.NET.DAOs
{
    public class ConexaoBD
    {
        /// <summary>
        /// Método estático que abre uma conexão com o banco de dados.
        /// </summary>
        /// <returns>Objeto de conexão do banco de dados</returns>
        public static SqlConnection GetConexao()
        {
            string cx = "data source=DESKTOP-AUHG4DS\\SQLEXPRESS; Database = Curriculos; user id=sa; password=123456";
            var conexao = new SqlConnection(cx);
            conexao.Open();
            return conexao;
        }
    }
}
