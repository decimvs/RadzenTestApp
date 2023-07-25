namespace RadzenTestApp.Data
{
    public class Products
    {
        public static List<Product> ProductList = new List<Product>
        {
            new Product
            {
                Id = "960152",
                CreationDate = new DateTime(2023, 06, 22),
                Designation = "Lorem ipsum designation",
                Inventory = 1000,
                Status = "PENDING"
            },

            new Product
            {
                Id = "940647",
                CreationDate = new DateTime(2022, 12, 05),
                Designation = "Lorem ipsum designation",
                Inventory = 154,
                Status = "DISTRIBUTING"
            },

            new Product
            {
                Id = "939221",
                CreationDate = new DateTime(2022, 09, 15),
                Designation = "Lorem ipsum designation",
                Inventory = 1478,
                Status = "DISTRIBUTING"
            },

            new Product
            {
                Id = "922539",
                CreationDate = new DateTime(2022, 04, 27),
                Designation = "Lorem ipsum designation",
                Inventory = 0,
                Status = "FINISHED"
            },

            new Product
            {
                Id = "919348",
                CreationDate = new DateTime(2021, 10, 11),
                Designation = "Lorem ipsum designation",
                Inventory = 3781,
                Status = "DISTRIBUTING"
            }
        };
    }
}
