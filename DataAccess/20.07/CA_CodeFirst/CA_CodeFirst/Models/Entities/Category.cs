namespace CA_CodeFirst.Models.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        //Bir category'nin birden fazla Product olur.
        public List<Product> Products { get; set; }

    }
}
