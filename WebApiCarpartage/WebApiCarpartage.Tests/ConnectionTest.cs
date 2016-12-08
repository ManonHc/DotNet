using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modeles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCarpartage.Models;
using System.Resources;

namespace WebApiCarpartage.Tests
{
    [TestClass]
    class ConnectionTest
    {

        private WebApiCarpartageContext GetContext()
        {
            return new WebApiCarpartageContext();
        }

        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DbInitializer());
            using (WebApiCarpartageContext context = GetContext())
            {
                context.Database.Initialize(true);
            }

        }

        [TestMethod]
        public void CreationDB()
        {
            // nous nous sommes également basé sur le help.cs de votre bankacount project
            using (SqlConnection conn = User.GetDatabaseConnection())
            {
                conn.Open();
                conn.Close();
            }
        }
    }
}
