namespace POC_Rest.Model
{
    public class Product
    {
        public long Id{ get; set; }

        public string Name { get; set; }

        //enum
        public string UnitOfMeasurement { get; set; }

        public double Liter { get; set; }

        public double Weight { get; set; }

        public decimal Price { get; set; }
    }
}
