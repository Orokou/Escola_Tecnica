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
    public partial class UCCadastroTurma : UserControl
    {
        public UCCadastroTurma()
        {
            InitializeComponent();
        }

        Turma turma = new Turma();
        Curso curso = new Curso();
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //SE TODOS OS CAMPOS ESTIVEREM PREENCHIDOS
            if ((!txtNome.Text.Equals("")) &&
                (turma.Turno == "Manhã" || turma.Turno == "Tarde" || turma.Turno == "Noite") &&
                (!cboxCurso.Text.Equals("")))
            {
                turma.NomeTurma = txtNome.Text;
                turma.curso.IdCurso = curso.IdCurso;

                if (turma.Cadastrar())
                {

                    MessageBox.Show("Cadastro realizado com sucesso!");
                    //LIMPAR OS CAMPOS
                    txtNome.Clear();
                    //FOCAR NO CAMPO NOME
                    txtNome.Focus();
                    //DESMARCAR OS BOTÕES
                    rbtnManha.Checked = false;
                    rbtnTarde.Checked = false;
                    rbtnNoite.Checked = false;
                    //LIMPAR A COMBOBOX
                    cboxCurso.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar!");
                    //LIMPAR OS CAMPOS
                    txtNome.Clear();
                    //FOCAR NO CAMPO NOME
                    txtNome.Focus();
                    //DESMARCAR OS BOTÕES
                    rbtnManha.Checked = false;
                    rbtnTarde.Checked = false;
                    rbtnNoite.Checked = false;
                    //LIMPAR A COMBOBOX
                    cboxCurso.SelectedIndex = -1;
                }
            }
            else
            {
                //SE OS CAMPOS NÃO ESTIVEREM PREENCHIDOS
                MessageBox.Show("Preencha todos os campos!");
                //LIMPAR OS CAMPOS
                txtNome.Clear();
                //FOCAR NO CAMPO NOME
                txtNome.Focus();
                //DESMARCAR OS BOTÕES
                rbtnManha.Checked = false;
                rbtnTarde.Checked = false;
                rbtnNoite.Checked = false;
                //LIMPAR A COMBOBOX
                cboxCurso.SelectedIndex = -1;
            }
        }

        private void CboxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            curso.NomeCurso = cboxCurso.Text;
            curso.ObterCurso();
        }

        private void RbtnManha_CheckedChanged(object sender, EventArgs e)
        {
            turma.Turno = "Manhã";
        }

        private void RbtnTarde_CheckedChanged(object sender, EventArgs e)
        {
            turma.Turno = "Tarde";
        }

        private void RbtnNoite_CheckedChanged(object sender, EventArgs e)
        {
            turma.Turno = "Noite";
        }

        private void CboxCurso_Click(object sender, EventArgs e)
        {
            cboxCurso.Items.Clear();

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
        }
    }
}
