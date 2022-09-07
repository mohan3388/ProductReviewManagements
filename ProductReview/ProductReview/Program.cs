namespace ProductReview
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review");
            Operation operation = new Operation();
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel() { ProductId = 1, UserId = 1, Rating = 4, IsLike = true, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 2, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 3, UserId = 2, Rating = 2, IsLike = false, Review = "Bad" });
            products.Add(new ProductModel() { ProductId = 4, UserId = 5, Rating = 5, IsLike = true, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 5, UserId = 3, Rating = 3, IsLike = false, Review = "Bad" });
            products.Add(new ProductModel() { ProductId = 6, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 7, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 8, UserId = 3, Rating = 5, IsLike = true, Review = "Bad" });
            products.Add(new ProductModel() { ProductId = 9, UserId = 4, Rating = 5, IsLike = false, Review = "Bad" });
            products.Add(new ProductModel() { ProductId = 10, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 11, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 12, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 13, UserId = 7, Rating = 5, IsLike = true, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 14, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 15, UserId = 6, Rating = 3, IsLike = true, Review = "Bad" });
            products.Add(new ProductModel() { ProductId = 16, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 17, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 18, UserId = 7, Rating = 1, IsLike = false, Review = "Bad" });
            products.Add(new ProductModel() { ProductId = 1, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 20, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 21, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 1, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 23, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 2, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });
            products.Add(new ProductModel() { ProductId = 25, UserId = 2, Rating = 4, IsLike = false, Review = "Good" });

            bool end = true;
            while (end)
            {
                Console.WriteLine("\n1.Create Product Review\n2.Retrive Top Three Records \n3.Retrive Top Record With Product Id \n4.get top records\n5.get top five records \n6.create data table");
                Console.WriteLine("\nEnter above Option");
                int option = Convert.ToInt16(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        operation.Display(products);
                        break;
                    case 2:
                        operation.GetTop3Records(products);
                        break;
                    case 3:
                        operation.GetTopRecordsWithProductId(products);
                        break;
                    case 4:
                        operation.GetTopRecordsCountWithProductId(products);
                        break;
                    case 5:
                        operation.SkipTop5Records(products);
                        break;
                    case 6:
                        operation.Datatables();
                        break;
                  
                    default:
                        Console.WriteLine("Enter above option");
                        break;
                }
            }
        }
    }
}