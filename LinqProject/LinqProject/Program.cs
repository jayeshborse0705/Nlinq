using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductReview productReview = new ProductReview();
            productReview.AddProductReview();
            productReview.DisplayList();
            productReview.RetrieveTopThreeRating();
            productReview.RetrieveTopThreeRating();


            

        }
    }
}
