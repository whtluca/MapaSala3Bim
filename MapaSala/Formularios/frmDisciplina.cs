﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        DataTable dados;
        DisciplinaDAO dao = new DisciplinaDAO();
        int LinhaSelecionada;

        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

         
            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade d = new DisciplinaEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeDisciplina.Text;
            d.Sigla = txtSigla.Text;

            dao.Inserir(d);
            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(); 
        }

        private void LimparCampos()
        {
            numId.Value = 0;
            txtNomeDisciplina.Text = "";
            txtSigla.Text = "";
        }

        private void dtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNomeDisciplina.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSigla.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            numId.Value = Convert.ToInt32(dtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btneditar(object sender, EventArgs e)
        {
            DataGridViewRow editar = dtGridDisciplina.Rows[LinhaSelecionada];
            editar.Cells[0].Value = numId.Value;
            editar.Cells[1].Value = txtNomeDisciplina.Text;
            editar.Cells[2].Value = txtSigla.Text;


        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridDisciplina.DataSource = dao.Pesquisar(txtPesquisa.Text);

        }
    }
}
