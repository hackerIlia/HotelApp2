using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HModels;

namespace HotelApp2.Controllers
{
    public class GuestLiving : Controller
    {
        IGeneralService<HModels.GuestLiving> typeService;

        public GuestLiving(IGeneralService<HModels.GuestLiving> serv)
        {
            typeService = serv;
        }

        public async Task<IEnumerable<HModels.GuestLiving>> Index()
        {
            return (await typeService.GetAll()).ToList();
        }

        public async Task<OperationResult> Create(HModels.GuestLiving guest)
        {
            return await typeService.Create(guest);
        }

        public async Task<HModels.GuestLiving> GetById(int id)
        {
            return await typeService.Get(id);
        }

        public async Task<HModels.GuestLiving> GetPyPassportNumber(string number)
        {
            return (await typeService.GetAll()).Where(g => g.PassportNumber == number).FirstOrDefault();
        }
    }
}
