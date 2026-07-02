using RetailInventory.Data;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

using AppDbContext context = new();

Category electronics = new()
{
    Name = "Electronics"
};

Category groceries = new()
{
    Name = "Groceries"
};

await context.Categories.AddRangeAsync(
    electronics,
    groceries);

Product laptop = new()
{
    Name = "Laptop",
    Price = 75000,
    Category = electronics
};

Product riceBag = new()
{
    Name = "Rice Bag",
    Price = 1200,
    Category = groceries
};

await context.Products.AddRangeAsync(
    laptop,
    riceBag);

await context.SaveChangesAsync();

Console.WriteLine("Data inserted successfully.");

List<Product> products =
    await context.Products.ToListAsync();

foreach (Product product in products)
{
    Console.WriteLine(
        $"{product.Id} - {product.Name} - ₹{product.Price}");
}

Product? pro =
    await context.Products.FindAsync(1);

Console.WriteLine(pro?.Name);

Product? expensive =
    await context.Products
        .FirstOrDefaultAsync(
            p => p.Price > 50000);

Console.WriteLine(expensive?.Name);
