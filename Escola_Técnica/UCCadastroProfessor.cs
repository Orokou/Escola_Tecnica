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
    public partial class UCCadastroProfessor : UserControl
    {
        public UCCadastroProfessor()
        {
            InitializeComponent();
        }

        Turma turma = new Turma();
        Professor professor = new Professor();

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //SE TODOS OS CAMPOS ESTIVEREM PREENCHIDOS
            if ((!txtBairro.Text.Equals("")) &&
                (!txtCelular.Text.Equals("")) &&
                (!txtCidade.Text.Equals("")) &&
                (!txtCpf.Text.Equals("")) &&
                (!txtEmail.Text.Equals("")) &&
                (!txtNome.Text.Equals("")) &&
                (!txtNumero.Text.Equals("")) &&
                (!txtRua.Text.Equals("")) &&
                (!txtSenha.Text.Equals("")) &&
                (!cboxTurma.Text.Equals("")) &&
                (!txtCep.Text.Equals("")) &&
                (!txtData.Text.Equals("")) &&
                (!txtTelefone.Text.Equals("")))
            {
                professor.CpfProfessor = Convert.ToInt64(txtCpf.Text);
                professor.CidadeProfessor = txtCidade.Text;
                professor.CelularProfessor = Convert.ToInt64(txtCelular.Text);
                professor.BairroProfessor = txtBairro.Text;
                professor.EmailProfessor = txtEmail.Text;
                professor.NomeProfessor = txtNome.Text;
                professor.NumeroProfessor = Convert.ToInt64(txtNumero.Text);
                professor.RuaProfessor = txtRua.Text;
                professor.SenhaProfessor = txtSenha.Text;
                professor.TelefoneProfessor = Convert.ToInt64(txtTelefone.Text);
                professor.turma.IdTurma = turma.IdTurma;
                professor.Cep = Convert.ToInt64(txtCep.Text);
                professor.DataNasc = DateTime.Parse(txtData.Text);

                if (professor.Cadastrar())
                {

                    MessageBox.Show("Cadastro realizado com sucesso!");
                    //LIMPAR OS CAMPOS
                    txtBairro.Clear();
                    txtCelular.Clear();
                    txtCidade.Clear();
                    txtCpf.Clear();
                    txtEmail.Clear();
                    txtNome.Clear();
                    txtNumero.Clear();
                    txtRua.Clear();
                    txtSenha.Clear();
                    txtTelefone.Clear();
                    txtCep.Clear();
                    txtData.Clear();
                    cboxTurma.SelectedIndex = -1;
                    //FOCAR NO CAMPO NOME
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar!");
                    //LIMPAR OS CAMPOS
                    txtBairro.Clear();
                    txtCelular.Clear();
                    txtCidade.Clear();
                    txtCpf.Clear();
                    txtEmail.Clear();
                    txtNome.Clear();
                    txtNumero.Clear();
                    txtRua.Clear();
                    txtSenha.Clear();
                    txtTelefone.Clear();
                    txtCep.Clear();
                    txtData.Clear();
                    cboxTurma.SelectedIndex = -1;
                    //FOCAR NO CAMPO NOME
                    txtNome.Focus();
                }
            }
            else
            {
                //SE OS CAMPOS NÃO ESTIVEREM PREENCHIDOS
                MessageBox.Show("Preencha todos os campos!");
                //LIMPAR OS CAMPOS
                txtBairro.Clear();
                txtCelular.Clear();
                txtCidade.Clear();
                txtCpf.Clear();
                txtEmail.Clear();
                txtNome.Clear();
                txtNumero.Clear();
                txtRua.Clear();
                txtSenha.Clear();
                txtTelefone.Clear();
                txtCep.Clear();
                txtData.Clear();
                cboxTurma.SelectedIndex = -1;
                //FOCAR NO CAMPO NOME
                txtNome.Focus();
            }
        }

        private void CboxTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            turma.NomeTurma = cboxTurma.Text;
            turma.ObterTurma();
        }

        private void CboxTurma_Click(object sender, EventArgs e)
        {
            cboxTurma.Items.Clear();
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
    }
}
