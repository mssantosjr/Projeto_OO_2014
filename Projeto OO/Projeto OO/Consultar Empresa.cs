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
    public partial class ConsultarEmpresa : Form
    {
        public ConsultarEmpresa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopUp_apagar pa = new PopUp_apagar();
            pa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopUp_editar pe = new PopUp_editar();
            pe.Show();
        }
    }
}
