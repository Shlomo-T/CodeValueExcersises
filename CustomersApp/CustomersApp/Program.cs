using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Program
    {
        delegate bool CustomerFilter(Customer c);
        static void Main(string[] args)
        { 
            Customer[] arr = new Customer[3];
            arr[0] = new Customer(3, "Shlomo", "address");
            arr[1] = new Customer(99, "Haim", "address");
            arr[2] = new Customer(101,"Avi","address");

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

            Console.WriteLine("Querying all users that their name start in the range of A-K...");
            ICollection<Customer> result = GetCustomers(arr, CustomersAtoK);
            foreach (var customer in result)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("Querying all users that their name start in the range of L-Z...");
             result = GetCustomers(arr, delegate(Customer customer)
             {
                 if (customer != null && !string.IsNullOrEmpty(customer.Name) && customer.Name[0] >= 'L' && customer.Name[0] <= 'Z')
                 {
                     return true;
                 }
                 return false;
             });
            foreach (var customer in result)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("Querying all users that their ID is less then 100...");
            result = GetCustomers(arr, customer=> customer!=null && customer.ID<100);
            foreach (var customer in result)
            {
                Console.WriteLine(customer);
            }
            Console.ReadKey();
        }

        static ICollection<Customer> GetCustomers(ICollection<Customer> collection, CustomerFilter filter)
        {
            ICollection<Customer> ans=new List<Customer>();
            foreach (var item in collection)
            {
                if (item != null && filter != null && filter(item))
                {
                    ans.Add(item);
                }
            }
            return ans;
        }

        static bool CustomersAtoK(Customer customer)
        {
            if (customer != null && !string.IsNullOrEmpty(customer.Name) && customer.Name[0]>='A' && customer.Name[0] <= 'K')
            {
                return true;
            }
            return false;
        } 
    }
}
