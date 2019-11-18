using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace Escola_Técnica
{
    public partial class UCAluno : UserControl
    {
        public UCAluno()
        {
            InitializeComponent();
        }

        private void UCAluno_Load(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.EmailAluno = Conta.Email;

            if (aluno.ObterAluno2())
            {
                lblNome.Text = aluno.NomeAluno;
                txtSenha.Text = aluno.SenhaAluno;
                txtEmail.Text = aluno.EmailAluno;
            }
        }

        private void LblSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSenha.Text == "Mostrar senha")
            {
                txtSenha.UseSystemPasswordChar = true;
                lblSenha.Text = "Ocultar senha";
            }
            else if (lblSenha.Text == "Ocultar senha")
            {
                txtSenha.UseSystemPasswordChar = false;
                lblSenha.Text = "Mostrar senha";
            }
        }

        private void LblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaEmailAluno tela = new telaEmailAluno();
            tela.Show();
        }

        private void LblTrocar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaSenhaAluno tela = new telaSenhaAluno();
            tela.Show();
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            telaLogin tela = new telaLogin();
            this.Hide();
            tela.Show();
        }
    }
}
