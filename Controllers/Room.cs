using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp2.Controllers
{
    public class Room : Controller
    {
        IGeneralService<HModels.Room> typeService;

        public Room(IGeneralService<HModels.Room> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<HModels.Room>> Index()
        {
            return (await typeService.GetAll()).ToList();
        }

        public async Task<HModels.Room> GetById(short id)
        {
            return await typeService.Get(Convert.ToInt16(id));
        }

        public void OrderCleaning(HModels.Room room) 
        {
            room.CleaningStatusId = (byte)3;
            typeService.Edit(room);
        }

        public async Task<string> CheckOut(HModels.Room room)
        {
            room.AvailabilityStatusId = (byte)1;
            room.CleaningStatusId = (byte)2;
            return await typeService.Edit(room);
        }
    }
}
