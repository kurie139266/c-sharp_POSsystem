using POSSystem.Models;

List<Product> products = new()
{
    new Product { Id = 1, Name = "おにぎり", Price = 150 },
    new Product { Id = 2, Name = "パン", Price = 220 },
    new Product { Id = 3, Name = "お茶", Price = 180 }
};

Console.WriteLine("===== POSシステム =====");

foreach (var product in products)
{
    Console.WriteLine($"{product.Id}. {product.Name} {product.Price}円");
}

Console.WriteLine("商品番号を入力してください:");

string? input = Console.ReadLine();

bool terminal = int.TryParse(input, out int result);

bool found = false;

if(!terminal)
{
    Console.WriteLine("数字を入力してください");
}
else
{
    foreach (var product in products)
    {
        if(result == product.Id)
        {
            found = true;
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
        }
    }
        if(!found)
    {
        Console.WriteLine("商品は存在しません");
    }
}
