using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loteria
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int val = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatorNumerow();

        }

        private void generatorNumerow()
        {
            val = rand.Next(1, 49);
            textBox1.Text = val.ToString();

            val = rand.Next(1, 49);
            while(val.ToString().Equals(textBox1.Text))
                val = rand.Next(1, 49);
            textBox2.Text = val.ToString();


            val = rand.Next(1, 49);
            while (val.ToString().Equals(textBox1.Text) || val.ToString().Equals(textBox2.Text))
                val = rand.Next(1, 49);
            textBox3.Text = val.ToString();

            val = rand.Next(1, 49);
            while (val.ToString().Equals(textBox1.Text) || val.ToString().Equals(textBox2.Text) || val.ToString().Equals(textBox3.Text))
                val = rand.Next(1, 49);
            textBox4.Text = val.ToString();

            val = rand.Next(1, 49);
            while (val.ToString().Equals(textBox1.Text) || val.ToString().Equals(textBox2.Text) || val.ToString().Equals(textBox3.Text) || val.ToString().Equals(textBox4.Text))
                val = rand.Next(1, 49);
            textBox5.Text = val.ToString();

            val = rand.Next(1, 49);
            while (val.ToString().Equals(textBox1.Text) || val.ToString().Equals(textBox2.Text) || val.ToString().Equals(textBox3.Text) || val.ToString().Equals(textBox4.Text) || val.ToString().Equals(textBox5.Text))
                val = rand.Next(1, 49);
            textBox6.Text = val.ToString();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void oautorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alicja Taczalska II Bg");
        }

        private void opisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program losuje sześć liczb w zakresie od 1 do 49");
        }

        private void oAutorzeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alicja Taczalska II Bg");
        }

        private void opisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program losuje sześć liczb w zakresie od 1 do 49");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
