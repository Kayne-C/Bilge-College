using AutoMapper;
using Bilge_College.Filters;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.DTOs.Student.Review;
using Bilge_College.Models.DTOs.Student;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;
using Bilge_College.Models.DTOs.Student.StudentNotice;
using Bilge_College.Models.Entities.Concrete;
using Bilge_College.Helpers;
using Newtonsoft.Json;
using Bilge_College.Hubs;
using Bilge_College.Models.DTOs.SchoolReport;
using Bilge_College.Models.DTOs.Note;

namespace Bilge_College.Areas.Student.Controllers
{
    [Area("Student")]
    [LoggedUser]
    public class HomeController : Controller
   {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly INoteRepository _noteRepository;
        private readonly IClassroomRepository _classroomRepository;
        private readonly ISubSubjectRepository _subSubjectRepository;
        private readonly IStudentNoticeRepository _studentNoticeRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly ISchoolReportRepository _schoolReportRepository;

        public HomeController(IStudentRepository studentRepository, IMapper mapper, IWebHostEnvironment webHostEnviroment, INoteRepository noteRepository, IClassroomRepository classroomRepository, ISubSubjectRepository subSubjectRepository, IStudentNoticeRepository studentNoticeRepository, IAdminRepository adminRepository,ISchoolReportRepository schoolReportRepository)
        {
            _studentRepository = studentRepository;
            _noteRepository = noteRepository;
            _classroomRepository = classroomRepository;
            _subSubjectRepository = subSubjectRepository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnviroment;
            _studentNoticeRepository = studentNoticeRepository;
            _adminRepository = adminRepository;
            _schoolReportRepository = schoolReportRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> NoticeBoard()
        {
            DateHelper dateHelper = new DateHelper();
            var StudentNotices = await _studentNoticeRepository.GetByDefaults(n => n.Status != Status.Passive && n.Student.Id == int.Parse(HttpContext.Session.GetString("userId")));
            var items = new List<MyClass>();
            if (StudentNotices != null)
            {
                
                var studentNoticeDTO = new List<AddStudentNoticeDTO>();
                foreach (var notice in StudentNotices)
                {
                    var NoticeOwner = await _adminRepository.GetByDefault(n => n.Status != Status.Passive && n.Id == notice.AdminId);
                    studentNoticeDTO.Add(new AddStudentNoticeDTO { Title = notice.Title, Description = notice.Description, AdminId = notice.AdminId, StudentId = notice.StudentId, Admin = NoticeOwner, CreateDate = notice.CreateDate,TimeAgo=dateHelper.timeSpan(notice.CreateDate)});
                    items.Add(new MyClass(){Id=$"{NoticeOwner.Id}{notice.StudentId}",CreatedDate=notice.CreateDate});
                }

                HttpContext.Session.Remove("noties");
                HttpContext.Session.SetString("noties", JsonConvert.SerializeObject(items));
                return View(studentNoticeDTO);
            }
            else
            {
                ViewBag.NoNotices = "Yeni Duyuru Yok.";
                return View();
            }
            
        }


    public IActionResult LogOut()
    {
        HttpContext.Session.Remove("userId");
        HttpContext.Session.Remove("fullname");
        HttpContext.Session.Remove("email");
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Login");
    }

    public async Task<IActionResult> Profile()
    {

        var profile = await _studentRepository.GetByDefault(s => s.Email == HttpContext.Session.GetString("email"));
        var classroom = await _classroomRepository.GetByDefault(c => c.Id == profile.ClassroomId);
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
            Gender = (Models.DTOs.Student.Review.Gender)profile.Gender,
            Grade = (Models.DTOs.Student.Review.Grade)profile.Grade,
            AvarageScore = profile.AvarageScore,
            Classroom = classroom
        };

        return View(reviewStudentDetailsDTO);
    }

        public async Task<IActionResult> Notes()
        {
            string StudentId = HttpContext.Session.GetString("userId");
            var SchoolReports = await _noteRepository.NotesQuery(StudentId);

            
            DateHelper dateHelper = new DateHelper();
            var items = new List<MyClass>();
            if (SchoolReports != null)
            {
                var AddSchoolReportDTOs = new List<AddSchoolReportDTO>();
                 foreach (var SchoolReport in SchoolReports)
                {
                    AddSchoolReportDTOs.Add(new AddSchoolReportDTO { StudentId = SchoolReport.StudentId, Student = SchoolReport.Student, Term = SchoolReport.Term, AbsentDay = SchoolReport.AbsentDay, Notes = SchoolReport.Notes,  CreatedDate = SchoolReport.CreateDate, TimeAgo = dateHelper.timeSpan(SchoolReport.CreateDate) });
                    items.Add(new MyClass() { CreatedDate = SchoolReport.CreateDate });
                }
                HttpContext.Session.Remove("noties");
                HttpContext.Session.SetString("noties", JsonConvert.SerializeObject(items));
                return View(AddSchoolReportDTOs);
            }
            else
            {
                ViewBag.NoNotices = "Yeni Duyuru Yok.";
                return View();
            }
        }

       
    public async Task<IActionResult> EditProfile()
    {

        var profile = await _studentRepository.GetByDefault(s => s.Email == HttpContext.Session.GetString("email"));
        if (profile == null)
        {
            ModelState.AddModelError("", "Bir hata oluştu. Lütfen çıkış yapıp tekrar deneyiniz..");
            return RedirectToAction("Index", "Home");
        }
        UpdateStudentDTO dto = new UpdateStudentDTO()
        {
            Password = profile.Password,
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
