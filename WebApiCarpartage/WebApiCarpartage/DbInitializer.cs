using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApiCarpartage.Models;

namespace WebApiCarpartage
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<WebApiCarpartageContext>
    {

    }
}