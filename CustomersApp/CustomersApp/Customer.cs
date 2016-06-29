using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    public class Customer: IComparable<Customer>, IEquatable<Customer>
    {
        private int _mId ;
        private string _mAddress;
        private string _mName;

        public int ID { get { return _mId; } }
        public  string Name { get { return _mName; } }
        public string Address { get { return _mAddress; } }

        public Customer(int id, string name, string address)
        {
            this._mId = id;
            this._mName = name;
            this._mAddress = address;
        }
        public int CompareTo(Customer other)
        {
            if (other == null)
            {
                return 1;
            }

            return string.Compare(this.Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
        }

        public bool Equals(Customer other)
        {
            return other != null && this.Name.Equals(other.Name) && this.ID.Equals(other.ID);
        }

        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Address: {2}", ID, Name, Address);
        }

         
    }
}
