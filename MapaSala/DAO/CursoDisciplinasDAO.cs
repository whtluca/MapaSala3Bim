using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entitidades;


namespace MapaSala.DAO
{
    public class CursoDisplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";// link do site
        private SqlConnection Conexao; //comunicacao programa/banco

        public CursoDisplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(CursoDisciplinaEntidade curso)
        {
            Conexao.Open();
            string query = "insert into Curso_Disciplina (Curso_Id, Disciplina_Id, Periodo) Values (@cursoid, @disciplinaid, @periodo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@cursoid", curso.CursoId);
            SqlParameter parametro2 = new SqlParameter("@disciplinaid", curso.DisciplinaId);
            SqlParameter parametro3 = new SqlParameter("@periodo", curso.Periodo);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery(); 
            Conexao.Close();
        }
        public DataTable ObterCursoDisciplina()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = @"SELECT C.Nome NomeCurso, D.Nome NomeDisciplina, CD.Periodo FROM CURSO_DISCIPLINA CD 
                                INNER JOIN CURSOS C ON(C.Id = CD.Curso_Id)
                                INNER JOIN DISCIPLINAS D ON(D.Id = CD.Disciplina_ID)
                                ORDER BY CD.Id DESC";
            SqlCommand Comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = Comando.ExecuteReader();

           
            dt.Columns.Add("NomeCurso");
            dt.Columns.Add("DisciplinaId");
            dt.Columns.Add("Periodo");

            if (Leitura.HasRows) 
            {
                while (Leitura.Read())
                {
                    CursoDisciplinaEntidade p = new CursoDisciplinaEntidade();
                    p.NomeCurso = Leitura[0].ToString();
                    p.NomeDisciplina = Leitura[1].ToString();
                    p.Periodo = Leitura[2].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = @"SELECT C.Nome NomeCurso, D.Nome NomeDisciplina, CD.Periodo FROM CURSO_DISCIPLINA CD 
                                INNER JOIN CURSOS C ON(C.Id = CD.Curso_Id)
                                INNER JOIN DISCIPLINAS D ON(D.Id = CD.Disciplina_ID)
                                ORDER BY CD.Id DESC";
            }
            else
            {
                query = @"SELECT C.Nome NomeCurso, D.Nome NomeDisciplina, CD.Periodo FROM CURSO_DISCIPLINA CD 
                                INNER JOIN CURSOS C ON(C.Id = CD.Curso_Id)
                                INNER JOIN DISCIPLINAS D ON(D.Id = CD.Disciplina_ID)
                                 WHERE D.NOME LIKE '%" + pesquisa + "%' OR  C.NOME LIKE '%" + pesquisa + "%' ORDER BY CD.ID desc"; //concatenação
            }

            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader();
            dt.Columns.Add("NomeCurso");
            dt.Columns.Add("DisciplinaId");
            dt.Columns.Add("Periodo");

            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    CursoDisciplinaEntidade p = new CursoDisciplinaEntidade();
                    p.NomeCurso = Leitura[0].ToString();
                    p.NomeDisciplina = Leitura[1].ToString();
                    p.Periodo = Leitura[2].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}

