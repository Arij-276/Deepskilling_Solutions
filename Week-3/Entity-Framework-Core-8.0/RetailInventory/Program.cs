using System.Threading.Tasks;

using var context = new AppDbContext();

// Create categories
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

// Add categories
await context.Categories.AddRangeAsync(electronics, groceries);

// Create products and assign categories
var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

// Add products
await context.Products.AddRangeAsync(product1, product2);

// Save changes to the database
await context.SaveChangesAsync();

Console.WriteLine("Initial data inserted successfully.");

using var context = new AppDbContext();

// 1. Retrieve all products
var products = await context.Products.ToListAsync();
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");

// 2. Find by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {product?.Name}");

// 3. FirstOrDefault with Condition
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive: {expensive?.Name}");
