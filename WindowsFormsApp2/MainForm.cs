using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Collections.Specialized;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    { //Путь к БД
        public string connectString { get; set; }// = @"server=127.0.0.1;user=root;database=shop;password=";

        private MySqlConnection myConnection;
        

        void OpenConnection()
        {
            myConnection.Open();
        }
        void CloseConnection()
        {
            myConnection.Close();
            
        }

        //При загрузки формы
        public MainForm(string server, string user, string database, string password)
        {
            InitializeComponent();
            this.connectString = "server=" + server + ";user=" + user + ";database=" + database + ";password=" + password + "";
            myConnection = new MySqlConnection(connectString); 
            Getinfo();

        }

        /// <summary>
        /// Закрыте соединения при выходе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            Application.Exit();
        }
        /// <summary>
        /// Открытие БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OpenBd()
        {

            if (filds.Text != "" && tables.Text != "")
            {
                try
                {
                    OpenConnection();
                    string filds1 = filds.Text;
                    string tables1 = tables.Text;
                    string query = String.Format("SELECT {0} From {1}", filds1, tables1);//SQL Запрос 
                    MySqlCommand command = new MySqlCommand(query, myConnection);

                    //Вывод данных в DataGridView
                    MySqlDataAdapter MyDA = new MySqlDataAdapter();
                    MyDA.SelectCommand = command;
                    DataTable dataSet = new DataTable();
                    MyDA.SelectCommand = command;
                    MyDA.Fill(dataSet);
                    dataGridView1.DataSource = dataSet;
                    MyDA.Update(dataSet);

                    /*
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    //adapter.SelectCommand = command;
                    MySqlDataReader dataSet = command.ExecuteReader();
                    adapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                    adapter.Update(dataSet);
                    */
                    CloseConnection();
                }

                catch (Exception)
                {
                    MessageBox.Show("Что-то пошло не так,проверьте правильность ввода данных");
                    CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Поле: Выбор поля ( * - все поля) или Выбор таблицы - пустые ");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenBd();
        }
  
        public string getdata;
        /// <summary>
        /// Редактирование
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (filds.Text != "" && tables.Text != "")
            {
               
                    Form sForm = new Editing(filds.Text, tables.Text,myConnection);
                    sForm.Show();
                
            }
            else
            {
                MessageBox.Show("Поле: Выбор поля ( * - все поля) или Выбор таблицы - пустые ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form request = new Requests(myConnection, TablesName);
            request.Show();
            
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Данное приложение разработано для работы с базой данных Магазин в MySql. ПИН 1705 Иванов Роман.","Справка", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Для будующих свершений ))) 
        /// </summary>
        public  List<string> TablesName { get; private set; } = new List<string>() ;
        /// <summary>
        /// Получаем название столбцов в открытой нами бд
        /// </summary>
        void Getinfo()
        {
            
            MySqlCommand cmd = new MySqlCommand("SHOW TABLES", myConnection);
            try
            {
                
                OpenConnection();
                var reader = cmd.ExecuteReader();
                tables.Items.Clear();
                while (reader.Read())
                {
                    tables.Items.Add( reader.GetString(0) );
                    TablesName.Add(reader.GetString(0));
                }
                CloseConnection();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Failed to populate table list: " + ex.Message);
            }
        }

        public Editing Editing
        {
            get => default(Editing);
            set
            {
            }
        }

        public Requests Requests
        {
            get => default(Requests);
            set
            {
            }
        }
    }
}
