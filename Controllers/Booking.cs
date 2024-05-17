using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;
using HotelApp2.Controllers;

namespace HotelApp2.Controllers
{
    public class Booking : Controller
    {
        IGeneralService<HBooking> typeService;

        public Booking(IGeneralService<HBooking> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<HBooking>> Index()
        {
            return await typeService.GetAll();
        }

        public async Task<string> Create(HBooking type)
        {
            return await typeService.Create(type);
        }

        public async Task<HBooking> GetById(int id)
        {
            return await typeService.Get(id);
        }
        public async Task<string> Delete(HBooking item)
        {
            return await typeService.Delete(item);
        }

        public Task<string> Edit(HBooking item)
        {
            return typeService.Edit(item);
        }

        public void Cancel(HBooking booking) {
            booking.StatusId = (byte)3;
            typeService.Edit(booking);
        }
    }
}
