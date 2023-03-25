// Есть некий магазин с товарами
// 

using NullObject_01;

Console.Clear();
ListProduct listProducts = new ListProduct();

foreach (string productName in listProducts.products)
{
		Product product = Shop.GetProductOf(productName);
		Console.WriteLine(product.KCalOfProduct());
		product.eat();

}

Console.ReadKey();