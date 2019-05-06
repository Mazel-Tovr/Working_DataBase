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
    public partial class Get_table_name : Form
    {
        List<string> list = new List<string>(); 
        public Get_table_name(List<string>list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void Get_table_name_Load(object sender, EventArgs e)
        {
            foreach (var item in list )
            {
                comboBox1.Items.Add(item);
            }
        }
        public string TableName
        {
            get {  return comboBox1.Text; }
        }
           
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
