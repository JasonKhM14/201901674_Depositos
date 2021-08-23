using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201901674_Depositos
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = true;
                textBox1.Focus();
            }
            else
            {
                textBox1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Visible = true;
                textBox2.Focus();
            }
            else
            {
                textBox2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Visible = true;
                textBox3.Focus();
            }
            else
            {
                textBox3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)) { textBox1.Text = "0"; }
            if (String.IsNullOrEmpty(textBox2.Text)) { textBox2.Text = "0"; }
            if (String.IsNullOrEmpty(textBox3.Text)) { textBox3.Text = "0"; }
            if (String.IsNullOrEmpty(textBox4.Text)) { textBox4.Text = "0"; }
            if (radioButton3.Checked)
            {
                intereses();
            }
            else if (radioButton2.Checked)
            {
                intereses2();
            }
            else if (radioButton1.Checked) {
                intereses3();
            }
        }
        private void intereses() {
            String a = textBox1.Text;
            String b = textBox2.Text;
            String c = textBox3.Text;
            String d = textBox4.Text;
            Double n, n2, n3, sa, te=0, to;
            n = double.Parse(a);
            n2 = double.Parse(b);
            n3 = double.Parse(c);
            sa = double.Parse(d);
            double li = sa + n + n2 + n3;
            if (1 <= li && li < 1001)
            {
                te = li * 0.015;
            }
            else if (1001 <= li && li < 5001) {
                te = li * 0.025;
            }
            else if (5001 <= li && li < 15001)
            {
                te = li * 0.075;
            }
            else if (15001 <= li)
            {
                te = li * 0.01;
            }
            to = li + te;
            interes.Text = "Q " + Math.Round(te, 2).ToString();
            nuevo.Text = "Q " + Math.Round(to, 2).ToString();
        }
        private void intereses2()
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            String c = textBox3.Text;
            String d = textBox4.Text;
            Double n, n2, n3, sa, te = 0, to;
            n = double.Parse(a);
            n2 = double.Parse(b);
            n3 = double.Parse(c);
            sa = double.Parse(d);
            double li = sa + n + n2 + n3;
            if (1 <= sa && sa < 10001)
            {
                te = li * 0.025;
            }
            else if (10001 <= sa && sa < 15001)
            {
                te = li * 0.03;
            }
            else if (15001 <= sa)
            {
                te = li * 0.045;
            }
            to = li + te;
            interes.Text = "Q " + Math.Round(te, 2).ToString();
            nuevo.Text = "Q " + Math.Round(to, 2).ToString();
        }
        private void intereses3()
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            String c = textBox3.Text;
            String d = textBox4.Text;
            Double n, n2, n3, sa, te = 0, to;
            n = double.Parse(a);
            n2 = double.Parse(b);
            n3 = double.Parse(c);
            sa = double.Parse(d);
            double li = sa + n + n2 + n3;
            te = 0;
            to = li + te;
            interes.Text = "Q " + Math.Round(te, 2).ToString();
            nuevo.Text = "Q " + Math.Round(to, 2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            interes.Text = "";
            nuevo.Text = "";
            radioButton1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea cerrar el sistema?", "Cerrar",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { this.Close(); }
            else if (dialogResult == DialogResult.No){
                MessageBox.Show("Está bien","Cerrar",MessageBoxButtons.OK);
            }
        }
    }
}
