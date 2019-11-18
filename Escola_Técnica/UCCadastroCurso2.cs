using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Classes;

namespace Escola_Técnica
{
    public partial class UCCadastroCurso2 : UserControl
    {
        public UCCadastroCurso2()
        {
            InitializeComponent();
        }

        Curso curso = new Curso();
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if ((!txtNome.Text.Equals("")) &&
                (!txtCh.Text.Equals("")))
            {
                curso.NomeCurso = txtNome.Text;
                curso.CargaHoraria = int.Parse(txtCh.Text);

                if (curso.Cadastrar())
                {

                    MessageBox.Show("Cadastro realizado com sucesso!");
                    //LIMPAR OS CAMPOS
                    txtNome.Clear();
                    txtCh.Clear();
                    //FOCAR NO CAMPO NOME
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar!");
                    //LIMPAR OS CAMPOS
                    txtNome.Clear();
                    txtCh.Clear();
                    //FOCAR NO CAMPO NOME
                    txtNome.Focus();
                }
            }

            else
            {
                //SE OS CAMPOS NÃO ESTIVEREM PREENCHIDOS
                MessageBox.Show("Preencha todos os campos!");
                //LIMPAR OS CAMPOS
                txtNome.Clear();
                txtCh.Clear();
                //FOCAR NO CAMPO NOME
                txtNome.Focus();
            }
        }
    }
}
