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
    public partial class UCLancarNotas : UserControl
    {
        public UCLancarNotas()
        {
            InitializeComponent();
        }

        Aluno aluno = new Aluno();
        Turma turma = new Turma();
        Professor professor = new Professor();
        Materia materia = new Materia();
        Curso curso = new Curso();
        private void UCLancarNotas_Load(object sender, EventArgs e)
        {
            professor.EmailProfessor = Conta.Email;

            if (professor.ObterProfessor2())
            {
                aluno.TurmaAluno = professor.TurmaProfessor;

                try
                {
                    MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                    string selectQuery = "SELECT * FROM aluno WHERE idTurma='" + aluno.TurmaAluno + "';";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader reader = command.ExecuteReader();

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

        private void CboxAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            aluno.NomeAluno = cboxAluno.Text;
            aluno.ObterAluno();
            turma.IdTurma = Convert.ToInt32(aluno.TurmaAluno);
            turma.ObterTurma2();
            curso.IdCurso = Convert.ToInt32(turma.CursoTurma);
            curso.ObterCurso2();
            materia.CursoMateria = curso.IdCurso.ToString();
            materia.ObterMateria2();

            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                string selectQuery = "select * from materia where idCurso='" + materia.CursoMateria +"';";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboxMateria.Items.Add(reader.GetString("nomeMateria"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }
        }

        private void BtnLancar_Click(object sender, EventArgs e)
        {
            if ((!txtNota.Text.Equals("")) &&
                (!cboxMateria.Text.Equals("")) &&
                (!cboxAluno.Text.Equals("")))
            {
                Notas notas = new Notas();
                notas.aluno.IdAluno = aluno.IdAluno;
                notas.materia.IdMateria = materia.IdMateria;
                notas.Nota = int.Parse(txtNota.Text);

                if (notas.Cadastrar())
                {

                    MessageBox.Show("Nota lançada com sucesso!");
                    //LIMPAR OS CAMPOS
                    txtNota.Clear();
                    cboxAluno.SelectedIndex = -1;
                    cboxMateria.SelectedIndex = -1;
                    //FOCAR NO CAMPO NOTA
                    txtNota.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar!");
                    //LIMPAR OS CAMPOS
                    txtNota.Clear();
                    cboxAluno.SelectedIndex = -1;
                    cboxMateria.SelectedIndex = -1;
                    //FOCAR NO CAMPO NOTA
                    txtNota.Clear();
                }
            }

            else
            {
                //SE OS CAMPOS NÃO ESTIVEREM PREENCHIDOS
                MessageBox.Show("Preencha todos os campos!");
                //LIMPAR OS CAMPOS
                txtNota.Clear();
                cboxAluno.SelectedIndex = -1;
                cboxMateria.SelectedIndex = -1;
                //FOCAR NO CAMPO NOTA
                txtNota.Clear();
            }
        }

        private void CboxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            materia.NomeMateria = cboxMateria.Text;
            materia.ObterMateria();
        }
    }
}
