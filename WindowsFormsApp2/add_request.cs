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
    public partial class add_request : Form
    {
        public add_request()
        {
            InitializeComponent();
        }
        string connectString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = F:\Kyrsach_Ivanov\Microsoft Access База данных.mdb";
        private OleDbConnection myConnection;
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string clentcode1, fio1, address1, pasport1, telephon1, bank1;
                clentcode1 = Client_code.Text; fio1 = FIO.Text; address1 = address.Text; pasport1 = pasport.Text; telephon1 = telephon.Text; bank1 = Bank.Text;
                string request2 = String.Format("INSERT INTO Клиент_Физическое_лицо (Код_Клиента,Фио,Адрес,Серия_и_номер_паспорта,Телефон,№_Банковского_счета) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", clentcode1, fio1, address1, pasport1, telephon1, bank1);
                OleDbCommand command = new OleDbCommand(request2, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!","Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch(Exception)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось,проверьте правильность ввода данных! ", "Уведомление о результатах", MessageBoxButtons.OK);
            }
            Gaga();
        }

        private void add_request_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            Gaga();
        }

        private void add_request_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string Client_cod11 = Client_code1.Text;

            DialogResult dialogResult = MessageBox.Show(String.Format("Вы уверены,что хотите удалить запись из таблицы Клиент_Физическое_лицо где Код_Клиента={0}", Client_cod11), "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                 try
            { 
                string request1 = String.Format("DELETE FROM Клиент_Физическое_лицо WHERE Код_Клиента={0}", Client_cod11);
                OleDbCommand command = new OleDbCommand(request1, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалина!", "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось,проверьте правильность ввода данных! ", "Уведомление о результатах", MessageBoxButtons.OK);
            }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            Gaga();


        }
        /// <summary>
        /// Вывод Бд для удобства
        /// </summary>
        private void Gaga()
        {
            string query = "SELECT * From Клиент_Физическое_лицо";//SQL Запрос 
            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
           
        }

        private void data_update_Click(object sender, EventArgs e)
        {
            

            DialogResult dialogResult = MessageBox.Show(String.Format("Вы уверены,что хотите изменить запись из таблицы Клиент_Физическое_лицо где Код_Клиента={0}", code_clientupdate.Text), "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string codclienta = String.Format("Код_Клиента={0}", code_clientupdate.Text);
                    string fio1 = String.Format("Фио='{0}'", FIOupdate.Text);
                    string address1 = String.Format("Адрес='{0}'", addressupdate.Text);
                    string pasport1 = String.Format("Серия_и_номер_паспорта='{0}'", pasportupdate.Text);
                    string telephon1 = String.Format("Телефон='{0}'", telephonupdate.Text);
                    string bank1 = String.Format("№_Банковского_счета='{0}'", bankupdate.Text);

                if (FIOupdate.Text != "")
                {
                    string request22 = String.Format("UPDATE Клиент_Физическое_лицо SET {1} WHERE {0}", codclienta, fio1);
                    OleDbCommand command22 = new OleDbCommand(request22, myConnection);
                    command22.ExecuteNonQuery();
                }
                if (addressupdate.Text != "")
                {
                    string request23 = String.Format("UPDATE Клиент_Физическое_лицо SET {1} WHERE {0}", codclienta, address1);
                    OleDbCommand command23 = new OleDbCommand(request23, myConnection);
                    command23.ExecuteNonQuery();
                }
                if (pasportupdate.Text != "")
                {
                    string request33 = String.Format("UPDATE Клиент_Физическое_лицо SET {1} WHERE {0}", codclienta,pasport1);
                    OleDbCommand command33 = new OleDbCommand(request33, myConnection);
                    command33.ExecuteNonQuery();
                }
                if (telephonupdate.Text != "")
                {
                    string request43 = String.Format("UPDATE Клиент_Физическое_лицо SET {1} WHERE {0}", codclienta,telephon1);
                    OleDbCommand command43 = new OleDbCommand(request43, myConnection);
                    command43.ExecuteNonQuery();
                }
                if (bankupdate.Text != "")
                {
                    string request99 = String.Format("UPDATE Клиент_Физическое_лицо SET {1} WHERE {0}", codclienta, bank1);
                    OleDbCommand command99 = new OleDbCommand(request99, myConnection);
                    command99.ExecuteNonQuery();
                }
                MessageBox.Show("Запись успешно обновлена!", "Уведомление о результатах", MessageBoxButtons.OK);

               }
                catch (Exception)
                {
                   MessageBox.Show("Изменения в базе данных выполнить не удалось,проверьте правильность ввода данных! ", "Уведомление о результатах", MessageBoxButtons.OK);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            Gaga();
        }
    }
}
