using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilge_College.Migrations
{
    public partial class testdbddfd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Teachers",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Teachers",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Teachers",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TeacherClassrooms",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "TeacherClassrooms",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TeacherClassrooms",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SubSubjectTeachers",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "SubSubjectTeachers",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SubSubjectTeachers",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SubSubjects",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "SubSubjects",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SubSubjects",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SubSubjectClassrooms",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "SubSubjectClassrooms",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SubSubjectClassrooms",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Subjects",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Subjects",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Subjects",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Students",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Students",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Students",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Students",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "StudentParents",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "StudentParents",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "StudentParents",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "StudentNotices",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "StudentNotices",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "StudentNotices",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "StudentMessages",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "StudentMessages",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "StudentMessages",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Schools",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Schools",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Schools",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SchoolReports",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "SchoolReports",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SchoolReports",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Parents",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Parents",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Parents",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ParentNotices",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "ParentNotices",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ParentNotices",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ParentMessages",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "ParentMessages",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ParentMessages",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Notes",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Notes",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Notes",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Inspectors",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Inspectors",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Inspectors",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Classrooms",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Classrooms",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Classrooms",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Admins",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Admins",
                type: "Datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Admins",
                type: "Datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldMaxLength: 7);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Teachers",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Teachers",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Teachers",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "TeacherClassrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "TeacherClassrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TeacherClassrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SubSubjectTeachers",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "SubSubjectTeachers",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SubSubjectTeachers",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SubSubjects",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "SubSubjects",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SubSubjects",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SubSubjectClassrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "SubSubjectClassrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SubSubjectClassrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Subjects",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Subjects",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Subjects",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Students",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Students",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Students",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Students",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "StudentParents",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "StudentParents",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "StudentParents",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "StudentNotices",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "StudentNotices",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "StudentNotices",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "StudentMessages",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "StudentMessages",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "StudentMessages",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Schools",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Schools",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Schools",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "SchoolReports",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "SchoolReports",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SchoolReports",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Parents",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Parents",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Parents",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ParentNotices",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "ParentNotices",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ParentNotices",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "ParentMessages",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "ParentMessages",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ParentMessages",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Notes",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Notes",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Notes",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Inspectors",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Inspectors",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Inspectors",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Classrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Classrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Classrooms",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Admins",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Admins",
                type: "Datetime2",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Admins",
                type: "Datetime2",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2(7)");

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
    }
}
