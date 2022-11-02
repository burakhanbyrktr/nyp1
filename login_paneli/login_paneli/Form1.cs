using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == ""|| textBox1.Text=="" )
            {
                MessageBox.Show("kulanıcı adı ve/veya şifre boş geçilemez.", "uyarı");
            }
            else
            {
                if(textBox2.Text=="admin"&& textBox1.Text=="1661")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("kullanıcı adı ve/veya şifre yanlış.", "uyarı");
                }
            }

        }
    }
}
