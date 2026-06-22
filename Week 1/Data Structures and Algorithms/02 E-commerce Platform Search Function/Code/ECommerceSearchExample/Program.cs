using ECommerceSearchExample;

Product[] products =
{
    new Product(101, "Laptop", "Electronics"),
    new Product(102, "Mouse", "Electronics"),
    new Product(103, "Keyboard", "Electronics"),
    new Product(104, "Monitor", "Electronics"),
    new Product(105, "Printer", "Electronics")
};

var linearResult = SearchService.LinearSearch(products, 104);

Console.WriteLine($"Linear Search: {linearResult}");

var binaryResult = SearchService.BinarySearch(products, 104);

Console.WriteLine($"Binary Search: {binaryResult}");
