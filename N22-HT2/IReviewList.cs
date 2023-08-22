using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2
{
    public interface IReviewList<TReview> where TReview : IReview
    {
        void Add(TReview review);
        void Update(int id, int star, string message);
        void Remove(int id);
        void Remove(TReview review);
        TReview GetReview(int id);
        TReview GetReview(string message);
        string GetOverallReview();
    }
}
