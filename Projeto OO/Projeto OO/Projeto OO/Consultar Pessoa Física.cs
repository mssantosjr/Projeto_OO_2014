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
using System.IO;

namespace Projeto_OO
{
    public partial class ConsultarPessoaFisica : Form
    {
        public ConsultarPessoaFisica()
        {
            InitializeComponent();
        }

        private void EditarBotão_Click(object sender, EventArgs e)
        {
            PopUp_editar_pessoafisica pepf = new PopUp_editar_pessoafisica();
            pepf.Show();
        }

        private void ApagarBotão_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=MISA-PC\SQLEXPRESS;Initial Catalog=Projeto_OO14;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE Region WHERE Nome = 'Misael'"; //AND RegionDescription = 'NorthWestern'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo diretorio = new DirectoryInfo(@"Data Source=MISA-PC\SQLEXPRESS;Initial Catalog=Projeto_OO14;Integrated Security=True");
            FileInfo[] Arquivos = diretorio.GetFiles("*.*");

            foreach (FileInfo fileinfo in Arquivos)
            {
                Response.Write(File.Nome);
            }

        }
    }
}
