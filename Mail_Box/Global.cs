using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Box
{
    static class Global
    {
        private static string username = "";
        private static string sqlConnectionString = "Data Source=SOHEIL-PC;Initial Catalog=Mail_Box;Integrated Security=True";
        public static string loginUser {
            get { return username; }
            set { username = value; }
        }
        public static string connectionString
        {
            get { return sqlConnectionString; }
        }
    
    }
}
