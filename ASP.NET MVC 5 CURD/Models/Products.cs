using System;
using System.Web;

namespace ASP.NET_MVC_5_CURD.Models
{
    public class Products 
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Caregory { get; set; }
        public string UnitPrice { get; set; }


    }
}
