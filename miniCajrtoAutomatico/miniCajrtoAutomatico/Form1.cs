using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCajrtoAutomatico
{
    public partial class Form1 : Form
    {
        private int cantidad;
        private int saldo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btdepositar_Click(object sender, EventArgs e)
        {
            int cantidad = System.Convert.ToInt32(textBox1.Text);
            int saldo = System.Convert.ToInt32(value: textBox2.Text);
            int sf = cantidad + saldo;
            textBox3.Text = sf.ToString();





        }

        private void btextraer_Click(object sender, EventArgs e)
        {
            cantidad = 0;
            saldo = 0;
            if (cantidad > saldo)
            {
                int cantidad = System.Convert.ToInt32(textBox1.Text);
                int saldo = System.Convert.ToInt32(value: textBox2.Text);
                int sf = cantidad - saldo;
                textBox3.Text = sf.ToString();
            }
            else
            { textBox3.Text = " SALDO INSUFICIENTE"; }
                
            }

            

            }
        }
    

