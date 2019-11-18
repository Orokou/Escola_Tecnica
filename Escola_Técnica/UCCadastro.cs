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
    public partial class UCCadastro : UserControl
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

        public UCCadastro()
        {
            InitializeComponent();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCCadastroAluno"))
            {
                UCCadastroAluno un = new UCCadastroAluno();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCCadastroAluno"].BringToFront();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCCadastroProfessor"))
            {
                UCCadastroProfessor un = new UCCadastroProfessor();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCCadastroProfessor"].BringToFront();
        }

        private void BtnTurma_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCCadastroTurma"))
            {
                UCCadastroTurma un = new UCCadastroTurma();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCCadastroTurma"].BringToFront();
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCCadastroCurso"))
            {
                UCCadastroCurso un = new UCCadastroCurso();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCCadastroCurso"].BringToFront();
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
