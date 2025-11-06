using CA_ServicePattern.Entities;

namespace CA_ServicePattern.Seeds
{
    internal class CategorySeeder
    {
        //CAtegories
        static internal List<Category> categories = new List<Category>
        {
            new Category{ID=1,CategoryName="Test Category 1"},
            new Category{ID=2,CategoryName="Test Category 2"},
            new Category{ID=3,CategoryName="Test Category 3"},

        };

        //Fake Data
        static internal List<Category> categoriesFakeData = new List<Category>
        {
            new Category{ID=1,CategoryName="Test Fake Category  1"},
            new Category{ID=2,CategoryName="Test Fake Category 2"},
            new Category{ID=3,CategoryName="Test Fake Category 3"},

        };

    }
}
