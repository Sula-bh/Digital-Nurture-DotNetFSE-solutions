using OrderSortingExample;

Order[] orders1 =
{
    new Order(1, "John", 1500),
    new Order(2, "Alice", 500),
    new Order(3, "Bob", 3000),
    new Order(4, "David", 750)
};

OrderSorter.QuickSort(orders1, 0, orders1.Length - 1);

Console.WriteLine("Sorted by Quick Sort:");

foreach (var order in orders1)
{
    Console.WriteLine(order);
}

Order[] orders2 =
{
    new Order(1, "Sam", 2500),
    new Order(2, "Ben", 600),
    new Order(3, "Chris", 1000),
    new Order(4, "Smith", 850)
};

OrderSorter.BubbleSort(orders2);

Console.WriteLine("\nSorted by Bubble Sort:");

foreach (var order in orders2)
{
    Console.WriteLine(order);
}
