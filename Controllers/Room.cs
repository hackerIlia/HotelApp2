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

        public IEnumerable<HRoom> Index()
        {
            return typeService.GetAll().ToList();
        }

        public HRoom GetById(int id)
        {
            return typeService.Get(id);
        }
    }
}
