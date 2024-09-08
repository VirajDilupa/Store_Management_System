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
    public partial class Manager_itemscs : Form
    {
        public Manager_itemscs()
        {
            InitializeComponent();
        }

        private void show_itm_Click(object sender, EventArgs e)
        {
            try
            {
                //import items table from database
                string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = constring;
                con.Open();

                string sql = "select*from items";
                MySqlCommand cmd1 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd1.ExecuteReader();

                int i = 0;
                while ((i < data_share_class.number_of_items) && (reader.Read()))
                {
                    dataGridView1.Rows.Add(reader["item_code"], reader["item_name"], reader["available_stock"]);
                    i++;
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database Loading!");
            }
        }

        //go to the manager page
        private void back_Click(object sender, EventArgs e)
        {
            Manager form = new Manager();
            form.Show();
            this.Hide();
        }

        //go back to the home
        private void close_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }

        //clear the record data from database
        private void clear_Click(object sender, EventArgs e)
        {
            string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();

                    // Clear the "items" table
                    string clearTableSql = "DELETE FROM items";
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
