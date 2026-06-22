namespace LibraryManagementSystem;

public class LibrarySearch
{
    public static Book? LinearSearch(
        Book[] books,
        string title)
    {
        foreach (var book in books)
        {
            if (book.Title.Equals(
                title,
                StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }

        return null;
    }

    public static Book? BinarySearch(
    Book[] books,
    string title)
    {
        int left = 0;
        int right = books.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int comparison =
                string.Compare(
                    books[mid].Title,
                    title,
                    StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
            {
                return books[mid];
            }

            if (comparison > 0)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return null;
    }
}