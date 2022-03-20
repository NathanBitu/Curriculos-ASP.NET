using System.Data.SqlClient;
using System.Data;
using Curriculos_ASP.NET.Models;
using CadAlunoMVC.DAO;
using System.Collections.Generic;
using System;

namespace Curriculos_ASP.NET.DAOs
{
    public class CurriculoDAO
    {
        /// <summary>
        /// Método que insere um currículo no banco de dados.
        /// </summary>
        /// <param name="curriculo">Objeto currículo com seus atributos preenchidos.</param>
        public void Inserir(CurriculoViewModel curriculo)
        {
            string sql =
           "insert into curriculos(cpf, nome, endereco, telefone, pretencaoSalarial, cargoPretendido, instituicaoFormacao1, tipoFormacao1, formacao1," +
           " instituicaoFormacao2, tipoFormacao2, formacao2, instituicaoFormacao3, tipoFormacao3, formacao3, instituicaoFormacao4," +
           " tipoFormacao4, formacao4, instituicaoFormacao5, tipoFormacao5, formacao5, empresaExperiencia1, tipoExperiencia1, experiencia1," +
           " empresaExperiencia2, tipoExperiencia2, experiencia2, empresaExperiencia3, tipoExperiencia3, experiencia3, idioma1, nivelIdioma1, idioma2, nivelIdioma2, idioma3, nivelIdioma3)" +
           " values (@cpf, @nome, @endereco, @telefone, @pretencaoSalarial, @cargoPretendido, @instituicaoFormacao1, @tipoFormacao1, @formacao1," +
           " @instituicaoFormacao2, @tipoFormacao2, @formacao2, @instituicaoFormacao3, @tipoFormacao3, @formacao3, @instituicaoFormacao4," +
           " @tipoFormacao4, @formacao4, @instituicaoFormacao5, @tipoFormacao5, @formacao5, @empresaExperiencia1, @tipoExperiencia1, @experiencia1," +
           " @empresaExperiencia2, @tipoExperiencia2, @experiencia2, @empresaExperiencia3, @tipoExperiencia3, @experiencia3, @idioma1, @nivelIdioma1, @idioma2, @nivelIdioma2, @idioma3, @nivelIdioma3)";

            HelperDAO.ExecutaSql(sql, CriaParametros(curriculo));
        }

        /// <summary>
        /// Método que consulta um aluno
        /// </summary>
        /// <param name="cpf">String com CPF para buscar</param>
        /// <returns></returns>
        public CurriculoViewModel Consulta(string cpf)
        {
            string sql = "select * from curriculos c where c.cpf = @cpf";
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("cpf", cpf);

            DataTable tabela = HelperDAO.ExecutaSelect(sql, parametros);

            if (tabela.Rows.Count == 0)
                return null;

            DataRow registro = tabela.Rows[0];
            return MontaCurriculo(registro);
        }

        /// <summary>
        /// Método que altera um currículo do banco de dados.
        /// </summary>
        /// <param name="curriculo">Objeto currículo com seus atributos.</param>
        public void Alterar(CurriculoViewModel curriculo)
        {
            string sql =
           "update curriculos set nome = @nome, endereco = @endereco , telefone = @telefone, pretencaoSalarial = @pretencaoSalarial, cargoPretendido = @cargoPretendido, instituicaoFormacao1 = @instituicaoFormacao1, tipoFormacao1 = @tipoFormacao1," +
           " formacao1 = @formacao1, instituicaoFormacao2 = @instituicaoFormacao2, tipoFormacao2 = @tipoFormacao2, formacao2 = @formacao2, instituicaoFormacao3 = @instituicaoFormacao3, tipoFormacao3 = @tipoFormacao3, formacao3 = @formacao3, instituicaoFormacao4 = @instituicaoFormacao4," +
           " tipoFormacao4 = @tipoFormacao4, formacao4 = @formacao4, instituicaoFormacao5 = @instituicaoFormacao5, tipoFormacao5 = @tipoFormacao5, formacao5 = @formacao5, empresaExperiencia1 = @empresaExperiencia1, tipoExperiencia1 = @tipoExperiencia1, experiencia1 = @experiencia1," +
           " empresaExperiencia2 = @empresaExperiencia2, tipoExperiencia2 = @tipoExperiencia2, experiencia2 = @experiencia2, empresaExperiencia3 = @empresaExperiencia3, tipoExperiencia3 = @tipoExperiencia3, experiencia3 = @experiencia3, idioma1 = @idioma1, nivelIdioma1 = @nivelIdioma1, idioma2 = @idioma2, nivelIdioma2 = @nivelIdioma2, idioma3 = @idioma3, nivelIdioma3 = @nivelIdioma3" +
           " where cpf = @cpf";

            HelperDAO.ExecutaSql(sql, CriaParametros(curriculo));
        }

        /// <summary>
        /// Método que exclui um currículo do banco de dados.
        /// </summary>
        /// <param name="cpf">String cpf, chave primária de um currículo.</param>
        public void Excluir(string cpf)
        {
            //Verificar a aplicação de sql injection
            string sql = "delete curriculos where cpf = @cpf";
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("cpf", cpf);

            HelperDAO.ExecutaSql(sql, parametros);
        }

        /// <summary>
        /// Método que cria os parâmetros de um currículo para uma instrução sql.
        /// </summary>
        /// <param name="curriculo">Objeto currículo com seus atributos preenchidos</param>
        /// <returns>Vetor de parâmetros</returns>
        private SqlParameter[] CriaParametros(CurriculoViewModel curriculo)
        {
            SqlParameter[] parametros = new SqlParameter[36];
            parametros[0] = new SqlParameter("cpf", curriculo.cpf);
            parametros[1] = new SqlParameter("nome", curriculo.nome);
            parametros[2] = new SqlParameter("endereco", curriculo.endereco);
            parametros[3] = new SqlParameter("telefone", curriculo.telefone);
            parametros[4] = new SqlParameter("pretencaoSalarial", curriculo.pretencaoSalarial);
            parametros[5] = new SqlParameter("cargoPretendido", curriculo.cargoPretendido);
            parametros[6] = new SqlParameter("instituicaoFormacao1", curriculo.instituicaoFormacao1);
            parametros[7] = new SqlParameter("tipoFormacao1", curriculo.tipoFormacao1);
            parametros[8] = new SqlParameter("formacao1", curriculo.formacao1);
            parametros[9] = new SqlParameter("instituicaoFormacao2", curriculo.instituicaoFormacao2);
            parametros[10] = new SqlParameter("tipoFormacao2", curriculo.tipoFormacao2);
            parametros[11] = new SqlParameter("formacao2", curriculo.formacao2);
            parametros[12] = new SqlParameter("instituicaoFormacao3", curriculo.instituicaoFormacao3);
            parametros[13] = new SqlParameter("tipoFormacao3", curriculo.tipoFormacao3);
            parametros[14] = new SqlParameter("formacao3", curriculo.formacao3);
            parametros[15] = new SqlParameter("instituicaoFormacao4", curriculo.instituicaoFormacao4);
            parametros[16] = new SqlParameter("tipoFormacao4", curriculo.tipoFormacao4);
            parametros[17] = new SqlParameter("formacao4", curriculo.formacao4);
            parametros[18] = new SqlParameter("instituicaoFormacao5", curriculo.instituicaoFormacao5);
            parametros[19] = new SqlParameter("tipoFormacao5", curriculo.tipoFormacao5);
            parametros[20] = new SqlParameter("formacao5", curriculo.formacao5);
            parametros[21] = new SqlParameter("empresaExperiencia1", curriculo.empresaExperiencia1);
            parametros[22] = new SqlParameter("tipoExperiencia1", curriculo.tipoExperiencia1);
            parametros[23] = new SqlParameter("experiencia1", curriculo.experiencia1);
            parametros[24] = new SqlParameter("empresaExperiencia2", curriculo.empresaExperiencia2);
            parametros[25] = new SqlParameter("tipoExperiencia2", curriculo.tipoExperiencia2);
            parametros[26] = new SqlParameter("experiencia2", curriculo.experiencia2);
            parametros[27] = new SqlParameter("empresaExperiencia3", curriculo.empresaExperiencia3);
            parametros[28] = new SqlParameter("tipoExperiencia3", curriculo.tipoExperiencia3);
            parametros[29] = new SqlParameter("experiencia3", curriculo.experiencia3);
            parametros[30] = new SqlParameter("idioma1", curriculo.idioma1);
            parametros[31] = new SqlParameter("nivelIdioma1", curriculo.nivelIdioma1);
            parametros[32] = new SqlParameter("idioma2", curriculo.idioma2);
            parametros[33] = new SqlParameter("nivelIdioma2", curriculo.nivelIdioma2);
            parametros[34] = new SqlParameter("idioma3", curriculo.idioma3);
            parametros[35] = new SqlParameter("nivelIdioma3", curriculo.nivelIdioma3);

            return parametros;
        }

        /// <summary>
        /// Método que retorna todos currículos registrados no banco de dados.
        /// </summary>
        /// <returns>Uma lista contendo os currículos.</returns>
        public List<CurriculoViewModel> Listagem()
        {
            List<CurriculoViewModel> lista = new List<CurriculoViewModel>();

            string sql = "select * from curriculos order by nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql);

            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaCurriculo(registro));
            return lista;
        }

        /// <summary>
        /// Método que monta um currículo com o dado extraído do banco.
        /// </summary>
        /// <param name="registro">Dado extraído do banco.</param>
        /// <returns>Objeto currículo com Nome e CPF.</returns>
        private CurriculoViewModel MontaCurriculo(DataRow registro)
        {
            CurriculoViewModel c = new CurriculoViewModel();
            c.nome = registro["nome"].ToString();
            c.cpf = registro["cpf"].ToString();
            c.endereco = registro["endereco"].ToString();
            c.telefone = registro["telefone"].ToString();
            c.pretencaoSalarial = Convert.ToDouble(registro["pretencaoSalarial"]);
            c.cargoPretendido = registro["cargoPretendido"].ToString();
            c.instituicaoFormacao1 = registro["instituicaoFormacao1"].ToString();
            c.tipoFormacao1 = registro["tipoFormacao1"].ToString();
            c.formacao1 = registro["formacao1"].ToString();
            c.instituicaoFormacao2 = registro["instituicaoFormacao2"].ToString();
            c.tipoFormacao2 = registro["tipoFormacao2"].ToString();
            c.formacao2 = registro["formacao2"].ToString();
            c.instituicaoFormacao3 = registro["instituicaoFormacao3"].ToString();
            c.tipoFormacao3 = registro["tipoFormacao3"].ToString();
            c.formacao3 = registro["formacao3"].ToString();
            c.instituicaoFormacao4 = registro["instituicaoFormacao4"].ToString();
            c.tipoFormacao4 = registro["tipoFormacao4"].ToString();
            c.formacao4 = registro["formacao4"].ToString();
            c.instituicaoFormacao5 = registro["instituicaoFormacao5"].ToString();
            c.tipoFormacao5 = registro["tipoFormacao5"].ToString();
            c.formacao5 = registro["formacao5"].ToString();
            c.empresaExperiencia1 = registro["empresaExperiencia1"].ToString();
            c.tipoExperiencia1 = registro["tipoExperiencia1"].ToString();
            c.experiencia1 = registro["experiencia1"].ToString();
            c.empresaExperiencia2 = registro["empresaExperiencia2"].ToString();
            c.tipoExperiencia2 = registro["tipoExperiencia2"].ToString();
            c.experiencia2 = registro["experiencia2"].ToString();
            c.empresaExperiencia3 = registro["empresaExperiencia3"].ToString();
            c.tipoExperiencia3 = registro["tipoExperiencia3"].ToString();
            c.experiencia3 = registro["experiencia3"].ToString();
            c.idioma1 = registro["idioma1"].ToString();
            c.nivelIdioma1 = registro["nivelIdioma1"].ToString();
            c.idioma2 = registro["idioma2"].ToString();
            c.nivelIdioma2 = registro["nivelIdioma2"].ToString();
            c.idioma3 = registro["idioma3"].ToString();
            c.nivelIdioma3 = registro["nivelIdioma3"].ToString();

            return c;
        }
    }
}
