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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarPF cdcf = new CadastrarPF();
            cdcf.Show();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarPJ cdcj = new CadastrarPJ();
            cdcj.Show();
        }

        private void hardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarHardware cdh = new CadastrarHardware();
            cdh.Show();
        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarSoftware cds = new CadastrarSoftware();
            cds.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void equipamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar_Hardware ce = new Consultar_Hardware();
            ce.Show();
        }

        private void softwareBoladãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre s = new Sobre();
            s.Show();
        }

        private void pessoaFísicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarPessoaFisica cpf = new ConsultarPessoaFisica();
            cpf.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEmpresa ce = new ConsultarEmpresa();
            ce.Show();
        }

        private void hardwareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar_Hardware ch = new Consultar_Hardware();
            ch.Show();
        }

        private void softwareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar_Software cs = new Consultar_Software();
            cs.Show();
        }

        private void hardwareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VenderProduto v = new VenderProduto();
            v.Show();
        }
    }
}
