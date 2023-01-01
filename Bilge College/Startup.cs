using AutoMapper;
using Bilge_College.Hubs;
using Bilge_College.Infrastructure.Context;
using Bilge_College.Infrastructure.Repositories.Concrete;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.AutoMapper;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilge_College
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Mapping));
            services.AddControllersWithViews();
            services.AddSession();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapping());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddDbContext<BilgeDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("conStr"));
            });
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IClassroomRepository, ClassroomRepository>();
            services.AddScoped<IInspectorRepository, InspectorRepository>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<IParentMessageRepository, ParentMessageRepository>();
            services.AddScoped<IParentNoticeRepository, ParentNoticeRepository>();
            services.AddScoped<IParentRepository, ParentRepository>();
            services.AddScoped<ISchoolReportRepository, SchoolReportRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IStudentMessageRepository, StudentMessageRepository>();
            services.AddScoped<IStudentNoticeRepository, StudentNoticeRepository>();
            services.AddScoped<IStudentParentRepository, StudentParentRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ISubSubjectClassroomRepository, SubSubjectClassroomRepository>();
            services.AddScoped<ISubSubjectRepository, SubSubjectRepository>();
            services.AddScoped<ISubSubjectTeacherRepository, SubSubjectTeacherRepository>();
            services.AddScoped<IClassroomRepository, ClassroomRepository>();
            services.AddScoped<ITeacherClassroomRepository, TeacherClassroomRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddSignalR();
            

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.WithOrigins("https://localhost:5001", "https://localhost:53217").
                     AllowAnyHeader().
                     AllowAnyMethod().
                     AllowCredentials();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
           

            app.UseAuthorization();
            app.UseSession();
            app.UseCors("CorsPolicy");
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapHub<TimeHub>("/TimeHub");
                endpoints.MapControllerRoute(
                name: "areaDefault",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });    
        }
    }
}
