using CA_ServicePattern.Context;
using CA_ServicePattern.Entities;
using CA_ServicePattern.Seeds;

namespace CA_ServicePattern.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        CodeFirstContext _context = new CodeFirstContext();
        public void CreateCategory(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteCategory(int id)
        {
            var deletedCategory = _context.Categories.FirstOrDefault(x => x.ID == id);
            if (deletedCategory != null)
            {
                _context.Categories.Remove(deletedCategory);
            }
            else
            {
                Console.WriteLine("böyle bir kategori bulunamadı!");
            }
        }

        public List<Category> GetCategories(bool desc)
        {
            //eğer desc true gelirse kategoriler Id'e göre çoktan az'a sıralansın.
            //Değilse az'dan çok'a sıralansın.

            if (desc)
            {
                return _context.Categories.OrderByDescending(x => x.ID).ToList();
            }
            else
            {
                return _context.Categories.ToList();
            }

        }

        public void UpdateCategory(Category updated)
        {
            //var existsCategory = _context.Categories.FirstOrDefault(x => x.ID == updated.ID);

            if (updated != null)
            {
                _context.Entry(updated).State = Microsoft.EntityFrameworkCore.EntityState.Modified;



                _context.SaveChanges();

            }
            else
            {
                Console.WriteLine("kategori bulunamadı!");
            }
        }
    }
}
