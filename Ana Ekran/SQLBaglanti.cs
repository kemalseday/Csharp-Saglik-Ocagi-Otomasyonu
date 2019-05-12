using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Ana_Ekran
{
    class SQLBaglanti
    {
        private static SqlConnection sqlBaglan;
        private static object _Lock = new object();

        protected SQLBaglanti() { }

        public static SqlConnection SqlBaglan()
        {
            if (sqlBaglan == null)
            {
                lock (_Lock)
                {
                    sqlBaglan = new SqlConnection();
                    SqlBaglan().ConnectionString = "Data Source=.;Initial Catalog=SOHTS;Integrated Security=True";
                }
            }
            return sqlBaglan;
        }
    }
}
