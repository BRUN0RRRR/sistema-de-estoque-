using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace estoque
{
    public partial class Form4 : Form
    {
        // String de conexão com o banco de dados
        private string connectionString = "SERVER=localhost;DATABASE=petroecoti;UID=root;PASSWORD= ;";

        public Form4()
        {
            InitializeComponent();
            CarregarProdutos(); // Carrega os produtos no ComboBox ao abrir o formulário
        }

        // Método para carregar produtos no ComboBox
        private void CarregarProdutos()
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM estoque";
                try
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                           
                            while (reader.Read())
                            {
                                Produto.Items.Add(reader["nome_produtos"].ToString());

                          
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
        private void comboBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string produtoSelecionado = Produto.SelectedItem?.ToString();
            CarregarDadosProduto(produtoSelecionado); // Carrega os dados do produto nos campos de edição
        }

        // Método para carregar dados do produto nos campos de edição
        private void CarregarDadosProduto(string nomeProduto)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT nome_produtos, marca FROM estoque WHERE nome_produtos = @nome";
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
                                edit_produto.Text = reader["nome_produtos"].ToString();
                                edit_marca.Text = reader["marca"].ToString();
                                
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

        // Método para editar informações do produto
        private void EditarProduto()
        {
            string produtoSelecionado = Produto.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(produtoSelecionado))
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string queryAtualizar = "UPDATE estoque SET nome_produtos = @novoNome, marca = @novaMarca WHERE nome_produtos = @nome";

                try
                {
                    conexao.Open();
                    using (MySqlCommand cmdAtualizar = new MySqlCommand(queryAtualizar, conexao))
                    {
                        cmdAtualizar.Parameters.AddWithValue("@nome", produtoSelecionado);
                        cmdAtualizar.Parameters.AddWithValue("@novoNome", edit_produto.Text); // Novo nome do produto
                        cmdAtualizar.Parameters.AddWithValue("@novaMarca", edit_marca.Text); // Nova marca
                        


                        int resultado = cmdAtualizar.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Informações do produto atualizadas com sucesso.");
                            Produto.Items.Clear(); // Limpa o ComboBox
                            CarregarProdutos(); // Recarrega a lista de produtos
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar as informações do produto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar produto: {ex.Message}");
                }
            }
        }

        // Evento do botão de editar
        private void button1_Click(object sender, EventArgs e)
        {
            EditarProduto(); // Chama o método para editar o produto ao clicar no botão
        }
    }
}
