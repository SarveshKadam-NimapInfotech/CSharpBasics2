namespace Contructors
{
    public class Order
    {
        public int OrderId;
        public string ProductName;

        public Order(int id, string name)
        {
            this.OrderId = id;
            this.ProductName = name;


        }
    }
}