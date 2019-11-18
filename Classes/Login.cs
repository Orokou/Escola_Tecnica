using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Classes
{
    public class Login
    {
        //ATRIBUTOS
        int idAssistente;
        string email, senha;

        //GETTERS E SETTERS
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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        //VERIFICA LOGIN DO ALUNO
        public bool VerificarAluno()
        {
            try
            {
                //CRIANDO CONEXÃO
                string Conexao = "Server=localhost; port=3306; Database=db_escola; User ID=root;";
                var connection = new MySqlConnection(Conexao);
                var comand = connection.CreateCommand();
                MySqlCommand query = new MySqlCommand("SELECT COUNT(*) FROM aluno WHERE emailAluno = '" + email + "' and senhaAluno ='" + senha + "'", connection);

                connection.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach (DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            //MENSAGEM CASO DE ALGUM ERRO
            catch (Exception)
            {
                
                return false;
            }
        }

        //VERIFICA LOGIN DO PROFESSOR
        public bool VerificarProfessor()
        {
            try
            {
                //CRIANDO CONEXÃO
                string Conexao = "Server=localhost; port=3306; Database=db_escola; User ID=root;";
                var connection = new MySqlConnection(Conexao);
                var comand = connection.CreateCommand();
                MySqlCommand query = new MySqlCommand("SELECT COUNT(*) FROM professor WHERE emailProfessor = '" + email + "' and senhaProfessor ='" + senha + "'", connection);

                connection.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach (DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                }
                return true;
            }
            //MENSAGEM CASO DE ALGUM ERRO
            catch (Exception)
            {
                
                return false;
            }
        }

        //VERIFICA LOGIN DO ASSISTENTE
        public bool VerificarAssistente()
        {
            try
            {
                //CRIANDO CONEXÃO
                string Conexao = "Server=localhost; port=3306; Database=db_escola; User ID=root;";
                var connection = new MySqlConnection(Conexao);
                var comand = connection.CreateCommand();
                MySqlCommand query = new MySqlCommand("SELECT COUNT(*) FROM loginAssistente WHERE emailAssistente = '" + email + "' and senhaAssistente ='" + senha + "'", connection);

                connection.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach (DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            //MENSAGEM CASO DE ALGUM ERRO
            catch (Exception)
            {
               
                return false;
            }
        }
    }
}
