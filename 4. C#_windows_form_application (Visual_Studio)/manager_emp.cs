using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_management_system
{
    public partial class manager_emp : Form
    {
        public manager_emp()
        {
            InitializeComponent();
        }

        private void show_emp_Click(object sender, EventArgs e)
        {
            try
            {
                //import employees table from database
                string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = constring;
                con.Open();

                int number_of_employees = data_share_class.number_of_employees;

                string sql = "select*from employees";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                //print data in data grid view
                int i = 0;
                while ((i < number_of_employees) && (reader.Read()))
                {
                    dataGridView.Rows.Add(reader["company_number"], reader["first_name"], reader["last_name"], reader["contact_number"], reader["passward"]);
                    i++;
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

        //go to the manager page
        private void back_Click(object sender, EventArgs e)
        {
            Manager form = new Manager();
            form.Show();
            this.Hide();
        }

        //clear employees data from database
        private void clear2_Click(object sender, EventArgs e)
        {
            string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // Clear the employees table
                    string clearTableSql = "DELETE FROM employees";
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
