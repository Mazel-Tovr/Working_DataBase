using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Collections.Specialized;
using System.Text;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    { //Путь к БД
        string connectString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = F:\Kyrsach_Ivanov\Microsoft Access База данных.mdb";

        private OleDbConnection myConnection;
        //При загрузки формы
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        /// <summary>
        /// Закрыте соединения при выходе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
        /// <summary>
        /// Открытие БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OpenBd()
        {
            string filds1 = filds.Text;
            string tables1 = tables.Text;
            string query = String.Format("SELECT {0} From {1}", filds1, tables1);//SQL Запрос 
            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenBd();
        }
        /// <summary>
        /// Получениеинформации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void получениеИнформацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
        }
        public string getdata;
        /// <summary>
        /// Редактирование
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void button2_Click(object sender, EventArgs e)
        {
            //  Editing s = new Editing();
            //s.Show();
            Form sForm = new Editing(filds.Text,tables.Text);
            sForm.Show();
        }
      
    }
}
