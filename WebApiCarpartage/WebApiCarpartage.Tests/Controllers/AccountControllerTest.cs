using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCarpartage.Controllers;
using WebApiCarpartage.Models;

namespace WebApiCarpartage.Tests.Controllers
{
    [TestClass]
   public class AccountControllerTest
    {

        [TestMethod]
        public void Register()
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "SuperPowerUser",
                Email = "taiseer.joudeh@mymail.com",
                EmailConfirmed = true,
            };

            manager.Create(user, "MySuperP@ssword!");

        }
    }
}
