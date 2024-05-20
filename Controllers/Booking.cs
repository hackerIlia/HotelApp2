using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;
using HotelApp2.Controllers;

namespace HotelApp2.Controllers
{
    public class Booking : Controller
    {
        IGeneralService<HModels.Booking> typeService;

        public Booking(IGeneralService<HModels.Booking> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<HModels.Booking>> Index()
        {
            return await typeService.GetAll();
        }

        public async Task<string> Create(HModels.Booking type)
        {
            return await typeService.Create(type);
        }

        public async Task<HModels.Booking> GetById(int id)
        {
            return await typeService.Get(id);
        }
        public async Task<string> Delete(HModels.Booking item)
        {
            return await typeService.Delete(item);
        }

        public Task<string> Edit(HModels.Booking item)
        {
            return typeService.Edit(item);
        }

        public void Cancel(HModels.Booking booking) {
            booking.StatusId = (byte)3;
            typeService.Edit(booking);
        }
    }
}
