using Bogus;
using DAL.Entities.Concretes;
using DAL.Entities.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Seeds
{
    public class SupplierSeeder
    {
        public static List<Supplier> GetFakeSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            var faker = new Faker();

            for (int i = 0; i < 10; i++)
            {
                Supplier supplier = new Supplier
                {
                    ID = i + 1,
                    CompanyName = faker.Company.CompanyName(),
                    ContactName = faker.Name.FullName(),
                    ContactTitle = faker.Name.JobTitle(),
                    Address = faker.Address.StreetAddress(),
                    City = faker.Address.City(),
                    Country = faker.Address.Country(),
                    Phone = faker.Phone.PhoneNumber(),
                    IsActive = true,
                    Status = DataStatus.Active,
                    CreatedDate = DateTime.Now
                };
                suppliers.Add(supplier);
            }

            return suppliers;
        }
    }
}