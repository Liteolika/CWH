using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWH.Tests
{
    public class SqlLiteTests
    {

        [Test]
        public void Test()
        {
            using (var db = new AppDb())
            {

                Person p = new Person { Name = "Peter" };
                p.Addresses.Add(new Address { City = "Bälinge" });
                p.Addresses.Add(new Address { City = "Spånga" });

                db.Persons.Add(p);

                db.SaveChanges();

                var a = db.Persons.Include("Addresses").ToList();

                var b = 1;

            }
        }

    }

    public class AppDb : DbContext
    {

        public AppDb()
            : base("AppDb")
        {
            Database.Connection.ConnectionString = "Data Source=myCards.db;Version=3;New=True;";
        }

        public DbSet<Person> Persons { get; set; }


    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public Person()
        {
            this.Addresses = new HashSet<Address>();
        }
    }

    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
    }

}
