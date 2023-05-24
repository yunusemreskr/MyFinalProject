using Business.Concrete;
using Business.Constants;
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

        var result = productManager.GetProductDetails();

        if (result.Success==true)
        {
            foreach (var product in result.Data)
            {

                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                
            }
            Console.WriteLine(Messages.ProductsListed);
        }
        else 
        {
            Console.WriteLine(result.Message);
        }
        
    }
}