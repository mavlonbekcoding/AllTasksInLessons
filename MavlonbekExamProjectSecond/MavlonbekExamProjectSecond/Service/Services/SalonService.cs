using MavlonbekExamProjectSecond.Data.Constants;
using MavlonbekExamProjectSecond.Domain.Entities.Salons;
using MavlonbekExamProjectSecond.Service.Helpers;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace MavlonbekExamProjectSecond.Service.Services
{
    public class SalonService : ISalonService
    {
        public SalonService()
        {
            string source = File.ReadAllText(PathFile.SALON_PATH);
            if (string.IsNullOrEmpty(source))
                File.WriteAllText(PathFile.SALON_PATH, "[]");
        }
        public Response<bool> Cancellation(long Id, long UserId)
        {
            string source = File.ReadAllText(PathFile.SALON_PATH);
            List<Salon> salons = JsonConvert.DeserializeObject<List<Salon>>(source);
            Salon salon = salons.FirstOrDefault(s => s.Id == Id && s.UserId == UserId);
            if (salon == null)
                return new Response<bool>()
                {
                    StatusCode = 404,
                    Message = "This book not fount",
                    Data = false
                };
            salon.UserId = 0;
            source = JsonConvert.SerializeObject(salons, Formatting.Indented);
            File.WriteAllText(PathFile.SALON_PATH, source);
            return new Response<bool>()
            {
                StatusCode = 200,
                Message = "Success",
                Data = true
            };
        }
        public Response<Salon> Create(Salon salon)
        {
            string source = File.ReadAllText(PathFile.SALON_PATH);

            List<Salon> salons = JsonConvert.DeserializeObject<List<Salon>>(source);

            string salonId = (salons.Count == 0) ? "1" : salons.LastOrDefault().Id.ToString();
            salon.Id = long.Parse(salonId);
            salons.Add(salon);
            source = JsonConvert.SerializeObject(salons, Formatting.Indented);
            File.WriteAllText(PathFile.SALON_PATH, source);
            return new Response<Salon>()
            {
                StatusCode = 200,
                Message = "Success",
                Data = salon
            };
        }


        public Response<bool> Delete(long Id)
        {
            string source = File.ReadAllText(PathFile.SALON_PATH);

            List<Salon> salons = JsonConvert.DeserializeObject<List<Salon>>(source);

            Salon existSalon = salons.FirstOrDefault(s => s.Id == Id);

            if (existSalon == null)
                return new Response<bool>()
                {
                    StatusCode = 404,
                    Message = "This book not fount",
                    Data = false
                };

            salons.Remove(existSalon);

            string source1 = JsonConvert.SerializeObject(existSalon, Formatting.Indented);
            File.WriteAllText(PathFile.SALON_PATH, source);

            return new Response<bool>()
            {
                StatusCode = 200,
                Message = "Success",
                Data = true
            };
        }

        public Response<Salon> Update(Salon salon)
        {
            string source = File.ReadAllText(PathFile.SALON_PATH);
            List<Salon> salons = JsonConvert.DeserializeObject<List<Salon>>(source);
            Salon existSalon = salons.FirstOrDefault(s => s.Id == salon.Id);
            if (existSalon == null)
                return new Response<Salon>()
                {
                    StatusCode = 404,
                    Message = "This user not fount",
                    Data = existSalon
                };
            existSalon.SalonName = salon.SalonName;
            existSalon.SalonPhoneNumber = salon.SalonPhoneNumber;
            string json = JsonConvert.SerializeObject(existSalon, Formatting.Indented);
            File.WriteAllText(PathFile.SALON_PATH, json);

            return new Response<Salon>()
            {
                StatusCode = 200,
                Message = "Success",
                Data = salon
            };
        }
        public Response<Salon> GetBySalonId(long Id)
        {
            string source = File.ReadAllText(PathFile.SALON_PATH);
            List<Salon> salons = JsonConvert.DeserializeObject<List<Salon>>(source);

            Salon existSalon = salons.FirstOrDefault(x => Id == x.Id);
            return new Response<Salon>
            {
                StatusCode = 200,
                Message = "Succes",
                Data = existSalon
            };
        }
        public Response<IEnumerable<Salon>> GetAll()
        {

            string source = File.ReadAllText(PathFile.SALON_PATH);
            IEnumerable<Salon> salons = JsonConvert.DeserializeObject<IEnumerable<Salon>>(source);

            return new Response<IEnumerable<Salon>>()
            {
                StatusCode = 200,
                Message = "Succes!",
                Data = salons
            };
        }
    }
}
