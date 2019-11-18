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
    public partial class telaEmailAluno : Form
    {
        public telaEmailAluno()
        {
            InitializeComponent();
        }

        Aluno aluno = new Aluno();
        private void TxtEmailAntigo_Leave(object sender, EventArgs e)
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

        private void TelaEmailAluno_Load(object sender, EventArgs e)
        {
            aluno.EmailAluno = Conta.Email;

            if (aluno.ObterAluno2())
            {
                txtId.Text = aluno.IdAluno.ToString();
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

        private void BtnTrocar_Click(object sender, EventArgs e)
        {
            if (pbV.Visible == true)
            {
                if ((!txtEmailAntigo.Text.Equals("")) &&
                (!txtEmailNovo.Text.Equals("")))
                {
                    aluno.IdAluno = int.Parse(txtId.Text);
                    aluno.EmailAluno = txtEmailNovo.Text;
                    if (aluno.EditarEmail())
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
    }
}
