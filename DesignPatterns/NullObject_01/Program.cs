// Есть некий магазин с товарами
// 

using NullObject_01;

Console.Clear();
ListProduct listProducts = new ListProduct();

foreach (string productName in listProducts.products)
{
	try
	{
		Product product = Shop.GetProductOf(productName);
		Console.WriteLine(product.KCalOfProduct());
		product.eat();
	}
	catch(Exception e) 
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"Возникло исключение: {e.Message}");
		Console.WriteLine($"Стек ошибок: {e.StackTrace}");
		Console.ForegroundColor = ConsoleColor.White;
	}

}

Console.ReadKey();