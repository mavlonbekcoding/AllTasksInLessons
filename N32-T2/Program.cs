using N32_T2;

ShortenedLink shortenedLinkA = new ShortenedLink();
shortenedLinkA.originalUrl = "https/najottalim.uz";
shortenedLinkA.shortenedUrl = "najottalim.uz";
shortenedLinkA.Id = 1;

ShortenedLink shortenedLinkB = new ShortenedLink();
shortenedLinkB.originalUrl = "https/tuit.uz";
shortenedLinkB.shortenedUrl = "tuit.uz";
shortenedLinkB.Id = 2;

ShortenedLink shortenedLinkC = new ShortenedLink();
shortenedLinkC.originalUrl = "https/najottalim.uz";
shortenedLinkC.shortenedUrl = "najottalim.uz";
shortenedLinkC.Id = 1;
Console.WriteLine(Equals(shortenedLinkC, shortenedLinkA));