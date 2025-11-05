//PRODUCT CRUD

/*
    OOP prensipleri
    1-Encapsulation
    2-Inheritance
    3-Polymorphism
    4-Abstaction (Soyutlama)
 */


using CA_ProductCRUD;

///

ProductCRUD productCRUD = new ProductCRUD();

Product p1 = new Product();
p1.Id = 1;
p1.Description = "Ayakkabı";
p1.UnitPrice = 5400;
productCRUD.CreateProduct(p1);


Product p2 = new Product();
p2.Id= 2;
p2.Description = "Şapka";
p2.UnitPrice = 50;
productCRUD.CreateProduct(p2);

Console.WriteLine("Güncelleme öncesi");
productCRUD.GetAllProducts();

Product guncellenecekUrun = new Product();
guncellenecekUrun.Id = 1;
guncellenecekUrun.Description = "Jean";
guncellenecekUrun.UnitPrice = 2000;

productCRUD.UpdateProduct(guncellenecekUrun);

Console.WriteLine("Güncelleme sonrası");
productCRUD.GetAllProducts();


productCRUD.DeleteProduct(2);
Console.WriteLine("***2 nolu Id kaldırıldı.***");

productCRUD.GetAllProducts();