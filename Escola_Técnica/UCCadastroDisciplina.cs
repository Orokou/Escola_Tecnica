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
    public partial class UCCadastroDisciplina : UserControl
    {
        public UCCadastroDisciplina()
        {
            InitializeComponent();
        }

        Curso curso = new Curso();
        Materia materia = new Materia();
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if ((!txtMateria.Text.Equals("")) &&
                (!cboxCurso.Text.Equals("")))
            {
                materia.NomeMateria = txtMateria.Text;
                materia.curso.IdCurso = curso.IdCurso;

                if (materia.Cadastrar())
                {

                    MessageBox.Show("Cadastro realizado com sucesso!");
                    //LIMPAR OS CAMPOS
                    txtMateria.Clear();
                    cboxCurso.SelectedIndex = -1;
                    //FOCAR NO CAMPO NOME
                    txtMateria.Focus();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar!");
                    //LIMPAR OS CAMPOS
                    txtMateria.Clear();
                    cboxCurso.SelectedIndex = -1;
                    //FOCAR NO CAMPO NOME
                    txtMateria.Focus();
                }
            }

            else
            {
                //SE OS CAMPOS NÃO ESTIVEREM PREENCHIDOS
                MessageBox.Show("Preencha todos os campos!");
                //LIMPAR OS CAMPOS
                txtMateria.Clear();
                cboxCurso.SelectedIndex = -1;
                //FOCAR NO CAMPO NOME
                txtMateria.Focus();
            }
        }

        private void CboxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            curso.NomeCurso = cboxCurso.Text;
            curso.ObterCurso();
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
