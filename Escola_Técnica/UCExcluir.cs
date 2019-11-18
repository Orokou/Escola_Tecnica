using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_Técnica
{
    public partial class UCExcluir : UserControl
    {
        public UCExcluir()
        {
            InitializeComponent();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCExcluirAluno"))
            {
                UCExcluirAluno un = new UCExcluirAluno();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCExcluirAluno"].BringToFront();
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCExcluirCurso"))
            {
                UCExcluirCurso un = new UCExcluirCurso();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCExcluirCurso"].BringToFront();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCExcluirProfessor"))
            {
                UCExcluirProfessor un = new UCExcluirProfessor();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCExcluirProfessor"].BringToFront();
        }

        private void BtnTurma_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCExcluirTurma"))
            {
                UCExcluirTurma un = new UCExcluirTurma();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCExcluirTurma"].BringToFront();
        }

        private void BtnAluno_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void BtnAluno_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Italic);
        }

        private void BtnProfessor_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
        }

        private void BtnProfessor_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Italic);
        }

        private void BtnTurma_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void BtnTurma_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Italic);
        }

        private void BtnCurso_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
        }

        private void BtnCurso_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Italic);
        }
    }
}
