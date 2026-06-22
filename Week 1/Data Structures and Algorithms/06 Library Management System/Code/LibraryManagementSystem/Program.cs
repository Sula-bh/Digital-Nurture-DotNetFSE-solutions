using LibraryManagementSystem;

Book[] books =
{
    new Book(1, "C", "Dennis Ritchie"),
    new Book(2, "C#", "Microsoft"),
    new Book(3, "Java", "James Gosling"),
    new Book(4, "Python", "Guido van Rossum"),
    new Book(5, "SQL", "Oracle")
};

var linearResult =
    LibrarySearch.LinearSearch(
        books,
        "Python");

Console.WriteLine($"Linear Search: {linearResult}");

var binaryResult =
    LibrarySearch.BinarySearch(
        books,
        "Python");

Console.WriteLine($"Binary Search: {binaryResult}");
