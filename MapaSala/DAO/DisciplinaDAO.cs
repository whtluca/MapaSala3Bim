﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.Entitidades;
using System.Data;

namespace MapaSala.DAO
{
    public class DisciplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao; //comunicacao programa/banco

        public DisciplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(DisciplinaEntidade disciplina)
        {
            Conexao.Open();
            string query = "insert into Disciplinas (Nome, Sigla, Ativo) Values (@nome, @sigla, @Ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", disciplina.Nome);
            SqlParameter parametro2 = new SqlParameter("@sigla", disciplina.Sigla);
            SqlParameter parametro3 = new SqlParameter("@Ativo", disciplina.Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery(); //nao retorna nd
            Conexao.Close();
        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Disciplinas";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Lida com erros, se necessário
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }

        public DataTable ObterDisciplinas()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM DISCIPLINAS ORDER BY Id desc";
            SqlCommand Comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    DisciplinaEntidade d = new DisciplinaEntidade();
                    d.Id = Convert.ToInt32(Leitura[0]);
                    d.Nome = Leitura[1].ToString();
                    d.Sigla = Leitura[2].ToString();
                    dt.Rows.Add(d.Linha());
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
                query = "SELECT * FROM Disciplinas ORDER BY ID desc";
            }
            else
            {
                query = "SELECT * FROM Disciplinas WHERE NOME LIKE '%" + pesquisa + "%' ORDER BY ID desc"; 
            }

            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    DisciplinaEntidade d = new DisciplinaEntidade();
                    d.Id = Convert.ToInt32(Leitura[0]);
                    d.Nome = Leitura[1].ToString();
                    d.Sigla = Leitura[2].ToString();
                    dt.Rows.Add(d.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}
