using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCTDL_16110CL2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox2.Focus();
        }
        private void dangnhap()
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập mật khẩu (username)!");
            else if (this.textBox1.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập username!");
            else if (this.textBox2.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập password!");
            else if (this.textBox1.Text == "Le Van A" && this.textBox2.Text == "123456")
                MessageBox.Show("Đăng nhập thành công!");
            else MessageBox.Show("Mật khẩu không đúng!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            dangnhap();
            fm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
