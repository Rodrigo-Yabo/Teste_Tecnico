using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Teste_tecnico.Controllers.Factory;
using Teste_tecnico.Models;



namespace Teste_tecnico.Controllers
{
    public abstract class ManipulaInfoBD : IManipulaInfo
    {
       
        private static List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        public bool Adicionar(Fornecedor fornecedor)
        {
            if (fornecedor == null)
                throw new ArgumentNullException(nameof(fornecedor));

            string comandoSql;
            var parametros = new List<MySqlParameter>();

            if (fornecedor.Id == 0)
            {
                comandoSql = @"INSERT INTO fornecedor 
                      (NomeRazao, CNPJ, Telefone, Email, NomeResponsavel, 
                       Rua, Numero, Bairro, Cidade, Estado, Cep) 
                      VALUES 
                      (@nome, @cnpj, @telefone, @email, @nomeResponsavel, 
                       @rua, @numero, @bairro, @cidade, @estado, @cep)";
            }
            else
            {
                comandoSql = @"UPDATE fornecedor SET
                      NomeRazao = @nome,
                      CNPJ = @cnpj,
                      Telefone = @telefone,
                      Email = @email,
                      NomeResponsavel = @nomeResponsavel,
                      Rua = @rua,
                      Numero = @numero,
                      Bairro = @bairro,
                      Cidade = @cidade,
                      Estado = @estado,
                      Cep = @cep
                      WHERE Id = @id";

                parametros.Add(new MySqlParameter("@id", fornecedor.Id));
            }

            
            parametros.AddRange(new[]
            {
        new MySqlParameter("@nome", fornecedor.Nome ?? (object)DBNull.Value),
        new MySqlParameter("@cnpj", fornecedor.CNPJ ?? (object)DBNull.Value),
        new MySqlParameter("@telefone", fornecedor.Telefone ?? (object)DBNull.Value),
        new MySqlParameter("@email", fornecedor.Email ?? (object)DBNull.Value),
        new MySqlParameter("@nomeResponsavel", fornecedor.NomeResponsavel ?? (object)DBNull.Value),
        new MySqlParameter("@rua", fornecedor.Rua ?? (object)DBNull.Value),
        new MySqlParameter("@numero", fornecedor.Numero ?? (object)DBNull.Value),
        new MySqlParameter("@bairro", fornecedor.Bairro ?? (object)DBNull.Value),
        new MySqlParameter("@cidade", fornecedor.Cidade ?? (object)DBNull.Value),
        new MySqlParameter("@estado", fornecedor.Estado ?? (object)DBNull.Value),
        new MySqlParameter("@cep", fornecedor.Cep ?? (object)DBNull.Value)
    });

            try
            {
                using (var connection = SingletonConnection.GetInstance().GetConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    using (var command = new MySqlCommand(comandoSql, (MySqlConnection)connection, transaction))
                    {
                        try
                        {
                            command.Parameters.AddRange(parametros.ToArray());
                            int linhasAfetadas = command.ExecuteNonQuery();
                            transaction.Commit();
                            return linhasAfetadas > 0;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Log específico para erros MySQL
                Console.WriteLine($"Erro MySQL ({ex.Number}): {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Log genérico
                Console.WriteLine($"Erro ao salvar fornecedor: {ex.Message}");
                return false;
            }
        }

        public int Remover(Fornecedor pfornecedor)
        {
 
            return SingletonConnection.GetInstance().ExecuteSemSelect($"delete from fornecedor where Id = {pfornecedor.Id}");
        }

        public List<Fornecedor> ListaFornecedor()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            DataTable dt = SingletonConnection.GetInstance().ExecuteSelect("SELECT * FROM fornecedor");

            foreach (DataRow row in dt.Rows) // Percorrendo o DataTable
            {
                Fornecedor fornecedor = new Fornecedor
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nome = row["NomeRazao"].ToString(),
                    CNPJ = row["CNPJ"].ToString(),
                    Telefone = row["Telefone"].ToString(),
                    Email = row["Email"].ToString(),
                    NomeResponsavel = row["NomeResponsavel"].ToString(),
                    Rua = row["Rua"].ToString(),
                    Numero = row["Numero"].ToString(),
                    Bairro = row["Bairro"].ToString(),
                    Cidade = row["Cidade"].ToString(),
                    Estado = row["Estado"].ToString(),
                    Cep = (row["Cep"].ToString())
                };

                fornecedores.Add(fornecedor);
            }

            return fornecedores; // Retorna a lista de fornecedores
        }
        

    }

}
