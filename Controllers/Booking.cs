using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp2.Controllers
{
    public class Booking : Controller
    {
        IGeneralService<HBooking> typeService;

        public Booking(IGeneralService<HBooking> serv)
        {
            typeService = serv;
        }

        public IEnumerable<HBooking> Index()
        {
            return typeService.GetAll().ToList();
        }

        public string Create(HBooking type)
        {
            return typeService.Create(type);
        }

        public HBooking GetById(int id)
        {
            return typeService.Get(id);
        }

        public string Edit(HBooking item)
        {
            return typeService.Edit(item);
        }

        public void Cancel(HBooking booking) {
            booking.StatusId = (byte)3;
            typeService.Edit(booking);
        }
    }
}
