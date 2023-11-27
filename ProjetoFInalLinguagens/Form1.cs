using ProjetoFInalLinguagens.Domain;
using System.Data;
using System.Globalization;

namespace ProjetoFInalLinguagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listaCarro();
        }
        void listaCarro()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCarros();
            cbVeiculo.DataSource = tabelaDados;
            cbVeiculo.DisplayMember = "modelo";
            cbPlaca.DataSource = tabelaDados;
            cbPlaca.DisplayMember = "placa";
        }

        void CalcularPreco()
        {
            string[] dataSaida = dtSaida.Text.Split('/');
            DateTime dateSaida = new DateTime(int.Parse(dataSaida[2]), int.Parse(dataSaida[1]), int.Parse(dataSaida[0]));
            string[] dataRetorno = dtRetorno.Text.Split('/');
            DateTime dateRetorno = new DateTime(int.Parse(dataRetorno[2]), int.Parse(dataRetorno[1]), int.Parse(dataRetorno[0]));
            TimeSpan dias = dateRetorno.Subtract(dateSaida);
            double totalDays = int.Parse(dias.Days.ToString());
            lblResultadoPreco.Text = $"R$ {(totalDays * 50).ToString("F2", CultureInfo.InvariantCulture)}";
        }
        private void btnCadastroAluguel_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string cpf = txtCPF.Text;
            string telefone = txtTelefone.Text;
            string[] dataSaida = dtSaida.Text.Split('/');
            DateTime dateSaida = new DateTime(int.Parse(dataSaida[2]), int.Parse(dataSaida[1]), int.Parse(dataSaida[0]));
            string[] dataRetorno = dtRetorno.Text.Split('/');
            DateTime dateRetorno = new DateTime(int.Parse(dataRetorno[2]), int.Parse(dataRetorno[1]), int.Parse(dataRetorno[0]));
            Cliente cliente = new Cliente(name, cpf, telefone, dateSaida, dateRetorno);

            TimeSpan dias = dateRetorno.Subtract(dateSaida);
            double totalDays = int.Parse(dias.Days.ToString());
            lblResultadoPreco.Text = $"R$ {(totalDays * 50).ToString("F2", CultureInfo.InvariantCulture)}";
            string placa = cbPlaca.Text;
            string modelo = cbVeiculo.Text;
            bool alugado = true;
            Carro carro = new Carro(modelo, placa, alugado);


            ConectaBanco conecta = new ConectaBanco();
            conecta.CadastroAluguel(cliente, carro);
            MessageBox.Show("Aluguel cadastrado com sucesso");
            Application.Restart();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPreco();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
