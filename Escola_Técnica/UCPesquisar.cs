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
    public partial class UCPesquisar : UserControl
    {
        public UCPesquisar()
        {
            InitializeComponent();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCPesquisarAluno"))
            {
                UCPesquisarAluno un = new UCPesquisarAluno();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCPesquisarAluno"].BringToFront();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCPesquisarProfessor"))
            {
                UCPesquisarProfessor un = new UCPesquisarProfessor();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCPesquisarProfessor"].BringToFront();
        }

        private void BtnTurma_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCPesquisarTurma"))
            {
                UCPesquisarTurma un = new UCPesquisarTurma();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCPesquisarTurma"].BringToFront();
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCPesquisarCurso"))
            {
                UCPesquisarCurso un = new UCPesquisarCurso();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCPesquisarCurso"].BringToFront();
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
