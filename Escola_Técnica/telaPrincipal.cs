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
    public partial class telaPrincipal : Form
    {

        public Form tela;
        static telaPrincipal _obj;

        public static telaPrincipal Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new telaPrincipal();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            if(Conta.Permissao == "assistente")
            {
                btnCadastrar.Visible = true;
                btnEditar.Visible = true;
                btnExcluir.Visible = true;
                btnPesquisar.Visible = true;
                btnEditarNotas.Visible = false;
                btnVerNotas.Visible = false;
                btnLançarNotas.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }
            else if (Conta.Permissao == "aluno")
            {
                btnEditarNotas.Visible = false;
                btnCadastrar.Visible = false;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;
                btnPesquisar.Visible = false;
                btnVerNotas.Visible = true;
                btnLançarNotas.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
            }
            else if (Conta.Permissao == "professor")
            {
                btnCadastrar.Visible = false;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;
                btnPesquisar.Visible = false;
                btnVerNotas.Visible = false;
                btnEditarNotas.Visible = true;
                btnLançarNotas.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = true;
                label7.Visible = true;
            }

            _obj = this;

            UCHome uc = new UCHome();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCCadastro"))
            {
                UCCadastro un = new UCCadastro();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCCadastro"].BringToFront();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCHome"].BringToFront();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCEditar"))
            {
                UCEditar un = new UCEditar();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCEditar"].BringToFront();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCPesquisar"))
            {
                UCPesquisar un = new UCPesquisar();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCPesquisar"].BringToFront();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCExcluir"))
            {
                UCExcluir un = new UCExcluir();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCExcluir"].BringToFront();
        }

        private void BtnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.Red;
        }

        private void BtnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.ForeColor = default(Color);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            confirmarSaida tela = new confirmarSaida { tela = this };
            tela.Show();
        }

        private void BtnVerNotas_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCVerNotas"))
            {
                UCVerNotas un = new UCVerNotas();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCVerNotas"].BringToFront();
        }

        private void BtnLançarNotas_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCLancarNotas"))
            {
                UCLancarNotas un = new UCLancarNotas();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCLancarNotas"].BringToFront();
        }

        private void BtnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void BtnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Italic);
        }

        private void BtnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
        }

        private void BtnPesquisar_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Italic);
        }

        private void BtnEditar_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void BtnEditar_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Italic);
        }

        private void BtnExcluir_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
        }

        private void BtnExcluir_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Italic);
        }

        private void BtnLançarNotas_MouseEnter(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font, FontStyle.Bold);
        }

        private void BtnLançarNotas_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font, FontStyle.Italic);
        }

        private void BtnVerNotas_MouseEnter(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
        }

        private void BtnVerNotas_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Italic);
        }

        private void BtnEditarNotas_MouseEnter(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Bold);
        }

        private void BtnEditarNotas_MouseLeave(object sender, EventArgs e)
        {
            label7.Font = new Font(label7.Font, FontStyle.Italic);
        }

        private void BtnEditarNotas_Click(object sender, EventArgs e)
        {
            if (!telaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCEditarNotas"))
            {
                UCEditarNotas un = new UCEditarNotas();
                un.Dock = DockStyle.Fill;
                telaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            telaPrincipal.Instance.PnlContainer.Controls["UCEditarNotas"].BringToFront();
        }
    }
}
