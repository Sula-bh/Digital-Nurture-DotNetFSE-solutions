using InventoryManagementSystem;

InventoryManager manager = new InventoryManager();

manager.AddProduct(
    new Product(
        101,
        "Laptop",
        10,
        50000));

manager.AddProduct(
    new Product(
        102,
        "Mouse",
        50,
        500));

manager.DisplayProducts();

Console.WriteLine();

manager.UpdateProduct(
    101,
    15,
    52000);

Console.WriteLine("After Update");

manager.DisplayProducts();

Console.WriteLine();

manager.DeleteProduct(102);

Console.WriteLine("After Delete");

manager.DisplayProducts();
