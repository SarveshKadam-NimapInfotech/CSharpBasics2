using System.Collections.Generic;

namespace Fields
{
    public class customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        //public customer()
        //{
        //    Orders = new List<Order>();
        //}

        public customer(int id)
        {
            this.Id = id;
            
        }

        public customer(int id, string name) : this(id)
        {
            this.Name = name;

        }
        
        public void Promote()
        {
            //Orders = new List<Order> (); // when field made readonly it gets initialize only once, if tried to 
                                         // initialize again it will give and compile time error
        }


    }
}
