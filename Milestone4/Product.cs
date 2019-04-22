namespace Milestone4
{
    public class Product
    {
        public string name { set; get; }
        public int stock { set; get; }
        public double price { set; get; }
        public string prodId { set; get; }
        public string origin { set; get; }

        public Product(string name, int stock, double price, string prodId, string origin)
        {
            this.name = name;
            this.stock = stock;
            this.price = price;
            this.prodId = prodId;
            this.origin = origin;
        }
        public override string ToString()
        {
            return "Name: " + name + ", Stock: " + stock + ", Price: $" + price + ", Id: " + prodId;
        }
    }
}