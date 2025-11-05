using MySql.Data.MySqlClient;

namespace login_bancodados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String strConexao = "Server=localhost;Database=DB_Cad;Uid=root;Pwd=;\r\n";
                MySqlConnection conexao = new(strConexao); // Faz a conexão com o banco de dados
                conexao.Open(); // abre a conexãao
                var comando = new MySqlCommand("INSERT INTO dboTable(id, nome, Email, Celular) VALUES (@id, @nome, @email, @celular)", conexao);
                comando.Parameters.AddWithValue("@id", textBox1.Text);
                comando.Parameters.AddWithValue("@nome", textBox2.Text);
                comando.Parameters.AddWithValue("@email", textBox3.Text);
                comando.Parameters.AddWithValue("@celular", textBox4.Text);
                comando.ExecuteNonQuery(); // Faz a execução do comando
                conexao.Close();  // Fecha o banco de dados quando for finalizado 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados." + ex.Message);
            }
        }

    }
}
