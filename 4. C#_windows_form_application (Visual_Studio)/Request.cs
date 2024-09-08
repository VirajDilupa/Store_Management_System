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
    public partial class Request : Form
    {
        //arrays to save data in this form
        string[] item_codes;
        string[] item_names;
        string[] req_arr;      
  
        //constructor for initilize the data
        public Request()
        {
            InitializeComponent();

            int number_of_items = data_share_class.number_of_items;
            item_codes = data_share_class.item_code_arr;
            item_names = data_share_class.item_name_arr;

            req_arr = new string[number_of_items];

            //change the item codes and name with respect to given data base
            itm_code0.Text = item_codes[0];itm_code1.Text = item_codes[1];itm_code2.Text = item_codes[2];
            itm_code3.Text = item_codes[3];itm_code4.Text = item_codes[4];itm_code5.Text = item_codes[5];
            itm_code6.Text = item_codes[6];itm_code7.Text = item_codes[7];itm_code8.Text = item_codes[8];
            itm_code9.Text = item_codes[9];

            itm_name0.Text = item_names[0];itm_name1.Text = item_names[1];itm_name2.Text = item_names[2];
            itm_name3.Text = item_names[3];itm_name4.Text = item_names[4];itm_name5.Text = item_names[5];
            itm_name6.Text = item_names[6];itm_name7.Text = item_names[7];itm_name8.Text = item_names[8];
            itm_name9.Text = item_names[9];
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            //save the order details 
            req_arr[0] = req_itm0.Text;req_arr[1] = req_itm1.Text;req_arr[2] = req_itm2.Text;
            req_arr[3] = req_itm3.Text;req_arr[4] = req_itm4.Text;req_arr[5] = req_itm5.Text;
            req_arr[6] = req_itm6.Text;req_arr[7] = req_itm7.Text;req_arr[8] = req_itm8.Text;
            req_arr[9] = req_itm9.Text;

            data_share_class.request_data_arr = req_arr;

            req_itm0.Text = req_itm1.Text = req_itm2.Text = req_itm3.Text = req_itm4.Text = req_itm5.Text = "0";
            req_itm6.Text = req_itm7.Text = req_itm8.Text = req_itm9.Text = "0";

            MessageBox.Show("Request is complete");

            //find the number of types,total number of items of the request
            int types_number = 0, total_number=0;
            for (int i = 0; i < data_share_class.number_of_items; i++)
            {
                if (req_arr[i]!="0")
                {
                    types_number++;
                    total_number=total_number+int.Parse(req_arr[i]);
                }
            }

            int num_index = data_share_class.index;
            data_share_class.index++;

            //identify the company number of the requesting persn
            string company_num = data_share_class.active_worker ;

            //save the request data to the data base
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
                    string query = "INSERT INTO record_data (IIndex, Number_of_Item_Types, Total_Number_of_Items, Company_Number) VALUES (@num_index, @types_number, @total_number, @company_num)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Add parameter values
                        cmd.Parameters.AddWithValue("@num_index", num_index);
                        cmd.Parameters.AddWithValue("@types_number", types_number);
                        cmd.Parameters.AddWithValue("@total_number", total_number);
                        cmd.Parameters.AddWithValue("@company_num", company_num);

                        int i = cmd.ExecuteNonQuery();

                        if (i > -1)
                        {
                            MessageBox.Show("Data Saved to Database Successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //again to the home
        private void btn_close_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }

    }
}

