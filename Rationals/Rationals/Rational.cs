using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rationals
{
    public struct Rational
    {
        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }
        public double Value { get { return (double)numerator / denominator; } }

        private int numerator;
        private int denominator;

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException();
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Rational(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public Rational Add(Rational rt)
        {
            // Adding two rational object
            this.Reduce();
            rt.Reduce();
            if (rt.denominator == this.denominator)
            {
                return new Rational(this.numerator + rt.numerator, this.denominator);

            }

            int numerator = this.numerator * rt.denominator + rt.numerator * this.denominator;
            int denominator = this.denominator * rt.denominator;
            return new Rational(numerator, denominator);
        }
        public Rational Mul(Rational rt)
        {
            int numerator = this.numerator * rt.numerator;
            int denominator = this.denominator * rt.denominator;
            return new Rational(numerator, denominator);
        }

        public void Reduce()
        {
            //using GCD algorithm to simplify the Rational object 
            int gcd = Gcd(Math.Max(this.numerator, this.denominator), Math.Min(this.numerator, this.denominator));
            if (gcd != 0)
            {
                this.numerator /= gcd;
                this.denominator /= gcd;
            }
        }
        private int Gcd(int a, int b)
        {
            //implementing  recursive GCD algorithm
            return b == 0 ? a : Gcd(b, a % b);
        }
        public override string ToString()
        {
            return string.Format("Rational - Numerator:{0} denominator:{1} and value is {2}", this.numerator, this.denominator,this.Value);
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof (Rational) && ((Rational) obj).numerator == this.numerator &&
                   ((Rational) obj).denominator == this.denominator;
            
        }
    }
}
