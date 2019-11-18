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
    public partial class UCVerNotas : UserControl
    {
        public UCVerNotas()
        {
            InitializeComponent();
        }

        Notas notas = new Notas();
        private void UCVerNotas_Load(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.EmailAluno = Conta.Email;
            aluno.ObterAluno2();
            notas.NomeAluno = aluno.IdAluno.ToString();
            MySqlDataReader reader = notas.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewNotas.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewNotas.Rows.Add();

                        dataGridViewNotas.Rows[n].Cells["columnDisciplina"].Value = reader["nomeMateria"];
                        dataGridViewNotas.Rows[n].Cells["columnNota"].Value = reader["nota"];
                    }
                }
            }
        }
    }
}
