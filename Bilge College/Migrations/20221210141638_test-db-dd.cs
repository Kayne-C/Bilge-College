using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilge_College.Migrations
{
    public partial class testdbdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 205, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 205, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 205, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 208, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 208, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 208, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 209, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 209, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 209, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 213, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 213, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 213, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 224, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 224, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 224, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 226, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 227, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 227, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 215, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 215, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 215, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 230, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 230, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 230, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 228, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 228, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 228, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 235, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 235, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 235, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 238, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 238, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 238, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 33, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 239, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 34, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 239, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 35, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 239, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 233, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 233, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 233, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 24, 60 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 242, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 25, 61 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 242, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 26, 62 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 242, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 60, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 245, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 61, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 245, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 62, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 245, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 243, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 243, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 243, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 240, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 240, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 240, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 24, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 246, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 25, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 246, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 26, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 246, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 248, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 248, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2022, 12, 10, 16, 53, 51, 248, DateTimeKind.Local).AddTicks(3805));
        }
    }
}
