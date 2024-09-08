using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;

namespace Store_management_system
{
    public partial class Start : Form
    {
        //array to initilize the data
        private int number_of_employees;
        private string[] company_numbers;
        private int[] passwards;
        
        private int number_of_items;
        private string[] item_names;
        private string[] item_codes;

        public Start()
        {
            InitializeComponent();

            //dispaly timer
            Project_Timer.Start();

            data_share_class.number_of_items = number_of_items;

            //get the data from the data base (data in the item and employees tables)
            try
                {
                string constring = "server=127.0.0.1;uid=root;pwd=a1234;database=Store_management_system";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = constring;
                con.Open();
              
                //number of items
                string query1 = "SELECT COUNT(*) FROM items";
                MySqlCommand cmd3 = new MySqlCommand(query1, con);                
                int number_of_items = Convert.ToInt32(cmd3.ExecuteScalar());

                data_share_class.number_of_items = number_of_items;        

                string sql = "select*from items";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
  
                item_names = new string[number_of_items];
                item_codes = new string[number_of_items];

                int i = 0;
                while ((i< number_of_items)&&(reader.Read()))
                {
                    item_codes[i] = reader["item_code"].ToString();
                    item_names[i] = reader["item_name"].ToString();
                    i++;
                }
                
                con.Close();
                MySqlConnection con1 = new MySqlConnection();
                con1.ConnectionString = constring;
                con1.Open();

                //number of employees
                string query3 = "SELECT COUNT(*) FROM employees";
                MySqlCommand cmd4 = new MySqlCommand(query3, con1);
                int number_of_employees = Convert.ToInt32(cmd4.ExecuteScalar());
                data_share_class.number_of_employees = number_of_employees;

                string sql1 = "select*from employees";
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                MySqlDataReader reader1 = cmd1.ExecuteReader();

                company_numbers = new string[number_of_employees];
                passwards = new int[number_of_employees];
                
                int j = 0;
                while ((j < number_of_employees) && (reader1.Read()))
                {
                    company_numbers[j] = reader1["company_number"].ToString();
                    passwards[j] = int.Parse((reader1["passward"]).ToString());
                    j++;
                }

                //save data in class to use in forms
                data_share_class.company_num_arr = company_numbers;
                data_share_class.passward_data_arr = passwards;

                con1.Close(); 
                
            }
            catch (MySqlException)
                {
                    MessageBox.Show("Error in Database Loading!");
                }
            number_of_employees= data_share_class.number_of_employees;

            //share data to outside class from the forms
            data_share_class.item_name_arr = item_names;
            data_share_class.item_code_arr = item_codes;

            if (data_share_class.data_base_impoted==0)
            {
                MessageBox.Show("Database Improted successfully!");
                data_share_class.data_base_impoted = 1;
            }
        } 

        private void btn_login_Click(object sender, EventArgs e)
        {            
            int status = 0;           
            for (int i = 0; i < number_of_employees-3; i++)
            {
                //check the login and save login details of workers and supervisors
                if ((company_num.Text == company_numbers[i])&&(int.Parse(passward.Text) == passwards[i]))
                {
                    //identify worker
                    data_share_class.active_worker=company_num.Text;
                    Request form = new Request();
                    form.Show();
                    this.Hide();
                    status = 1;
                    break;  
                }

                //identify supervisor
                else if ((company_num.Text == company_numbers[i+3])&&(int.Parse(passward.Text) == passwards[i+3]))
                {
                    Check form = new Check();
                    form.Show();
                    this.Hide();
                    status = 1;
                    break;
                }
                //identify manager
                else if ((company_num.Text == company_numbers[number_of_employees-1]) && (int.Parse(passward.Text) == passwards[number_of_employees-1]))
                {
                    Manager form = new Manager();
                    form.Show();
                    this.Hide();
                    status = 1;
                    break;
                }
            }

            //Invalid ligin identification
            if (status==0)
            {
                MessageBox.Show("Invaid Inputs. Enter again");
            }
        }

        //clear data area
        private void btn_clear_Click(object sender, EventArgs e)
        {
            company_num.Clear();
            passward.Clear();
        }

        //date and time
        private void Project_Timer_Tick(object sender, EventArgs e)
        {
            DateTime dt= DateTime.Now;
            this.date_time.Text = dt.ToString();
        }

        //conatact for more details
        private void contact_Click(object sender, EventArgs e)
        {
            Contact form = new Contact();
            form.Show();
            this.Hide();
        }
    }
}
