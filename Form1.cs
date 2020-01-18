 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSM_2B.BO;


namespace BSM_2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Tomar los valores de input
            double n1, n2, r_suma;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);


            operaciones_BO Obj_ops = new operaciones_BO(n1, n2);


            // ejecutar el metodo


            r_suma = Obj_ops.Suma();

            textBox3.Text = r_suma.ToString();

            // textBox3.Text = r_suma.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Tomar los valores de input
            double n1, n2, r_mul;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);


            var Obj_ops = new operaciones_BO(n1, n2);


            // ejecutar el metodo


            r_mul = Obj_ops.Multi();

            textBox4.Text = r_mul.ToString();

            // textBox3.Text = r_suma.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
