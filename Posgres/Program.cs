using (var context = new ApplicationDbContext())
{
    var products = context.Cats.ToList();
    foreach (var product in products)
    {
        Console.WriteLine($"Product Name: {product.name}, Price: {product.id}");
    }
}