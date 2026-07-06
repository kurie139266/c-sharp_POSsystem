using POSSystem.Models;

List<Product> products = new()
{
    new Product { Id = 1, Name = "おにぎり", Price = 150 },
    new Product { Id = 2, Name = "パン", Price = 220 },
    new Product { Id = 3, Name = "お茶", Price = 180 }
};

List<Product> cart = new();


Console.WriteLine("===== POSシステム =====");

foreach (var product in products)
{
    Console.WriteLine($"{product.Id}. {product.Name} {product.Price}円");
}

while (true)
{
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
        if(result == 0)
        {
        break;
        }
        foreach (var product in products)
        {
            if(result == product.Id)
            {
                int total = 0;
                found = true;
                cart.Add(product);
                Console.WriteLine($"{product.Name} をカートに追加しました");
                Console.WriteLine("現在のカート");
                Console.WriteLine("----------------");
                foreach (var item in cart)
                {
                    Console.WriteLine($"{item.Name} {item.Price}円");
                    total += item.Price;
                    Console.WriteLine($"現在のカート合計金額：{total}円");
                }
            }
        }
            if(!found)
        {
            Console.WriteLine("商品は存在しません");
        }
    }
}