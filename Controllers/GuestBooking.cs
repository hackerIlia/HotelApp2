using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HModels;

namespace HotelApp2.Controllers
{
    public class GuestBooking : Controller
    {
        IGeneralService<HModels.GuestBooking> typeService;

        public GuestBooking(IGeneralService<HModels.GuestBooking> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<HModels.GuestBooking>> Index()
        {
            return (await typeService.GetAll()).ToList();
        }

        public async Task<HModels.GuestBooking> GetById(int id)
        {
            return await typeService.Get(id);
        }
    }
}
