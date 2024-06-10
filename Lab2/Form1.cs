using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int results;
            string str = textBox1.Text;
            if (int.TryParse(str, out result))

            {
                MessageBox.Show("this is a valid integer");
            }
            else
            {
                MessageBox.Show("NOT a valid integer");

            }
            try
            {
                result = int.Parse(str);

            }
            catch
            { MessageBox.Show("catch - not a valid int");
                MessageBox.Show("please try again");



