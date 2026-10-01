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
//商品選択
while (true)
{
    Console.WriteLine("商品番号を入力してください:");
    Console.WriteLine("会計へ進む場合は0を");

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
            int total = CalculateTotal(cart);

            Console.WriteLine($"合計金額：{total}円");
            Console.WriteLine("お預かり金額を入力してください:");

            string? moneyInput = Console.ReadLine();

            bool moneyCheck = int.TryParse(moneyInput, out int money);

            if(!moneyCheck)
            {
                Console.WriteLine("数字を入力してください");
                continue;
            }
            else if(money < total)
            {
                Console.WriteLine("お金が足りません");
                continue;
            }
            else
            {
                int change = money - total;
                Console.WriteLine($"お釣り：{change}円");
            }

            break;
        }
        foreach (var product in products)
        {
            if(result == product.Id)
            {
                found = true;
                cart.Add(product);
                Console.WriteLine($"{product.Name} をカートに追加しました");
                Console.WriteLine("現在のカート");
                Console.WriteLine("----------------");
                foreach (var item in cart)
                {
                    Console.WriteLine($"{item.Name} {item.Price}円");
                }

                int total = CalculateTotal(cart);


                Console.WriteLine($"現在のカート合計金額：{total}円");
            }
        }
            if(!found)
        {
            Console.WriteLine("商品は存在しません");
        }
    }
}

//ここで合計計算をする
static int CalculateTotal(List<Product> cart)
{
    int total = 0;

    foreach(var item in cart)
    {
        total += item.Price;
    }

    return total;
}