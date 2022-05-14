using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_de_Cliques_CSharp
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
         int contador = 0;
        //incremento
        private void button1_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            label2.Text = contador.ToString();
        }
        //decremento
        private void button2_Click(object sender, EventArgs e)
        {
            if (contador >= 1)
            {
                contador = contador - 1;
                label2.Text = contador.ToString();
            }
        }
        //reset
        private void button3_Click(object sender, EventArgs e)
        {
            contador = 0;
            label2.Text = contador.ToString();
        }
    }
}
