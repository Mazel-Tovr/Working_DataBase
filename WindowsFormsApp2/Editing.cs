using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Editing : Form
    {
        private MySqlConnection myConnection;
        //Данные из первой формы
        public Editing(string sTEXT,string ssTEXT, MySqlConnection myConnection)
        {
            InitializeComponent();
            filds.Text = sTEXT;
            tables.Text = ssTEXT;
            this.myConnection = myConnection;
            
        }
 
        public Editing()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// Закрыте Соединения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editing_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adap.Update(ds.Tables[0]);
                MessageBox.Show("Изменения в базе данных выполнены!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось,проверьте правильность ввода данных! ",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
        }
        MySqlDataAdapter adap = null;
        DataSet ds = new DataSet();
        private void Editing_Load(object sender, EventArgs e)
        {
            try
            {
            myConnection.Open();
            string filds1 = filds.Text;
            string tables1 = tables.Text;
            string query = String.Format("SELECT {0} From {1}", filds1, tables1);//SQL Запрос 
            
            //Вывод данных в DataGridView
            adap = new MySqlDataAdapter(query, myConnection);
             MySqlCommandBuilder bulder = new MySqlCommandBuilder(adap);
            adap.UpdateCommand = bulder.GetUpdateCommand();
            adap.InsertCommand = bulder.GetInsertCommand();
            adap.DeleteCommand = bulder.GetDeleteCommand();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так,проверьте правильность ввода данных");
                this.Close();
            }
        }
    }
}
