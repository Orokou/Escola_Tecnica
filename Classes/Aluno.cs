using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Classes
{
    public class Aluno
    {
        int idAluno;
        long cpfAluno, telefoneAluno, celularAluno, numeroAluno, cep;
        string nomeAluno, emailAluno, senhaAluno, ruaAluno, bairroAluno, cidadeAluno, turmaAluno;
        public Turma turma;
        DateTime dataNasc;

        public Aluno()
        {
            turma = new Turma();
        }

        //MÉTODOS
        //GETTERS E SETTERS
        public int IdAluno
        {
            get
            {
                return idAluno;
            }

            set
            {
                idAluno = value;
            }
        }
        public long CpfAluno
        {
            get
            {
                return cpfAluno;
            }

            set
            {
                cpfAluno = value;
            }
        }
        public long TelefoneAluno
        {
            get
            {
                return telefoneAluno;
            }

            set
            {
                telefoneAluno = value;
            }
        }
        public long CelularAluno
        {
            get
            {
                return celularAluno;
            }

            set
            {
                celularAluno = value;
            }
        }
        public long NumeroAluno
        {
            get
            {
                return numeroAluno;
            }

            set
            {
                numeroAluno = value;
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
        public string EmailAluno
        {
            get
            {
                return emailAluno;
            }

            set
            {
                emailAluno = value;
            }
        }
        public string SenhaAluno
        {
            get
            {
                return senhaAluno;
            }

            set
            {
                senhaAluno = value;
            }
        }
        public string RuaAluno
        {
            get
            {
                return ruaAluno;
            }

            set
            {
                ruaAluno = value;
            }
        }
        public string BairroAluno
        {
            get
            {
                return bairroAluno;
            }

            set
            {
                bairroAluno = value;
            }
        }
        public string CidadeAluno
        {
            get
            {
                return cidadeAluno;
            }

            set
            {
                cidadeAluno = value;
            }
        }
        public string TurmaAluno
        {
            get
            {
                return turmaAluno;
            }

            set
            {
                turmaAluno = value;
            }
        }

        public long Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
            }
        }

        //CADASTRO ALUNO
        public bool Cadastrar()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();
                MySqlCommand comando = connection.CreateCommand();


                string insert = "INSERT INTO aluno (cpfAluno, nomeAluno, telefoneAluno, celularAluno, emailAluno, senhaAluno, ruaAluno, numeroAluno, bairroAluno, cidadeAluno, idTurma, cepAluno, dataNasc) VALUES('" + cpfAluno + "', '" + nomeAluno + "', '" + telefoneAluno + "', '" + celularAluno + "', '" + emailAluno + "', '" + senhaAluno + "', '" + ruaAluno + "', '" + numeroAluno + "', '" + bairroAluno + "', '" + cidadeAluno + "', '" + turma.IdTurma + "', '" + cep + "', '" + dataNasc.ToString("yyyy-MM-dd") + "'); select last_insert_id() AS id;'";
                comando.CommandText = insert;

                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                idAluno = int.Parse(reader["ID"].ToString());
                return true;
            }
            //MENSAGEM CASO DE ALGUM ERRO
            catch (Exception)
            {
                return false;
            }
        }
        //EDITAR DADOS DO ALUNO
        public bool Editar()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string update = "UPDATE aluno SET cpfAluno ='" + cpfAluno + "', nomeAluno ='" + nomeAluno + "', telefoneAluno ='" + telefoneAluno + "', celularAluno = '" + celularAluno + "', emailAluno ='" + emailAluno + "', senhaAluno = '" + senhaAluno + "', ruaAluno = '" + ruaAluno + "', numeroAluno = '" + numeroAluno + "', bairroAluno = '" + bairroAluno + "', cidadeAluno = '" + cidadeAluno + "', cepAluno ='" + cep + "', dataNasc ='" + dataNasc.ToString("yyyy-MM-dd") + "', idTurma ='" + turma.IdTurma + "' WHERE cpfAluno = " + cpfAluno + ";";
                comando.CommandText = update;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
               

                return false;
            }
        }

        public bool EditarSenha()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string update = "UPDATE aluno SET senhaAluno ='" + senhaAluno + "' WHERE idAluno = " + idAluno + ";";
                comando.CommandText = update;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                

                return false;
            }
        }

        public bool EditarEmail()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string update = "UPDATE aluno SET emailAluno ='" + emailAluno + "' WHERE IdAluno = " + idAluno + ";";
                comando.CommandText = update;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
              

                return false;
            }
        }
        //EXCLUIR ALUNO
        public bool Excluir()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string delete = "delete from aluno where nomeAluno = '" + nomeAluno + "';";
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
                string select = "select a.idAluno,a.cpfAluno,a.nomeAluno,a.telefoneAluno,a.celularAluno,a.emailAluno,a.senhaAluno,a.ruaAluno,a.numeroAluno,a.bairroAluno,a.cidadeAluno,a.cepAluno,a.dataNasc,t.nomeTurma from aluno a join turma t on a.idTurma = t.idTurma;";

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

        public MySqlDataReader Listar2()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "select a.idAluno,a.cpfAluno,a.nomeAluno,a.telefoneAluno,a.celularAluno,a.emailAluno,a.senhaAluno,a.ruaAluno,a.numeroAluno,a.bairroAluno,a.cidadeAluno,a.cepAluno,a.dataNasc,t.nomeTurma from aluno a join turma t on a.idTurma = t.idTurma where nomeTurma= '" + TurmaAluno + "';";

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
        //OBTER ATRIBUTOS DE ALUNO
        public bool ObterAluno()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM aluno WHERE nomeAluno='" + nomeAluno + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Aluno aluno = new Aluno();
                    reader.Read();
                    idAluno = Convert.ToInt32(reader["idAluno"]);
                    nomeAluno = reader["nomeAluno"].ToString();
                    numeroAluno = Convert.ToInt64(reader["numeroAluno"]);
                    telefoneAluno = Convert.ToInt64(reader["telefoneAluno"]);
                    cpfAluno = Convert.ToInt64(reader["cpfAluno"]);
                    emailAluno = reader["emailAluno"].ToString();
                    senhaAluno = reader["senhaAluno"].ToString();
                    ruaAluno = reader["ruaAluno"].ToString();
                    bairroAluno = reader["bairroAluno"].ToString();
                    cidadeAluno = reader["cidadeAluno"].ToString();
                    celularAluno = Convert.ToInt64(reader["celularAluno"]);
                    cep = Convert.ToInt64(reader["cepAluno"]);
                    dataNasc = Convert.ToDateTime(reader["dataNasc"]);

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
        public bool ObterAluno2()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM aluno WHERE emailAluno='" + emailAluno + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Aluno aluno = new Aluno();
                    reader.Read();
                    idAluno = Convert.ToInt32(reader["idAluno"]);
                    nomeAluno = reader["nomeAluno"].ToString();
                    numeroAluno = Convert.ToInt64(reader["numeroAluno"]);
                    telefoneAluno = Convert.ToInt64(reader["telefoneAluno"]);
                    cpfAluno = Convert.ToInt64(reader["cpfAluno"]);
                    emailAluno = reader["emailAluno"].ToString();
                    senhaAluno = reader["senhaAluno"].ToString();
                    ruaAluno = reader["ruaAluno"].ToString();
                    bairroAluno = reader["bairroAluno"].ToString();
                    cidadeAluno = reader["cidadeAluno"].ToString();
                    turmaAluno = reader["idTurma"].ToString();
                    celularAluno = Convert.ToInt64(reader["celularAluno"]);
                    cep = Convert.ToInt64(reader["cepAluno"]);
                    dataNasc = Convert.ToDateTime(reader["dataNasc"]);

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
