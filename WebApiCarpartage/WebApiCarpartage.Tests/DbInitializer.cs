
using Modeles;
using System.Data.Entity;
using WebApiCarpartage.Models;

namespace WebApiCarpartage.Tests
{
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {


        /*    ApplicationUser user1 = new ApplicationUser()
            {
                Name = "LauraB",
                Password = "1efgeugrh23",
                Phone = "0471652493",
                Mail = "lauraB@gmail.com",
            };
            context.Users.Add(user1);

            Address address1 = new Address()
            {
                Street = "Rue pepin",
                Number = 4,
                Location = "Namur",
                Longitude = 183818.131,
                Latitude = 138813.131,
                User = user1
            };
            context.Addresses.Add(address1);

            Post post1 = new Post()
            {
                SizeShopping = 2,
                AmountPlace = 4,
                Date = new System.DateTime(2016, 11, 30),
                UserOwner = user1,
                Description = "blabla",
                Price = 2.30,
                typeOfPost = "driver",
                TimePeriod = 3,
                DetourKm = 5
            };
            context.Posts.Add(post1);
            Post post2 = new Post()
            {
                SizeShopping = 2,
                AmountPlace = 4,
                Date = new System.DateTime(2016, 12, 01),
                UserOwner = user1,
                Description = "blabla",
                Price = 1.60,
                typeOfPost = "driver",
                TimePeriod = 2,
                DetourKm = 2
            };
            context.Posts.Add(post2);


            ApplicationUser user2 = new ApplicationUser()
            {
                Name = "Marie",
                Password = "zuhegrbo6262",
                Phone = "0471465512",
                Mail = "marie@gmail.com"

            };
            context.Users.Add(user2);

            Address address2 = new Address()
            {
                Street = "Rue pepin",
                Number = 4,
                Location = "Namur",
                Longitude = 183818.131,
                Latitude = 138813.131,
                User = user2
            };
            context.Addresses.Add(address2);

            Post post3 = new Post()
            {
                SizeShopping = 1,
                Date = new System.DateTime(2016, 12, 03),
                UserOwner = user2,
                Description = "blabla",
                typeOfPost = "passenger",
                TimePeriod = 2,
                NbPersons = 2
            };
            context.Posts.Add(post3);

            ApplicationUser user3 = new ApplicationUser()
            {
                Name = "Manon",
                Password = "ayzrhuertij777",
                Phone = "0471452599",
                Mail = "manon@gwallontours.be"

            };
            context.Users.Add(user3);

            Address address3 = new Address()
            {
                Street = "Rue pepin",
                Number = 4,
                Location = "Namur",
                Longitude = 183818.131,
                Latitude = 138813.131,
                User = user3
            };
            context.Addresses.Add(address3);


            ApplicationUser user4 = new ApplicationUser()
            {
                Name = "Leandro",
                Password = "azgirvnt",
                Phone = "0495790740",
                Mail = "leandro@pokerbelgique.be"

            };
            context.Users.Add(user4);

            Address address4 = new Address()
            {
                Street = "Rue pepin",
                Number = 4,
                Location = "Namur",
                Longitude = 183818.131,
                Latitude = 138813.131,
                User = user4
            };
            context.Addresses.Add(address4);


            ApplicationUser user5 = new ApplicationUser()
            {
                Name = "Damien",
                Password = "09876543",
                Phone = "049876543",
                Mail = "damine@gmail.com"

            };
            context.Users.Add(user5);

            Address address5 = new Address()
            {
                Street = "Rue pepin",
                Number = 4,
                Location = "Namur",
                Longitude = 183818.131,
                Latitude = 138813.131,
                User = user5
            };
            context.Addresses.Add(address5);



            context.SaveChanges();*/
        }
    }
    }
