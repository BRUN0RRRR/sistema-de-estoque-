using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace estoque
{
    public partial class Form3 : Form
    {
        // String de conexão com o banco de dados
        private string connectionString = "SERVER=localhost;DATABASE=petroecoti;UID=root;PASSWORD= ;";

        public Form3()
        {
            InitializeComponent();
            CarregarProdutos(); // Carrega os produtos no ComboBox ao abrir o formulário
        }

        // Método para carregar produtos no ComboBox
        private void CarregarProdutos()
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT nome_produtos FROM estoque";
                try
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                produtos.Items.Add(reader["nome_produtos"].ToString()); // Alterado para "produtos"
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
                }
            }
        }

        // Evento de seleção de produto no ComboBox
        private void produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string produtoSelecionado = produtos.SelectedItem.ToString();
            CarregarDadosProduto(produtoSelecionado); // Carrega os dados nos campos
        }

        // Método para carregar dados do produto nos TextBoxes e DateTimePicker
        private void CarregarDadosProduto(string nomeProduto)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM estoque WHERE nome_produtos = @nome";
                try
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeProduto);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nome.Text = reader["nome_colaborador"].ToString(); // Ajustado para carregar o nome do colaborador
                                quantidade.Text = reader["quantidade_atual"].ToString();
                                data.Value = Convert.ToDateTime(reader["data_entrada"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados do produto: {ex.Message}");
                }
            }
        }

        // Método para registrar saída de estoque e deletar produto
        private void RegistrarSaidaEAtualizarQuantidade()
        {
            string produtoSelecionado = produtos.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(produtoSelecionado))
            {
                MessageBox.Show("Selecione um produto para baixar.");
                return;
            }

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                // Consulta para obter a quantidade atual do produto
                string queryQuantidade = "SELECT quantidade_atual FROM estoque WHERE nome_produtos = @produto";
                // Consulta para registrar a saída
                string querySaida = "INSERT INTO estoque_saida (nome_produtos,colaborador, quantidade_saida, data_saida) VALUES (@produto, @colaborador, @quantidade, @data)";
                // Consulta para atualizar a quantidade no estoque
                string queryAtualizar = "UPDATE estoque SET quantidade_atual = @novaQuantidade WHERE nome_produtos = @produto";

                try
                {
                    conexao.Open();

                    // Obter a quantidade atual
                    int quantidadeAtual;
                    using (MySqlCommand cmdQuantidade = new MySqlCommand(queryQuantidade, conexao))
                    {
                        cmdQuantidade.Parameters.AddWithValue("@produto", produtoSelecionado);
                        quantidadeAtual = Convert.ToInt32(cmdQuantidade.ExecuteScalar());
                    }

                    // Verificar se a quantidade de saída não excede a quantidade atual
                    int quantidadeSaida = Convert.ToInt32(quantidade.Text);
                    if (quantidadeSaida > quantidadeAtual)
                    {
                        MessageBox.Show("Quantidade de saída não pode ser maior que a quantidade disponível.");
                        return;
                    }

                    // Registrar saída de estoque
                    using (MySqlCommand cmdSaida = new MySqlCommand(querySaida, conexao))
                    {
                        cmdSaida.Parameters.AddWithValue("@produto", produtoSelecionado);
                        cmdSaida.Parameters.AddWithValue("@colaborador", nome.Text);
                        cmdSaida.Parameters.AddWithValue("@quantidade", quantidadeSaida);
                        cmdSaida.Parameters.AddWithValue("@data", DateTime.Now);
                        cmdSaida.ExecuteNonQuery();
                    }

                    // Atualizar a quantidade no estoque
                    int novaQuantidade = quantidadeAtual - quantidadeSaida;
                    using (MySqlCommand cmdAtualizar = new MySqlCommand(queryAtualizar, conexao))
                    {
                        cmdAtualizar.Parameters.AddWithValue("@novaQuantidade", novaQuantidade);
                        cmdAtualizar.Parameters.AddWithValue("@produto", produtoSelecionado);
                        cmdAtualizar.ExecuteNonQuery();
                    }

                    MessageBox.Show("Saída registrada e quantidade atualizada com sucesso.");
                    produtos.Items.Clear(); // Limpa a ComboBox
                    CarregarProdutos(); // Recarrega a lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao registrar saída e atualizar quantidade: {ex.Message}");
                }
            }
        }

        // Evento do botão de baixar (deletar)
        private void btnBaixar_Click(object sender, EventArgs e)
        {
            RegistrarSaidaEAtualizarQuantidade(); // Chama o método para registrar saída e atualizar quantidade
        }
    }
}