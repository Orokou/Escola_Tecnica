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
    public partial class UCExcluirTurma : UserControl
    {
        public UCExcluirTurma()
        {
            InitializeComponent();
        }

        private void UCExcluirTurma_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                string selectQuery = "select * from turma";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboxTurma.Items.Add(reader.GetString("nomeTurma"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if ((!cboxTurma.Text.Equals("")))
            {
                Turma turma = new Turma();

                turma.NomeTurma = cboxTurma.Text;

                if (turma.Excluir())
                {

                    MessageBox.Show("Turma excluída com sucesso!");
                    //LIMPAR OS CAMPOS
                    cboxTurma.SelectedIndex = -1;            
                }
                else
                {
                    MessageBox.Show("Falha ao excluir!");
                    //LIMPAR OS CAMPOS
                    cboxTurma.SelectedIndex = -1;
                }
            }
        }
    }
}
