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
    public partial class UCExcluirCurso : UserControl
    {
        public UCExcluirCurso()
        {
            InitializeComponent();
        }


        private void UCExcluirCurso_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost; port=3306; Database=db_escola; User ID=root;");
                string selectQuery = "select * from curso";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboxCurso.Items.Add(reader.GetString("nomeCurso"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if ((!cboxCurso.Text.Equals("")))
            {
                Curso curso = new Curso();

                curso.NomeCurso = cboxCurso.Text;

                if (curso.Excluir())
                {

                    MessageBox.Show("Curso excluído com sucesso!");                   
                    //LIMPAR OS CAMPOS
                    cboxCurso.SelectedIndex = -1;                 
                }
                else
                {
                    MessageBox.Show("Falha ao excluir!");
                    //LIMPAR OS CAMPOS
                    cboxCurso.SelectedIndex = -1;
                }
            }
        }
    }
}
