using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace Escola_Técnica
{
    public partial class telaLogin : Form
    {
        public Form tela;
        public telaLogin()
        {
            InitializeComponent();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            //SE TODOS OS CAMPOS ESTIVEREM PREENCHIDOS
            if ((!txtEmail.Text.Equals("")) &&
                (!txtSenha.Text.Equals("")))
            {
                Login login = new Login();
                login.Email = txtEmail.Text;
                login.Senha = txtSenha.Text;
                Conta.Email = txtEmail.Text;
                Conta.Senha = txtSenha.Text;

                if (login.VerificarAssistente())
                {
                    if (login.VerificarAssistente())
                    {
                        Conta.Permissao = "assistente";
                        telaPrincipal tela = new telaPrincipal { tela = this };
                        this.Hide();
                        tela.Show();
                        MessageBox.Show("Bem vindo " + login.Email);                      
                    }
                    else
                    {
                        telaLogin tela = new telaLogin { tela = this };
                        this.Hide();
                        tela.Show();
                    }
                }
                else if (login.VerificarAluno())
                {
                    if (login.VerificarAluno())
                    {
                        Conta.Permissao = "aluno";
                        telaPrincipal tela = new telaPrincipal { tela = this };
                        this.Hide();
                        tela.Show();
                        MessageBox.Show("Bem vindo " + login.Email);                      
                    }
                    else
                    {
                        telaLogin tela = new telaLogin { tela = this };
                        this.Hide();
                        tela.Show();
                    }
                }

                else if (login.VerificarProfessor())
                {
                    if (login.VerificarProfessor())
                    {
                        Conta.Permissao = "professor";
                        telaPrincipal tela = new telaPrincipal { tela = this };
                        this.Hide();
                        tela.Show();
                        MessageBox.Show("Bem vindo " + login.Email);                     
                    }
                    else
                    {
                        telaLogin tela = new telaLogin { tela = this };
                        this.Hide();
                        tela.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Email ou senha inválidos!");
                    //LIMPAR OS CAMPOS
                    txtEmail.Clear();
                    txtSenha.Clear();
                    //FOCAR NO CAMPO EMAIL
                    txtEmail.Focus();
                }
            }

            else
            {
                //SE OS CAMPOS NÃO ESTIVEREM PREENCHIDOS
                MessageBox.Show("Preencha todos os campos!");
                //LIMPAR OS CAMPOS
                txtEmail.Clear();
                txtSenha.Clear();
                //FOCAR NO CAMPO EMAIL
                txtEmail.Focus();
            }
            //LIMPAR OS CAMPOS
            txtEmail.Clear();
            txtSenha.Clear();
            //FOCAR NO CAMPO EMAIL
            txtEmail.Focus();
        }
    }
}
