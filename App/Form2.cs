using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double[] a = new double[1000];
        int n = 0;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            if(n==0)
            {
                s = "invalid input";
                MessageBox.Show(s);
                this.Close();
                return;

            }
            string Output = "The Array after sorting : ";
            for (int i = 1; i < n; i++)
            {
                var key = a[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < a[j])
                    {
                        a[j + 1] = a[j];
                        j--;
                        a[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            string z = "";
            for (int i = 0; i < n; i++)
            {
                z += Convert.ToString(a[i]);
                z += " ";
            }
            MessageBox.Show(z, Output);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a[n] = double.Parse(input.Text);
            lbl.Text += a[n] + " ";
            n++;
            input.Clear();
            input.Focus();
        }

        
    }
}
