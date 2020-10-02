using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            lstHasil.Items.Clear();

            if (comboBox.SelectedIndex == 0)
            {
                lstHasil.Items.Add(string.Format("{0}", Penambahan(a, b)));
            }
            if (comboBox.SelectedIndex == 1)
            {
                lstHasil.Items.Add(string.Format("{0}", Pengurangan(a, b)));
            }
            if (comboBox.SelectedIndex == 2)
            {
                lstHasil.Items.Add(string.Format("{0}", Perkalian(a, b)));
            }
            if (comboBox.SelectedIndex == 3)
            {
                lstHasil.Items.Add(string.Format("{0}", Pembagian(a, b)));
            }
        }


            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
