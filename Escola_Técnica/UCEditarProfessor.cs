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
    public partial class UCEditarProfessor : UserControl
    {
        public UCEditarProfessor()
        {
            InitializeComponent();
        }

        Professor professor = new Professor();
        Turma turma = new Turma();
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //SE OS CAMPOS NÃO ESTIVEREM VAZIOS
            if ((!txtBairro.Text.Equals("")) &&
                (!txtCelular.Text.Equals("")) &&
                (!txtCidade.Text.Equals("")) &&
                (!txtCpf.Text.Equals("")) &&
                (!txtEmail.Text.Equals("")) &&
                (!txtNome.Text.Equals("")) &&
                (!txtNumero.Text.Equals("")) &&
                (!txtRua.Text.Equals("")) &&
                (!txtSenha.Text.Equals("")) &&
                (!txtTelefone.Text.Equals("")) &&
                 (!txtCep.Text.Equals("")) &&
                (!txtData.Text.Equals("")) &&
                (!cboxTurma.Text.Equals("")))
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
                professor.Cep = Convert.ToInt64(txtCep.Text);
                professor.DataNasc = DateTime.Parse(txtData.Text);
                turma.ObterTurma();
                professor.turma.IdTurma = turma.IdTurma;

                if (professor.Editar())
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                    btnConfirmar.Visible = true;
                    cboxTurma2.Visible = true;
                    cboxProfessor.Visible = true;
                    label11.Visible = true;
                    label13.Visible = true;
                    btnAlterar.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label12.Visible = false;
                    label14.Visible = false;
                    cboxTurma.Visible = false;
                    txtBairro.Visible = false;
                    txtCelular.Visible = false;
                    txtCidade.Visible = false;
                    txtCpf.Visible = false;
                    txtEmail.Visible = false;
                    txtNome.Visible = false;
                    txtNumero.Visible = false;
                    txtRua.Visible = false;
                    txtSenha.Visible = false;
                    txtTelefone.Visible = false;
                    txtData.Visible = false;
                    txtCep.Visible = false;
                }
                else
                {
                    MessageBox.Show("Falha ao alterar os dados!");
                    btnConfirmar.Visible = true;
                    cboxTurma2.Visible = true;
                    cboxProfessor.Visible = true;
                    label11.Visible = true;
                    label13.Visible = true;
                    btnAlterar.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label12.Visible = false;
                    label14.Visible = false;
                    cboxTurma.Visible = false;
                    txtBairro.Visible = false;
                    txtCelular.Visible = false;
                    txtCidade.Visible = false;
                    txtCpf.Visible = false;
                    txtEmail.Visible = false;
                    txtNome.Visible = false;
                    txtNumero.Visible = false;
                    txtRua.Visible = false;
                    txtSenha.Visible = false;
                    txtTelefone.Visible = false;
                    txtData.Visible = false;
                    txtCep.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
     
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            professor.NomeProfessor = cboxProfessor.Text;
            if (professor.ObterProfessor())
            {
                cboxTurma2.Visible = false;
                cboxProfessor.Visible = false;
                label13.Visible = false;
                label11.Visible = false;
                btnConfirmar.Visible = false;
                btnAlterar.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label12.Visible = true;
                label14.Visible = true;
                cboxTurma.Visible = true;
                txtBairro.Visible = true;
                txtCelular.Visible = true;
                txtCidade.Visible = true;
                txtCpf.Visible = true;
                txtEmail.Visible = true;
                txtNome.Visible = true;
                txtNumero.Visible = true;
                txtRua.Visible = true;
                txtSenha.Visible = true;
                txtTelefone.Visible = true;
                txtData.Visible = true;
                txtCep.Visible = true;

                //ATRIBUI O VALOR DAS TEXT COM OS VALORES CADASTRADOS NO BANCO DE DADOS
                txtBairro.Text = professor.BairroProfessor;
                txtCelular.Text = professor.CelularProfessor.ToString();
                txtCidade.Text = professor.CidadeProfessor;
                txtCpf.Text = professor.CpfProfessor.ToString();
                txtEmail.Text = professor.EmailProfessor;
                txtNome.Text = professor.NomeProfessor;
                txtNumero.Text = professor.NumeroProfessor.ToString();
                txtRua.Text = professor.RuaProfessor;
                txtSenha.Text = professor.SenhaProfessor;
                txtTelefone.Text = professor.TelefoneProfessor.ToString();
                cboxTurma.Text = professor.TurmaProfessor;
                txtData.Text = professor.DataNasc.ToString();
                txtCep.Text = professor.Cep.ToString();

                //MOSTRAR AS TURMAS NA COMBOBOX DE TURMAS
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

        private void UCEditarProfessor_Load(object sender, EventArgs e)
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
