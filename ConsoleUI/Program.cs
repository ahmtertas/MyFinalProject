// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;




ProductManager productManager = new ProductManager(new EfProductDal());

var result = productManager.GetProductDetails();
if (result.Success)
{
    foreach (var product in result.Data)
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
   
}
else
{
    Console.WriteLine(result.Message);
}

foreach (var productDetail in productManager.GetProductDetails().Data)
{
    Console.WriteLine("{0}  {1} ",productDetail.ProductName,productDetail.CategoryName);
}        

Console.ReadLine();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var item in productManager.GetByUnitPrice(10, 30).Data)
    {
        Console.WriteLine(item.ProductName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
} 