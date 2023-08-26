Console.WriteLine("1.Content download\n2.File translate\n3.Game");
int choose = int.Parse(Console.ReadLine());
switch (choose)
{
    case 1:
        Console.WriteLine("Enter video url");
        string url = Console.ReadLine();
         DownloadVideoAsync(url);
        break;
}