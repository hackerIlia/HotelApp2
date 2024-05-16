using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using HModels;

namespace HotelApp2.Controllers
{
    public class HDRoomTypeC : Controller
    {
        IGeneralService<HDRoomType> typeService;
        
        public HDRoomTypeC(IGeneralService<HDRoomType> serv)
        {
            typeService = serv;
        }

        public IEnumerable<HDRoomType> Index()
        {
            return typeService.GetAll().ToList();
        }

        public HDRoomType GetById(int id)
        {
            return typeService.Get(id);
        }

        public string Create(HDRoomType type)
        {
            return typeService.Create(type);
        }

        public string Edit(HDRoomType type)
        {
            return typeService.Edit(type);
        }

        public string Delete(HDRoomType type)
        {
            return typeService.Delete(type);
        }

        protected override void Dispose(bool disposing)
        {
            typeService.Dispose();
            base.Dispose(disposing);
        }
    }
}
