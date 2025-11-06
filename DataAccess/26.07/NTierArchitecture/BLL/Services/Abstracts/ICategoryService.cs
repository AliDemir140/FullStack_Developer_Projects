using DAL.Entities;

namespace BLL.Services.Abstracts
{
    public interface ICategoryService
    {
        //?
        //CRUD
        //Create: bir kategori oluşturmak için hangi metoda ihtiyacımız bulunmaktadır.
        void CreateCategory(Category category);

        //Read
        List<Category> GetCategories(bool desc);
        //Update
        void UpdateCategory(Category updated);
        //Delete
        void DeleteCategory(int id);
    }
}
