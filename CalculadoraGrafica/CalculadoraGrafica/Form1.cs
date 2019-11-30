﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c = 0;
            
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);

            if (radioButton1.Checked == true)
                c = a + b;
            else if (radioButton2.Checked == true)
            {
                c = a * b;
            }

            else if (radioButton3.Checked == true)
            {
                if (textBox2.Text == "0")
                    MessageBox.Show("Divisão por ZERO, NÃO PODE BURRO!");
                else
                    c = a / b;



            }

            else if (radioButton4.Checked == true)
            {
                c = a - b;
            }


            textBox3.Text = c.ToString();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Focus();
            else
                textBox2.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                button1.Enabled = true;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                button1.Enabled = true;
        }
    }
}
