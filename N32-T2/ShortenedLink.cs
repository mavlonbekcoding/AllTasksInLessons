using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T2
{
    public class ShortenedLink
    {
        public int Id { get; set; }
        public string originalUrl { get; set; }
        public string shortenedUrl { get; set; }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Id.GetHashCode();
            hash = hash * 23 + (originalUrl != null ? originalUrl.GetHashCode() : 0);
            hash = hash * 23 + (shortenedUrl != null ? shortenedUrl.GetHashCode() : 0);
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ShortenedLink other = (ShortenedLink)obj;
            return Id == other.Id &&
                   originalUrl == other.originalUrl &&
                   shortenedUrl == other.shortenedUrl;
        }
    }
}

