using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_management_system
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void show_record_Click(object sender, EventArgs e)
        {
            try
            {
                //import record data table from database
                string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = constring;
                con.Open();

                string sql = "select*from record_data";
                MySqlCommand cmd1 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd1.ExecuteReader();
 
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader["IIndex"], reader["Number_of_Item_Types"], reader["Total_Number_of_Items"], reader["Company_Number"]);
                }            
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database Loading!");
            }
        }

        private void show_msg_Click(object sender, EventArgs e)
        {
            try
            {
                //import record data table from database
                string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = constring;
                con.Open();

                string sql = "select*from message_data";
                MySqlCommand cmd1 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView3.Rows.Add(reader["company_number"], reader["message_detail"]);
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database Loading!");
            }
        }

        //back to the home
        private void close_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }

        //to another form
        private void emp_strip_Click(object sender, EventArgs e)
        {
            manager_emp form = new manager_emp();
            form.Show();
            this.Hide();
        }

        //to another form
        private void itm_strip_Click(object sender, EventArgs e)
        {
            Manager_itemscs form = new Manager_itemscs();
            form.Show();
            this.Hide();
        }

        //clear the message data from database
        private void clear1_Click(object sender, EventArgs e)
        {
            string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // Clear the message_data table
                    string clearTableSql = "DELETE FROM message_data";
                    using (MySqlCommand clearCmd = new MySqlCommand(clearTableSql, con))
                    {
                        clearCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cleared Database Successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        //clear the record data from database
        private void clear2_Click(object sender, EventArgs e)
        {
            string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // Clear the record_data table
                    string clearTableSql = "DELETE FROM record_data";
                    using (MySqlCommand clearCmd = new MySqlCommand(clearTableSql, con))
                    {
                        clearCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cleared Database Successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
        }
    }
}
