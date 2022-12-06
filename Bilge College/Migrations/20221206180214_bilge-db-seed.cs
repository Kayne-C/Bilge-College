using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilge_College.Migrations
{
    public partial class bilgedbseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    Duty = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch = table.Column<string>(type: "Char(1)", nullable: false),
                    Grade = table.Column<int>(type: "INT", nullable: false),
                    Capacity = table.Column<int>(type: "Int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inspectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    Duty = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    HomePhone = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    WorkPhone = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    HomeAddress = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Level = table.Column<int>(type: "INT", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    Branch = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Duty = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParentMessages",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Context = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentMessages", x => new { x.AdminId, x.ParentId });
                    table.ForeignKey(
                        name: "FK_ParentMessages_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentMessages_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentNotices",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentNotices", x => new { x.AdminId, x.ParentId });
                    table.ForeignKey(
                        name: "FK_ParentNotices_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentNotices_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolNumber = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Gender = table.Column<int>(type: "INT", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    Grade = table.Column<int>(type: "INT", nullable: false),
                    ClassroomId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    AvarageScore = table.Column<int>(type: "Int", nullable: false),
                    AttendanceStatus = table.Column<int>(type: "INT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubSubjectsName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    WeeklyClassTime = table.Column<int>(type: "Int", nullable: false),
                    SubSubjectCredit = table.Column<int>(type: "Int", nullable: false),
                    Grade = table.Column<int>(type: "INT", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherClassrooms",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    ClassroomId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherClassrooms", x => new { x.ClassroomId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_TeacherClassrooms_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherClassrooms_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Term = table.Column<int>(type: "INT", nullable: false),
                    AbsentDay = table.Column<int>(type: "Int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolReports_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentMessages",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Context = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMessages", x => new { x.AdminId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentMessages_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentMessages_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentNotices",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentNotices", x => new { x.AdminId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentNotices_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentNotices_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentParents",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentParents", x => new { x.StudentId, x.ParentId });
                    table.ForeignKey(
                        name: "FK_StudentParents_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentParents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubSubjectClassrooms",
                columns: table => new
                {
                    SubSubjectId = table.Column<int>(type: "int", nullable: false),
                    ClassroomId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubSubjectClassrooms", x => new { x.SubSubjectId, x.ClassroomId });
                    table.ForeignKey(
                        name: "FK_SubSubjectClassrooms_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubSubjectClassrooms_SubSubjects_SubSubjectId",
                        column: x => x.SubSubjectId,
                        principalTable: "SubSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubSubjectTeachers",
                columns: table => new
                {
                    SubSubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubSubjectTeachers", x => new { x.SubSubjectId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_SubSubjectTeachers_SubSubjects_SubSubjectId",
                        column: x => x.SubSubjectId,
                        principalTable: "SubSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubSubjectTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubSubjectId = table.Column<int>(type: "int", nullable: false),
                    FirstExamScore = table.Column<int>(type: "Int", nullable: false),
                    SecondExamScore = table.Column<int>(type: "Int", nullable: false),
                    AvarageScore = table.Column<int>(type: "Int", nullable: false),
                    SchoolReportId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdateDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Status = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_SchoolReports_SchoolReportId",
                        column: x => x.SchoolReportId,
                        principalTable: "SchoolReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notes_SubSubjects_SubSubjectId",
                        column: x => x.SubSubjectId,
                        principalTable: "SubSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Duty", "Email", "FirstName", "Image", "LastName", "Password", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 21, new DateTime(2022, 12, 6, 21, 2, 13, 524, DateTimeKind.Local).AddTicks(4413), null, "Administrator", "chucklockwood@live.com", "Chuck", "None", "LockWood", "12345678", 1, null },
                    { 22, new DateTime(2022, 12, 6, 21, 2, 13, 524, DateTimeKind.Local).AddTicks(5114), null, "Co-Administrator", "samwinchester@live.com", "Sam", "None", "Winchester", "12345678", 1, null },
                    { 23, new DateTime(2022, 12, 6, 21, 2, 13, 524, DateTimeKind.Local).AddTicks(5117), null, "Co-Administrator", "deanwinchester@live.com", "Dean", "None", "Winchester", "12345678", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Branch", "Capacity", "CreateDate", "DeleteDate", "Grade", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 24, "A", 25, new DateTime(2022, 12, 6, 21, 2, 13, 526, DateTimeKind.Local).AddTicks(9239), null, 1, 1, null },
                    { 25, "B", 25, new DateTime(2022, 12, 6, 21, 2, 13, 526, DateTimeKind.Local).AddTicks(9566), null, 1, 1, null },
                    { 26, "C", 25, new DateTime(2022, 12, 6, 21, 2, 13, 526, DateTimeKind.Local).AddTicks(9568), null, 1, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Inspectors",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Duty", "Email", "FirstName", "Image", "LastName", "Password", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 27, new DateTime(2022, 12, 6, 21, 2, 13, 528, DateTimeKind.Local).AddTicks(3117), null, "Pirate", "jacksparrow@live.com", "Jack", "None", "Sparrow", "12345678", 1, null },
                    { 28, new DateTime(2022, 12, 6, 21, 2, 13, 528, DateTimeKind.Local).AddTicks(4196), null, "Maniac", "billylittle@live.com", "Billy", "None", "Little", "12345678", 1, null },
                    { 29, new DateTime(2022, 12, 6, 21, 2, 13, 528, DateTimeKind.Local).AddTicks(4199), null, "Astronout", "buzzlightyear@live.com", "Buzz", "None", "Lightyear", "12345678", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Email", "FirstName", "HomeAddress", "HomePhone", "LastName", "Password", "Status", "UpdateDate", "WorkPhone" },
                values: new object[,]
                {
                    { 35, new DateTime(2022, 12, 6, 21, 2, 13, 533, DateTimeKind.Local).AddTicks(6681), null, "ezioauidotore@live.com", "Claire", "NoAddress", "12345678900", "Redfield", "12345678", 1, null, "123456789" },
                    { 34, new DateTime(2022, 12, 6, 21, 2, 13, 533, DateTimeKind.Local).AddTicks(6678), null, "altairniobe@live.com", "Altair", "NoAddress", "1234567899", "Niobe", "12345678", 1, null, "123456789" },
                    { 33, new DateTime(2022, 12, 6, 21, 2, 13, 533, DateTimeKind.Local).AddTicks(5565), null, "ezioauidotore@live.com", "Ezio", "NoAddress", "123456789", "Auidotore", "12345678", 1, null, "123456789" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Capacity", "CreateDate", "DeleteDate", "Level", "Rate", "SchoolName", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 42, 1222, new DateTime(2022, 12, 6, 21, 2, 13, 542, DateTimeKind.Local).AddTicks(3231), null, 1, 58, "Testschool", 1, null },
                    { 43, 1244, new DateTime(2022, 12, 6, 21, 2, 13, 542, DateTimeKind.Local).AddTicks(3862), null, 1, 57, "Testschool2", 1, null },
                    { 44, 1253, new DateTime(2022, 12, 6, 21, 2, 13, 542, DateTimeKind.Local).AddTicks(3865), null, 2, 67, "Testschool3", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Status", "SubjectName", "UpdateDate" },
                values: new object[,]
                {
                    { 57, new DateTime(2022, 12, 6, 21, 2, 13, 553, DateTimeKind.Local).AddTicks(1901), null, 1, "Subject1", null },
                    { 58, new DateTime(2022, 12, 6, 21, 2, 13, 553, DateTimeKind.Local).AddTicks(1905), null, 1, "Subject2", null },
                    { 59, new DateTime(2022, 12, 6, 21, 2, 13, 553, DateTimeKind.Local).AddTicks(1908), null, 1, "Subject3", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Branch", "CreateDate", "DeleteDate", "Duty", "Email", "FirstName", "Image", "LastName", "Password", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 63, "Math", new DateTime(2022, 12, 6, 21, 2, 13, 561, DateTimeKind.Local).AddTicks(1190), null, "None", "williamjones@live.com", "William", "Empty", "Jones", "12345678", 1, null },
                    { 64, "Physics", new DateTime(2022, 12, 6, 21, 2, 13, 561, DateTimeKind.Local).AddTicks(2319), null, "None", "moirabarret@live.com", "Moira", "Empty", "Barret", "12345678", 1, null },
                    { 65, "Biology", new DateTime(2022, 12, 6, 21, 2, 13, 561, DateTimeKind.Local).AddTicks(2322), null, "None", "gabriellogan@live.com", "Gabriel", "Empty", "Logan", "12345678", 1, null }
                });

            migrationBuilder.InsertData(
                table: "ParentMessages",
                columns: new[] { "AdminId", "ParentId", "Context", "CreateDate", "DeleteDate", "Status", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 21, 33, "This is a test message", new DateTime(2022, 12, 6, 21, 2, 13, 538, DateTimeKind.Local).AddTicks(9785), null, 1, "Hello", null },
                    { 22, 34, "This is a test message2", new DateTime(2022, 12, 6, 21, 2, 13, 539, DateTimeKind.Local).AddTicks(454), null, 1, "Hello2", null },
                    { 23, 35, "This is a test message3", new DateTime(2022, 12, 6, 21, 2, 13, 539, DateTimeKind.Local).AddTicks(457), null, 1, "Hello3", null }
                });

            migrationBuilder.InsertData(
                table: "ParentNotices",
                columns: new[] { "AdminId", "ParentId", "CreateDate", "DeleteDate", "Description", "Status", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 21, 33, new DateTime(2022, 12, 6, 21, 2, 13, 540, DateTimeKind.Local).AddTicks(8642), null, "This is a test notice", 1, "Hello", null },
                    { 22, 34, new DateTime(2022, 12, 6, 21, 2, 13, 540, DateTimeKind.Local).AddTicks(9341), null, "This is a test notice2", 1, "Hello2", null },
                    { 23, 35, new DateTime(2022, 12, 6, 21, 2, 13, 540, DateTimeKind.Local).AddTicks(9344), null, "This is a test notice3", 1, "Hello3", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AttendanceStatus", "AvarageScore", "BirthDate", "ClassroomId", "CreateDate", "DeleteDate", "Email", "FirstName", "Gender", "Grade", "Image", "LastName", "Password", "SchoolId", "SchoolNumber", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 48, 1, 70, new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, new DateTime(2022, 12, 6, 21, 2, 13, 546, DateTimeKind.Local).AddTicks(8374), null, "johnswear@live.com", "John", 1, 1, "Empty", "Swear", "12345678", 42, "103", 1, null },
                    { 49, 1, 85, new DateTime(1995, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new DateTime(2022, 12, 6, 21, 2, 13, 547, DateTimeKind.Local).AddTicks(302), null, "callyswear@live.com", "Cally", 1, 1, "Empty", "Swear", "12345678", 43, "104", 1, null },
                    { 50, 1, 90, new DateTime(1990, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, new DateTime(2022, 12, 6, 21, 2, 13, 547, DateTimeKind.Local).AddTicks(306), null, "klausainzbell@live.com", "Klaus", 1, 1, "Empty", "Ainzbell", "12345678", 44, "105", 1, null }
                });

            migrationBuilder.InsertData(
                table: "SubSubjects",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Grade", "Status", "SubSubjectCredit", "SubSubjectsName", "SubjectId", "UpdateDate", "WeeklyClassTime" },
                values: new object[,]
                {
                    { 60, new DateTime(2022, 12, 6, 21, 2, 13, 556, DateTimeKind.Local).AddTicks(3588), null, 1, 1, 6, "SubSubject1", 57, null, 5 },
                    { 61, new DateTime(2022, 12, 6, 21, 2, 13, 556, DateTimeKind.Local).AddTicks(4312), null, 1, 1, 5, "SubSubject2", 58, null, 4 },
                    { 62, new DateTime(2022, 12, 6, 21, 2, 13, 556, DateTimeKind.Local).AddTicks(4315), null, 1, 1, 3, "SubSubject3", 59, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "TeacherClassrooms",
                columns: new[] { "ClassroomId", "TeacherId", "CreateDate", "DeleteDate", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 24, 63, new DateTime(2022, 12, 6, 21, 2, 13, 559, DateTimeKind.Local).AddTicks(6255), null, 1, null },
                    { 25, 64, new DateTime(2022, 12, 6, 21, 2, 13, 559, DateTimeKind.Local).AddTicks(6618), null, 1, null },
                    { 26, 65, new DateTime(2022, 12, 6, 21, 2, 13, 559, DateTimeKind.Local).AddTicks(6621), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "SchoolReports",
                columns: new[] { "Id", "AbsentDay", "CreateDate", "DeleteDate", "Status", "StudentId", "Term", "UpdateDate" },
                values: new object[,]
                {
                    { 45, 5, new DateTime(2022, 12, 6, 21, 2, 13, 543, DateTimeKind.Local).AddTicks(8824), null, 1, 48, 1, null },
                    { 46, 7, new DateTime(2022, 12, 6, 21, 2, 13, 543, DateTimeKind.Local).AddTicks(9306), null, 1, 49, 1, null },
                    { 47, 9, new DateTime(2022, 12, 6, 21, 2, 13, 543, DateTimeKind.Local).AddTicks(9309), null, 1, 50, 1, null }
                });

            migrationBuilder.InsertData(
                table: "StudentMessages",
                columns: new[] { "AdminId", "StudentId", "Context", "CreateDate", "DeleteDate", "Status", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 21, 48, "This is a test message", new DateTime(2022, 12, 6, 21, 2, 13, 548, DateTimeKind.Local).AddTicks(8487), null, 1, "Hello", null },
                    { 22, 49, "This is a test message2", new DateTime(2022, 12, 6, 21, 2, 13, 548, DateTimeKind.Local).AddTicks(9139), null, 1, "Hello2", null },
                    { 23, 50, "This is a test message3", new DateTime(2022, 12, 6, 21, 2, 13, 548, DateTimeKind.Local).AddTicks(9142), null, 1, "Hello3", null }
                });

            migrationBuilder.InsertData(
                table: "StudentNotices",
                columns: new[] { "AdminId", "StudentId", "CreateDate", "DeleteDate", "Description", "Status", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 22, 49, new DateTime(2022, 12, 6, 21, 2, 13, 550, DateTimeKind.Local).AddTicks(7086), null, "This is a test notice2", 1, "Hello2", null },
                    { 23, 50, new DateTime(2022, 12, 6, 21, 2, 13, 550, DateTimeKind.Local).AddTicks(7089), null, "This is a test notice3", 1, "Hello3", null },
                    { 21, 48, new DateTime(2022, 12, 6, 21, 2, 13, 550, DateTimeKind.Local).AddTicks(6386), null, "This is a test notice", 1, "Hello", null }
                });

            migrationBuilder.InsertData(
                table: "StudentParents",
                columns: new[] { "ParentId", "StudentId", "CreateDate", "DeleteDate", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 33, 48, new DateTime(2022, 12, 6, 21, 2, 13, 552, DateTimeKind.Local).AddTicks(2736), null, 1, null },
                    { 34, 49, new DateTime(2022, 12, 6, 21, 2, 13, 552, DateTimeKind.Local).AddTicks(3087), null, 1, null },
                    { 35, 50, new DateTime(2022, 12, 6, 21, 2, 13, 552, DateTimeKind.Local).AddTicks(3090), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "SubSubjectClassrooms",
                columns: new[] { "ClassroomId", "SubSubjectId", "CreateDate", "DeleteDate", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 26, 62, new DateTime(2022, 12, 6, 21, 2, 13, 554, DateTimeKind.Local).AddTicks(8415), null, 1, null },
                    { 24, 60, new DateTime(2022, 12, 6, 21, 2, 13, 554, DateTimeKind.Local).AddTicks(8055), null, 1, null },
                    { 25, 61, new DateTime(2022, 12, 6, 21, 2, 13, 554, DateTimeKind.Local).AddTicks(8412), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "SubSubjectTeachers",
                columns: new[] { "SubSubjectId", "TeacherId", "CreateDate", "DeleteDate", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 60, 63, new DateTime(2022, 12, 6, 21, 2, 13, 558, DateTimeKind.Local).AddTicks(14), null, 1, null },
                    { 61, 64, new DateTime(2022, 12, 6, 21, 2, 13, 558, DateTimeKind.Local).AddTicks(363), null, 1, null },
                    { 62, 65, new DateTime(2022, 12, 6, 21, 2, 13, 558, DateTimeKind.Local).AddTicks(366), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "AvarageScore", "CreateDate", "DeleteDate", "FirstExamScore", "SchoolReportId", "SecondExamScore", "Status", "SubSubjectId", "UpdateDate" },
                values: new object[] { 30, 55, new DateTime(2022, 12, 6, 21, 2, 13, 532, DateTimeKind.Local).AddTicks(720), null, 60, 45, 50, 1, 60, null });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "AvarageScore", "CreateDate", "DeleteDate", "FirstExamScore", "SchoolReportId", "SecondExamScore", "Status", "SubSubjectId", "UpdateDate" },
                values: new object[] { 31, 70, new DateTime(2022, 12, 6, 21, 2, 13, 532, DateTimeKind.Local).AddTicks(1457), null, 70, 46, 70, 1, 61, null });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "AvarageScore", "CreateDate", "DeleteDate", "FirstExamScore", "SchoolReportId", "SecondExamScore", "Status", "SubSubjectId", "UpdateDate" },
                values: new object[] { 32, 80, new DateTime(2022, 12, 6, 21, 2, 13, 532, DateTimeKind.Local).AddTicks(1460), null, 80, 47, 80, 1, 62, null });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_SchoolReportId",
                table: "Notes",
                column: "SchoolReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_SubSubjectId",
                table: "Notes",
                column: "SubSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentMessages_ParentId",
                table: "ParentMessages",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentNotices_ParentId",
                table: "ParentNotices",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolReports_StudentId",
                table: "SchoolReports",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMessages_StudentId",
                table: "StudentMessages",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentNotices_StudentId",
                table: "StudentNotices",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentParents_ParentId",
                table: "StudentParents",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassroomId",
                table: "Students",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_SubSubjectClassrooms_ClassroomId",
                table: "SubSubjectClassrooms",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_SubSubjects_SubjectId",
                table: "SubSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubSubjectTeachers_TeacherId",
                table: "SubSubjectTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherClassrooms_TeacherId",
                table: "TeacherClassrooms",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspectors");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "ParentMessages");

            migrationBuilder.DropTable(
                name: "ParentNotices");

            migrationBuilder.DropTable(
                name: "StudentMessages");

            migrationBuilder.DropTable(
                name: "StudentNotices");

            migrationBuilder.DropTable(
                name: "StudentParents");

            migrationBuilder.DropTable(
                name: "SubSubjectClassrooms");

            migrationBuilder.DropTable(
                name: "SubSubjectTeachers");

            migrationBuilder.DropTable(
                name: "TeacherClassrooms");

            migrationBuilder.DropTable(
                name: "SchoolReports");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "SubSubjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
