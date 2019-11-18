using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Classes
{
    public class Turma
    {
        int idTurma;
        string nomeTurma, turno, cursoTurma;
        public Curso curso;

        public Turma()
        {
            curso = new Curso();
        }

        public int IdTurma
        {
            get
            {
                return idTurma;
            }

            set
            {
                idTurma = value;
            }
        }

        public string CursoTurma
        {
            get
            {
                return cursoTurma;
            }

            set
            {
                cursoTurma = value;
            }
        }

        public string NomeTurma
        {
            get
            {
                return nomeTurma;
            }

            set
            {
                nomeTurma = value;
            }
        }

        public string Turno
        {
            get
            {
                return turno;
            }

            set
            {
                turno = value;
            }
        }

        //CADASTRAR
        public bool Cadastrar()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();

                string insert = "INSERT INTO turma (nomeTurma, turno, idCurso) VALUES('" + nomeTurma + "', '" + turno + "', '" + curso.IdCurso + "');select last_insert_id() AS id; '";

                comando.CommandText = insert;

                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                idTurma = int.Parse(reader["ID"].ToString());
                return true;
            }
            //MENSAGEM CASO DE ALGUM ERRO
            catch (Exception)
            {
                return false;
            }
        }
        //ALTERAR DADOS
        public bool Editar()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string update = "UPDATE turma SET nomeTurma ='" + nomeTurma + "', turno ='" + turno + "', idCurso ='" + curso.IdCurso + "' WHERE idTurma = " + idTurma + ";";
                comando.CommandText = update;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                

                return false;
            }
        }

        //EXCLUIR
        public bool Excluir()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string delete = "delete from turma where nomeTurma = '" + nomeTurma + "';";
                comando.CommandText = delete;
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                

                return false;
            }
        }
        //LISTAR
        public MySqlDataReader Listar()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "select t.idTurma,t.nomeTurma,t.turno,c.nomeCurso from turma t join curso c on t.idCurso = c.idCurso;";


                comando.CommandText = select;

                return comando.ExecuteReader();

                //TRATAMENTO DO ERRO
                //TENTA EXECUTAR UMA SEQUÊNCIA DE CÓDIGO
            }
            catch (Exception)
            {
                return null;
            }
        }

        //OBTER ATRIBUTOS DE TURMA
        public bool ObterTurma()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM turma WHERE nomeTurma='" + nomeTurma + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Turma turma = new Turma();
                    reader.Read();
                    idTurma = Convert.ToInt32(reader["idTurma"]);
                    nomeTurma = reader["nomeTurma"].ToString();
                    cursoTurma = reader["idCurso"].ToString();
                    turno = reader["turno"].ToString();
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

        public bool ObterTurma2()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM turma WHERE idTurma='" + idTurma + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Turma turma = new Turma();
                    reader.Read();
                    idTurma = Convert.ToInt32(reader["idTurma"]);
                    nomeTurma = reader["nomeTurma"].ToString();
                    cursoTurma = reader["idCurso"].ToString();
                    turno = reader["turno"].ToString();
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
