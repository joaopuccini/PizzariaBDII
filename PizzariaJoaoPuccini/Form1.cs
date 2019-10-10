using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaJoaoPuccini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente cadastrtoCliente = new TelaCadastroCliente();
            cadastrtoCliente.StartPosition = FormStartPosition.CenterParent;
            cadastrtoCliente.ShowDialog();

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
