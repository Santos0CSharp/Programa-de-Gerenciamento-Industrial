using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Programa_de_Gerenciamento_Industrial
{
    public partial class Form3 : Form
    {
        // String de conexão com o banco de dados
        private string connectionString = "Host=aws-0-sa-east-1.pooler.supabase.com;Port=6543;Username=postgres.stjotefgyhrhlobwldqs;Password=Q9nWPZV8.reuyMC;Database=postgres";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarLotes(); // Chama o método para carregar os dados
        }

        private void CarregarLotes()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_lote, nome_lote, data_criacao, status FROM lotes"; // Substitua "lotes" pelo nome real da tabela
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Renomear a coluna "nome_lote" para "conteudo"
                            dt.Columns["nome_lote"].ColumnName = "conteudo";

                            // Atualiza o DataGridView
                            dataGridViewLotes.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os lotes: {ex.Message}");
            }
        }

        private void dataGridViewLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para lidar com o clique nas células do DataGridView, se necessário
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adicionar lote
            // Aqui você pode abrir um formulário para adicionar um novo lote
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Atualizar
            CarregarLotes(); // Recarrega os lotes do banco de dados
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Editar lote
            // Aqui você pode abrir um formulário para editar um lote selecionado
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Excluir lote
            // Lógica para excluir o lote selecionado
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Sair do form (Apenas deixa esse form invisível)
            this.Hide(); // Alternativamente, você pode usar Close() se quiser fechar o formulário
        }
    }
}
