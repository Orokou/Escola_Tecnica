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
    public partial class telaSenhaProfessor : Form
    {
        public Form tela;
        public telaSenhaProfessor()
        {
            InitializeComponent();
        }

        Professor professor = new Professor();
        private void TelaSenhaProfessor_Load(object sender, EventArgs e)
        {
            professor.EmailProfessor = Conta.Email;

            if (professor.ObterProfessor2())
            {
                txtI.Text = professor.IdProfessor.ToString();
            }
        }

        private void BtnTrocar_Click(object sender, EventArgs e)
        {
            if (pbV.Visible == true)
            {
                if ((!txtSenhaAntiga.Text.Equals("")) &&
                (!txtSenhaNova.Text.Equals("")))
                {
                    professor.IdProfessor = int.Parse(txtI.Text);
                    professor.SenhaProfessor = txtSenhaNova.Text;
                    if (professor.EditarSenha())
                    {
                        MessageBox.Show("Senha alterada com sucesso!");
                        txtSenhaAntiga.Clear();
                        txtSenhaNova.Clear();
                        txtSenhaAntiga.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar a senha!");
                        txtSenhaAntiga.Clear();
                        txtSenhaNova.Clear();
                        txtSenhaAntiga.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                    txtSenhaAntiga.Clear();
                    txtSenhaNova.Clear();
                    txtSenhaAntiga.Focus();
                }
            }
            else
            {
                MessageBox.Show("Senha antiga incorreta!");
                txtSenhaAntiga.Clear();
                txtSenhaNova.Clear();
                txtSenhaAntiga.Focus();
            }
        }

        private void TxtSenhaAntiga_Leave(object sender, EventArgs e)
        {
            if (txtSenhaAntiga.Text == Conta.Senha)
            {
                pbV.Visible = true;
                pbX.Visible = false;
            }
            else if (txtSenhaAntiga.Text == "")
            {
                pbX.Visible = false;
                pbV.Visible = false;
            }
            else
            {
                pbX.Visible = true;
                pbV.Visible = false;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.Red;
        }

        private void BtnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.ForeColor = default(Color);
        }
    }
}
