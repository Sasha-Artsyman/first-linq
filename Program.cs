using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
       // создание набор для тестирования
        ProductInfo[] itemsInStock = new[] {
new ProductInfo{ Name = "Coffee", Price = 2, NumberlnStock = 24},
new ProductInfo{ Name = "Milk", Price = 2, NumberlnStock = 100},
new ProductInfo{ Name = "Tofu", Price = 4, NumberlnStock = 120},
new ProductInfo{ Name = "Pops", Price = 3, NumberlnStock = 2},
new ProductInfo{ Name = "Water", Price = 1, NumberlnStock = 100},
new ProductInfo{ Name = "Pizza", Price = 4, NumberlnStock = 73}
};
        // подсчет количества элементов
        int numb = (from g in itemsInStock where g.Name.Length > 4 select g).Count();
        Console.WriteLine("{0} items honor the LINQ query (name length > 4)", numb);
        Console.WriteLine("-------------------");

        // изменение порядка на обратный
        Console.WriteLine("Product in reverse:");
        var allProducts = from p in itemsInStock select p;
        foreach (var prod in allProducts.Reverse())
        {
            Console.WriteLine(prod.ToString());
        }
        Console.WriteLine("-------------------");

        // сортировка по условию
        var subset = from p in itemsInStock orderby p.Name select p;
        Console.WriteLine("Ordered by Name:");
        foreach (var p in subset)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine("-------------------");

        // отбор по условию
        var selectedProducts = itemsInStock.Where(p => p.Name.ToUpper().StartsWith("T"));
        Console.WriteLine("Whose Name starts with T:");
        foreach (var selectedProduct in selectedProducts)
            Console.WriteLine(selectedProduct.ToString());
        Console.WriteLine("-------------------");


        Console.ReadLine();
    }
}