using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace OrderCalculator
{
    public class ReadOrder
    {
        //Connection string
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLSERVER2014;Initial Catalog=Order;Integrated Security=True");
        SqlDataReader reader;
        
        string selectOrderInfo = "select * from dbo.OrderInfo where Id=1";
        

    }
}
