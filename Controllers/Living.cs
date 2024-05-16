using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp2.Controllers
{
    public class Living : Controller
    {
        IGeneralService<HLiving> typeService;

        public Living(IGeneralService<HLiving> serv)
        {
            typeService = serv;
        }

        public IEnumerable<HLiving> Index()
        {
            return typeService.GetAll().ToList();
        }
    }
}
