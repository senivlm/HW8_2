namespace HW8_21
{
    class Product
    {
        private string name;
        private double price;
        public string Name => name;
        public double Price => price;


        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

    }
}
