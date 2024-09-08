using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_management_system
{
    internal class data_share_class
    {
        public static string[] request_data_arr { get; set; }
        public static string[] company_num_arr { get; set; }
        public static int[] passward_data_arr { get; set; }
        public static string[] item_name_arr { get; set; }
        public static string[] item_code_arr { get; set; }
        public static int data_base_impoted { get; set; } = 0;

        public static int number_of_employees { get; set; }
        public static int index { get; set; } = 1;
        public static string active_worker { get; set; } 

        public static int number_of_items { get; set; }
        public static string[] available_arr { get; set; } = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
    }
}
