using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HModels;

namespace HotelApp2.Controllers
{
    public class GuestLiving : Controller
    {
        IGeneralService<HGuestLiving> typeService;

        public GuestLiving(IGeneralService<HGuestLiving> serv)
        {
            typeService = serv;
        }

        public IEnumerable<HGuestLiving> Index()
        {
            return typeService.GetAll().ToList();
        }

        public string Create(HGuestLiving guest)
        {
            return typeService.Create(guest);
        }

        public HGuestLiving GetById(int id)
        {
            return typeService.Get(id);
        }

        public HGuestLiving GetPyPassportNumber(string number)
        {
            return typeService.GetAll().Where(g => g.PassportNumber == number).FirstOrDefault();
        }
    }
}
