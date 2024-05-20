using BLL.Interfaces;
using HModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp2.Controllers
{
    public class Living : Controller
    {
        IGeneralService<HModels.Living> typeService;

        public Living(IGeneralService<HModels.Living> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<HModels.Living>> Index()
        {
            return await typeService.GetAll();
        }

        public async Task<HModels.Living> GetById(int id)
        {
            return await typeService.Get(id);
        }

        public async Task<string> Create(HModels.Living living)
        {
            return await typeService.Create(living);
        }

        public Task<string> Edit(HModels.Living item)
        {
            return typeService.Edit(item);
        }

        public async Task<string> Delete(HModels.Living item)
        {
            return await typeService.Delete(item);
        }

        public async Task<string> CheckOut(HModels.Living item)
        {
            item.StatusId = (byte)2;
            return await typeService.Edit(item);
        }
    }
}
