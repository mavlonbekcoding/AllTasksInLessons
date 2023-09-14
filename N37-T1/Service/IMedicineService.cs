namespace N37_T1.Service;
public interface IMedicineService
{
     Medicine Create(Medicine medicine);
    Medicine Update(Medicine medicine);
    bool Delete(Medicine medicine);
};
