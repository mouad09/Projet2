using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace GESTION_ENTREPRISE
{
    public class CLA
    {
       public static string str = @"DESKTOP-OF8J0JR\SQLEXPRESS;Initial Catalog=GESTION_ENTREPRISE;Integrated Security=True";
       public static  SqlConnection cns = new SqlConnection(str);
        public static SqlCommand DR = new SqlCommand("", cns);
        public static SqlDataReader dr;

    }
}
