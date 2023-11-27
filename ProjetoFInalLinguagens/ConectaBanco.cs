using MySql.Data.MySqlClient;
using ProjetoFInalLinguagens.Domain;
using System.Data;

namespace ProjetoFInalLinguagens
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server= localhost;user id=root;password=;database=banco_carental");

        public string mensagem;

        public bool CadastroAluguel(Cliente cliente, Carro carro)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_update_aluguel", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", cliente.Name);
                cmd.Parameters.AddWithValue("cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("telefone", cliente.Telefone);

                cmd.Parameters.AddWithValue("nplaca", carro.Placa);
                cmd.Parameters.AddWithValue("dataDeSaida", cliente.DtSaida);
                cmd.Parameters.AddWithValue("dataDeRetorno", cliente.DtRetorno);
                cmd.Parameters.AddWithValue("precoAluguel", 10);
                cmd.ExecuteNonQuery();//executar no banco


                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }

        }

        public DataTable listaCarros()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("select * from carro where alugado = false", conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}