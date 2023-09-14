using N37_T1;
using N37_T1.Service;

Console.WriteLine("1. Create\n2.Update\n3.Delete");
int chooser = int.Parse(Console.ReadLine());
switch(chooser)
{
    case 1:
        Medicine medicineA = new Medicine();
        Console.WriteLine("Dorini nomini kiriting: ");
        medicineA.Name =  Console.ReadLine();
        Console.WriteLine("Dorini narxini kiriting: ");
        medicineA.Price = int.Parse(Console.ReadLine());
        Console.WriteLine("Dorini ishlab chiqarilgan sanasini kiriting: ");
        medicineA.ExpirationDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Dorini sonini kiriting: ");
        medicineA.Count = int.Parse(Console.ReadLine());
        Console.WriteLine("Dorini batafsil tafsivlang:");
        medicineA.Description =  Console.ReadLine();
        Console.WriteLine("Muvaffaqiyapti qo'shildi!");
        MediceService mediceService = new MediceService();
        mediceService.Create(medicineA);
        break;
}