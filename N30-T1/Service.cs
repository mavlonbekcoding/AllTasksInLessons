using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N30_T1
{
    public class Service
    {
        private static async Task DownloadVideoAsync(string videoUrl)
        {
            string filePath = @"D:\\Video.mp4";
            Console.WriteLine("Downloading video...");


            using (var httpClient = new HttpClient())
            {
                var videoData = await
                    httpClient.GetByteArrayAsync(videoUrl);

                await File.WriteAllBytesAsync(filePath, videoData);
            }
        }
    }
}
