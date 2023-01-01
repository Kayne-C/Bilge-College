using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilge_College.Migrations
{
    public partial class testdbsdfas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentNotices",
                table: "StudentNotices");

            migrationBuilder.DeleteData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 });

            migrationBuilder.DeleteData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 });

            migrationBuilder.DeleteData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 });

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentNotices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentNotices",
                table: "StudentNotices",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 33, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 33, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 33, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 35, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 35, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 35, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 36, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 37, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 37, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 40, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 40, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 40, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 50, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 50, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 50, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 52, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 52, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 52, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 41, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 42, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 42, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 55, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 55, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 55, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 53, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 53, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 53, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 59, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 59, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 59, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.InsertData(
                table: "StudentNotices",
                columns: new[] { "Id", "AdminId", "CreateDate", "DeleteDate", "Description", "Status", "StudentId", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 54, 21, new DateTime(2022, 12, 11, 21, 6, 36, 61, DateTimeKind.Local).AddTicks(3965), null, "This is a test notice", 1, 48, "Hello", null },
                    { 56, 23, new DateTime(2022, 12, 11, 21, 6, 36, 61, DateTimeKind.Local).AddTicks(4607), null, "This is a test notice3", 1, 50, "Hello3", null },
                    { 55, 22, new DateTime(2022, 12, 11, 21, 6, 36, 61, DateTimeKind.Local).AddTicks(4605), null, "This is a test notice2", 1, 49, "Hello2", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 33, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 62, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 34, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 63, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 35, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 63, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 57, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 58, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 58, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 24, 60 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 65, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 25, 61 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 65, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 26, 62 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 65, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 60, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 68, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 61, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 68, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 62, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 68, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 66, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 66, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 66, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 63, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 63, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 63, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 24, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 69, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 25, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 70, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 26, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 70, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 71, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 71, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2022, 12, 11, 21, 6, 36, 71, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.CreateIndex(
                name: "IX_StudentNotices_AdminId",
                table: "StudentNotices",
                column: "AdminId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentNotices",
                table: "StudentNotices");

            migrationBuilder.DropIndex(
                name: "IX_StudentNotices_AdminId",
                table: "StudentNotices");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentNotices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentNotices",
                table: "StudentNotices",
                columns: new[] { "AdminId", "StudentId" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 914, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 914, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 914, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 917, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 917, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 917, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 918, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 918, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 918, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 922, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 922, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 922, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 933, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 933, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 933, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 935, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 935, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 935, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 923, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 923, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 923, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 938, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 938, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 938, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 936, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 936, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 936, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 943, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 943, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 943, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 945, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 945, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 945, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 33, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 946, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 34, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 946, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 35, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 946, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 941, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 941, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 941, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 24, 60 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 949, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 25, 61 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 949, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 26, 62 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 949, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 60, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 952, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 61, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 952, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 62, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 952, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 950, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 950, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 950, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 947, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 947, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 947, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 24, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 953, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 25, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 953, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 26, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 953, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 955, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 955, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 17, 16, 37, 955, DateTimeKind.Local).AddTicks(4112));
        }
    }
}
