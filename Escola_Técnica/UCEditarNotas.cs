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
    public partial class UCEditarNotas : UserControl
    {
        public UCEditarNotas()
        {
            InitializeComponent();
        }

        Aluno aluno = new Aluno();
        Turma turma = new Turma();
        Professor professor = new Professor();
        Materia materia = new Materia();
        Curso curso = new Curso();
        Notas nota = new Notas();
        private void UCEditarNotas_Load(object sender, EventArgs e)
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
            cboxMateria.Items.Clear();
            txtNotaAntiga.Clear();
            dataGridViewNotas.Visible = true;
            aluno.NomeAluno = cboxAluno.Text;
            aluno.ObterAluno();
            nota.NomeAluno = aluno.IdAluno.ToString();
            MySqlDataReader reader2 = nota.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader2.HasRows)
            {
                dataGridViewNotas.Rows.Clear();
                while (reader2.Read())
                {
                    {
                        int n = dataGridViewNotas.Rows.Add();

                        dataGridViewNotas.Rows[n].Cells["ColumnMateria"].Value = reader2["nomeMateria"];
                        dataGridViewNotas.Rows[n].Cells["ColumnNota"].Value = reader2["nota"];
                    }
                }
            }
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
                string selectQuery = "select * from materia where idCurso='" + materia.CursoMateria + "';";
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

        private void CboxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Notas nota = new Notas();
            aluno.NomeAluno = cboxAluno.Text;
            aluno.ObterAluno();
            nota.NomeAluno = aluno.IdAluno.ToString();
            materia.NomeMateria = cboxMateria.Text;
            materia.ObterMateria();
            nota.NomeMateria = materia.IdMateria.ToString();
            nota.ObterNota();
            txtNotaAntiga.Text = nota.Nota.ToString();  
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (!cboxAluno.Text.Equals("") && !cboxMateria.Text.Equals("") && !txtNota.Text.Equals("") && !txtNotaAntiga.Text.Equals(""))
            {
                nota.Nota = Convert.ToInt32(txtNota.Text);
                aluno.NomeAluno = cboxAluno.Text;
                aluno.ObterAluno();              
                materia.NomeMateria = cboxMateria.Text;
                materia.ObterMateria();              
                nota.NomeMateria = materia.IdMateria.ToString();
                nota.NomeAluno = aluno.IdAluno.ToString();
                if (nota.Editar())
                {
                    MessageBox.Show("Nota alterada com sucesso!");
                    cboxAluno.SelectedIndex = -1;
                    cboxMateria.Items.Clear();
                    txtNota.Clear();
                    txtNotaAntiga.Clear();
                    dataGridViewNotas.Visible = false;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar a nota!");
                    cboxAluno.SelectedIndex = -1;
                    cboxMateria.Items.Clear();
                    txtNota.Clear();
                    txtNotaAntiga.Clear();
                    dataGridViewNotas.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
                cboxAluno.SelectedIndex = -1;
                cboxMateria.Items.Clear();
                txtNota.Clear();
                txtNotaAntiga.Clear();
                dataGridViewNotas.Visible = false;
            }
        }
    }
}
