using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp2.Controllers
{
    public class BookingStatuses
    {
        IGeneralService<BookingStatus> typeService;

        public BookingStatuses(IGeneralService<BookingStatus> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<BookingStatus>> Index()
        {
            return (await typeService.GetAll()).ToList();
        }
    }
}
