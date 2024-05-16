using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp2.Controllers
{
    public class BookingStatuses
    {
        IGeneralService<HDBookingStatus> typeService;

        public BookingStatuses(IGeneralService<HDBookingStatus> serv)
        {
            typeService = serv;
        }

        public IEnumerable<HDBookingStatus> Index()
        {
            return typeService.GetAll().ToList();
        }
    }
}
