using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PopUp_apagar_pessoafisica papf = new PopUp_apagar_pessoafisica();
            papf.Show();
        }
    }
}
