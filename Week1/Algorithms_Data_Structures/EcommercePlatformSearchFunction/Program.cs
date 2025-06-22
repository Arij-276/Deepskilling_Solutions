using System;
using System.Diagnostics;
using System.Linq;

namespace EcommercePlatformSearchFunction
{

    class Program
    {
        static void Main()
        {
            // Create larger dataset for meaningful measurements
            const int productCount = 10000;
            Product[] products = GenerateProducts(productCount);

            // For binary search, sort by ID
            Product[] sortedProducts = products.OrderBy(p => p.ProductId).ToArray();

            // Test searches
            TestSearchPerformance(products, sortedProducts, productCount);
        }

        static void TestSearchPerformance(Product[] unsorted, Product[] sorted, int size)
        {
            const int iterations = 10000;
            var sw = new Stopwatch();

            // Test worst-case linear search (last item)
            int linearTarget = unsorted[^1].ProductId;
            sw.Start();
            for (int i = 0; i < iterations; i++)
                SSearch.LinearSearch(unsorted, linearTarget);
            sw.Stop();
            Console.WriteLine($"Linear Search (n={size}) avg: {sw.ElapsedTicks / (double)iterations} ticks");

            // Test binary search
            sw.Restart();
            int binaryTarget = sorted[size / 2].ProductId; // Midpoint
            for (int i = 0; i < iterations; i++)
                SSearch.BinarySearch(sorted, binaryTarget);
            sw.Stop();
            Console.WriteLine($"Binary Search (n={size}) avg: {sw.ElapsedTicks / (double)iterations} ticks");
        }

        static Product[] GenerateProducts(int count)
        {
            var rand = new Random();
            return Enumerable.Range(1, count)
                .Select(id => new Product(
                    id,
                    $"Product {id}",
                    $"Category {rand.Next(1, 10)}"))
                .ToArray();
        }
    }
}