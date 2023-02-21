using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Vi_Du
{
    class DBUtils
    {
        public static SqlConnection GetConnection(string conString)
        {
            return new SqlConnection(conString);
        }
    }
}
