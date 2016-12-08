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
using WebApiCarpartage.Controllers;

namespace WebApiCarpartage.Tests
{
    [TestClass]
    public class ConnectionTest
    {

        private ApplicationDbContext GetContext()
        {
            return new ApplicationDbContext();
        }

        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationDbContext>());
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Database.Initialize(true);
            }

        }


    }
}

