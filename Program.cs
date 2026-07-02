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