using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    public class Operation
    {
        DataTable productdt = new DataTable();
        public void GetTop3Records(List<ProductModel> reviewlist)
        {
            var result = reviewlist.OrderByDescending(x => x.Rating).Take(3).ToList();
            Display(result);
        }
        public void Display(List<ProductModel> list)
        {
            //Display list
            foreach (ProductModel product in list)
            {
                Console.WriteLine("ProductId: " + product.ProductId + " UserId: " + product.UserId + " Rating: " + product.Rating + " IsLike: " + product.IsLike + " Review: " + product.Review);
            }
        }
        public void GetTopRecordsWithProductId(List<ProductModel> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9)).Take(3).ToList();
            Display(result);
        }
        public void GetTopRecordsCountWithProductId(List<ProductModel> list)
        {
            var result = list.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductID + " " + data.Count);
            }
        }
        public void SkipTop5Records(List<ProductModel> list)
        {
            var result = list.OrderByDescending(x => x.Rating).Skip(5).ToList();
            Display(result);
        }
        public void Datatables()
        {
            //created datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Review");
            dt.Columns.Add("Islike");
            //created row
            dt.Rows.Add("1", "111", "5", "best", "true");
            dt.Rows.Add(2, 112, 5, "best", true);
            dt.Rows.Add(3, 113, 4, "better", true);
            dt.Rows.Add(4, 114, 3, "Good", true);
            dt.Rows.Add(5, 115, 5, "best", true);
            dt.Rows.Add(6, 116, 4, "better", true);
            dt.Rows.Add(7, 117, 3, "Good", true);
            dt.Rows.Add(8, 118, 4, "better", true);
            dt.Rows.Add(9, 119, 1, "worst", false);
            dt.Rows.Add(10, 120, 5, "best", true);
            dt.Rows.Add(11, 121, 4, "better", true);
            dt.Rows.Add(12, 122, 4, "better", true);
            dt.Rows.Add(13, 123, 2, "bad", false);
            dt.Rows.Add(14, 124, 1, "worst", false);
            dt.Rows.Add(15, 125, 5, "best", true);
            dt.Rows.Add(16, 126, 5, "best", true);
            dt.Rows.Add(17, 127, 4, "better", true);
            dt.Rows.Add(18, 128, 4, "better", true);
            dt.Rows.Add(19, 129, 3, "Good", true);
            dt.Rows.Add(20, 130, 3, "Good", true);
            dt.Rows.Add(21, 131, 2, "better", true);
            dt.Rows.Add(22, 132, 5, "best", true);
            dt.Rows.Add(23, 133, 4, "better", true);
            dt.Rows.Add(24, 134, 3, "Good", true);
            dt.Rows.Add(25, 135, 2, "bad", false);

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Review"]}\t|{row["Rating"]}\t|{row["Islike"]}");
            }

        }

        public string RetrievedetailsWithLikes()
        {
            List<ProductModel> ProductReviewsList = new List<ProductModel>();
            Datatables();
            string productsList = "";
            var res = from product in productdt.AsEnumerable() where product.Field<bool>("IsLike") == true select product;
            foreach (var product in res)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", product["ProductId"], product["UserId"], product["Rating"], product["Review"], product["IsLike"]);
                productsList += product["UserId"] + " ";
            }
            return productsList;
        }

            public string RetrieveAverageRating()
            {
                string result = "";
            Datatables();
                var res = from product in productdt.AsEnumerable() group product by product.Field<int>("ProductId") into temp select new { productid = temp.Key, Average = Math.Round(temp.Average(x => x.Field<int>("Rating")), 1) };
                foreach (var product in res)
                {
                    Console.WriteLine("Product id: {0} Average Rating: {1}", product.productid, product.Average);
                    result += product.Average + " ";
                }
                return result;
            }
        public string RetrieveAllNiceReviews()
        {
            Datatables();
            List<ProductModel> ProductReviewsList = new List<ProductModel>();

            string productsList = "";
            var res = from product in productdt.AsEnumerable() where product.Field<string>("Review") == "nice" select product;
            foreach (var products in res)
            {
                Console.WriteLine("{0} ; {1} ; {2} ; {3} ; {4} ", products["ProductId"], products["UserId"], products["Rating"], products["Review"], products["IsLike"]);
                productsList += products["UserId"] + " ";
            }
            return productsList;
        }
      
    }
}
