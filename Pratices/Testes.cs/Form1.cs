using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = { 10, 20, 30, 40, 50, 60 };
            string res = "";
            

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    res += vetor[i] + " ";
                }
                label1.Text = res;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }   
    }
}
