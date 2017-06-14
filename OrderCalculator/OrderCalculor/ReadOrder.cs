using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCalculor
{
    public class ReadOrder
    {
        public ReadOrder(string column, ref List<int> orderList, int theGroupYouWant)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLSERVER2014;Initial Catalog=Order;Integrated Security=True");
                SqlDataReader reader;
                conn.Open();

                string selectOrderInfo = "select * from dbo.OrderInfo";
                SqlCommand cmd = new SqlCommand(selectOrderInfo, conn);
                reader = cmd.ExecuteReader();
                List<int> result = new List<int>();
                int sum = 0;

                while (reader.Read())
                {
                    result.Add((int)reader[column]);
                }
                
                while (result.Count > 0)
                {
                    var value = (from e in result
                                 select e).Take(theGroupYouWant);
                    sum = Convert.ToInt32(value.AsEnumerable().Sum());
                    orderList.Add(sum);

                    if (result.Count < theGroupYouWant)
                    {
                        theGroupYouWant = result.Count;
                    }
                    result.RemoveRange(0, theGroupYouWant);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
