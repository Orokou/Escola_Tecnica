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
    public partial class UCEditarTurma : UserControl
    {
        public UCEditarTurma()
        {
            InitializeComponent();
        }

        private void UCEditarTurma_Load(object sender, EventArgs e)
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
                    cboxTurma.Items.Add(reader.GetString("nomeTurma"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //SE OS CAMPOS NÃO ESTIVEREM VAZIOS
            if ((!txtTurma.Text.Equals("")) &&
                (turma.Turno == "Manhã" || turma.Turno == "Tarde" || turma.Turno == "Noite") &&
                (!cboxCurso.Text.Equals("")))
            {
                if (rbtnManha.Checked)
                {
                    turma.Turno = rbtnManha.Text;
                }
                else if (rbtnTarde.Checked)
                {
                    turma.Turno = rbtnTarde.Text;
                }
                else if (!rbtnNoite.Checked)
                {
                    turma.Turno = rbtnNoite.Text;
                }

                turma.NomeTurma = txtTurma.Text;
                curso.NomeCurso = cboxCurso.Text;
                curso.ObterCurso();
                turma.curso.IdCurso = curso.IdCurso;
                if (turma.Editar())
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                    //DEIXAR VISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                    cboxTurma.Visible = true;
                    btnConfirmar.Visible = true;
                    label11.Visible = true;
                    //DEIXAR INVISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                    btnAlterar.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    txtTurma.Visible = false;
                    cboxCurso.Visible = false;
                    rbtnManha.Visible = false;
                    rbtnTarde.Visible = false;
                    rbtnNoite.Visible = false;
                }
                else
                {
                    MessageBox.Show("Falha ao alterar os dados!");
                    //DEIXAR VISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                    cboxTurma.Visible = true;
                    btnConfirmar.Visible = true;
                    label11.Visible = true;
                    //DEIXAR INVISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                    btnAlterar.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    txtTurma.Visible = false;
                    cboxCurso.Visible = false;
                    rbtnManha.Visible = false;
                    rbtnTarde.Visible = false;
                    rbtnNoite.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        Turma turma = new Turma();
        Curso curso = new Curso();
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            turma.NomeTurma = cboxTurma.Text;
            if (!cboxTurma.Text.Equals("") && turma.ObterTurma())
            {
                //DEIXAR INVISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                cboxTurma.Visible = false;
                btnConfirmar.Visible = false;
                label11.Visible = false;
                //DEIXAR VISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                btnAlterar.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                txtTurma.Visible = true;
                cboxCurso.Visible = true;
                rbtnManha.Visible = true;
                rbtnTarde.Visible = true;
                rbtnNoite.Visible = true;

                txtTurma.Text = turma.NomeTurma;
                //MOSTRAR OS CURSOS NA COMBOBOX DE CURSOS
                try
                {
                    MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                    string selectQuery = "select * from curso";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cboxCurso.Items.Add(reader.GetString("nomeCurso"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha no Sistema: " + ex.Message);
                }
              
                //SE O TURNO FOR MANHÃ, O RADIOBUTTON SERÁ MARCADO
                if (turma.Turno == "Manhã")
                {
                    rbtnManha.Checked = true;
                }
                //SE O TURNO FOR TARDE, O RADIOBUTTON SERÁ MARCADO
                else if (turma.Turno == "Tarde")
                {
                    rbtnTarde.Checked = true;
                }
                //SE O TURNO FOR NOITE, O RADIOBUTTON SERÁ MARCADO
                else if (turma.Turno == "Noite")
                {
                    rbtnNoite.Checked = true;
                }
            }
            //CASO NÃO ENCONTRE NENHUMA TURMA
            else
            {
                MessageBox.Show("Nenhuma turma encontrada!");
            }
        }
    }
}
