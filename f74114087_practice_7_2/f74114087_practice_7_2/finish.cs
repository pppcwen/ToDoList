using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f74114087_practice_7_2
{
    public partial class finish : Form
    {
        public string check;
        public finish()
        {
            InitializeComponent();
        }

        private void finish_Load(object sender, EventArgs e)
        {
            check = "";
            //this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入事項");
            }
            else
            {
                check = textBox1.Text;
                textBox1.Text = "";
                this.Close();
            }
        }
    }
}
