using N32_T2._1;


ChatMessage chatMessageA = new ChatMessage();
chatMessageA.Id = 1;
chatMessageA.Message = "QodirAli Molga qara";
chatMessageA.Subject = "QodirAli Mollarni sugor";
chatMessageA.chatId = 99;

ChatMessage chatMessageV = new ChatMessage();
chatMessageV.Id = 2;
chatMessageV.Message = "Mollarni qaytar";
chatMessageV.Subject = "Tomga chiqib gozapaya tasha";
chatMessageV.chatId = 100;

Console.WriteLine(Equals(chatMessageA,chatMessageV));
Console.WriteLine(chatMessageA.GetHashCode());
Console.WriteLine(chatMessageA.ToString());
Console.WriteLine(chatMessageV.ToString());
Console.WriteLine(chatMessageV.GetHashCode());