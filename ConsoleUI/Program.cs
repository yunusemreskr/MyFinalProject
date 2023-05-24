using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Collections.Generic;
using System.Net.Http.Headers;

public class Program
{
    //Data Transformation Object
    //SOLID
    //Open Closed Principle
    private static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------------------------");
        ProductTest();
        Console.WriteLine("-------------------------------------------------");
        //CategoryTest();










    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetProductDetails())
        {
            
            Console.WriteLine(product.ProductName+ "/" + product.CategoryName);
        }
    }
}