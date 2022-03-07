using System.ComponentModel.DataAnnotations.Schema;

namespace POC_Rest.Model
{
    [Table("product")]
    public class Product
    {
        [Column("id")]
        public long Id{ get; set; }

        [Column("name")]
        public string Name { get; set; }

        //enum
        [Column("unit_of_measurement")]
        public string UnitOfMeasurement { get; set; }

        [Column("liter")]
        public double Liter { get; set; }

        [Column("weight")]
        public double Weight { get; set; }

        [Column("price")]
        public decimal Price { get; set; }
    }
}
