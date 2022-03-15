using System.Data.SqlClient;

namespace Curriculos_ASP.NET.DAOs
{
    public class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string cx = "data source=DESKTOP-2808IRF\\SQLEXPRESS; Database = Curriculos; integrated security = true";
            SqlConnection conexao = new SqlConnection(cx);
            conexao.Open();
            return conexao;
        }
    }
}
