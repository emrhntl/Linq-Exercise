using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProject
{
    internal class Order
    {
        public int orderId { get; set; }
        public string customerId { get; set; }
        public int employeeId { get; set; }
        public DateTime orderDate { get; set; }
        public Customer customer { get; set; }

        public List<Order> GetOrders()
        {
            List <Order> list = new List<Order>();
            //sql de çalışacak olan sorgu ile ihtiyacım olan tabloyu getiriyorum
            string sorgu = @"select o.CustomerID,o.EmployeeID,o.OrderID,o.OrderDate , (select c.ContactName from Customers c where c.CustomerID=o.CustomerID) as [Contact Name] from Orders o ";
            DataTable dt = GetDataTable(sorgu);
            foreach (DataRow item in dt.Rows)//her bir satır içinde dönüyorum
            {
                Order order = new Order();//her satırda yeni bir sipariş olduğu için her satır döndüğünde yeni nesne oluşturuyorum
                order.orderId = (int)item["OrderID"];//OrderID tablosundakşi veriyi nesneyye aktarıyorum
                order.customerId = item["CustomerID"].ToString();
                order.employeeId = (int)item["EmployeeID"];
                order.orderDate = (DateTime)item["OrderDate"];
                order.customer = new Customer();//müşteri için nesne oluşturuyorum ve order nesneme verileri atıyorum
                order.customer.customerId = item["CustomerID"].ToString();
                order.customer.contactName = item["Contact Name"].ToString();
                list.Add(order);//her bir satırdaki verileri çektikten sonra listeme çekilen verileri ekliyorum
            }
            return list;
        }

        private DataTable GetDataTable(string sorgu)
        {
            //kendiniz çalıştırmak isterseniz koyduğum backup dosyasını sql e ekleyip bağlantı dizinini aşağıdaki stringe kopyalamanız gerekiyor
            string cs = @"Data Source=EMIRHAN;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu,cs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
