using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_Técnica
{
    public partial class confirmarSaida : Form
    {
        public Form tela;
        public confirmarSaida()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.Close();
            Application.Exit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
