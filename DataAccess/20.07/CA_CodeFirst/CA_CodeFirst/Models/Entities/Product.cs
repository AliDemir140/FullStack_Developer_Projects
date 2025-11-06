namespace CA_CodeFirst.Models.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        //Bir Product (ürün) bir adet category (kategori) olur.
        public int CategoryId { get; set; } //FK Property
        public Category Category { get; set; }
    }
}
