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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Store_management_system
{
    public partial class Contact : Form
    {
        private string[] company_numbers;
        private int[] passwards;
        string c_numm;
        public Contact()
        {
            InitializeComponent();
            company_numbers = data_share_class.company_num_arr;
            passwards = data_share_class.passward_data_arr;
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            //validate the inputs and get the company number
            int status = 0;
            for (int i = 0; i < data_share_class.number_of_employees; i++)
            {
                if ((company_num.Text == company_numbers[i]) && (int.Parse(passward_box.Text) == passwards[i]))
                {
                    c_numm = company_num.Text;
                    status = 1;
                    break;
                }               
            }

            //Invalid ligin identification
            if (status == 0)
            {
                MessageBox.Show("Invaid Inputs. Enter again");
            }

            //input message
            string msgg = message_box.Text;

            // Save the data to the database
            string server = "127.0.0.1";
            string uid = "root";
            string passward = "a1234";
            string database = "store_management_system";
            string constring = $"server={server};uid={uid};pwd={passward};database={database}";

            try
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();

                    // Define query with parameters
                    string query = "INSERT INTO message_data (company_number , message_detail) VALUES (@company_number, @message_detail)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Add parameter values
                        cmd.Parameters.AddWithValue("@company_number", c_numm);
                        cmd.Parameters.AddWithValue("@message_detail", msgg);

                        int i = cmd.ExecuteNonQuery();

                        if (i > 0) // Changed from -1 to 0, as ExecuteNonQuery returns the number of rows affected
                        {
                            MessageBox.Show("Data Saved to Database Successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Show the exception message
            }
        }

        //back to the home page
        private void btn_close_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }
    };
}
