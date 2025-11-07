using Microsoft.AspNetCore.Mvc;
//using MVC_Layout.Models;
using MVC_Layout.Models.Northwind;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MVC_Layout.Controllers
{
    public class SupplierController : Controller
    {

        //Northwind Instance
        NorthwindContext _context=new NorthwindContext();




        //tedarikçi Listeleme
        public IActionResult Index()
        {
            //List<Supplier> suppliers = MVC_Layout.Data.SupplierDummyData.suppliers;
            //return View(suppliers);

           

            return View(_context.Suppliers.ToList());
        }


        //Tedarikçi Oluşturma
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            //supplier.ID = MVC_Layout.Data.SupplierDummyData.suppliers.Count + 1;
            //MVC_Layout.Data.SupplierDummyData.suppliers.Add(supplier);
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        //Tedarikçi Güncelleme
        [HttpGet]
        public IActionResult Update(int id)
        {
            //Supplier updated = MVC_Layout.Data.SupplierDummyData.suppliers.FirstOrDefault(x => x.ID == id);
            //return View(updated);

            Supplier updated= _context.Suppliers.Find(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Supplier updated)
        {

            //Supplier existSupplier = MVC_Layout.Data.SupplierDummyData.suppliers.FirstOrDefault(x => x.ID == updated.ID);

            //if (existSupplier != null)
            //{
            //    //güncelleme işlemi
            //    existSupplier.CompanyName = updated.CompanyName;
            //    existSupplier.ContactName = updated.ContactName;
            //    existSupplier.PhoneNumber = updated.PhoneNumber;
            //}

            //return RedirectToAction("Index");

            Supplier supplier = _context.Suppliers.Find(updated.SupplierId);

            supplier.CompanyName=updated.CompanyName;
            supplier.ContactName=updated.ContactName;
            supplier.Phone = updated.Phone;

            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            //Supplier deleted = MVC_Layout.Data.SupplierDummyData.suppliers.FirstOrDefault(x => x.ID == id);
            //if (deleted != null)
            //{
            //    MVC_Layout.Data.SupplierDummyData.suppliers.Remove(deleted);
            //}
            //return RedirectToAction("Index");

            Supplier supplier = _context.Suppliers.Find(id);
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
