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
    public partial class UCExcluirProfessor : UserControl
    {
        public UCExcluirProfessor()
        {
            InitializeComponent();
        }

        Professor professor = new Professor();
        Turma turma = new Turma();
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if ((!cboxTurma2.Text.Equals("")) && (!cboxProfessor.Text.Equals("")))
            {
                professor.NomeProfessor = cboxProfessor.Text;

                if (professor.ObterProfessor())
                {
                    professor.Excluir();
                    MessageBox.Show("Professor excluído com sucesso!");
                    //LIMPAR OS CAMPOS
                    cboxProfessor.Items.Clear();
                    cboxTurma2.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Falha ao excluir!");
                    //LIMPAR OS CAMPOS
                    cboxProfessor.Items.Clear();
                    cboxTurma2.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
                //LIMPAR OS CAMPOS
                cboxProfessor.Items.Clear();
                cboxTurma2.SelectedIndex = -1;
            }
        }

        private void UCExcluirProfessor_Load(object sender, EventArgs e)
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
                string selectQuery = "select * from professor where idTurma ='" + turma.IdTurma + "';";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                cboxProfessor.Items.Clear();

                while (reader.Read())
                {
                    cboxProfessor.Items.Add(reader.GetString("nomeProfessor"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }
        }          
    }
}
