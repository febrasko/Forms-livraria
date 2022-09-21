using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Livraria
{
    public partial class ConsultarLivros : Form
    {
        public ConsultarLivros()
        {
            InitializeComponent();
        }

        private void ConsultarLivros_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            // Criando variável dt que recebe o datatable

            string conexao = @"Server=localhost;Database=livraria2;Uid=root;Pwd='etec'";
            // variavel conexao
            // servidor localhost
            // banco de dados livraria2
            // usuario root
            // senha etec

            MySqlConnection msconnection = new MySqlConnection(conexao);
            // criando variavel msconnection que se conecta com o conteudo da variavel conexao pelo mysql

            msconnection.Open();
            // abrindo conexão

            MySqlCommand mscommand = new MySqlCommand();
            mscommand.CommandText = "select * from livro";
            mscommand.Connection = msconnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(mscommand);
            msdAdapter.Fill(dt);
            dgvLivros.DataSource = dt;
            // colocando dados da tabela livro no DgvLivros
        }
    }
}
