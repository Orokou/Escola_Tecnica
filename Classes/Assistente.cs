using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Classes
{
    public class Assistente
    {
        string emailAssistente, senhaAssistente;
        int idAssistente;

        public int IdAssistente
        {
            get
            {
                return idAssistente;
            }

            set
            {
                idAssistente = value;
            }
        }
        public string EmailAssistente
        {
            get
            {
                return emailAssistente;
            }

            set
            {
                emailAssistente = value;
            }
        }
        public string SenhalAssistente
        {
            get
            {
                return senhaAssistente;
            }

            set
            {
                senhaAssistente = value;
            }
        }

        public bool ObterAssistente()
        {
            try
            {
                //CRIANDO CONEXÃO
                string connectionString = "Server=localhost; port=3306; Database=db_escola; User ID=root;";


                MySqlConnection connection = new MySqlConnection(connectionString);

                //ABRIR CONEXÃO
                connection.Open();

                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM loginAssistente WHERE emailAssistente='" + emailAssistente + "';";

                comando.CommandText = select;

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    Aluno aluno = new Aluno();
                    reader.Read();
                    idAssistente = Convert.ToInt32(reader["idAssistente"]);
                    emailAssistente = reader["emailAssistente"].ToString();
                    senhaAssistente = reader["senhaAssistente"].ToString();

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
