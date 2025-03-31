using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Teste_tecnico.Controllers
{
    public class SingletonConnection 
    {
        private static SingletonConnection _instance;
        private static readonly Object _lock = new Object();
        private MySqlConnection _connection;

        // string de conexao com o banco.
        private readonly string _connectionString = "Server= 127.0.0.1;Database=Teste_Tecnico;User Id=root;Password=root;";

        private SingletonConnection()
        {
            try
            {
                _connection = new MySqlConnection(_connectionString);
                _connection.Open();
                MessageBox.Show("Conexao Com banco estabelecida");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexao" + ex.Message);
            }
        }
        public static SingletonConnection GetInstance()
        {
            if (_instance == null)

                lock (_lock) // garente segurança em mult -threading
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonConnection();
                    }
                }
            return _instance;
        }
        public  MySqlConnection GetConnection()
        {
            return _connection;
        }
       

        public DataTable ExecuteSelect(String query)
        {
           try
           {
                    MySqlCommand cmd = new MySqlCommand(query, _connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
           }
           catch (Exception ex)
           {
                MessageBox.Show("Erro em executar consulta:" + ex.Message);
                    return null;
           }

        }

        public int ExecuteSemSelect(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando" + ex.Message);
                return -1;
            }
        }




    }

}
    


