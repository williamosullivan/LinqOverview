using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverview
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return CustomerID + "\t" + City;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ObjectQuery();
        }

        static IEnumerable<Customer> CreateCustomers()
        {
            return new List<Customer>
            {
                new Customer { CustomerID = "ALFKI", City = "Berlin" },
                new Customer { CustomerID = "BONAP", City = "Merseille" },
                new Customer { CustomerID = "CONSH", City = "London" },
                new Customer { CustomerID = "EASTC", City = "London" },
                new Customer { CustomerID = "FRANS", City = "Torino" },
                new Customer { CustomerID = "LONEP", City = "Portland" },
                new Customer { CustomerID = "NORTS", City = "London" },
                new Customer { CustomerID = "THEBI", City = "Portland" }
            };
        }

        static void ObjectQuery()
        {
            var results = from c in CreateCustomers()
                          where c.City == "London"
                          select c;
            foreach (var c in results)
                Console.WriteLine(c);
        }
        static void NumQuery()
        {
            var numbers = new int[] { 1, 4, 9, 16, 25, 36 };
            var evenNumbers = from p in numbers
                              where (p % 2) == 0
                              select p;
            Console.WriteLine("Result: ");
            foreach (var val in evenNumbers)
                Console.WriteLine(val);
        }
    }
}
