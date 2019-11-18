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
    public partial class UCCadastroCurso : UserControl
    {
        public UCCadastroCurso()
        {
            InitializeComponent();
        }

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

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCCadastroCurso2"))
            {
                UCCadastroCurso2 un = new UCCadastroCurso2();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCCadastroCurso2"].BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCCadastroDisciplina"))
            {
                UCCadastroDisciplina un = new UCCadastroDisciplina();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCCadastroDisciplina"].BringToFront();
        }

        private void BtnCurso_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
        }

        private void BtnCurso_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Italic);
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Italic);
        }
    }
}
