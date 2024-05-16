using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HModels;

namespace HotelApp2.Controllers
{
    public class GuestBooking : Controller
    {
        IGeneralService<HGuestBooking> typeService;

        public GuestBooking(IGeneralService<HGuestBooking> serv)
        {
            typeService = serv;
        }

        public IEnumerable<HGuestBooking> Index()
        {
            return typeService.GetAll().ToList();
        }
    }
}
