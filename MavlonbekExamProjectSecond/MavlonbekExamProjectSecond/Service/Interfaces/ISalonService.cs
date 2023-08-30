using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavlonbekExamProjectSecond.Service.Interfaces
{
    public interface ISalonService
    {
        Response<Salon> Create(Salon salon);
        Response<Salon> Update(Salon salon);
        Response<bool> Delete(long Id);
        Response<Salon> GetBySalonId(long Id);
        Response<IEnumerable<Salon>> GetAll();
        Response<bool> Cancellation(long Id, long UserId);
        void Delete(Salon salon);
    }
}
