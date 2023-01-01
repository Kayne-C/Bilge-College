using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilge_College.Migrations
{
    public partial class gadfgdsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 549, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 550, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 550, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 552, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 552, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 552, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 553, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 553, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Inspectors",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 553, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 557, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 557, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 557, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 567, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 567, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "ParentMessages",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 567, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 21, 33 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 569, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 22, 34 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 569, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "ParentNotices",
                keyColumns: new[] { "AdminId", "ParentId" },
                keyValues: new object[] { 23, 35 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 569, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 558, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 558, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 558, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 572, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 572, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "SchoolReports",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 572, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 570, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 570, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 570, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 577, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 577, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "StudentMessages",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 577, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 21, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 579, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 22, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 579, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "StudentNotices",
                keyColumns: new[] { "AdminId", "StudentId" },
                keyValues: new object[] { 23, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 579, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 33, 48 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 580, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 34, 49 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 580, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "StudentParents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { 35, 50 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 580, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 575, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 575, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 575, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 24, 60 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 583, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 25, 61 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 583, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "SubSubjectClassrooms",
                keyColumns: new[] { "ClassroomId", "SubSubjectId" },
                keyValues: new object[] { 26, 62 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 583, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 60, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 586, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 61, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 586, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "SubSubjectTeachers",
                keyColumns: new[] { "SubSubjectId", "TeacherId" },
                keyValues: new object[] { 62, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 586, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 584, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 584, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "SubSubjects",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 584, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 581, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 581, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 581, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 24, 63 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 587, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 25, 64 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 587, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "TeacherClassrooms",
                keyColumns: new[] { "ClassroomId", "TeacherId" },
                keyValues: new object[] { 26, 65 },
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 587, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 589, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 589, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2022, 12, 9, 23, 21, 32, 589, DateTimeKind.Local).AddTicks(4908));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
