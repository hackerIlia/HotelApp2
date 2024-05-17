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

        public async Task<IEnumerable<HLiving>> Index()
        {
            return await typeService.GetAll();
        }

        public async Task<HLiving> GetById(int id)
        {
            return await typeService.Get(id);
        }

        public async Task<string> Create(HLiving living)
        {
            return await typeService.Create(living);
        }

        public Task<string> Edit(HLiving item)
        {
            return typeService.Edit(item);
        }

        public async Task<string> Delete(HLiving item)
        {
            return await typeService.Delete(item);
        }
    }
}
