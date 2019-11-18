using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Classes
{
    public class Materia
    {
        int idMateria;
        string cursoMateria, nomeMateria;
        public Curso curso;

        public Materia()
        {
            curso = new Curso();
        }
        public string CursoMateria
        {
            get
            {
                return cursoMateria;
            }

            set
            {
                cursoMateria = value;
            }
        }
        public string NomeMateria
        {
            get
            {
                return nomeMateria;
            }

            set
            {
                nomeMateria = value;
            }
        }

        public int IdMateria
        {
            get
            {
                return idMateria;
            }

            set
            {
                idMateria = value;
            }
        }

        public bool Cadastrar()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();

                string insert = "INSERT INTO materia (idCurso, nomeMateria) VALUES('" + curso.IdCurso + "', '" + nomeMateria + "');select last_insert_id() AS id; '";

                comando.CommandText = insert;

                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                IdMateria = int.Parse(reader["ID"].ToString());
                return true;
            }

            //MENSAGEM CASO DE ALGUM ERRO
            catch (Exception)
            {
                return false;
            }
        }

        public bool ObterMateria()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM materia WHERE nomeMateria='" + nomeMateria + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Turma turma = new Turma();
                    reader.Read();
                    IdMateria = Convert.ToInt32(reader["idMateria"]);
                    cursoMateria = reader["idCurso"].ToString();
                    nomeMateria = reader["nomeMateria"].ToString();
                    return true;
                }
                return false;

                //TRATAMENTO DO ERRO
                //TENTA EXECUTAR UMA SEQUÊNCIA DE CÓDIGO
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ObterMateria2()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM materia WHERE idCurso='" + cursoMateria + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Turma turma = new Turma();
                    reader.Read();
                    IdMateria = Convert.ToInt32(reader["idMateria"]);
                    cursoMateria = reader["idCurso"].ToString();
                    nomeMateria = reader["nomeMateria"].ToString();
                    return true;
                }
                return false;

                //TRATAMENTO DO ERRO
                //TENTA EXECUTAR UMA SEQUÊNCIA DE CÓDIGO
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
