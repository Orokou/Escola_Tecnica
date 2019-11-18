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
    public partial class telaEmailProfessor : Form
    {
        public Form tela;
        public telaEmailProfessor()
        {
            InitializeComponent();
        }

        Professor professor = new Professor();
        private void TelaEmailProfessor_Load(object sender, EventArgs e)
        {
            professor.EmailProfessor = Conta.Email;

            if (professor.ObterProfessor2())
            {
                txtId.Text = professor.IdProfessor.ToString();
            }
        }

        private void BtnTrocar_Click(object sender, EventArgs e)
        {
            if (pbV.Visible == true)
            {
                if ((!txtEmailAntigo.Text.Equals("")) &&
                (!txtEmailNovo.Text.Equals("")))
                {
                    professor.IdProfessor = int.Parse(txtId.Text);
                    professor.EmailProfessor = txtEmailNovo.Text;
                    if (professor.EditarEmail())
                    {
                        MessageBox.Show("Email alterado com sucesso!");
                        txtEmailAntigo.Clear();
                        txtEmailNovo.Clear();
                        txtEmailAntigo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar o email!");
                        txtEmailAntigo.Clear();
                        txtEmailNovo.Clear();
                        txtEmailAntigo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                    txtEmailAntigo.Clear();
                    txtEmailNovo.Clear();
                    txtEmailAntigo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Email antigo incorreto!");
                txtEmailAntigo.Clear();
                txtEmailNovo.Clear();
                txtEmailAntigo.Focus();
            }
        }

        private void TelaEmailProfessor_Leave(object sender, EventArgs e)
        {
            if (txtEmailAntigo.Text == Conta.Email)
            {
                pbV.Visible = true;
                pbX.Visible = false;
            }
            else if (txtEmailAntigo.Text == "")
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
