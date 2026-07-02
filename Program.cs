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

if (terminal == true)
{
    Console.WriteLine($"入力された番号：{result}");
}
else
{
    Console.WriteLine("数字を入力してください");
}
