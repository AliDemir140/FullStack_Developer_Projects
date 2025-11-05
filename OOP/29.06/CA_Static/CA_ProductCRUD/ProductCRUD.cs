using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCRUD
{
    internal class ProductCRUD
    {
        //CREATE
        public void CreateProduct(Product product)
        {
            ProductData.productList.Add(product);

        }
        //READ
        public void GetAllProducts()
        {
            foreach (Product p in ProductData.productList)
            {
                Console.WriteLine(p.Description+" "+p.UnitPrice);
            }
        }

        //UPDATE
        public void UpdateProduct(Product updated)
        {
            foreach (Product p in ProductData.productList)
            {
                if (updated.Id == p.Id)
                {
                    p.UnitPrice = updated.UnitPrice;
                    p.Description = updated.Description;
                    break;
                }
            }
        }

        //DELETE
        public void DeleteProduct(int id)
        {
            foreach (Product p in ProductData.productList)
            {
                if (id == p.Id)
                {
                    ProductData.productList.Remove(p);
                    break;
                }
            }
        }

    }
}
