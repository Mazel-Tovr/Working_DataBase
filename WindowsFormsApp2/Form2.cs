using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBox1.Items.Clear();
            
                OleDbConnection dbCon = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = F:\Kyrsach_Ivanov\Microsoft Access База данных.mdb");
                dbCon.Open();
                DataTable tbls = dbCon.GetSchema("Tables", new string[] { null, null, null, "TABLE" }); //список всех таблиц
                foreach (DataRow row in tbls.Rows)
                {
                    string TableName = row["TABLE_NAME"].ToString();
                    comboBox1.Items.Add(TableName);
                }
                dbCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection dbCon = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = F:\Kyrsach_Ivanov\Microsoft Access База данных.mdb");
            dbCon.Open();
            OleDbDataAdapter dbAdapter1 = new OleDbDataAdapter(@"SELECT * FROM " + comboBox1.SelectedItem, dbCon);
            DataTable dataTable = new DataTable();
            dbAdapter1.Fill(dataTable);
            dbCon.Close();
            foreach (var item in dataTable.Columns)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}


