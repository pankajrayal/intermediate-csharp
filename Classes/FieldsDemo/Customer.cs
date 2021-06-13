using System.Collections.Generic;

namespace FieldsDemo
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // Below field will error because the List<Order> is readonly.
            //Orders = new List<Order>();
        }
    }
}
