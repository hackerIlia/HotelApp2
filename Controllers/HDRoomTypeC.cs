using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using AutoMapper;
using HModels;

namespace HotelApp2.Controllers
{
    public class HDRoomTypeC : Controller
    {
        IRoomTypeService typeService;
        
        public HDRoomTypeC(IRoomTypeService serv)
        {
            typeService = serv;
        }

        public IEnumerable<HDRoomType> Index()
        {
            //IEnumerable<HDRoomType> typeDTOs = typeService.GetAllRoomTypes();
            //var mapper = new MapperConfiguration(cfg => cfg.CreateMap<HDRoomType, HDRoomType>()).CreateMapper();
            //var types = mapper.Map<IEnumerable<HDRoomType>, List<HDRoomType>>(typeDTOs);
            //return types;
            return typeService.GetAllRoomTypes().ToList();
        }

        public HDRoomType GetById(int id)
        {
            return typeService.GetRoomType(id);
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
