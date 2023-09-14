namespace N37_T1.Service;
public class MediceService : IMedicineService
{
    private List<Medicine> medicines = new List<Medicine>();

    public Medicine Create(Medicine medicine)
    {
        int medicineId = (medicines.Count == 0) ? 1 : (medicines.LastOrDefault().Id + 1);
        
        medicine.Id =medicineId;
        medicines.Add(medicine);

        return medicine;
    }

    public bool Delete(Medicine medicine)
    {
        throw new NotImplementedException();
    }

    public Medicine Update(Medicine medicine)
    {
        throw new NotImplementedException();
    }
}
