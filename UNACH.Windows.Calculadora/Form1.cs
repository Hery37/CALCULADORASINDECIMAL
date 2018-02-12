using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNACH.Windows.Calculadora
{
    public partial class Form1 : Form
    {
        /*variable*/
        bool punto = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNBorrar_Click(object sender, EventArgs e)
        {
            TXBA.Clear();
            TXBB.Clear();
            TXBResultado.Clear();
        }

        private void BTNResultado_Click(object sender, EventArgs e)
        {
            string op = CBOperacion.Text;
            double n1 = double.Parse(TXBA.Text);
            double n2 = double.Parse(TXBB.Text);
            double r = 0;
            switch (op)
            {
                case "*":
                    r = n1 * n2;
                    break;

                case "/":
                    if (n2 != 0)
                    {
                        r = n1 = n2;
                    }
                    else
                    {
                        MessageBox.Show("No Permitido","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        TXBA.Clear();
                        TXBB.Clear();
                        TXBResultado.Clear();
                    }
                    break;

                case "+":
                    r = n1 + n2;
                    break;

                case "-":
                    r = n1 - n2;
                    break;


            }
            TXBResultado.Text = r.ToString();

        }

        private void TXBA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Datos Erroneos","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXBA.Focus();
                e.Handled = true;
                {
                }
            }

        }

       /*private void button1_Click(object sender, EventArgs e)
        {
            if (punto == false)
                TXBA.Text += ".";
            punto = true;
        }*/
    }
}
