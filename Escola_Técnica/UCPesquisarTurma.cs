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
    public partial class UCPesquisarTurma : UserControl
    {
        public UCPesquisarTurma()
        {
            InitializeComponent();
        }

        private void UCPesquisarTurma_Load(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            MySqlDataReader reader = turma.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewTurma.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewTurma.Rows.Add();

                        dataGridViewTurma.Rows[n].Cells["columnId"].Value = reader["idTurma"];
                        dataGridViewTurma.Rows[n].Cells["columnTurma"].Value = reader["nomeTurma"];
                        dataGridViewTurma.Rows[n].Cells["columnCurso"].Value = reader["nomeCurso"];
                        dataGridViewTurma.Rows[n].Cells["columnTurno"].Value = reader["turno"];
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            MySqlDataReader reader = turma.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewTurma.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewTurma.Rows.Add();

                        dataGridViewTurma.Rows[n].Cells["columnId"].Value = reader["idTurma"];
                        dataGridViewTurma.Rows[n].Cells["columnTurma"].Value = reader["nomeTurma"];
                        dataGridViewTurma.Rows[n].Cells["columnCurso"].Value = reader["nomeCurso"];
                        dataGridViewTurma.Rows[n].Cells["columnTurno"].Value = reader["turno"];
                    }
                }
            }
        }
    }
}
