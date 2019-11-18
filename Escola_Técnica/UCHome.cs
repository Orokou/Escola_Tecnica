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
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void BtnAssistente_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCAssistente"))
            {
                UCAssistente un = new UCAssistente();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCAssistente"].BringToFront();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            if(Conta.Permissao == "aluno")
            {
                Aluno aluno = new Aluno();
                aluno.EmailAluno = Conta.Email;
                btnAluno.Visible = true;
                btnAssistente.Visible = false;
                btnProfessor.Visible = false;
                label1.Visible = false;

                if (aluno.ObterAluno2())
                {
                    lblNome.Text = aluno.EmailAluno;
                }
            }
            else if (Conta.Permissao == "assistente")
            {
                Aluno aluno = new Aluno();
                aluno.EmailAluno = Conta.Email;
                btnAluno.Visible = false;
                btnAssistente.Visible = true;
                btnProfessor.Visible = false;
                label1.Visible = true;

                if (aluno.ObterAluno2())
                {
                    lblNome.Text = aluno.EmailAluno;
                }
            }
            else if (Conta.Permissao == "professor")
            {
                Professor professor = new Professor();
                professor.EmailProfessor = Conta.Email;
                btnAluno.Visible = false;
                btnAssistente.Visible = false;
                btnProfessor.Visible = true;
                label1.Visible = false;

                if (professor.ObterProfessor2())
                {
                    lblNome.Text = professor.EmailProfessor;
                }
            }
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCAluno"))
            {
                UCAluno un = new UCAluno();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCAluno"].BringToFront();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCProfessor"))
            {
                UCProfessor un = new UCProfessor();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCProfessor"].BringToFront();
        }

        private void BtnAluno_MouseEnter(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.Blue;
        }

        private void BtnAluno_MouseLeave(object sender, EventArgs e)
        {
            lblNome.ForeColor = default(Color);
        }

        private void BtnProfessor_MouseEnter(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.Blue;
        }

        private void BtnProfessor_MouseLeave(object sender, EventArgs e)
        {
            lblNome.ForeColor = default(Color);
        }

        private void BtnAssistente_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void BtnAssistente_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = default(Color);
        }
    }
}
