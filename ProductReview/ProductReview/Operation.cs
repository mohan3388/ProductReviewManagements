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
    }
}
