namespace ECommerceSearchExample;

public class SearchService
{
    public static Product? LinearSearch(
        Product[] products,
        int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
            {
                return product;
            }
        }

        return null;
    }

    public static Product? BinarySearch(
    Product[] products,
    int targetId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == targetId)
            {
                return products[mid];
            }

            if (targetId < products[mid].ProductId)
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