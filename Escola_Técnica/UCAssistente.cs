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
    public partial class UCAssistente : UserControl
    {
        public UCAssistente()
        {
            InitializeComponent();
        }

        private void UCAssistente_Load(object sender, EventArgs e)
        {
            Assistente assistente = new Assistente();
            assistente.EmailAssistente = Conta.Email;

            if (assistente.ObterAssistente())
            {
                lblNome.Text = assistente.EmailAssistente;
                txtSenha.Text = assistente.SenhalAssistente;
                txtEmail.Text = assistente.EmailAssistente;
            }
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            telaPrincipal tela2 = new telaPrincipal();
            telaLogin tela = new telaLogin { tela = tela2 };
            this.Hide();
            tela.Show();                 
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

        }

        private void LblTrocar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
