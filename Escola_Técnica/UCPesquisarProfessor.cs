using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Classes;

namespace Escola_Técnica
{
    public partial class UCPesquisarProfessor : UserControl
    {
        public UCPesquisarProfessor()
        {
            InitializeComponent();
        }

        private void UCPesquisarProfessor_Load(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            MySqlDataReader reader = professor.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewProfessor.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewProfessor.Rows.Add();

                        dataGridViewProfessor.Rows[n].Cells["columnId"].Value = reader["idProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnCpf"].Value = reader["cpfProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnNome"].Value = reader["nomeProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnTelefone"].Value = reader["telefoneProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnCelular"].Value = reader["celularProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnEmail"].Value = reader["emailProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnCidade"].Value = reader["cidadeProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnBairro"].Value = reader["bairroProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnRua"].Value = reader["ruaProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnNumero"].Value = reader["numeroProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnTurma"].Value = reader["nomeTurma"];
                        dataGridViewProfessor.Rows[n].Cells["columnDataNasc"].Value = reader["dataNasc"];
                        dataGridViewProfessor.Rows[n].Cells["columnCep"].Value = reader["cepProfessor"];
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            MySqlDataReader reader = professor.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewProfessor.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewProfessor.Rows.Add();

                        dataGridViewProfessor.Rows[n].Cells["columnId"].Value = reader["idProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnCpf"].Value = reader["cpfProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnNome"].Value = reader["nomeProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnTelefone"].Value = reader["telefoneProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnCelular"].Value = reader["celularProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnEmail"].Value = reader["emailProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnCidade"].Value = reader["cidadeProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnBairro"].Value = reader["bairroProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnRua"].Value = reader["ruaProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnNumero"].Value = reader["numeroProfessor"];
                        dataGridViewProfessor.Rows[n].Cells["columnTurma"].Value = reader["nomeTurma"];
                        dataGridViewProfessor.Rows[n].Cells["columnDataNasc"].Value = reader["dataNasc"];
                        dataGridViewProfessor.Rows[n].Cells["columnCep"].Value = reader["cepProfessor"];
                    }
                }
            }
        }
    }
}
