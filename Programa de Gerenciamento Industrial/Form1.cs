using Npgsql;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace Programa_de_Gerenciamento_Industrial
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 interacao = new Form2();
            interacao.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
