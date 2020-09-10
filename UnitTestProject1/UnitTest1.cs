using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Web;
using ASP.NET_MVC_5_CURD.Controllers;
using System.Data.SqlClient;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    [DeploymentItem("App_Data\\Northwind.mdf")]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(context.TestDeploymentDir, string.Empty));
        }

        public UnitTest1()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data"));
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }
        [TestMethod]
        [DeploymentItem("Northwind.mdf")]
        public void TestMethod1()
        {
            var dbContext = new ProductsContext("ProductsContext");
            IEnumerable<Products> result = null;
            result = dbContext.Identities.ToList();
            Assert.IsNotNull(result);

            //unit test 呼叫專案controller無法直接讀取mdf
            //IEnumerable<Products> result = null;
            //using (ProductsContext dbb = new ProductsContext())
            //{
            //    result = dbb.Identities.AsNoTracking().ToList();
            //}
            //ProductsController cc = new ProductsController();
            //ViewResult result = cc.Index() as ViewResult;
        }

        public class ProductsContext : DbContext
        {
            public ProductsContext()
                : base("ProductsContext")
            {
            }

            public ProductsContext(string connectString)
                : base(connectString)
            {
            }

            public DbSet<Products> Identities { get; set; }

        }

        public class Products
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string Price { get; set; }
            public string Caregory { get; set; }
            public string UnitPrice { get; set; }
        }
    }
}
