using CA_NorthwindEF.Managers.Concretes;
using CA_NorthwindEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindEF.Managers
{
    internal class ConsoleManager
    {

         CategoryManagerTest categoryManager = new CategoryManagerTest();
        ProductManager productManager = new ProductManager();
        #region Kategori Console İşlemleri


        internal Category GetConsoleCategoryValues()
        {

            Category category = new Category();

            Console.WriteLine("ltüfen kategori adı girin: ");
            category.CategoryName = Console.ReadLine();
            Console.WriteLine("açıklama girin: ");
            category.Description = Console.ReadLine();

            return category;
        }

        internal string UpdateConsoleCategory(int id)
        {
            try
            {
                Category category = categoryManager.GetCategoryById(id);
                Console.WriteLine("Güncellenecek kategori ad: ");
                category.CategoryName = Console.ReadLine();
                Console.WriteLine("Güncellenecek açıklama");
                category.Description = Console.ReadLine();

                categoryManager.UpdateCategory(category);

                return "Güncelleme başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        internal string DeleteConsoleCategory(int id)
        {


            try
            {
                categoryManager.DeleteCategory(id);
                return "kategori başarılı şekilde kaldırıldı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        internal void GetConsoleCategories()
        {

            Console.WriteLine("Kategoriler çoktan az'a mı listelensin?");

            string tercih = Console.ReadLine();
            if (tercih == "evet" || tercih == "e")
            {
                foreach (var item in categoryManager.GetCategories(true))
                {
                    Console.WriteLine(item.CategoryName);
                }
            }
            else
            {
                foreach (var item in categoryManager.GetCategories(false))
                {
                    Console.WriteLine(item.CategoryName);
                }
            }




        }
        #endregion



        #region Ürün Console İşlemleri
        public void GetConsoleProductValues()
        {
            foreach (var item in productManager.GetProducts())
            {
                Console.WriteLine(item.ProductName);
            }
        }
        #endregion


        #region Tedarikçi Console İşlemleri

        #endregion

    }
}
