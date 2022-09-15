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
    public partial class SelecaoTelas : Form
    {
        public SelecaoTelas()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cliente = new CadastrarCliente();
            cliente.Show();
        }
    }
}
