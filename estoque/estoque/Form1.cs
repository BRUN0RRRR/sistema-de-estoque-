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
    public partial class Form1 : Form
    {
        // String de conexão com o banco de dados
        private string connectionString = "SERVER=localhost;DATABASE=petroecoti;UID=root;PASSWORD= ;";

        public Form1()
        {
            InitializeComponent();
            inventario.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            consumo.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            panelconsumo.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            panelinventario.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

        }

        // Evento que é disparado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Método para carregar os dados do inventário no DataGridView 'inventario'
        private void CarregarInventario()
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open(); // Abre a conexão

                    string query = "select nome_produtos as 'Produtos', quantidade_atual as 'Quantidade Atual', marca as \"Marca\" , data_entrada as \"Data de Entrada\" from estoque;"; // Query para buscar os dados do inventário
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexao); // Adaptador para preencher o DataTable
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Preenche o DataTable com os dados do banco

                    inventario.DataSource = dt; // Exibe os dados no DataGridView de inventário
                    //MessageBox.Show("Dados do inventário carregados com sucesso!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao carregar dados do inventário: {ex.Message}");
                }
                finally
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close(); // Fecha a conexão
                    }
                }
            }
        }

        // Método para carregar os dados do consumo no DataGridView 'consumo'
        private void CarregarConsumo()
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open(); // Abre a conexão

                    string query = "select colaborador as 'Usuario', nome_produtos as \"Nome Produtos\", quantidade_saida as \"Quantidade\", data_saida as 'Data' from estoque_saida ;"; // Query para buscar os dados do consumo
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexao); // Adaptador para preencher o DataTable
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Preenche o DataTable com os dados do banco

                    consumo.DataSource = dt; // Exibe os dados no DataGridView de consumo
                    //MessageBox.Show("Dados do consumo carregados com sucesso!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao carregar dados do consumo: {ex.Message}");
                }
                finally
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close(); // Fecha a conexão
                    }
                }
            }
        }

        // Eventos dos DataGridView (opcionais)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            CarregarConsumo();
            CarregarInventario();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void consumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 telacad = new Form2();
            telacad.ShowDialog();
        }

        private void btnatual_Click(object sender, EventArgs e)
        {
            CarregarConsumo();
            CarregarInventario();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 telabaixa = new Form3();
            telabaixa.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 telaeditar = new Form4();
            telaeditar.ShowDialog();
        }
    }
}
