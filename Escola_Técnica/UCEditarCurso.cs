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
    public partial class UCEditarCurso : UserControl
    {
        public UCEditarCurso()
        {
            InitializeComponent();
        }

        private void UCEditarCurso_Load(object sender, EventArgs e)
        {
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

        Curso curso = new Curso();
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            curso.NomeCurso = cboxCurso.Text;
            if (!cboxCurso.Text.Equals("") && curso.ObterCurso())
            {
                //DEIXAR INVISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                cboxCurso.Visible = false;
                btnConfirmar.Visible = false;
                label11.Visible = false;
                //DEIXAR VISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                btnAlterar.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                txtNome.Visible = true;
                txtCh.Visible = true;

                //ATRIBUI O VALOR DAS TEXT COM OS VALORES CADASTRADOS NO BANCO DE DADOS
                txtNome.Text = curso.NomeCurso;
                txtCh.Text = curso.CargaHoraria.ToString();

            }
            //CASO NÃO ENCONTRE NENHUM CURSO
            else
            {
                MessageBox.Show("Nenhum curso encontrado!");
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //SE OS CAMPOS NÃO ESTIVEREM VAZIOS
            if ((!txtNome.Text.Equals("")) &&
                (!txtCh.Text.Equals("")))
            {
                cboxCurso.Text = curso.NomeCurso;
                curso.ObterCurso();
                curso.NomeCurso = txtNome.Text;
                curso.CargaHoraria = Convert.ToInt32(txtCh.Text);
                curso.IdCurso = curso.IdCurso;

                if (curso.Editar())
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                    //DEIXAR VISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                    cboxCurso.Visible = true;
                    btnConfirmar.Visible = true;
                    label11.Visible = true;
                    //DEIXAR INVISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                    btnAlterar.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    txtNome.Visible = false;
                    txtCh.Visible = false;
                }
                else
                {
                    MessageBox.Show("Falha ao alterar os dados!");
                    //DEIXAR VISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                    cboxCurso.Visible = true;
                    btnConfirmar.Visible = true;
                    label11.Visible = true;
                    //DEIXAR INVISÍVEL APÓS CONFIRMAR O NOME DA TURMA
                    btnAlterar.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    txtNome.Visible = false;
                    txtCh.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
