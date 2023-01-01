using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilge_College.Migrations
{
    public partial class bilgedbtest35672 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 111, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 112, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 112, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 114, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 114, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 114, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 115, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 115, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 115, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 120, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 120, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 120, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 128, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 128, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 128, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 129, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 129, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 129, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 122, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 122, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 122, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 133, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 133, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 133, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 131, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 131, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 131, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 137, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 138, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 138, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 139, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 139, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 139, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 33, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 141, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 34, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 141, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 35, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 141, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 135, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 136, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 136, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 24, 60 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 144, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 25, 61 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 144, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 26, 62 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 144, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 60, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 147, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 61, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 147, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 62, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 147, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 145, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 145, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 145, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 142, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 142, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 142, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 24, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 148, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 25, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 148, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 26, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 148, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 150, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 150, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 15, 55, 150, DateTimeKind.Local).AddTicks(5386));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 524, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 524, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 524, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 526, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 526, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 526, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 528, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 528, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 528, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 532, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 532, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 532, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 538, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 539, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 539, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 540, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 540, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 540, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 533, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 533, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 533, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 543, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 543, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 543, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 542, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 542, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 542, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 548, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 548, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 548, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 550, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 550, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 550, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 33, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 552, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 34, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 552, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 35, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 552, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 546, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 547, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 547, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 24, 60 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 554, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 25, 61 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 554, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 26, 62 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 554, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 60, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 558, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 61, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 558, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 62, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 558, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 556, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 556, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 556, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 553, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 553, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 553, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 24, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 559, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 25, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 559, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 26, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 559, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 561, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 561, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2022, 12, 6, 21, 2, 13, 561, DateTimeKind.Local).AddTicks(2322));
        }
    }
}
