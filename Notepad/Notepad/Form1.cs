using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MnuNovo_Click(object sender, EventArgs e)
        {
            // criar um novo documento / limpar
            richTextBox1.Clear();
        }

        private void mnuSelecionarTudo_Click(object sender, EventArgs e)
        {
            //Selecionar Todo o texto
            richTextBox1.SelectAll();
        }
    }
}
