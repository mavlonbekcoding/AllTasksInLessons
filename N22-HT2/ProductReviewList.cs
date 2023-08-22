using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2
{
    public class ProductReviewList : IReviewList<ProductReview>
    {
        public void Add(ProductReview review)
        {
            throw new NotImplementedException();
        }

        public string GetOverallReview()
        {
            throw new NotImplementedException();
        }

        public ProductReview GetReview(int id)
        {
            throw new NotImplementedException();
        }

        public ProductReview GetReview(string message)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProductReview review)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, int star, string message)
        {
            throw new NotImplementedException();
        }
    }
}
