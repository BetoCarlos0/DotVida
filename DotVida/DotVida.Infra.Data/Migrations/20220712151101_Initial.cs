using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotVida.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    Specialty = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BloodType = table.Column<int>(type: "int", nullable: false),
                    PersonStatus = table.Column<bool>(type: "bit", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BloodType = table.Column<int>(type: "int", nullable: false),
                    PersonStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientsEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateEntry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateExit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusEntry = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsEntry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sicks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sicks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(1,2)", precision: 1, scale: 2, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentsDoctor = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    PatientEntryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attendances_PatientsEntry_PatientEntryId",
                        column: x => x.PatientEntryId,
                        principalTable: "PatientsEntry",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Personal_Illnesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    StatusSick = table.Column<int>(type: "int", nullable: false),
                    SickId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttendanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal_Illnesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personal_Illnesses_Attendances_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personal_Illnesses_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personal_Illnesses_Sicks_SickId",
                        column: x => x.SickId,
                        principalTable: "Sicks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_DoctorId",
                table: "Attendances",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_PatientEntryId",
                table: "Attendances",
                column: "PatientEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_PatientId",
                table: "Attendances",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Illnesses_AttendanceId",
                table: "Personal_Illnesses",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Illnesses_PatientId",
                table: "Personal_Illnesses",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Illnesses_SickId",
                table: "Personal_Illnesses",
                column: "SickId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personal_Illnesses");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Sicks");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PatientsEntry");
        }
    }
}
