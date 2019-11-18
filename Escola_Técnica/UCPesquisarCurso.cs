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
    public partial class UCPesquisarCurso : UserControl
    {
        public UCPesquisarCurso()
        {
            InitializeComponent();
        }

        private void UCPesquisarCurso_Load(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            MySqlDataReader reader = curso.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewCurso.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewCurso.Rows.Add();

                        dataGridViewCurso.Rows[n].Cells["columnId"].Value = reader["idCurso"];
                        dataGridViewCurso.Rows[n].Cells["columnCurso"].Value = reader["nomeCurso"];
                        dataGridViewCurso.Rows[n].Cells["columnCargaHoraria"].Value = reader["cargaHoraria"];
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            MySqlDataReader reader = curso.Listar();
            //SE READER FOR DIFERENTE DE NULO
            if (reader.HasRows)
            {
                dataGridViewCurso.Rows.Clear();
                while (reader.Read())
                {
                    {
                        int n = dataGridViewCurso.Rows.Add();

                        dataGridViewCurso.Rows[n].Cells["columnId"].Value = reader["idCurso"];
                        dataGridViewCurso.Rows[n].Cells["columnCurso"].Value = reader["nomeCurso"];
                        dataGridViewCurso.Rows[n].Cells["columnCargaHoraria"].Value = reader["cargaHoraria"];
                    }
                }
            }
        }
    }
}
