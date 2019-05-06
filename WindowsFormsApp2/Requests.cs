using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Requests : Form
    {
        private List<string> list;
        private MySqlConnection myConnection;
        public Requests(MySqlConnection myConnection,List<string> list)
        {
            InitializeComponent();
            this.myConnection = myConnection;
            this.list = list;
        }

        
        
        private string from()
        {
            Get_table_name a = new Get_table_name(list);
            a.ShowDialog();
            return a.TableName;
        }
        


        private void Search_request_Click(object sender, EventArgs e)
        {
            try
            {
                string filds1 = "*";
                string tables1 = from(); //Microsoft.VisualBasic.Interaction.InputBox("Введите название таблице из которой хотите взять данные"); 
                string where1 = Microsoft.VisualBasic.Interaction.InputBox("Введите параметры поиска"); 
                string query = String.Format("SELECT {0} From {1} WHERE {2}", filds1, tables1, where1);//SQL Запрос 
                MySqlCommand command = new MySqlCommand(query, myConnection);
                //Вывод данных в DataGridView
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                adapter.Update(dataSet);
                MessageBox.Show("Запрос успешно построен!", "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Введенный вами запрос некорректен!", "Уведомление о результатах", MessageBoxButtons.OK);
            }

        }
        /// <summary>
        /// При загузки формы открваем соединение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Requests_Load(object sender, EventArgs e)
        {
            myConnection.Open();
        }

        void SqlRequest(string tables)
        {
            string query = String.Format("SELECT * FROM {0}", tables);
            MySqlCommand command = new MySqlCommand(query, myConnection);
            //Вывод данных в DataGridView
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

        private void del_request_Click(object sender, EventArgs e)
        {
            string tables1 = from(); //Microsoft.VisualBasic.Interaction.InputBox("Введите название таблице из которой хотите взять данные"); 
            string where1 = Microsoft.VisualBasic.Interaction.InputBox("Введите параметры удаление");
            string query = String.Format("DELETE FROM {0} WHERE {1}", tables1, where1);//SQL Запрос 
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.ExecuteNonQuery();
            //Вывод данных в DataGridView
            SqlRequest(tables1);
            MessageBox.Show("Запрос успешно построен!", "Уведомление о результатах", MessageBoxButtons.OK);
        }

        private void your_request_Click(object sender, EventArgs e)
        {
            try
            {
                string query = Microsoft.VisualBasic.Interaction.InputBox("Введите свой sql запрос:");
                MySqlCommand command = new MySqlCommand(query, myConnection);
                //Вывод данных в DataGridView
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                adapter.Update(dataSet);
                MessageBox.Show("Запрос успешно построен!", "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch(Exception)
            {
                MessageBox.Show("Введенный вами запрос некорректен!", "Уведомление о результатах", MessageBoxButtons.OK);
            }
        }

        
    }
}
