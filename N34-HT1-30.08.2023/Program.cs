using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class User
    {
        public string UserName { get; set; }
        public List<string> BlogPosts { get; set; } = new List<string>();
    }

    static void Main()
    {
        // Foydalanuvchilarni va ularning bloglari bilan to'ldirish
        List<User> users = new List<User>
        {
            new User { UserName = "user1", BlogPosts = new List<string> { "Post1", "Post2", "Post3" } },
            new User { UserName = "user2", BlogPosts = new List<string> { "Post4", "Post5" } },
            new User { UserName = "user3", BlogPosts = new List<string> { "Post6" } },
            new User { UserName = "user4", BlogPosts = new List<string> { } }
        };

        // Eng ko'p va eng kam post yozgan user
        var mostActiveUser = users.OrderByDescending(u => u.BlogPosts.Count).FirstOrDefault();
        var leastActiveUser = users.OrderBy(u => u.BlogPosts.Count).FirstOrDefault();

        Console.WriteLine($"Eng ko'p post yozgan user: {mostActiveUser.UserName}");
        Console.WriteLine($"Eng kam post yozgan user: {leastActiveUser.UserName}");

        // Eng ko'p va eng kam like/dislike olgan post
        var posts = users.SelectMany(u => u.BlogPosts).ToList();
        Dictionary<string, int> postScores = new Dictionary<string, int>();

        foreach (var post in posts)
        {
            Console.WriteLine($"Post: {post}");
            Console.WriteLine($"Like: {CountLikes(post)}");
            Console.WriteLine($"Dislike: {CountDislikes(post)}");

            int postScore = CountLikes(post) * 3 - CountDislikes(post);
            postScores.Add(post, postScore);
        }

        var mostLikedPost = postScores.OrderByDescending(p => p.Value).FirstOrDefault();
        var mostDislikedPost = postScores.OrderBy(p => p.Value).FirstOrDefault();

        Console.WriteLine($"Eng ko'p like olgan post: {mostLikedPost.Key}");
        Console.WriteLine($"Eng kam like olgan post: {mostDislikedPost.Key}");

        // Eng ko'p va eng kam rating berilgan post
        var mostRatedPost = postScores.OrderByDescending(p => Math.Abs(p.Value)).FirstOrDefault();
        var leastRatedPost = postScores.OrderBy(p => Math.Abs(p.Value)).FirstOrDefault();

        Console.WriteLine($"Eng ko'p rating berilgan post: {mostRatedPost.Key}");
        Console.WriteLine($"Eng kam rating berilgan post: {leastRatedPost.Key}");
    }

    static int CountLikes(string post)
    {
        // Bu funksiya postdagi like'larni hisoblash uchun ishlatiladi.
        // Sizning tadbiring ma'lumotlar bazangiz yoki web ilova interfeysingiz bo'yicha o'zgartirishingiz mumkin.
        // Bu faqat misolni o'rnatish uchun ishlatilgan funksiya.
        // Real loyihalarda sizning tadbiringizga mos funksiya ishlatiladi.
        Random random = new Random();
        return random.Next(1, 10);
    }

    static int CountDislikes(string post)
    {
        // Bu funksiya postdagi dislike'larni hisoblash uchun ishlatiladi.
        // Sizning tadbiringiz yoki web ilova interfeysingiz bo'yicha o'zgartirishingiz mumkin.
        // Bu faqat misolni o'rnatish uchun ishlatilgan funksiya.
        // Real loyihalarda sizning tadbiringizga mos funksiya ishlatiladi.
        Random random = new Random();
        return random.Next(1, 5);
    }
}
