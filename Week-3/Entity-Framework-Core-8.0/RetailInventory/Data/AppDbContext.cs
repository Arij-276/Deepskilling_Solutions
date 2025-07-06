protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("Server=localhost;Database=RetailInventory;Trusted_Connection=True;");
}
