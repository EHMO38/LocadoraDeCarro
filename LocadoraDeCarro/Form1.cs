using System.Data;
using System.Data.SqlClient;

namespace LocadoraDeCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAlugar_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\olive\\source\\repos\\LocadoraDeCarro\\LocadoraDeCarro\\Database.mdf;Integrated Security=True";
            string strComando = "SELECT Nome, Marca, Tipo, Quantidade, PrecoDia FROM TabelaVeiculos WHERE Nome=@VarNome AND Marca=@VarMarca AND Tipo=@VarTipo AND Quantidade=@VarQuantidade AND PrecoDia=@VarPrecoDia";

            SqlConnection? conexao = null;

            try
            {
                conexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strComando, conexao);
                // Pegando valores
                comando.Parameters.AddWithValue("@VarNome", textBoxNome.Text);
                comando.Parameters.AddWithValue("@VarMarca", textBoxMarca.Text);
                comando.Parameters.AddWithValue("@VarTipo", textBoxTipo.Text);
                comando.Parameters.AddWithValue("@VarQuantidade", textBoxQuantidade.Text);
                comando.Parameters.AddWithValue("@VarPrecoDia", textBoxDias.Text);

                conexao.Open();
                // Verificando Quantidade

                int quantidadeBanco = PegarQuantidade();
                int quantidadeInserida = Convert.ToInt32(textBoxQuantidade.Text);
                if (quantidadeInserida > 0)
                {
                    if (quantidadeBanco < quantidadeInserida)
                    {
                        MessageBox.Show("No momento não temos essa quantidade de veículos disponíveis!", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Retirar quantidade do banco de dados
                        AtualizaQuantidade(quantidadeBanco, quantidadeInserida);
                        int diasInseridos = Convert.ToInt32(textBoxDias.Text);
                        MessageBox.Show("Aluguel no valor de: R$" + MostrarPreço(diasInseridos) + " efetuado com sucesso!", "Veículo alugado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Quantidade inserida menor ou igual a zero", "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\olive\\source\\repos\\LocadoraDeCarro\\LocadoraDeCarro\\Database.mdf;Integrated Security=True";
            string strComando = "SELECT Nome,Marca,Tipo,Quantidade,PrecoDia FROM TabelaVeiculos WHERE Nome=@VarNome";
            SqlConnection? conexao = null;

            try
            {
                conexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(strComando, conexao);

                comando.Parameters.AddWithValue("@VarNome", textBoxConsulta.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                conexao.Open();
                adapter.Fill(dt);
                dataGridViewConsulta.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
        public int PegarQuantidade()
        {
            string strConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\olive\\source\\repos\\LocadoraDeCarro\\LocadoraDeCarro\\Database.mdf;Integrated Security=True";
            string strQuantidade = "SELECT Quantidade FROM TabelaVeiculos WHERE Nome=@VarNome";
            SqlConnection ? conexao = null;
            int quantidade = 0;

            try {
                conexao = new SqlConnection(strConexao);
                SqlCommand comandoQuan = new SqlCommand(strQuantidade, conexao);

                comandoQuan.Parameters.AddWithValue("@VarNome", textBoxNome.Text);
                conexao.Open();

                quantidade = Convert.ToInt32(comandoQuan.ExecuteScalar());
                comandoQuan.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally 
            { 
                if (conexao != null)
                {
                    conexao.Close();
                    
                }
            }
            return quantidade;

        }

        public void AtualizaQuantidade(int pQBanco, int pQInserida)
        {
            string strConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\olive\\source\\repos\\LocadoraDeCarro\\LocadoraDeCarro\\Database.mdf;Integrated Security=True";
            string strAtualizaQuantidade = "UPDATE TabelaVeiculos SET Quantidade=@VarNovaQuantidade WHERE Nome=@VarNome";
            SqlConnection ? conexao = null;
            try
            {
                conexao = new SqlConnection(strConexao);

                SqlCommand ComandoAtualiza = new SqlCommand(strAtualizaQuantidade, conexao);

                ComandoAtualiza.Parameters.AddWithValue("@VarNome", textBoxNome.Text);
                ComandoAtualiza.Parameters.AddWithValue("@VarNovaQuantidade", pQBanco - pQInserida);
                conexao.Open();
                ComandoAtualiza.ExecuteNonQuery ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if (conexao != null) 
                {  
                    conexao.Close(); 
                } 
            }


            

        }

        public string MostrarPreço(int pDias)
        {
            string strConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\olive\\source\\repos\\LocadoraDeCarro\\LocadoraDeCarro\\Database.mdf;Integrated Security=True";
            string strSelecionaQuantidade = "SELECT PrecoDia FROM TabelaVeiculos WHERE Nome=@VarNome";
            string valorFinal = "";
            SqlConnection? conexao = null;
            try
            { 
            conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(strSelecionaQuantidade, conexao);

            comando.Parameters.AddWithValue("@VarNome", textBoxNome.Text);

            conexao.Open();

            int valorTotal;
            int ValorCarro = Convert.ToInt32(comando.ExecuteScalar());
            int QuanDias = Convert.ToInt32(textBoxDias.Text.ToString());
            valorTotal = ValorCarro * QuanDias;
            valorFinal = valorTotal.ToString();

            comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            return valorFinal;
        }

        private void textBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
