namespace DAL.Entities
{
    public class Category
    {

        public int ID { get; set; }

        #region Encapsulation
        //private string _categoryName;
        //public string CategoryName
        //{
        //    get
        //    {
        //        return _categoryName;
        //    }
        //    set
        //    {
        //        if (value != null)
        //        {
        //            _categoryName = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("kategori adı boş geçilemez!");
        //        }
        //    }



        //} 
        #endregion
        public string CategoryName { get; set; }
  

        //bir kategorinin birden fazla ürünü olur.
        public List<Product> Products { get; set; }
    }
}
