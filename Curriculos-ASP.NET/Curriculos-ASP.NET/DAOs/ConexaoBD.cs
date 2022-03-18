using System.Data.SqlClient;
using System.Data;

namespace Curriculos_ASP.NET.DAOs
{
    public class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string cx = "data source=DESKTOP-2808IRF\\SQLEXPRESS; Database = Curriculos; integrated security = true";
            var conexao = new SqlConnection(cx);
            conexao.Open();
            return conexao;
        }
    }
}
