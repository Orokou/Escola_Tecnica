using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Classes
{
    public class Professor
    {
        int idProfessor;
        long cpfProfessor, telefoneProfessor, celularProfessor, numeroProfessor, cep;
        string nomeProfessor, emailProfessor, senhaProfessor, ruaProfessor, bairroProfessor, cidadeProfessor, turmaProfessor;
        public Turma turma;
        DateTime dataNasc;

        public Professor()
        {
            turma = new Turma();
        }

        public int IdProfessor
        {
            get
            {
                return idProfessor;
            }

            set
            {
                idProfessor = value;
            }
        }

        public long CpfProfessor
        {
            get
            {
                return cpfProfessor;
            }

            set
            {
                cpfProfessor = value;
            }
        }

        public long TelefoneProfessor
        {
            get
            {
                return telefoneProfessor;
            }

            set
            {
                telefoneProfessor = value;
            }
        }

        public long CelularProfessor
        {
            get
            {
                return celularProfessor;
            }

            set
            {
                celularProfessor = value;
            }
        }

        public long NumeroProfessor
        {
            get
            {
                return numeroProfessor;
            }

            set
            {
                numeroProfessor = value;
            }
        }

        public string NomeProfessor
        {
            get
            {
                return nomeProfessor;
            }

            set
            {
                nomeProfessor = value;
            }
        }

        public string EmailProfessor
        {
            get
            {
                return emailProfessor;
            }

            set
            {
                emailProfessor = value;
            }
        }

        public string SenhaProfessor
        {
            get
            {
                return senhaProfessor;
            }

            set
            {
                senhaProfessor = value;
            }
        }

        public string RuaProfessor
        {
            get
            {
                return ruaProfessor;
            }

            set
            {
                ruaProfessor = value;
            }
        }

        public string BairroProfessor
        {
            get
            {
                return bairroProfessor;
            }

            set
            {
                bairroProfessor = value;
            }
        }

        public string CidadeProfessor
        {
            get
            {
                return cidadeProfessor;
            }

            set
            {
                cidadeProfessor = value;
            }
        }

        public string TurmaProfessor
        {
            get
            {
                return turmaProfessor;
            }

            set
            {
                turmaProfessor = value;
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

                string insert = "INSERT INTO professor (cpfProfessor, nomeProfessor, telefoneProfessor, celularProfessor, emailProfessor, senhaProfessor, ruaProfessor, numeroProfessor, bairroProfessor, cidadeProfessor, idTurma, cepProfessor, dataNasc) VALUES('" + cpfProfessor + "', '" + nomeProfessor + "', '" + telefoneProfessor + "', '" + celularProfessor + "', '" + emailProfessor + "', '" + senhaProfessor + "', '" + ruaProfessor + "', '" + numeroProfessor + "', '" + bairroProfessor + "', '" + cidadeProfessor + "', '" + turma.IdTurma + "', '" + cep + "', '" + dataNasc.ToString("yyyy-MM-dd") + "');select last_insert_id() AS id; '";

                comando.CommandText = insert;

                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                idProfessor = int.Parse(reader["ID"].ToString());
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
                string update = "UPDATE professor SET cpfProfessor ='" + cpfProfessor + "', nomeProfessor ='" + nomeProfessor + "', telefoneProfessor ='" + telefoneProfessor + "', celularProfessor = '" + celularProfessor + "', emailProfessor ='" + emailProfessor + "', senhaProfessor = '" + senhaProfessor + "', ruaProfessor = '" + ruaProfessor + "', numeroProfessor = '" + numeroProfessor + "', bairroProfessor = '" + bairroProfessor + "', cidadeProfessor = '" + cidadeProfessor + "', cepProfessor ='" + cep + "', dataNasc ='" + dataNasc.ToString("yyyy-MM-dd") + "', idTurma ='" + turma.IdTurma + "' WHERE cpfProfessor = " + cpfProfessor + ";";
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
                string update = "UPDATE professor SET senhaProfessor ='" + senhaProfessor + "' WHERE idProfessor = " + idProfessor + ";";
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
                string update = "UPDATE professor SET emailProfessor ='" + emailProfessor + "' WHERE idProfessor = " + idProfessor + ";";
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
                string delete = "delete from professor where nomeProfessor = '" + nomeProfessor + "';";
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
                string select = "select p.idProfessor,p.cpfProfessor,p.nomeProfessor,p.telefoneProfessor,p.celularProfessor,p.emailProfessor,p.senhaProfessor,p.ruaProfessor,p.numeroProfessor,p.bairroProfessor,p.cidadeProfessor,p.cepProfessor,p.dataNasc,t.nomeTurma from professor p join turma t on p.idTurma = t.idTurma; ";

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
                string select = "SELECT * FROM professor where emailProfessor= '" + emailProfessor + "';";

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

        //OBTER ATRIBUTOS DE PROFESSOR
        public bool ObterProfessor()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM professor WHERE nomeProfessor='" + nomeProfessor + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    nomeProfessor = reader["nomeProfessor"].ToString();
                    numeroProfessor = Convert.ToInt64(reader["numeroProfessor"]);
                    telefoneProfessor = Convert.ToInt64(reader["telefoneProfessor"]);
                    cpfProfessor = Convert.ToInt64(reader["cpfProfessor"]);
                    emailProfessor = reader["emailProfessor"].ToString();
                    senhaProfessor = reader["senhaProfessor"].ToString();
                    ruaProfessor = reader["ruaProfessor"].ToString();
                    bairroProfessor = reader["bairroProfessor"].ToString();
                    cidadeProfessor = reader["cidadeProfessor"].ToString();
                    turmaProfessor = reader["idTurma"].ToString();
                    celularProfessor = Convert.ToInt64(reader["celularProfessor"]);
                    cep = Convert.ToInt64(reader["cepProfessor"]);
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
        public bool ObterProfessor2()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM professor WHERE emailProfessor='" + emailProfessor + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    idProfessor = Convert.ToInt32(reader["idProfessor"]);
                    nomeProfessor = reader["nomeProfessor"].ToString();
                    numeroProfessor = Convert.ToInt64(reader["numeroProfessor"]);
                    telefoneProfessor = Convert.ToInt64(reader["telefoneProfessor"]);
                    cpfProfessor = Convert.ToInt64(reader["cpfProfessor"]);
                    emailProfessor = reader["emailProfessor"].ToString();
                    senhaProfessor = reader["senhaProfessor"].ToString();
                    ruaProfessor = reader["ruaProfessor"].ToString();
                    bairroProfessor = reader["bairroProfessor"].ToString();
                    cidadeProfessor = reader["cidadeProfessor"].ToString();
                    turmaProfessor = reader["idTurma"].ToString();
                    celularProfessor = Convert.ToInt64(reader["celularProfessor"]);
                    cep = Convert.ToInt64(reader["cepProfessor"]);
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
