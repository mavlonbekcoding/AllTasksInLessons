using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2
{
    public class ReviewList<TReview> : IReviewList<TReview> where TReview : IReview
    {
        private List<TReview> reviews = new List<TReview>();

        public void Add(TReview review)
        {
            reviews.Add(review);
        }

        public void Update(int id, int star, string message)
        {
            TReview review = reviews.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                review.Star = star;
                review.Message = message;
            }
        }

        public void Remove(int id)
        {
            TReview review = reviews.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                reviews.Remove(review);
            }
        }

        public void Remove(TReview review)
        {
            reviews.Remove(review);
        }

        public TReview GetReview(int id)
        {
            return reviews.FirstOrDefault(r => r.Id == id);
        }

        public TReview GetReview(string message)
        {
            return reviews.FirstOrDefault(r => r.Message == message);
        }

        public string GetOverallReview()
        {
            if (reviews.Count == 0)
                return "Be the first to leave a review for this product";

            bool allFiveStars = reviews.All(r => r.Star == 5);
            bool hasOneStar = reviews.Any(r => r.Star == 1);

            if (allFiveStars)
                return "Great news! All reviews for this product are 5-star ratings.";

            if (hasOneStar)
            {
                TReview reviewWithOneStar = reviews.FirstOrDefault(r => r.Star == 1);
                return reviewWithOneStar?.Message ?? "";
            }

            return ""; // Handle other cases here if needed
        }
    }
}
