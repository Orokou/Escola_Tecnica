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
    public partial class UCEditar : UserControl
    {
        static telaPrincipal _obj;

        public static telaPrincipal Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new telaPrincipal();
                }
                return _obj;
            }
        }

        public Button BotaoAluno
        {
            get { return btnAluno; }
            set { btnAluno = value; }
        }

        public UCEditar()
        {
            InitializeComponent();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCEditarAluno"))
            {
                UCEditarAluno un = new UCEditarAluno();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCEditarAluno"].BringToFront();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCEditarProfessor"))
            {
                UCEditarProfessor un = new UCEditarProfessor();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCEditarProfessor"].BringToFront();
        }

        private void BtnTurma_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCEditarTurma"))
            {
                UCEditarTurma un = new UCEditarTurma();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCEditarTurma"].BringToFront();
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCEditarCurso"))
            {
                UCEditarCurso un = new UCEditarCurso();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCEditarCurso"].BringToFront();
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
