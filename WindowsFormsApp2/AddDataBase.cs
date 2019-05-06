using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddDataBase : Form
    {
        public AddDataBase()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Запускаем базу данных
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                var a = new MainForm(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Проверьте правильность ввода данных");
            }

        }
    }
}
