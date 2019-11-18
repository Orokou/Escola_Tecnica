using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Classes
{
    public class Curso
    {
        int idCurso, cargaHoraria;
        string nomeCurso;

        public int IdCurso
        {
            get
            {
                return idCurso;
            }

            set
            {
                idCurso = value;
            }
        }

        public string NomeCurso
        {
            get
            {
                return nomeCurso;
            }

            set
            {
                nomeCurso = value;
            }
        }
      
        public int CargaHoraria
        {
            get
            {
                return cargaHoraria;
            }

            set
            {
                cargaHoraria = value;
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

                string insert = "INSERT INTO curso (nomeCurso, cargaHoraria) VALUES('"+ nomeCurso +"', '"+ cargaHoraria + "');select last_insert_id() AS id; '";

                comando.CommandText = insert;

                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                idCurso = int.Parse(reader["ID"].ToString());
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
                string update = "UPDATE curso SET nomeCurso ='" + nomeCurso + "', cargaHoraria ='" + cargaHoraria + "' WHERE idCurso = " + idCurso + ";";
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
                string delete = "delete from curso where nomeCurso = '" + nomeCurso + "';";
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
                string select = "SELECT * FROM curso";

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

        //OBTER ATRIBUTOS DE CURSO
        public bool ObterCurso()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM curso WHERE nomeCurso='" + nomeCurso + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Turma turma = new Turma();
                    reader.Read();
                    idCurso = Convert.ToInt32(reader["idCurso"]);
                    nomeCurso = reader["nomeCurso"].ToString();
                    cargaHoraria = Convert.ToInt32(reader["cargaHoraria"]);
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

        public bool ObterCurso2()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM curso WHERE idCurso='" + idCurso + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Turma turma = new Turma();
                    reader.Read();
                    idCurso = Convert.ToInt32(reader["idCurso"]);
                    nomeCurso = reader["nomeCurso"].ToString();
                    cargaHoraria = Convert.ToInt32(reader["cargaHoraria"]);
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
