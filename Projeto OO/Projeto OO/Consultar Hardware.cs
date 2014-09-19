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
    public partial class Consultar_Hardware : Form
    {
        public Consultar_Hardware()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopUp_editar_hardware peh = new PopUp_editar_hardware();
            peh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopUp_apagar_hardware pah = new PopUp_apagar_hardware();
            pah.Show();
        }
    }
}
