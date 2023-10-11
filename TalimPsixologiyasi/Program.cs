using TalimPsixologiyasi.Model;

Console.WriteLine("Xurmatli AKT 650-21 talabasi Ta'lim testni boshlash uchun ro'yxatdan o'ting : 1. Ro'yxatdan o'tish");
int choose = int.Parse(Console.ReadLine());
switch (choose)
{
    case 1:
        Student studentA = new Student();

        Console.WriteLine("Ismingizni kiriting: ");
        studentA.FirstName = Console.ReadLine();

        Console.WriteLine("Familyangizni kiriting: ");
        studentA.LastName = Console.ReadLine();

        Console.WriteLine("Siz muvaffiyatli ro'yxatdan o'tdingiz testni boshlash uchun tanlang: 1. Testni boshlash.");
        int chooseA = int.Parse(Console.ReadLine());
        break;

    default:
        Console.WriteLine("Belgilanmagan harakat!!!");
        break;
}
