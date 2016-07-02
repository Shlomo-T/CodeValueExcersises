using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rationals
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational first = new Rational(6,12);
            Rational sec = new Rational(12, 6);
            Rational third = new Rational(5);

            Console.WriteLine("{0} object {1}","first", first);
            Console.WriteLine("{0} object {1}", "sec", sec);
            Console.WriteLine("{0} object {1}", "third", third);

            Console.WriteLine("reducing all objects");
            first.Reduce();
            sec.Reduce();
            third.Reduce();

            Console.WriteLine("Adding...");
            Console.WriteLine("Add first object and second object...");
            Console.WriteLine("Result is {0}",first.Add(sec));
            Console.WriteLine("Add second object and third object...");
            Console.WriteLine("Result is {0}", sec.Add(third));

            Console.WriteLine("Multiplying...");
            Console.WriteLine("Multiplying first object and second object...");
            Console.WriteLine("Result is {0}", first.Mul(sec));
            Console.WriteLine("Multiplying second object and third object...");
            Console.WriteLine("Result is {0}", sec.Mul(third));

            if (new Rational(5, 5).Equals(new Rational(5, 5)) && !new Rational(5, 5).Equals(new Rational(5, 3)))
            {
                Console.WriteLine("Equals working perfect...");
            }
            try
            {
                Rational rationalWithException = new Rational(5,0);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Not valid Rational was caught by the test...");
            }

            Console.WriteLine("---------------------------- lab 10 Appendix: ----------------------------");
            Rational test = new Rational(2,5);

            Console.WriteLine($"multiply test object {test} with itself equals to {test*test}");
            Console.WriteLine($"Dividing test object {test} with itself equals to {test / test}");
            Console.WriteLine($"Adding test object {test} with itself equals to {test + test}");
            Console.WriteLine($"Subtraction test object {test} with Rational of 1 equals to {test - new Rational(1)}");

            Console.WriteLine($"Cast int 10 to Rational object {(Rational) 10}");
            Console.WriteLine($"Cast test object {test} to double {(double) test}");

            Console.ReadKey();
        }
    }
}
