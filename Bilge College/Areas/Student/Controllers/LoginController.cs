﻿using AutoMapper;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.DTOs.Login;
using Bilge_College.Models.Entities.Abstract;
using Bilge_College.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bilge_College.Areas.Student.Controllers
{
    [Area("Student")]
    public class LoginController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public LoginController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //var list = await _studentRepository.GetByDefaults(x => x.Status != Status.Passive);
             return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginStudentDTO loginStudentDTO)
        {

                var response = await _studentRepository.GetByDefault(s => s.Email == loginStudentDTO.Email && s.Password == loginStudentDTO.Password);
            if (response == null)
            {
                ModelState.AddModelError("", "Girmiş olduğunuz bilgilerle eşleşen bir Öğrenci bulunamadı");
                return View();
            }
            //string FullName = response.FirstName + response.LastName;
            HttpContext.Session.SetString("userId", response.Id.ToString());
            HttpContext.Session.SetString("fullname", (response.FirstName + " " + response.LastName));
            HttpContext.Session.SetString("email", response.Email);
            return RedirectToAction("Index", "Home"); 
        }
    }
}
