namespace EcommercePlatformSearchFunction;

public static class SSearch
{
    public static Product? LinearSearch(Product[] products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }

    public static Product? BinarySearch(Product[] sortedProducts, int targetId)
    {
        int low = 0;
        int high = sortedProducts.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int midId = sortedProducts[mid].ProductId;

            if (midId == targetId)
                return sortedProducts[mid];
            else if (midId < targetId)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return null;
    }
}

