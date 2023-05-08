using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Collections.Generic;
using System.Net.Http.Headers;

public class Program
{
    //SOLID
    //Open Closed Principle
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetAllByCategoryId(2))
        {
            Console.WriteLine(product.ProductName);
        }

        

        //Console.WriteLine(List<Product> GetAll());
    }
}