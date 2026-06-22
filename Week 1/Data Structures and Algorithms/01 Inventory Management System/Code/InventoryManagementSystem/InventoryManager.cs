namespace InventoryManagementSystem;

public class InventoryManager
{
    private readonly Dictionary<int, Product> inventory = new();

    public void AddProduct(Product product)
    {
        inventory[product.ProductId] = product;
    }

    public void UpdateProduct(
        int productId,
        int quantity,
        decimal price)
    {
        if (inventory.TryGetValue(
            productId,
            out Product? product))
        {
            product.Quantity = quantity;
            product.Price = price;
        }
    }

    public void DeleteProduct(int productId)
    {
        inventory.Remove(productId);
    }

    public Product? GetProduct(int productId)
    {
        inventory.TryGetValue(
            productId,
            out Product? product);

        return product;
    }

    public void DisplayProducts()
    {
        foreach (var product in inventory.Values)
        {
            Console.WriteLine(product);
        }
    }
}