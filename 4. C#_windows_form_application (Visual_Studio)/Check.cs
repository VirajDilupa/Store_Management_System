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
    public partial class Check : Form
    {
        string[] item_codes;
        string[] item_names;
        string[] request_data;
        string[] avalable;
        int number_of_items;

        //array to save available items temporarily 
        string[] temp;

        public Check()
        {
            InitializeComponent();

            item_codes = data_share_class.item_code_arr;
            item_names = data_share_class.item_name_arr;
            request_data = data_share_class.request_data_arr;
            number_of_items = data_share_class.number_of_items;
            avalable = data_share_class.available_arr;

            temp = new string[number_of_items];

            //change the item codes and item names according to the data base
            itm_code0.Text = item_codes[0]; itm_code1.Text = item_codes[1]; itm_code2.Text = item_codes[2];
            itm_code3.Text = item_codes[3]; itm_code4.Text = item_codes[4]; itm_code5.Text = item_codes[5];
            itm_code6.Text = item_codes[6]; itm_code7.Text = item_codes[7]; itm_code8.Text = item_codes[8];
            itm_code9.Text = item_codes[9];

            itm_name0.Text = item_names[0]; itm_name1.Text = item_names[1]; itm_name2.Text = item_names[2];
            itm_name3.Text = item_names[3]; itm_name4.Text = item_names[4]; itm_name5.Text = item_names[5];
            itm_name6.Text = item_names[6]; itm_name7.Text = item_names[7]; itm_name8.Text = item_names[8];
            itm_name9.Text = item_names[9];

            //data of the request
            if (data_share_class.request_data_arr != null)
            {
                req0.Text = request_data[0];req1.Text = request_data[1];req2.Text = request_data[2];req3.Text = request_data[3];
                req4.Text = request_data[4];req5.Text = request_data[5];req6.Text = request_data[6];req7.Text = request_data[7];
                req8.Text = request_data[8];req9.Text = request_data[9];
            }
            else
            {
                req0.Text = req1.Text = req2.Text = req3.Text = req4.Text = req5.Text = req6.Text = req7.Text = req8.Text = req9.Text = "0";
            }

            avalable0.Text = avalable[0];avalable1.Text = avalable[1];avalable2.Text = avalable[2];avalable3.Text = avalable[3];
            avalable4.Text = avalable[4];avalable5.Text = avalable[5];avalable6.Text = avalable[6];avalable7.Text = avalable[7];
            avalable8.Text = avalable[8];avalable9.Text = avalable[9];

        }
      
        //back to the home after save the data of the available items
        private void close_Click(object sender, EventArgs e)
        {

            temp[0] = avalable0.Text;temp[1] = avalable1.Text;temp[2] = avalable2.Text;temp[3] = avalable3.Text;
            temp[4] = avalable4.Text;temp[5] = avalable5.Text;temp[6] = avalable6.Text;temp[7] = avalable7.Text;
            temp[8] = avalable8.Text;temp[9] = avalable9.Text;

            data_share_class.available_arr=temp;

            Start form = new Start();
            form.Show();
            this.Hide();
        }

        //items update
        private void update_Click(object sender, EventArgs e)
        {
            avalable0.Text = (int.Parse(update0.Text) + int.Parse(avalable0.Text)).ToString();
            avalable1.Text = (int.Parse(update1.Text) + int.Parse(avalable1.Text)).ToString();
            avalable2.Text = (int.Parse(update2.Text) + int.Parse(avalable2.Text)).ToString();
            avalable3.Text = (int.Parse(update3.Text) + int.Parse(avalable3.Text)).ToString();
            avalable4.Text = (int.Parse(update4.Text) + int.Parse(avalable4.Text)).ToString();
            avalable5.Text = (int.Parse(update5.Text) + int.Parse(avalable5.Text)).ToString();
            avalable6.Text = (int.Parse(update6.Text) + int.Parse(avalable6.Text)).ToString();
            avalable7.Text = (int.Parse(update7.Text) + int.Parse(avalable7.Text)).ToString();
            avalable8.Text = (int.Parse(update8.Text) + int.Parse(avalable8.Text)).ToString();
            avalable9.Text = (int.Parse(update9.Text) + int.Parse(avalable9.Text)).ToString();

            update0.Text = update1.Text = update2.Text = update3.Text = update4.Text = update5.Text = "0";
            update6.Text = update7.Text = update8.Text = update9.Text = update5.Text = "0";
        }

        //approve the request
        private void approve_Click(object sender, EventArgs e)
        {
            avalable0.Text = (int.Parse(avalable0.Text) - int.Parse(req0.Text)).ToString();
            avalable1.Text = (int.Parse(avalable1.Text) - int.Parse(req1.Text)).ToString();
            avalable2.Text = (int.Parse(avalable2.Text) - int.Parse(req2.Text)).ToString();
            avalable3.Text = (int.Parse(avalable3.Text) - int.Parse(req3.Text)).ToString();
            avalable4.Text = (int.Parse(avalable4.Text) - int.Parse(req4.Text)).ToString();
            avalable5.Text = (int.Parse(avalable5.Text) - int.Parse(req5.Text)).ToString();
            avalable6.Text = (int.Parse(avalable6.Text) - int.Parse(req6.Text)).ToString();
            avalable7.Text = (int.Parse(avalable7.Text) - int.Parse(req7.Text)).ToString();
            avalable8.Text = (int.Parse(avalable8.Text) - int.Parse(req8.Text)).ToString();
            avalable9.Text = (int.Parse(avalable9.Text) - int.Parse(req9.Text)).ToString();

            req0.Text = req1.Text = req2.Text = req3.Text = req4.Text = req5.Text = "0";
            req6.Text = req7.Text = req8.Text = req9.Text = "0";

            for (int i = 0; i < number_of_items; i++)
            {
                data_share_class.request_data_arr[i] = "0"; 
            }

            MessageBox.Show("Approval Completed");
        }
    }
}
