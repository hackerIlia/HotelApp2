using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp2.Controllers
{
    public class Room : Controller
    {
        IGeneralService<HRoom> typeService;

        public Room(IGeneralService<HRoom> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<HRoom>> Index()
        {
            return (await typeService.GetAll()).ToList();
        }

        public async Task<HRoom> GetById(short id)
        {
            return await typeService.Get(Convert.ToInt16(id));
        }

        public void OrderCleaning(HRoom room) 
        {
            room.CleaningStatusId = (byte)3;
            typeService.Edit(room);
        }

        public void CheckOut(HRoom room)
        {
            room.AvailabilityStatusId = (byte)1;
            typeService.Edit(room);
        }
    }
}
