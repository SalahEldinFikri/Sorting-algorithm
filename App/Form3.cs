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
    public partial class Form3 : Form
    {
        static public void MergeMethod(double[] numbers, int left, int mid, int right)
        {
            double[] temp = new double[1000];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void SortMethod(double[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }

        public Form3()
        {
            InitializeComponent();
        }
        double[] a = new double[1000];
        int n = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            if (n == 0)
            {
                s = "invalid input";
                MessageBox.Show(s);
                this.Close();
                return;
            }
            string Output = "The Array after sorting : ";
            SortMethod(a, 0, n - 1);
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
