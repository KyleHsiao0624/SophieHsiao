using System.Collections.Generic;
using System.Data.Entity;

namespace ASP.NET_MVC_5_CURD.Models
{
    public class ProductsInitializer:DropCreateDatabaseIfModelChanges<ProductsContext>
    {
        protected override void Seed(ProductsContext pdtContext)
        {
            //base.Seed(context);

            // Step 1:以List泛型集合建立員工資料
            List<Products> Productss = new List<Products>
            {
                new Products{ Id=1, ProductName="Nike 360", UnitPrice="0933-152667", Caregory="Shoes"},
                new Products{ Id=2, ProductName="Nike", UnitPrice="0938-456889", Caregory="Shoes"},
                new Products{ Id=3, ProductName="NET", UnitPrice="0925-331225", Caregory="Clothes" },
                new Products{ Id=4, ProductName="Reebok", UnitPrice="0935-863991", Caregory="Clothes"},
                new Products{ Id=5, ProductName="Vans", UnitPrice="0987-335668", Caregory="Clothes" },
                new Products{ Id=6, ProductName="H&M", UnitPrice="0955-259885", Caregory="Shoes" },
                new Products{ Id=7, ProductName="Adidas Sport", UnitPrice="0921-123456", Caregory="Clothes"}
            };

            //Step 2:將List的每筆資料逐一加入Entity Framework的Productss之中
            Productss.ForEach(x => pdtContext.Products.Add(x));

            //Step 3:儲存異動
            pdtContext.SaveChanges();
        }

    }
}