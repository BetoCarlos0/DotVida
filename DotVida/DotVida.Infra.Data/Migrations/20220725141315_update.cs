using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotVida.Infra.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_PatientsEntry_PatientEntryId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientsEntry_Patients_PatientId",
                table: "PatientsEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalSicks_Attendances_AttendanceId",
                table: "PersonalSicks");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalSicks_Patients_PatientId",
                table: "PersonalSicks");

            migrationBuilder.DropIndex(
                name: "IX_PersonalSicks_AttendanceId",
                table: "PersonalSicks");

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientId",
                table: "PersonalSicks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AttendanceId",
                table: "PersonalSicks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientId",
                table: "PatientsEntry",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientEntryId",
                table: "Attendances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_PatientsEntry_PatientEntryId",
                table: "Attendances",
                column: "PatientEntryId",
                principalTable: "PatientsEntry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientsEntry_Patients_PatientId",
                table: "PatientsEntry",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalSicks_Patients_PatientId",
                table: "PersonalSicks",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_PatientsEntry_PatientEntryId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientsEntry_Patients_PatientId",
                table: "PatientsEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalSicks_Patients_PatientId",
                table: "PersonalSicks");

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientId",
                table: "PersonalSicks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AttendanceId",
                table: "PersonalSicks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientId",
                table: "PatientsEntry",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientEntryId",
                table: "Attendances",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalSicks_AttendanceId",
                table: "PersonalSicks",
                column: "AttendanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_PatientsEntry_PatientEntryId",
                table: "Attendances",
                column: "PatientEntryId",
                principalTable: "PatientsEntry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientsEntry_Patients_PatientId",
                table: "PatientsEntry",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalSicks_Attendances_AttendanceId",
                table: "PersonalSicks",
                column: "AttendanceId",
                principalTable: "Attendances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalSicks_Patients_PatientId",
                table: "PersonalSicks",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }
    }
}
