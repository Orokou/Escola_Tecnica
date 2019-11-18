using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Classes
{
    public class Notas
    {
        int idNota, nota;
        string nomeAluno, nomeMateria;
        public Aluno aluno;
        public Materia materia;

        public Notas()
        {
            aluno = new Aluno();
            materia = new Materia();
        }

        public int Nota
        {
            get
            {
                return nota;
            }

            set
            {
                nota = value;
            }
        }
        public string NomeAluno
        {
            get
            {
                return nomeAluno;
            }

            set
            {
                nomeAluno = value;
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
        public int IdNota
        {
            get
            {
                return idNota;
            }

            set
            {
                idNota = value;
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

                string insert = "INSERT INTO nota (idAluno, idMateria, nota) VALUES('" + aluno.IdAluno + "', '" + materia.IdMateria + "', '" + nota + "');select last_insert_id() AS id; '";

                comando.CommandText = insert;

                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                idNota = int.Parse(reader["ID"].ToString());
                return true;
            }
            //MENSAGEM CASO DE ALGUM ERRO
            catch (Exception)
            {
                return false;
            }
        }

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
                string select = "select n.nota,m.nomeMateria from nota n join materia m on n.idMateria = m.idMateria where idAluno = '" + nomeAluno +"';";

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
        public bool ObterNota()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM nota WHERE idMateria='" + NomeMateria + "' and idAluno='" + NomeAluno + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Turma turma = new Turma();
                    reader.Read();
                    IdNota = Convert.ToInt32(reader["idNota"]);
                    nomeAluno = reader["idAluno"].ToString();
                    NomeMateria = reader["idMateria"].ToString();
                    nota = Convert.ToInt32(reader["nota"]);
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

        public bool ObterNota2()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM nota WHERE idMateria='" + NomeMateria + "' and idAluno='" + NomeAluno + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Turma turma = new Turma();
                    reader.Read();
                    IdNota = Convert.ToInt32(reader["idNota"]);
                    nomeAluno = reader["idAluno"].ToString();
                    NomeMateria = reader["idMateria"].ToString();
                    nota = Convert.ToInt32(reader["nota"]);
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
        public bool Editar()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string update = "UPDATE nota SET nota ='" + nota + "' WHERE idMateria='" + NomeMateria + "' and idAluno='" + NomeAluno + "';";
                comando.CommandText = update;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {


                return false;
            }
        }
    }
}
