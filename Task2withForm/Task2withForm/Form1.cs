using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Task2withForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            List<int> number = new List<int>();
            string text = Input.Text;
            Regex regex = new Regex(@"[-+]?\d{1,}");
            MatchCollection matches = regex.Matches(text);
            foreach (Match line in matches)
            {
                int i = Convert.ToInt32(line.Value);
                sum += i;
                number.Add(i);
            }
            Sum.Text = sum.ToString();
            Count.Text = Convert.ToString(number.Count);     
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
                    {
                        Input.Text = reader.ReadToEnd();
                    }
                }
            }
        }
    }
    }

