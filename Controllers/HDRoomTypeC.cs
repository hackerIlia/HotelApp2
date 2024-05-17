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

        public async Task<IEnumerable<HDRoomType>> Index()
        {
            return await typeService.GetAll();
        }

        public async Task<HDRoomType> GetById(int id)
        {
            return await typeService.Get(id);
        }

        public async Task<string> Create(HDRoomType type)
        {
            return await typeService.Create(type);
        }

        public Task<string> Edit(HDRoomType type)
        {
            return typeService.Edit(type);
        }

        public async Task<string> Delete(HDRoomType type)
        {
            return await typeService.Delete(type);
        }

        protected override void Dispose(bool disposing)
        {
            typeService.Dispose();
            base.Dispose(disposing);
        }
    }
}
