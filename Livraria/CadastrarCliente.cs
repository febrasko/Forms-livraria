using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "" || txtNome.Text == "" || txtEmail.Text == "" || txtCpf.Text == "" || txtCep.Text == "" || txtCidade.Text == "" || txtBairro.Text == "" || txtEstado.Text == "" || txtRua.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }
    }
}
