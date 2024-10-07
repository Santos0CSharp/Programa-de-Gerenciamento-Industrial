using System;
using System.Collections.Generic;
using Npgsql; // Biblioteca para trabalhar com PostgreSQL

// Classe para gerenciar o contexto geral
public class ContextoVendas
{
    private string connectionString;

    public ContextoVendas(string connString)
    {
        connectionString = connString;
    }

    // Método para adicionar um cliente
    public void AdicionarCliente(Cliente cliente)
    {
        try
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Cliente (Nome, Endereco, Cidade, Estado, CEP, Telefone, Email) VALUES (@Nome, @Endereco, @Cidade, @Estado, @CEP, @Telefone, @Email)", conn))
                {
                    // Validação básica antes de inserir no banco de dados
                    if (string.IsNullOrEmpty(cliente.Nome) || string.IsNullOrEmpty(cliente.Telefone) || string.IsNullOrEmpty(cliente.Email))
                    {
                        throw new ArgumentException("Nome, Telefone e Email são obrigatórios.");
                    }

                    // Adicionando parâmetros ao comando
                    cmd.Parameters.AddWithValue("Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("Endereco", cliente.Endereco);
                    cmd.Parameters.AddWithValue("Cidade", cliente.Cidade);
                    cmd.Parameters.AddWithValue("Estado", cliente.Estado);
                    cmd.Parameters.AddWithValue("CEP", cliente.CEP);
                    cmd.Parameters.AddWithValue("Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("Email", cliente.Email);
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Cliente adicionado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao adicionar cliente: {ex.Message}");
        }
    }

    // Método para adicionar uma indústria
    public void AdicionarIndustria(Industria industria)
    {
        try
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Industria (Nome_Industria, Tipo_Industria, Endereco, Cidade, Estado, CEP, Telefone, Email) VALUES (@NomeIndustria, @TipoIndustria, @Endereco, @Cidade, @Estado, @CEP, @Telefone, @Email)", conn))
                {
                    // Validação básica antes de inserir no banco de dados
                    if (string.IsNullOrEmpty(industria.NomeIndustria) || string.IsNullOrEmpty(industria.Telefone) || string.IsNullOrEmpty(industria.Email))
                    {
                        throw new ArgumentException("Nome da Indústria, Telefone e Email são obrigatórios.");
                    }

                    // Adicionando parâmetros ao comando
                    cmd.Parameters.AddWithValue("NomeIndustria", industria.NomeIndustria);
                    cmd.Parameters.AddWithValue("TipoIndustria", industria.TipoIndustria);
                    cmd.Parameters.AddWithValue("Endereco", industria.Endereco);
                    cmd.Parameters.AddWithValue("Cidade", industria.Cidade);
                    cmd.Parameters.AddWithValue("Estado", industria.Estado);
                    cmd.Parameters.AddWithValue("CEP", industria.CEP);
                    cmd.Parameters.AddWithValue("Telefone", industria.Telefone);
                    cmd.Parameters.AddWithValue("Email", industria.Email);
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Indústria adicionada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao adicionar indústria: {ex.Message}");
        }
    }

    // Método para obter todos os clientes
    public List<Cliente> ObterClientes()
    {
        List<Cliente> clientes = new List<Cliente>();

        try
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Cliente", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cliente = new Cliente
                        {
                            ID_Cliente = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Endereco = reader.GetString(2),
                            Cidade = reader.GetString(3),
                            Estado = reader.GetString(4),
                            CEP = reader.GetString(5),
                            Telefone = reader.GetString(6),
                            Email = reader.GetString(7)
                        };
                        clientes.Add(cliente);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter clientes: {ex.Message}");
        }

        return clientes;
    }

    // Método para obter todas as indústrias
    public List<Industria> ObterIndustrias()
    {
        List<Industria> industrias = new List<Industria>();

        try
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Industria", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var industria = new Industria
                        {
                            ID_Industria = reader.GetInt32(0),
                            NomeIndustria = reader.GetString(1),
                            TipoIndustria = reader.GetString(2),
                            Endereco = reader.GetString(3),
                            Cidade = reader.GetString(4),
                            Estado = reader.GetString(5),
                            CEP = reader.GetString(6),
                            Telefone = reader.GetString(7),
                            Email = reader.GetString(8)
                        };
                        industrias.Add(industria);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter indústrias: {ex.Message}");
        }

        return industrias;
    }

    // Método de teste para adicionar cliente e indústria
    public void TestarOperacoes()
    {
        // Adicionando um novo cliente
        var novoCliente = new Cliente
        {
            Nome = "João da Silva",
            Endereco = "Avenida Central, 123",
            Cidade = "São Paulo",
            Estado = "SP",
            CEP = "12345-678",
            Telefone = "99999-9999",
            Email = "joao@email.com"
        };

        AdicionarCliente(novoCliente);

        // Adicionando uma nova indústria
        var novaIndustria = new Industria
        {
            NomeIndustria = "Indústria X",
            TipoIndustria = "Alimentos",
            Endereco = "Rua das Flores, 456",
            Cidade = "Campinas",
            Estado = "SP",
            CEP = "98765-432",
            Telefone = "88888-8888",
            Email = "contato@industriax.com"
        };

        AdicionarIndustria(novaIndustria);
    }
}

// Classe representando um Cliente
public class Cliente
{
    public int ID_Cliente { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

// Classe representando uma Indústria
public class Industria
{
    public int ID_Industria { get; set; }
    public string NomeIndustria { get; set; }
    public string TipoIndustria { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}
