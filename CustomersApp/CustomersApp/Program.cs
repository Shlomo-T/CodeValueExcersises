using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Customer[] arr = new Customer[3];
            arr[0] = new Customer(3, "shlomo", "address");
            arr[1] = new Customer(99, "Haim", "address");
            arr[2] = new Customer(21,"avi","address");

            foreach (var customer in arr)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("After regular sorting....");
            Array.Sort(arr);
            foreach (var customer in arr)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("After AnotherCustomerComparer sorting");
            Array.Sort(arr,new AnotherCustomerComparer());
            foreach (var customer in arr)
            {
                Console.WriteLine(customer);
            }
            Console.ReadKey();
        }
    }
}
