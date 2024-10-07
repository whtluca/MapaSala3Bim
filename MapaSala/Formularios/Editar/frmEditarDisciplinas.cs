using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios.Editar
{
    public partial class frmEditarDisciplinas : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;

        public frmEditarDisciplinas()
        {
        }

        public frmEditarDisciplinas(int DisciplinasId)
        {
            InitializeComponent();
            string query = "select Id, Nome, Sigla, Ativo" + "from Disciplinas where Id = @Id";
            Conexao.Open();
            SqlCommand Comando = new SqlCommand(query, Conexao);
            Comando.Parameters.Add(new SqlParameter("@Id", DisciplinasId));
            SqlDataReader Leitura = Comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                   
                    Convert.ToInt32(Leitura[0]);
                    Leitura[1].ToString();
                    Leitura[2].ToString();
                }
            }
            Conexao.Close();
        }

        private void frmEditarDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
