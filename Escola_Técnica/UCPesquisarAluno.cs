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
    public partial class UCPesquisarAluno : UserControl
    {
        public UCPesquisarAluno()
        {
            InitializeComponent();
        }

        private void UCPesquisarAluno_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                string selectQuery = "select * from turma";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader2 = command.ExecuteReader();

                while (reader2.Read())
                {
                    cboxTurma.Items.Add(reader2.GetString("nomeTurma"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }


            MySqlDataReader reader = aluno.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewAluno.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewAluno.Rows.Add();

                        dataGridViewAluno.Rows[n].Cells["columnId"].Value = reader["idAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCpf"].Value = reader["cpfAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnNome"].Value = reader["nomeAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnTelefone"].Value = reader["telefoneAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCelular"].Value = reader["celularAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnEmail"].Value = reader["emailAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCidade"].Value = reader["cidadeAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnBairro"].Value = reader["bairroAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnRua"].Value = reader["ruaAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnNumero"].Value = reader["numeroAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnTurma"].Value = reader["nomeTurma"];
                        dataGridViewAluno.Rows[n].Cells["ColumnDataNasc"].Value = reader["dataNasc"];
                        dataGridViewAluno.Rows[n].Cells["ColumnCep"].Value = reader["cepAluno"];
                    }
                }
            }
        }

        Aluno aluno = new Aluno();
        Turma turma = new Turma();
        private void CboxTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            turma.NomeTurma = cboxTurma.Text;
            if (turma.ObterTurma())
            {
                aluno.TurmaAluno = turma.NomeTurma.ToString();
            }
            MySqlDataReader reader = aluno.Listar2();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewAluno.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewAluno.Rows.Add();

                        dataGridViewAluno.Rows[n].Cells["columnId"].Value = reader["idAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnNome"].Value = reader["nomeAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCpf"].Value = reader["cpfAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnTelefone"].Value = reader["telefoneAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCelular"].Value = reader["celularAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnEmail"].Value = reader["emailAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCidade"].Value = reader["cidadeAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnBairro"].Value = reader["bairroAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnRua"].Value = reader["ruaAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnNumero"].Value = reader["numeroAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnTurma"].Value = reader["nomeTurma"];
                        dataGridViewAluno.Rows[n].Cells["ColumnDataNasc"].Value = reader["dataNasc"];
                        dataGridViewAluno.Rows[n].Cells["ColumnCep"].Value = reader["cepAluno"];
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                string selectQuery = "select * from turma";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader2 = command.ExecuteReader();

                while (reader2.Read())
                {
                    cboxTurma.Items.Add(reader2.GetString("nomeTurma"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }


            MySqlDataReader reader = aluno.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewAluno.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewAluno.Rows.Add();

                        dataGridViewAluno.Rows[n].Cells["columnId"].Value = reader["idAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCpf"].Value = reader["cpfAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnNome"].Value = reader["nomeAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnTelefone"].Value = reader["telefoneAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCelular"].Value = reader["celularAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnEmail"].Value = reader["emailAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnCidade"].Value = reader["cidadeAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnBairro"].Value = reader["bairroAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnRua"].Value = reader["ruaAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnNumero"].Value = reader["numeroAluno"];
                        dataGridViewAluno.Rows[n].Cells["columnTurma"].Value = reader["nomeTurma"];
                        dataGridViewAluno.Rows[n].Cells["ColumnDataNasc"].Value = reader["dataNasc"];
                        dataGridViewAluno.Rows[n].Cells["ColumnCep"].Value = reader["cepAluno"];
                    }
                }
            }
        }
    }
}
