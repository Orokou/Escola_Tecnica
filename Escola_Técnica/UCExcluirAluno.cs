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
    public partial class UCExcluirAluno : UserControl
    {
        public UCExcluirAluno()
        {
            InitializeComponent();
        }

        Turma turma = new Turma();
        Aluno aluno = new Aluno();
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if ((!cboxAluno.Text.Equals("")) && (!cboxTurma2.Text.Equals("")))
            {
                aluno.NomeAluno = cboxAluno.Text;

                if (aluno.Excluir())
                {

                    MessageBox.Show("Aluno excluído com sucesso!");
                    //LIMPAR OS CAMPOS
                    cboxAluno.Items.Clear();
                    cboxTurma2.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Falha ao excluir!");
                    //LIMPAR OS CAMPOS
                    cboxAluno.Items.Clear();
                    cboxTurma2.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
                //LIMPAR OS CAMPOS
                cboxAluno.Items.Clear();
                cboxTurma2.SelectedIndex = -1;
            }
        }

        private void UCExcluirAluno_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                string selectQuery = "select * from turma";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboxTurma2.Items.Add(reader.GetString("nomeTurma"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }
        }

        private void CboxTurma2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                turma.NomeTurma = cboxTurma2.Text;
                turma.ObterTurma();

                MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                string selectQuery = "select * from aluno where idTurma ='" + turma.IdTurma + "';";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                cboxAluno.Items.Clear();

                while (reader.Read())
                {
                    cboxAluno.Items.Add(reader.GetString("nomeAluno"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }
        }
    }
}
