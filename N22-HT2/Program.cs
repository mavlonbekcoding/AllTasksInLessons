using N22_HT2;

public class Program
{
    static void Main(string[] args)
    {
        ReviewList<IReview> reviewList = new ReviewList<IReview>();

        // Reviews and CrashReports
        Review review1 = new Review { Id = 1, Star = 4, Message = "Great product!" };
        CrashReport crashReport1 = new CrashReport { Id = 2, Star = 1, Message = "It crashed.", Screenshot = "screenshot.png" };

        reviewList.Add(review1);
        reviewList.Add(crashReport1);

        // Update a review
        reviewList.Update(1, 5, "Excellent product!");

        // Get overall review
        string overallReview = reviewList.GetOverallReview();
        Console.WriteLine(overallReview);
    }
}