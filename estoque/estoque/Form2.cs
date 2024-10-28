using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque
{
    public partial class Form2 : Form
    {
        // String de conexão com o banco de dados
        private string connectionString = "SERVER=localhost;DATABASE=petroecoti;UID=root;PASSWORD= ;";

        public Form2()
        {
            InitializeComponent();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                   // MessageBox.Show("Conexão bem-sucedida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }

        }

        // Método para cadastrar produtos no banco de dados
        private void cadastrarProdutos()
        {
            // Pega os valores dos inputs
            string nomeProduto = nomeProdu.Text;        // Campo de nome do produto
            string marcaProduto = marcaProd.Text;       // Campo de marca do produto
            int quantidadeProduto;                      // Campo de quantidade do produto
            DateTime dataEntrada = dataProd.Value;      // Campo de data de entrada (DateTimePicker)

            // Verifica se a quantidade é um número válido
            if (!int.TryParse(quantidadeProd.Text, out quantidadeProduto))
            {
                MessageBox.Show("Insira uma quantidade válida.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // String de inserção no banco de dados
            string query = "INSERT INTO estoque (nome_produtos, marca, quantidade_atual, data_entrada) VALUES (@nome, @marca, @quantidade, @dataEntrada);";

            // Conexão com o banco de dados
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open(); // Abre a conexão com o banco

                    // Cria o comando de execução da query
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        // Adiciona os parâmetros à query
                        cmd.Parameters.AddWithValue("@nome", nomeProduto);
                        cmd.Parameters.AddWithValue("@marca", marcaProduto);
                        cmd.Parameters.AddWithValue("@quantidade", quantidadeProduto);
                        cmd.Parameters.AddWithValue("@dataEntrada", dataEntrada.ToString("yyyy-MM-dd"));

                        // Executa o comando de inserção
                        int result = cmd.ExecuteNonQuery();

                        // Verifica se a inserção foi bem-sucedida
                        if (result > 0)
                        {
                           MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Exibe mensagem de erro caso a conexão ou inserção falhe
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Fecha a conexão com o banco
                    if (conexao.State == System.Data.ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
        }

        // Evento do botão de cadastro
        private void btnCadas_Click(object sender, EventArgs e)
        {
            cadastrarProdutos(); // Chama o método para cadastrar os produtos quando o botão é clicado
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
