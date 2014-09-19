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
    public partial class Consultar_Software : Form
    {
        public Consultar_Software()
        {
            InitializeComponent();
        }

        private void EditarBotão_Click(object sender, EventArgs e)
        {
            PopUp_editar_software pes = new PopUp_editar_software();
            pes.Show();
        }

        private void ApagarBotão_Click(object sender, EventArgs e)
        {
            PopUp_apagar_software pas = new PopUp_apagar_software();
            pas.Show();
        }
    }
}
