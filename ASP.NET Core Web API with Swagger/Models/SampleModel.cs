using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API_with_Swagger.Model
{
    public class SampleModel
    {
        //public class Products
        //{
        //    public Products() { }
        //    public Products(string No, string Name)
        //    {
        //        ProductNo = No;
        //        ProductType = Name;
        //    }
            public int Id { get; set; }
            public Products Product { get; set; }
            //public string ProductType { get; set; }
        //}
    }

    public class Products
    {
        public string ProductNo { get; set; }
        public string ProductType { get; set; }
    }
}
