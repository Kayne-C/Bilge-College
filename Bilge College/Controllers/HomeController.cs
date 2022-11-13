using AutoMapper;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.Entities.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Bilge_College.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseRepository<BaseEntity> _baseRepository;
        private readonly IMapper _mapper;

        public HomeController(IBaseRepository<BaseEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       

    }
}
