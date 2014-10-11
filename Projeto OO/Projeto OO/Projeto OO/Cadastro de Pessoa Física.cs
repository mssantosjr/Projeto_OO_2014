using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_OO
{
    public partial class CadastrarPF : Form
    {
        public CadastrarPF()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MISA-PC\SQLEXPRESS;Initial Catalog=Projeto_OO14;Integrated Security=True");
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;

            comm.CommandText = "INSERT INTO CLIENTE_PF (Nome, Cpf, Endereco) VALUES (@Nome, @Cpf, @Endereco) ";
            comm.Parameters.AddWithValue("@Nome", NOME.Text);
            comm.Parameters.AddWithValue("@Cpf", CPF.Text);
            comm.Parameters.AddWithValue("@Endereco", ENDEREÇO.Text);

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Registro salvo com sucesso.", "Mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
