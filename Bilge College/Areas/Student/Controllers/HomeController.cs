﻿using AutoMapper;
using Bilge_College.Filters;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.DTOs.Review;
using Bilge_College.Models.DTOs.Student;
using Bilge_College.Models.Entities.Abstract;
using Bilge_College.Models.Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bilge_College.Areas.Student.Controllers
{
    [Area("Student")]
    [LoggedUser]
    public class HomeController : Controller
    {
        private readonly INoteRepository _noticeRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IClassroomRepository _classroomRepository;
        private readonly ISubSubjectRepository _subSubjectRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public HomeController(IStudentRepository studentRepository, IMapper mapper,IWebHostEnvironment webHostEnviroment,INoteRepository noticeRepository, IClassroomRepository classroomRepository, ISubSubjectRepository subSubjectRepository)
        {
            _studentRepository = studentRepository;
            _noticeRepository = noticeRepository;
            _classroomRepository = classroomRepository;
            _subSubjectRepository = subSubjectRepository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> NoticeBoard()
        {
            Models.Entities.Concrete.Student student = await _studentRepository.GetByDefault(s => s.Id == int.Parse(HttpContext.Session.GetString("userId")));
            var notices = await _noticeRepository.GetByDefaults( n => n.Status != Status.Passive && n.Students.Contains(student));
            return View(notices);
        } 
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("userId");
            HttpContext.Session.Remove("fullname");
            HttpContext.Session.Remove("email");
            HttpContext.Session.Clear();
        return RedirectToAction("Index","Login");
        }

        public async Task<IActionResult> Profile()
        {

            var profile = await _studentRepository.GetByDefault(s => s.Email == HttpContext.Session.GetString("email"));
            var classroom = await _classroomRepository.GetByDefault(s => s.Id == profile.ClassroomId);
            if (profile == null)
            {
                ModelState.AddModelError("", "Bir hata oluştu. Lütfen çıkış yapıp tekrar deneyiniz..");
                return RedirectToAction("LogOut", "Home");
            }
            ReviewStudentDetailsDTO reviewStudentDetailsDTO = new ReviewStudentDetailsDTO()
            {
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                Email = profile.Email,
                BirthDate = profile.BirthDate,
                Gender  = (Models.DTOs.Review.Gender)profile.Gender,
                Grade = (Models.DTOs.Review.Grade)profile.Grade,
                AvarageScore = profile.AvarageScore,
                Classroom = classroom
            };
            return View(reviewStudentDetailsDTO);
        }

        public async Task<IActionResult> Notes()
        {
            var profile = await _studentRepository.GetByDefault(s => s.Email == HttpContext.Session.GetString("email"));        
            return View();
        }

        public async Task <IActionResult> EditProfile()
        {
            
            var profile = await _studentRepository.GetByDefault(s => s.Email == HttpContext.Session.GetString("email"));
            if (profile == null)
            {
                ModelState.AddModelError("", "Bir hata oluştu. Lütfen çıkış yapıp tekrar deneyiniz..");
                return RedirectToAction("Index","Home");
            }
            UpdateStudentDTO dto = new UpdateStudentDTO()
            {
                Password =  profile.Password,
                Image = profile.Image

            };
            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> EditProfile(UpdateStudentDTO model)
        {
            if (ModelState.IsValid)
            {
                string imageName = "noimage.png";
                if (model.UploadImage != null)
                {
                    string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "ProfileImages");

                    if (!string.Equals(model.Image, "noimage.png"))
                    {
                        string oldPath = Path.Combine(uploadDir, model.Image);

                        if (System.IO.File.Exists(oldPath)) System.IO.File.Delete(oldPath);
                    }

                    imageName = $"{Guid.NewGuid()}_{model.UploadImage.FileName}";
                    string filePath = Path.Combine(uploadDir, imageName);
                    FileStream fileStream = new FileStream(filePath, FileMode.Create);
                    model.UploadImage.CopyTo(fileStream);
                    fileStream.Close();
                }
                Models.Entities.Concrete.Student user = new Models.Entities.Concrete.Student();
                if (imageName != "noimage.png")
                {
                    user.Image = imageName;
                }

                await _studentRepository.Update(user);
                TempData["Success"] = "Kullanıcı güncellendi..!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Error"] = "Kullanıcı güncellenirken bir hata oluştu..!";
                return View(model);
            }

        }

    }
}
