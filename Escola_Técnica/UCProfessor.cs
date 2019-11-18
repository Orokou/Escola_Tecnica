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
    public partial class UCProfessor : UserControl
    {
        public UCProfessor()
        {
            InitializeComponent();
        }

        private void UCProfessor_Load(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.EmailProfessor = Conta.Email;

            if (professor.ObterProfessor2())
            {
                lblNome.Text = professor.NomeProfessor;
                txtSenha.Text = professor.SenhaProfessor;
                txtEmail.Text = professor.EmailProfessor;
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
            telaEmailProfessor tela = new telaEmailProfessor();
            tela.Show();
        }

        private void LblTrocar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaSenhaProfessor tela = new telaSenhaProfessor();
            tela.Show();
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            telaLogin tela = new telaLogin();
            telaPrincipal tela2 = new telaPrincipal();
            tela2.Hide();
            tela.Show();
        }
    }
}
