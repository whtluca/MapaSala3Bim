using MapaSala.DAO;
using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmCursoDisciplinacs : Form
    {
        DisciplinaDAO disciplinaDAO = new DisciplinaDAO();
        CursoDAO cursoDAO = new CursoDAO();
        CursoDisplinaDAO dao = new CursoDisplinaDAO();

        private void AtualizarGrid(DataTable dados)
        {
            dtCursoDisciplina.DataSource = dados;
        }
        public frmCursoDisciplinacs()
        {
            InitializeComponent();

            CbxDisciplinas.DataSource = disciplinaDAO.PreencherComboBox();
            CbxDisciplinas.DisplayMember = "Nome";
            CbxDisciplinas.ValueMember = "Id";

            CbxCursos.DataSource = cursoDAO.PreencherComboBox();
            CbxCursos.DisplayMember = "Nome";
            CbxCursos.ValueMember = "Id";

            AtualizarGrid(dao.ObterCursoDisciplina());

        }

        
        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CursoDisplinaDAO cursoDisplinaDAO = new CursoDisplinaDAO();
            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();

            entidade.CursoId = Convert.ToInt32(CbxCursos.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(CbxDisciplinas.SelectedValue);
            entidade.Periodo = CbxPeriodos.SelectedItem.ToString();

            cursoDisplinaDAO.Inserir(entidade);
            AtualizarGrid(dao.ObterCursoDisciplina());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtCursoDisciplina.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }
    }
}
