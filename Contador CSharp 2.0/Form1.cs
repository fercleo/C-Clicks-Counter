using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_CSharp_2._0
{
    public partial class Form1 : Form
    {
        private contador basecontador; // definindo novo atributo
        public Form1()
        {
            InitializeComponent();
            basecontador = new contador(); // definindo novo valor ao objeto

        }

        private void button1_Click(object sender, EventArgs e)
        {
            basecontador.setsoma();  // chamar o método setsoma
            switch (basecontador.getcontadorcliques())
            {
                case 10:
                    label5.Text = "Acabou!";  // casos específicos da label 5
                    button1.Enabled = false; // desativar o botão de cliques
                    break;
                case 9:
                    label5.Text = "Falta apenas mais 1.";
                    break;
                case 8:
                    label5.Text = "Faltam apenas mais 2.";
                    break;
                case 7:
                    label5.Text = "Faltam apenas mais 3.";
                    break;
                default:
                    label5.Text = "Siga clicando!";  // situação padrão da label 5
                    break;
            }
            label2.Text = basecontador.getcontadorcliques().ToString(); // converter o getcontador para string

        }

        private void button2_Click(object sender, EventArgs e)
        {
            basecontador.setreset(); // chamar o método setreset
            button1.Enabled = true; // reativar o botão de cliques
            label5.Text = "Siga clicando!"; 
            label2.Text = basecontador.getcontadorcliques().ToString();
        }
    }
    public class contador
        {
        private int contadorcliques;

        public contador()
        {
            contadorcliques = 0; // definindo o ínicio do contador
        }

        public void setreset()
        {
            contadorcliques = 0; // definindo o método do botão reset
        }

        public void setsoma() 
        {
            contadorcliques++; // definindo o método do botão clique
        }

        public int getcontadorcliques()
        {
            return contadorcliques; // definindo o retorno das informações dos métodos acima
        }
    }
}
