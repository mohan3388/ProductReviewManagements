using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    public class Operation
    {
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
    }
}
