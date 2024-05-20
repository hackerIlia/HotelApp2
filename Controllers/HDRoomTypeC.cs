using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using HModels;

namespace HotelApp2.Controllers
{
    public class HDRoomTypeC : Controller
    {
        IGeneralService<RoomType> typeService;
        
        public HDRoomTypeC(IGeneralService<RoomType> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<RoomType>> Index()
        {
            return await typeService.GetAll();
        }

        public async Task<RoomType> GetById(int id)
        {
            return await typeService.Get(id);
        }

        public async Task<string> Create(RoomType type)
        {
            return await typeService.Create(type);
        }

        public Task<string> Edit(RoomType type)
        {
            return typeService.Edit(type);
        }

        public async Task<string> Delete(RoomType type)
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
