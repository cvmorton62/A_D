using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace A_D.Data.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceNfieldVersion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceNfieldVersion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceOS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentFormat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFormat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacilityNoteTheme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityNoteTheme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterviewerEmployer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewerEmployer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterviewerNoteTheme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewerNoteTheme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotifyingParty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifyingParty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recommendation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefusalReasonNCI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 2, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefusalReasonNCI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepresentativeListStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentativeListStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepresentativeSurveyMethod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentativeSurveyMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RescheduleReason",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RescheduleReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultCategoryNCI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultCategoryNCI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultCodeQOLIncomplete",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(maxLength: 100, nullable: false),
                    Number = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultCodeQOLIncomplete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultCodeQOLNotInterviewed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(maxLength: 100, nullable: false),
                    Exclude = table.Column<bool>(nullable: false),
                    Number = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultCodeQOLNotInterviewed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnVisitReason",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnVisitReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleAgeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleAgeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleAgency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleAgency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleCCO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleCCO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleEthnicity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleEthnicity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleGender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleGender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleGeography",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleGeography", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleHomeSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleHomeSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleProgram",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleProgram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleRace",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleRace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeparationReason",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeparationReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inactive = table.Column<bool>(nullable: false),
                    Initials = table.Column<string>(maxLength: 3, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    WinUserId = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitCode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceModel_Id = table.Column<int>(nullable: false),
                    DeviceNfieldVersion_Id = table.Column<int>(nullable: false),
                    DeviceOS_Id = table.Column<int>(nullable: false),
                    Inactive = table.Column<bool>(nullable: false),
                    SerialNumber = table.Column<string>(maxLength: 100, nullable: true),
                    VRID = table.Column<string>(maxLength: 10, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Device_DeviceModel_DeviceModel_Id",
                        column: x => x.DeviceModel_Id,
                        principalTable: "DeviceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Device_DeviceNfieldVersion_DeviceNfieldVersion_Id",
                        column: x => x.DeviceNfieldVersion_Id,
                        principalTable: "DeviceNfieldVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Device_DeviceOS_DeviceOS_Id",
                        column: x => x.DeviceOS_Id,
                        principalTable: "DeviceOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultNCI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultCategoryNCI_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultNCI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultNCI_ResultCategoryNCI_ResultCategoryNCI_Id",
                        column: x => x.ResultCategoryNCI_Id,
                        principalTable: "ResultCategoryNCI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleAgeGroupMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleAgeGroup_Id_Original = table.Column<int>(nullable: false),
                    SampleAgeGroup_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleAgeGroupMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleAgeGroupMap_SampleAgeGroup_SampleAgeGroup_Id_Original",
                        column: x => x.SampleAgeGroup_Id_Original,
                        principalTable: "SampleAgeGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleAgeGroupMap_SampleAgeGroup_SampleAgeGroup_Id_Standardized",
                        column: x => x.SampleAgeGroup_Id_Standardized,
                        principalTable: "SampleAgeGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleAgencyMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleAgency_Id_Original = table.Column<int>(nullable: false),
                    SampleAgency_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleAgencyMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleAgencyMap_SampleAgency_SampleAgency_Id_Original",
                        column: x => x.SampleAgency_Id_Original,
                        principalTable: "SampleAgency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleAgencyMap_SampleAgency_SampleAgency_Id_Standardized",
                        column: x => x.SampleAgency_Id_Standardized,
                        principalTable: "SampleAgency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleCCOMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleCCO_Id_Original = table.Column<int>(nullable: false),
                    SampleCCO_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleCCOMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleCCOMap_SampleCCO_SampleCCO_Id_Original",
                        column: x => x.SampleCCO_Id_Original,
                        principalTable: "SampleCCO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleCCOMap_SampleCCO_SampleCCO_Id_Standardized",
                        column: x => x.SampleCCO_Id_Standardized,
                        principalTable: "SampleCCO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleEthnicityMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleEthnicity_Id_Original = table.Column<int>(nullable: false),
                    SampleEthnicity_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleEthnicityMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleEthnicityMap_SampleEthnicity_SampleEthnicity_Id_Original",
                        column: x => x.SampleEthnicity_Id_Original,
                        principalTable: "SampleEthnicity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleEthnicityMap_SampleEthnicity_SampleEthnicity_Id_Standardized",
                        column: x => x.SampleEthnicity_Id_Standardized,
                        principalTable: "SampleEthnicity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleGenderMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleGender_Id_Original = table.Column<int>(nullable: false),
                    SampleGender_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleGenderMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleGenderMap_SampleGender_SampleGender_Id_Original",
                        column: x => x.SampleGender_Id_Original,
                        principalTable: "SampleGender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleGenderMap_SampleGender_SampleGender_Id_Standardized",
                        column: x => x.SampleGender_Id_Standardized,
                        principalTable: "SampleGender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleGeographyMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleGeography_Id_Original = table.Column<int>(nullable: false),
                    SampleGeography_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleGeographyMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleGeographyMap_SampleGeography_SampleGeography_Id_Original",
                        column: x => x.SampleGeography_Id_Original,
                        principalTable: "SampleGeography",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleGeographyMap_SampleGeography_SampleGeography_Id_Standardized",
                        column: x => x.SampleGeography_Id_Standardized,
                        principalTable: "SampleGeography",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleHomeSettingMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleHomeSetting_Id_Original = table.Column<int>(nullable: false),
                    SampleHomeSetting_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleHomeSettingMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleHomeSettingMap_SampleHomeSetting_SampleHomeSetting_Id_Original",
                        column: x => x.SampleHomeSetting_Id_Original,
                        principalTable: "SampleHomeSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleHomeSettingMap_SampleHomeSetting_SampleHomeSetting_Id_Standardized",
                        column: x => x.SampleHomeSetting_Id_Standardized,
                        principalTable: "SampleHomeSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleLanguageMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleLanguage_Id_Original = table.Column<int>(nullable: false),
                    SampleLanguage_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleLanguageMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleLanguageMap_SampleLanguage_SampleLanguage_Id_Original",
                        column: x => x.SampleLanguage_Id_Original,
                        principalTable: "SampleLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleLanguageMap_SampleLanguage_SampleLanguage_Id_Standardized",
                        column: x => x.SampleLanguage_Id_Standardized,
                        principalTable: "SampleLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleProgramMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleProgram_Id_Original = table.Column<int>(nullable: false),
                    SampleProgram_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleProgramMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleProgramMap_SampleProgram_SampleProgram_Id_Original",
                        column: x => x.SampleProgram_Id_Original,
                        principalTable: "SampleProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleProgramMap_SampleProgram_SampleProgram_Id_Standardized",
                        column: x => x.SampleProgram_Id_Standardized,
                        principalTable: "SampleProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleRaceMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleRace_Id_Original = table.Column<int>(nullable: false),
                    SampleRace_Id_Standardized = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleRaceMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleRaceMap_SampleRace_SampleRace_Id_Original",
                        column: x => x.SampleRace_Id_Original,
                        principalTable: "SampleRace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SampleRaceMap_SampleRace_SampleRace_Id_Standardized",
                        column: x => x.SampleRace_Id_Standardized,
                        principalTable: "SampleRace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consumer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    SampleAgeGroup_Id = table.Column<int>(nullable: true),
                    SampleAgency_Id = table.Column<int>(nullable: true),
                    SampleCCO_Id = table.Column<int>(nullable: true),
                    SampleEthnicity_Id = table.Column<int>(nullable: true),
                    SampleGender_Id = table.Column<int>(nullable: true),
                    SampleGeography_Id = table.Column<int>(nullable: true),
                    SampleHomeSetting_Id = table.Column<int>(nullable: true),
                    SampleLanguage_Id = table.Column<int>(nullable: true),
                    SampleProgram_Id = table.Column<int>(nullable: true),
                    SampleRace_Id = table.Column<int>(nullable: true),
                    State_Id_Mailing = table.Column<int>(nullable: true),
                    State_Id_Physical = table.Column<int>(nullable: true),
                    Accommodation = table.Column<string>(maxLength: 1000, nullable: true),
                    AddressLine1Mailing = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine1Physical = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine2Mailing = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine2Physical = table.Column<string>(maxLength: 100, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    CaseManager = table.Column<string>(maxLength: 100, nullable: true),
                    CaseManagerEmail = table.Column<string>(maxLength: 100, nullable: true),
                    CaseManagerPhone = table.Column<string>(maxLength: 20, nullable: true),
                    CityMailing = table.Column<string>(maxLength: 100, nullable: true),
                    CityPhysical = table.Column<string>(maxLength: 100, nullable: true),
                    ConsentForm = table.Column<bool>(nullable: false),
                    ConsentFormGuardian = table.Column<bool>(nullable: false),
                    DateBIRequest = table.Column<DateTime>(type: "date", nullable: true),
                    DateBIResponse = table.Column<DateTime>(type: "date", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    DateReturnedLetter = table.Column<DateTime>(type: "date", nullable: true),
                    DateVerificationSheet = table.Column<DateTime>(type: "date", nullable: true),
                    DoNotAssign = table.Column<bool>(nullable: false),
                    DoNotAssignTargetMet = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneHome = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneMobile = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneWork = table.Column<string>(maxLength: 15, nullable: true),
                    PlaceOfEmployment = table.Column<string>(maxLength: 100, nullable: true),
                    SelfDirectedSupports = table.Column<bool>(nullable: false),
                    SpecialInstruction = table.Column<string>(maxLength: 1000, nullable: true),
                    StateIdentifier = table.Column<string>(maxLength: 100, nullable: true),
                    VRID = table.Column<string>(maxLength: 10, nullable: true),
                    ZipCodeMailing = table.Column<string>(maxLength: 15, nullable: true),
                    ZipCodePhysical = table.Column<string>(maxLength: 15, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleAgeGroup_SampleAgeGroup_Id",
                        column: x => x.SampleAgeGroup_Id,
                        principalTable: "SampleAgeGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleAgency_SampleAgency_Id",
                        column: x => x.SampleAgency_Id,
                        principalTable: "SampleAgency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleCCO_SampleCCO_Id",
                        column: x => x.SampleCCO_Id,
                        principalTable: "SampleCCO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleEthnicity_SampleEthnicity_Id",
                        column: x => x.SampleEthnicity_Id,
                        principalTable: "SampleEthnicity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleGender_SampleGender_Id",
                        column: x => x.SampleGender_Id,
                        principalTable: "SampleGender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleGeography_SampleGeography_Id",
                        column: x => x.SampleGeography_Id,
                        principalTable: "SampleGeography",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleHomeSetting_SampleHomeSetting_Id",
                        column: x => x.SampleHomeSetting_Id,
                        principalTable: "SampleHomeSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleLanguage_SampleLanguage_Id",
                        column: x => x.SampleLanguage_Id,
                        principalTable: "SampleLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleProgram_SampleProgram_Id",
                        column: x => x.SampleProgram_Id,
                        principalTable: "SampleProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_SampleRace_SampleRace_Id",
                        column: x => x.SampleRace_Id,
                        principalTable: "SampleRace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_State_State_Id_Mailing",
                        column: x => x.State_Id_Mailing,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumer_State_State_Id_Physical",
                        column: x => x.State_Id_Physical,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "County",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_County", x => x.Id);
                    table.ForeignKey(
                        name: "FK_County_State_State_Id",
                        column: x => x.State_Id,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interviewer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recommendation_Id = table.Column<int>(nullable: false),
                    State_Id = table.Column<int>(nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    NameFirst = table.Column<string>(maxLength: 100, nullable: false),
                    NameLast = table.Column<string>(maxLength: 100, nullable: false),
                    NfieldId = table.Column<string>(maxLength: 8, nullable: true),
                    Number = table.Column<string>(maxLength: 5, nullable: true),
                    Password = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneHome = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneMobile = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneWork = table.Column<string>(maxLength: 15, nullable: true),
                    Profession = table.Column<string>(maxLength: 100, nullable: true),
                    UserId = table.Column<string>(maxLength: 100, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 15, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviewer_Recommendation_Recommendation_Id",
                        column: x => x.Recommendation_Id,
                        principalTable: "Recommendation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interviewer_State_State_Id",
                        column: x => x.State_Id,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewerEmployer_Id = table.Column<int>(nullable: true),
                    State_Id = table.Column<int>(nullable: false),
                    Budget = table.Column<double>(nullable: true),
                    FolderPath = table.Column<string>(maxLength: 200, nullable: true),
                    DateBegin = table.Column<DateTime>(type: "date", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "date", nullable: true),
                    DatePHIDelete = table.Column<DateTime>(type: "date", nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    InterraterAgreement = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    QualityAssurance = table.Column<bool>(nullable: false),
                    TrainingLocation = table.Column<string>(maxLength: 200, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_InterviewerEmployer_InterviewerEmployer_Id",
                        column: x => x.InterviewerEmployer_Id,
                        principalTable: "InterviewerEmployer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_State_State_Id",
                        column: x => x.State_Id,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeviceNote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Device_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 1000, nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceNote_Device_Device_Id",
                        column: x => x.Device_Id,
                        principalTable: "Device",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeviceNote_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consumer_Id = table.Column<int>(nullable: false),
                    State_Id = table.Column<int>(nullable: true),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneHome = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneMobile = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneWork = table.Column<string>(maxLength: 15, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 15, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumerContact_Consumer_Consumer_Id",
                        column: x => x.Consumer_Id,
                        principalTable: "Consumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsumerContact_State_State_Id",
                        column: x => x.State_Id,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerGuardian",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consumer_Id = table.Column<int>(nullable: false),
                    State_Id = table.Column<int>(nullable: true),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneHome = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneMobile = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneWork = table.Column<string>(maxLength: 15, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 15, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerGuardian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumerGuardian_Consumer_Consumer_Id",
                        column: x => x.Consumer_Id,
                        principalTable: "Consumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsumerGuardian_State_State_Id",
                        column: x => x.State_Id,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerNote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consumer_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    Caller = table.Column<string>(maxLength: 100, nullable: true),
                    Comment = table.Column<string>(maxLength: 1000, nullable: true),
                    DateInterviewerNotified = table.Column<DateTime>(type: "date", nullable: true),
                    Note = table.Column<string>(maxLength: 1000, nullable: false),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumerNote_Consumer_Consumer_Id",
                        column: x => x.Consumer_Id,
                        principalTable: "Consumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsumerNote_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    County_Id = table.Column<int>(nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    BedCount = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    Fax = table.Column<string>(maxLength: 15, nullable: true),
                    FID = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Phone1 = table.Column<string>(maxLength: 15, nullable: true),
                    Phone2 = table.Column<string>(maxLength: 15, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 15, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facility_County_County_Id",
                        column: x => x.County_Id,
                        principalTable: "County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consumer_Id = table.Column<int>(nullable: false),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    Interviewer_Id_Peer = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DriveTime = table.Column<DateTime>(nullable: true),
                    Miles = table.Column<double>(nullable: true),
                    Payment = table.Column<double>(nullable: true),
                    PaymentApproved = table.Column<bool>(nullable: false),
                    PeerPayment = table.Column<double>(nullable: true),
                    PeerPaymentApproved = table.Column<bool>(nullable: false),
                    VerificationSheet = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignment_Consumer_Consumer_Id",
                        column: x => x.Consumer_Id,
                        principalTable: "Consumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_Interviewer_Interviewer_Id_Peer",
                        column: x => x.Interviewer_Id_Peer,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DateConflict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(maxLength: 1000, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateConflict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateConflict_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeviceDeployment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Device_Id = table.Column<int>(nullable: false),
                    Interviewer_Id = table.Column<int>(nullable: true),
                    User_Id = table.Column<int>(nullable: true),
                    Comment = table.Column<string>(maxLength: 1000, nullable: true),
                    DateIssue = table.Column<DateTime>(type: "date", nullable: false),
                    DateReturn = table.Column<DateTime>(type: "date", nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDeployment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceDeployment_Device_Device_Id",
                        column: x => x.Device_Id,
                        principalTable: "Device",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeviceDeployment_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeviceDeployment_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interviewer_Language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    Language_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewer_Language", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviewer_Language_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interviewer_Language_Language_Language_Id",
                        column: x => x.Language_Id,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InterviewerNote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    InterviewerNoteTheme_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 1000, nullable: false),
                    Retain = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewerNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewerNote_InterviewerNoteTheme_InterviewerNoteTheme_Id",
                        column: x => x.InterviewerNoteTheme_Id,
                        principalTable: "InterviewerNoteTheme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterviewerNote_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterviewerNote_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StatusLogNCI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consumer_Id = table.Column<int>(nullable: false),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    RefusalReasonNCI_Id = table.Column<int>(nullable: false),
                    ResultCategoryNCI_Id = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Exclude = table.Column<bool>(nullable: false),
                    InterviewNumber = table.Column<string>(maxLength: 8, nullable: true),
                    InterviewTime = table.Column<string>(maxLength: 5, nullable: true),
                    LastResult = table.Column<bool>(nullable: false),
                    RefusalReasonOther = table.Column<string>(maxLength: 100, nullable: true),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLogNCI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusLogNCI_Consumer_Consumer_Id",
                        column: x => x.Consumer_Id,
                        principalTable: "Consumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusLogNCI_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusLogNCI_RefusalReasonNCI_RefusalReasonNCI_Id",
                        column: x => x.RefusalReasonNCI_Id,
                        principalTable: "RefusalReasonNCI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusLogNCI_ResultCategoryNCI_ResultCategoryNCI_Id",
                        column: x => x.ResultCategoryNCI_Id,
                        principalTable: "ResultCategoryNCI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project_Language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language_Id = table.Column<int>(nullable: false),
                    Project_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_Language", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Language_Language_Language_Id",
                        column: x => x.Language_Id,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Language_Project_Project_Id",
                        column: x => x.Project_Id,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project_User_UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    UserRole_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_User_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_User_UserRole_Project_Project_Id",
                        column: x => x.Project_Id,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_User_UserRole_UserRole_UserRole_Id",
                        column: x => x.UserRole_Id,
                        principalTable: "UserRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_User_UserRole_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectNCI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotifyingParty_Id = table.Column<int>(nullable: true),
                    Project_Id = table.Column<int>(nullable: false),
                    SelfDirectedSupports = table.Column<bool>(nullable: false),
                    StateSpecificQuestions = table.Column<bool>(nullable: false),
                    WrittenConsent = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectNCI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectNCI_NotifyingParty_NotifyingParty_Id",
                        column: x => x.NotifyingParty_Id,
                        principalTable: "NotifyingParty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectNCI_Project_Project_Id",
                        column: x => x.Project_Id,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectQOL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_Id = table.Column<int>(nullable: false),
                    FamilyData = table.Column<bool>(nullable: false),
                    LinkedFacilities = table.Column<bool>(nullable: false),
                    ShortTerm = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectQOL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_Project_Project_Id",
                        column: x => x.Project_Id,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilityContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facility_Id = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Administrator = table.Column<bool>(nullable: false),
                    CensusCoordinator = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneExtension = table.Column<string>(maxLength: 10, nullable: true),
                    PrimaryContact = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilityContact_Facility_Facility_Id",
                        column: x => x.Facility_Id,
                        principalTable: "Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilityNote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facility_Id = table.Column<int>(nullable: false),
                    FacilityNoteTheme_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 1000, nullable: false),
                    Retain = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilityNote_FacilityNoteTheme_FacilityNoteTheme_Id",
                        column: x => x.FacilityNoteTheme_Id,
                        principalTable: "FacilityNoteTheme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilityNote_Facility_Facility_Id",
                        column: x => x.Facility_Id,
                        principalTable: "Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilityNote_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sample",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectNCI_Id = table.Column<int>(nullable: false),
                    DateStatusLog = table.Column<DateTime>(nullable: true),
                    DateSurvey = table.Column<DateTime>(nullable: true),
                    DateVerification = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sample_ProjectNCI_ProjectNCI_Id",
                        column: x => x.ProjectNCI_Id,
                        principalTable: "ProjectNCI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PSARegion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectQOL_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSARegion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSARegion_ProjectQOL_ProjectQOL_Id",
                        column: x => x.ProjectQOL_Id,
                        principalTable: "ProjectQOL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RepresentativeSurveyBatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectQOL_Id = table.Column<int>(nullable: false),
                    DateMailDoNotCallList = table.Column<DateTime>(type: "date", nullable: false),
                    DateMailPhoneList = table.Column<DateTime>(type: "date", nullable: false),
                    DateMailPostcardList = table.Column<DateTime>(type: "date", nullable: false),
                    DateMailSurveyList = table.Column<DateTime>(type: "date", nullable: false),
                    Number = table.Column<string>(maxLength: 1, nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentativeSurveyBatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepresentativeSurveyBatch_ProjectQOL_ProjectQOL_Id",
                        column: x => x.ProjectQOL_Id,
                        principalTable: "ProjectQOL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleRateRepresentative",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectQOL_Id = table.Column<int>(nullable: false),
                    SampleCount = table.Column<int>(nullable: false),
                    SurveyGoal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleRateRepresentative", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleRateRepresentative_ProjectQOL_ProjectQOL_Id",
                        column: x => x.ProjectQOL_Id,
                        principalTable: "ProjectQOL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SampleRateResident",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectQOL_Id = table.Column<int>(nullable: false),
                    SampleCount = table.Column<int>(nullable: false),
                    SurveyGoal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleRateResident", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleRateResident_ProjectQOL_ProjectQOL_Id",
                        column: x => x.ProjectQOL_Id,
                        principalTable: "ProjectQOL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incentive",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incentive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incentive_Sample_Sample_Id",
                        column: x => x.Sample_Id,
                        principalTable: "Sample",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PayRate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sample_Id = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    MilesMaximum = table.Column<int>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayRate_Sample_Sample_Id",
                        column: x => x.Sample_Id,
                        principalTable: "Sample",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sample_ResultCategoryNCI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultCategoryNCI_Id = table.Column<int>(nullable: false),
                    Sample_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample_ResultCategoryNCI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sample_ResultCategoryNCI_ResultCategoryNCI_ResultCategoryNCI_Id",
                        column: x => x.ResultCategoryNCI_Id,
                        principalTable: "ResultCategoryNCI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sample_ResultCategoryNCI_Sample_Sample_Id",
                        column: x => x.Sample_Id,
                        principalTable: "Sample",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PSA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PSARegion_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSA_PSARegion_PSARegion_Id",
                        column: x => x.PSARegion_Id,
                        principalTable: "PSARegion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project_Interviewer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    Interviewer_Id_Peer = table.Column<int>(nullable: true),
                    Interviewer_Id_QAM = table.Column<int>(nullable: true),
                    Project_Id = table.Column<int>(nullable: false),
                    PSA_Id = table.Column<int>(nullable: true),
                    Recommendation_Id = table.Column<int>(nullable: true),
                    SeparationReason_Id = table.Column<int>(nullable: true),
                    DateBegin = table.Column<DateTime>(type: "date", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "date", nullable: true),
                    DateMaterialsIssue = table.Column<DateTime>(type: "date", nullable: true),
                    DateMaterialsReturn = table.Column<DateTime>(type: "date", nullable: true),
                    MaterialsCallSheet = table.Column<bool>(nullable: false),
                    MaterialsClipboard = table.Column<bool>(nullable: false),
                    MaterialsConsentForm = table.Column<bool>(nullable: false),
                    MaterialsHearingAmplifier = table.Column<bool>(nullable: false),
                    MaterialsLaminate = table.Column<bool>(nullable: false),
                    MaterialsLockBox = table.Column<bool>(nullable: false),
                    MaterialsNameTag = table.Column<bool>(nullable: false),
                    MaterialsReferenceManual = table.Column<bool>(nullable: false),
                    MaterialsTablet = table.Column<bool>(nullable: false),
                    MaterialsTabletAccessories = table.Column<bool>(nullable: false),
                    QAM = table.Column<bool>(nullable: false),
                    Trainer = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_Interviewer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Interviewer_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Interviewer_Interviewer_Interviewer_Id_Peer",
                        column: x => x.Interviewer_Id_Peer,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Interviewer_Interviewer_Interviewer_Id_QAM",
                        column: x => x.Interviewer_Id_QAM,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Interviewer_PSA_PSA_Id",
                        column: x => x.PSA_Id,
                        principalTable: "PSA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Interviewer_Project_Project_Id",
                        column: x => x.Project_Id,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Interviewer_Recommendation_Recommendation_Id",
                        column: x => x.Recommendation_Id,
                        principalTable: "Recommendation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Interviewer_SeparationReason_SeparationReason_Id",
                        column: x => x.SeparationReason_Id,
                        principalTable: "SeparationReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectQOL_Facility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentFormat_Id_Representative = table.Column<int>(nullable: false),
                    DocumentFormat_Id_Resident = table.Column<int>(nullable: false),
                    Facility_Id = table.Column<int>(nullable: false),
                    ProjectQOL_Id = table.Column<int>(nullable: false),
                    PSA_Id = table.Column<int>(nullable: false),
                    RepresentativeListStatus_Id = table.Column<int>(nullable: false),
                    ReturnVisitReason_Id = table.Column<int>(nullable: false),
                    DateContact = table.Column<DateTime>(type: "date", nullable: true),
                    DateEmailCensus = table.Column<DateTime>(type: "date", nullable: true),
                    DateEmailConfirmation = table.Column<DateTime>(type: "date", nullable: true),
                    DateEmailFollowUp = table.Column<DateTime>(type: "date", nullable: true),
                    DateEmailReminder = table.Column<DateTime>(type: "date", nullable: true),
                    DateImportRepresentativeList = table.Column<DateTime>(type: "date", nullable: true),
                    DateImportResidentList = table.Column<DateTime>(type: "date", nullable: true),
                    DateNonCompliant = table.Column<DateTime>(type: "date", nullable: true),
                    DateReceiveRepresentativeList = table.Column<DateTime>(type: "date", nullable: true),
                    DateReceiveResidentList = table.Column<DateTime>(type: "date", nullable: true),
                    DoNotSchedule = table.Column<bool>(nullable: false),
                    NoBackupList = table.Column<bool>(nullable: false),
                    NonCompliant = table.Column<bool>(nullable: false),
                    NonCompliantComment = table.Column<string>(maxLength: 1000, nullable: true),
                    Reminder = table.Column<bool>(nullable: false),
                    RepresentativeListNote = table.Column<string>(maxLength: 1000, nullable: true),
                    ResidentCountEligibleEstimate = table.Column<int>(nullable: true),
                    ResidentCountEligibleLongTerm = table.Column<int>(nullable: true),
                    ResidentCountEligibleShortTerm = table.Column<int>(nullable: true),
                    ResidentCountGuardianRefusal = table.Column<int>(nullable: true),
                    ResidentCountIsolation = table.Column<int>(nullable: true),
                    ResidentCountLongTerm = table.Column<int>(nullable: true),
                    ResidentCountPreliminary = table.Column<int>(nullable: true),
                    ResidentCountResidentList = table.Column<int>(nullable: true),
                    ResidentCountResidentListBackup = table.Column<int>(nullable: true),
                    ResidentCountShortTerm = table.Column<int>(nullable: true),
                    ResidentListComplete = table.Column<bool>(nullable: false),
                    ResidentListReturnVisitComplete = table.Column<bool>(nullable: false),
                    ResidentListNote = table.Column<string>(maxLength: 1000, nullable: true),
                    ResidentSurveyCountActual = table.Column<int>(nullable: true),
                    ResidentSurveyCountActualLongTerm = table.Column<int>(nullable: true),
                    ResidentSurveyCountActualPrevious = table.Column<int>(nullable: true),
                    ResidentSurveyCountActualReportedLongTerm = table.Column<int>(nullable: true),
                    ResidentSurveyCountActualReportedShortTerm = table.Column<int>(nullable: true),
                    ResidentSurveyCountActualShortTerm = table.Column<int>(nullable: true),
                    ResidentSurveyCountGoalEstimate = table.Column<int>(nullable: true),
                    ResidentSurveyCountGoalLongTerm = table.Column<int>(nullable: true),
                    ResidentSurveyCountGoalReturnVisit = table.Column<int>(nullable: true),
                    ResidentSurveyCountGoalShortTerm = table.Column<int>(nullable: true),
                    ReturnVisitNote = table.Column<string>(nullable: true),
                    ReturnVisitRequired = table.Column<bool>(nullable: false),
                    ScheduleNote = table.Column<string>(maxLength: 1000, nullable: true),
                    TestFacility = table.Column<bool>(nullable: false),
                    TrainingFacility = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectQOL_Facility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_Facility_DocumentFormat_DocumentFormat_Id_Representative",
                        column: x => x.DocumentFormat_Id_Representative,
                        principalTable: "DocumentFormat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_Facility_DocumentFormat_DocumentFormat_Id_Resident",
                        column: x => x.DocumentFormat_Id_Resident,
                        principalTable: "DocumentFormat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_Facility_Facility_Facility_Id",
                        column: x => x.Facility_Id,
                        principalTable: "Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_Facility_PSA_PSA_Id",
                        column: x => x.PSA_Id,
                        principalTable: "PSA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_Facility_ProjectQOL_ProjectQOL_Id",
                        column: x => x.ProjectQOL_Id,
                        principalTable: "ProjectQOL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_Facility_RepresentativeListStatus_RepresentativeListStatus_Id",
                        column: x => x.RepresentativeListStatus_Id,
                        principalTable: "RepresentativeListStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_Facility_ReturnVisitReason_ReturnVisitReason_Id",
                        column: x => x.ReturnVisitReason_Id,
                        principalTable: "ReturnVisitReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Census",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    RepresentativeSurveyBatch_Id = table.Column<int>(nullable: false),
                    RepresentativeSurveyMethod_Id = table.Column<int>(nullable: false),
                    State_Id_Representative = table.Column<int>(nullable: false),
                    AssistedLivingMedicaidWaiver = table.Column<bool>(nullable: false),
                    Ineligible = table.Column<bool>(nullable: false),
                    Invalid = table.Column<bool>(nullable: false),
                    RepresentativeAddress = table.Column<string>(maxLength: 100, nullable: true),
                    RepresentativeBlankSurvey = table.Column<bool>(nullable: false),
                    RepresentativeCity = table.Column<string>(maxLength: 100, nullable: true),
                    RepresentativeEmail = table.Column<string>(maxLength: 100, nullable: true),
                    RepresentativeNameFirst = table.Column<string>(maxLength: 100, nullable: true),
                    RepresentativeNameLast = table.Column<string>(maxLength: 100, nullable: true),
                    RepresentativePhone = table.Column<string>(maxLength: 15, nullable: true),
                    RepresentativeRefusal = table.Column<bool>(nullable: false),
                    RepresentativeSurveyDateImport = table.Column<DateTime>(nullable: false),
                    RepresentativeUninvolved = table.Column<bool>(nullable: false),
                    RepresentativeZipCode = table.Column<string>(maxLength: 15, nullable: true),
                    ResidentDateOfBirth = table.Column<DateTime>(nullable: false),
                    ResidentNameFirst = table.Column<string>(maxLength: 100, nullable: true),
                    ResidentNameLast = table.Column<string>(maxLength: 100, nullable: true),
                    RID = table.Column<string>(maxLength: 3, nullable: true),
                    RoomNumber = table.Column<string>(maxLength: 100, nullable: true),
                    RoomOrder = table.Column<int>(nullable: false),
                    ShortTerm = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Census", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Census_ProjectQOL_Facility_ProjectQOL_Facility_Id",
                        column: x => x.ProjectQOL_Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Census_RepresentativeSurveyBatch_RepresentativeSurveyBatch_Id",
                        column: x => x.RepresentativeSurveyBatch_Id,
                        principalTable: "RepresentativeSurveyBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Census_RepresentativeSurveyMethod_RepresentativeSurveyMethod_Id",
                        column: x => x.RepresentativeSurveyMethod_Id,
                        principalTable: "RepresentativeSurveyMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Census_State_State_Id_Representative",
                        column: x => x.State_Id_Representative,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilityConflict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(maxLength: 1000, nullable: true),
                    Facility_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityConflict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilityConflict_ProjectQOL_Facility_Facility_Id",
                        column: x => x.Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilityConflict_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilityDistance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    Miles = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityDistance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilityDistance_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilityDistance_ProjectQOL_Facility_ProjectQOL_Facility_Id",
                        column: x => x.ProjectQOL_Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InterviewerConflict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id_A = table.Column<int>(nullable: false),
                    Interviewer_Id_B = table.Column<int>(nullable: false),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewerConflict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewerConflict_Interviewer_Interviewer_Id_A",
                        column: x => x.Interviewer_Id_A,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterviewerConflict_Interviewer_Interviewer_Id_B",
                        column: x => x.Interviewer_Id_B,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterviewerConflict_ProjectQOL_Facility_ProjectQOL_Facility_Id",
                        column: x => x.ProjectQOL_Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotInterviewedQOL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    ResultCodeQOLNotInterviewed_Id = table.Column<int>(nullable: false),
                    Exclude = table.Column<bool>(nullable: false),
                    InterviewNumber = table.Column<string>(maxLength: 8, nullable: true),
                    RID = table.Column<string>(maxLength: 3, nullable: true),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true),
                    NotInterviewedCode_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotInterviewedQOL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotInterviewedQOL_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotInterviewedQOL_ResultCodeQOLNotInterviewed_NotInterviewedCode_Id",
                        column: x => x.NotInterviewedCode_Id,
                        principalTable: "ResultCodeQOLNotInterviewed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotInterviewedQOL_ProjectQOL_Facility_ProjectQOL_Facility_Id",
                        column: x => x.ProjectQOL_Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectQOL_FacilityLink",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectQOL_Facility_Id_A = table.Column<int>(nullable: false),
                    ProjectQOL_Facility_Id_B = table.Column<int>(nullable: false),
                    CoSchedule = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectQOL_FacilityLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_FacilityLink_ProjectQOL_Facility_ProjectQOL_Facility_Id_A",
                        column: x => x.ProjectQOL_Facility_Id_A,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_FacilityLink_ProjectQOL_Facility_ProjectQOL_Facility_Id_B",
                        column: x => x.ProjectQOL_Facility_Id_B,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectQOL_FacilityReschedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    RescheduleReason_Id = table.Column<int>(nullable: false),
                    DateScheduleOriginal = table.Column<DateTime>(type: "date", nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectQOL_FacilityReschedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_FacilityReschedule_ProjectQOL_Facility_ProjectQOL_Facility_Id",
                        column: x => x.ProjectQOL_Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_FacilityReschedule_RescheduleReason_RescheduleReason_Id",
                        column: x => x.RescheduleReason_Id,
                        principalTable: "RescheduleReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectQOL_FacilitySchedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    VisitCode_Id = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectQOL_FacilitySchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_FacilitySchedule_ProjectQOL_Facility_ProjectQOL_Facility_Id",
                        column: x => x.ProjectQOL_Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_FacilitySchedule_VisitCode_VisitCode_Id",
                        column: x => x.VisitCode_Id,
                        principalTable: "VisitCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestartQOL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncompleteCode_Id = table.Column<int>(nullable: false),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    AdmitDay = table.Column<string>(maxLength: 2, nullable: true),
                    AdmitMonth = table.Column<string>(maxLength: 2, nullable: true),
                    AdmitYear = table.Column<string>(maxLength: 4, nullable: true),
                    Assisted = table.Column<string>(maxLength: 1, nullable: true),
                    AssistedBy = table.Column<string>(maxLength: 1, nullable: true),
                    Completed = table.Column<bool>(nullable: false),
                    Consent = table.Column<string>(maxLength: 1, nullable: true),
                    Exclude = table.Column<bool>(nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: true),
                    Initials = table.Column<string>(maxLength: 2, nullable: true),
                    InterviewNumber = table.Column<string>(maxLength: 8, nullable: true),
                    InterviewTime = table.Column<string>(maxLength: 5, nullable: true),
                    Questions = table.Column<string>(maxLength: 100, nullable: true),
                    RID = table.Column<string>(maxLength: 3, nullable: true),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TooManyNA = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true),
                    ResultCodeQOLIncomplete_Id = table.Column<int>(nullable: true),
                    ResultCodeQOLNotInterviewedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestartQOL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestartQOL_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestartQOL_ProjectQOL_Facility_ProjectQOL_Facility_Id",
                        column: x => x.ProjectQOL_Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestartQOL_ResultCodeQOLIncomplete_ResultCodeQOLIncomplete_Id",
                        column: x => x.ResultCodeQOLIncomplete_Id,
                        principalTable: "ResultCodeQOLIncomplete",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestartQOL_ResultCodeQOLNotInterviewed_ResultCodeQOLNotInterviewedId",
                        column: x => x.ResultCodeQOLNotInterviewedId,
                        principalTable: "ResultCodeQOLNotInterviewed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQOL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    ProjectQOL_Facility_Id = table.Column<int>(nullable: false),
                    ResultCodeQOLIncomplete_Id = table.Column<int>(nullable: false),
                    AdmitDay = table.Column<string>(maxLength: 2, nullable: true),
                    AdmitMonth = table.Column<string>(maxLength: 2, nullable: true),
                    AdmitYear = table.Column<string>(maxLength: 4, nullable: true),
                    Assisted = table.Column<string>(maxLength: 1, nullable: true),
                    AssistedBy = table.Column<string>(maxLength: 1, nullable: true),
                    Completed = table.Column<bool>(nullable: false),
                    Consent = table.Column<string>(maxLength: 1, nullable: true),
                    DateStart = table.Column<DateTime>(type: "date", nullable: false),
                    Exclude = table.Column<bool>(nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: true),
                    Initials = table.Column<string>(maxLength: 2, nullable: true),
                    InterviewNumber = table.Column<string>(maxLength: 8, nullable: true),
                    InterviewTime = table.Column<string>(maxLength: 5, nullable: true),
                    Questions = table.Column<string>(maxLength: 100, nullable: true),
                    RID = table.Column<string>(maxLength: 3, nullable: true),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TooManyNA = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    SourceCreate = table.Column<string>(maxLength: 200, nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(maxLength: 200, nullable: true),
                    IncompleteCode_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQOL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyQOL_ResultCodeQOLIncomplete_IncompleteCode_Id",
                        column: x => x.IncompleteCode_Id,
                        principalTable: "ResultCodeQOLIncomplete",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQOL_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQOL_ProjectQOL_Facility_ProjectQOL_Facility_Id",
                        column: x => x.ProjectQOL_Facility_Id,
                        principalTable: "ProjectQOL_Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectQOL_FacilitySchedule_Interviewer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer_Id = table.Column<int>(nullable: false),
                    ProjectQOL_FacilitySchedule_Id = table.Column<int>(nullable: false),
                    FacilityOrganizer = table.Column<bool>(nullable: false),
                    QAM = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    SourceCreate = table.Column<string>(nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true),
                    SourceModify = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectQOL_FacilitySchedule_Interviewer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_FacilitySchedule_Interviewer_Interviewer_Interviewer_Id",
                        column: x => x.Interviewer_Id,
                        principalTable: "Interviewer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectQOL_FacilitySchedule_Interviewer_ProjectQOL_FacilitySchedule_ProjectQOL_FacilitySchedule_Id",
                        column: x => x.ProjectQOL_FacilitySchedule_Id,
                        principalTable: "ProjectQOL_FacilitySchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Consumer_Id",
                table: "Assignment",
                column: "Consumer_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Interviewer_Id",
                table: "Assignment",
                column: "Interviewer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Interviewer_Id_Peer",
                table: "Assignment",
                column: "Interviewer_Id_Peer");

            migrationBuilder.CreateIndex(
                name: "IX_Census_ProjectQOL_Facility_Id",
                table: "Census",
                column: "ProjectQOL_Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Census_RepresentativeSurveyBatch_Id",
                table: "Census",
                column: "RepresentativeSurveyBatch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Census_RepresentativeSurveyMethod_Id",
                table: "Census",
                column: "RepresentativeSurveyMethod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Census_State_Id_Representative",
                table: "Census",
                column: "State_Id_Representative");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleAgeGroup_Id",
                table: "Consumer",
                column: "SampleAgeGroup_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleAgency_Id",
                table: "Consumer",
                column: "SampleAgency_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleCCO_Id",
                table: "Consumer",
                column: "SampleCCO_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleEthnicity_Id",
                table: "Consumer",
                column: "SampleEthnicity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleGender_Id",
                table: "Consumer",
                column: "SampleGender_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleGeography_Id",
                table: "Consumer",
                column: "SampleGeography_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleHomeSetting_Id",
                table: "Consumer",
                column: "SampleHomeSetting_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleLanguage_Id",
                table: "Consumer",
                column: "SampleLanguage_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleProgram_Id",
                table: "Consumer",
                column: "SampleProgram_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_SampleRace_Id",
                table: "Consumer",
                column: "SampleRace_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_State_Id_Mailing",
                table: "Consumer",
                column: "State_Id_Mailing");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_State_Id_Physical",
                table: "Consumer",
                column: "State_Id_Physical");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_VRID",
                table: "Consumer",
                column: "VRID");

            migrationBuilder.CreateIndex(
                name: "IX_Consumer_Sample_Id_VRID",
                table: "Consumer",
                columns: new[] { "Sample_Id", "VRID" },
                unique: true,
                filter: "[VRID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerContact_Consumer_Id",
                table: "ConsumerContact",
                column: "Consumer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerContact_State_Id",
                table: "ConsumerContact",
                column: "State_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerGuardian_Consumer_Id",
                table: "ConsumerGuardian",
                column: "Consumer_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerGuardian_State_Id",
                table: "ConsumerGuardian",
                column: "State_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerNote_Consumer_Id",
                table: "ConsumerNote",
                column: "Consumer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerNote_User_Id",
                table: "ConsumerNote",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_County_State_Id",
                table: "County",
                column: "State_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DateConflict_Interviewer_Id_Date",
                table: "DateConflict",
                columns: new[] { "Interviewer_Id", "Date" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Device_DeviceModel_Id",
                table: "Device",
                column: "DeviceModel_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Device_DeviceNfieldVersion_Id",
                table: "Device",
                column: "DeviceNfieldVersion_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Device_DeviceOS_Id",
                table: "Device",
                column: "DeviceOS_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Device_VRID",
                table: "Device",
                column: "VRID",
                unique: true,
                filter: "[VRID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceDeployment_Device_Id",
                table: "DeviceDeployment",
                column: "Device_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceDeployment_Interviewer_Id",
                table: "DeviceDeployment",
                column: "Interviewer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceDeployment_User_Id",
                table: "DeviceDeployment",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceModel_Name",
                table: "DeviceModel",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceNfieldVersion_Name",
                table: "DeviceNfieldVersion",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceNote_Device_Id",
                table: "DeviceNote",
                column: "Device_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceNote_User_Id",
                table: "DeviceNote",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceOS_Name",
                table: "DeviceOS",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFormat_Name",
                table: "DocumentFormat",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facility_County_Id",
                table: "Facility",
                column: "County_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_FID",
                table: "Facility",
                column: "FID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facility_Name",
                table: "Facility",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacilityConflict_Facility_Id",
                table: "FacilityConflict",
                column: "Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityConflict_Interviewer_Id_ProjectQOL_Facility_Id",
                table: "FacilityConflict",
                columns: new[] { "Interviewer_Id", "ProjectQOL_Facility_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacilityContact_Facility_Id_Name",
                table: "FacilityContact",
                columns: new[] { "Facility_Id", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacilityDistance_ProjectQOL_Facility_Id",
                table: "FacilityDistance",
                column: "ProjectQOL_Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityDistance_Interviewer_Id_ProjectQOL_Facility_Id",
                table: "FacilityDistance",
                columns: new[] { "Interviewer_Id", "ProjectQOL_Facility_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacilityNote_FacilityNoteTheme_Id",
                table: "FacilityNote",
                column: "FacilityNoteTheme_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityNote_Facility_Id",
                table: "FacilityNote",
                column: "Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityNote_User_Id",
                table: "FacilityNote",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityNoteTheme_Definition",
                table: "FacilityNoteTheme",
                column: "Definition",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacilityNoteTheme_Name",
                table: "FacilityNoteTheme",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Incentive_Sample_Id_Amount",
                table: "Incentive",
                columns: new[] { "Sample_Id", "Amount" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interviewer_Recommendation_Id",
                table: "Interviewer",
                column: "Recommendation_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interviewer_State_Id",
                table: "Interviewer",
                column: "State_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interviewer_Language_Language_Id",
                table: "Interviewer_Language",
                column: "Language_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interviewer_Language_Interviewer_Id_Language_Id",
                table: "Interviewer_Language",
                columns: new[] { "Interviewer_Id", "Language_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerConflict_Interviewer_Id_B",
                table: "InterviewerConflict",
                column: "Interviewer_Id_B");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerConflict_ProjectQOL_Facility_Id",
                table: "InterviewerConflict",
                column: "ProjectQOL_Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerConflict_Interviewer_Id_A_Interviewer_Id_B_ProjectQOL_Facility_Id",
                table: "InterviewerConflict",
                columns: new[] { "Interviewer_Id_A", "Interviewer_Id_B", "ProjectQOL_Facility_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerEmployer_Name",
                table: "InterviewerEmployer",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerNote_InterviewerNoteTheme_Id",
                table: "InterviewerNote",
                column: "InterviewerNoteTheme_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerNote_Interviewer_Id",
                table: "InterviewerNote",
                column: "Interviewer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerNote_User_Id",
                table: "InterviewerNote",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerNoteTheme_Definition",
                table: "InterviewerNoteTheme",
                column: "Definition",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InterviewerNoteTheme_Name",
                table: "InterviewerNoteTheme",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Language_Name",
                table: "Language",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotifyingParty_Name",
                table: "NotifyingParty",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotInterviewedQOL_Interviewer_Id",
                table: "NotInterviewedQOL",
                column: "Interviewer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_NotInterviewedQOL_NotInterviewedCode_Id",
                table: "NotInterviewedQOL",
                column: "NotInterviewedCode_Id");

            migrationBuilder.CreateIndex(
                name: "IX_NotInterviewedQOL_ProjectQOL_Facility_Id",
                table: "NotInterviewedQOL",
                column: "ProjectQOL_Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PayRate_Sample_Id_Amount",
                table: "PayRate",
                columns: new[] { "Sample_Id", "Amount" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayRate_Sample_Id_MilesMaximum",
                table: "PayRate",
                columns: new[] { "Sample_Id", "MilesMaximum" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_InterviewerEmployer_Id",
                table: "Project",
                column: "InterviewerEmployer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Name",
                table: "Project",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_State_Id",
                table: "Project",
                column: "State_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Interviewer_Interviewer_Id_Peer",
                table: "Project_Interviewer",
                column: "Interviewer_Id_Peer");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Interviewer_Interviewer_Id_QAM",
                table: "Project_Interviewer",
                column: "Interviewer_Id_QAM");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Interviewer_PSA_Id",
                table: "Project_Interviewer",
                column: "PSA_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Interviewer_Project_Id",
                table: "Project_Interviewer",
                column: "Project_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Interviewer_Recommendation_Id",
                table: "Project_Interviewer",
                column: "Recommendation_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Interviewer_SeparationReason_Id",
                table: "Project_Interviewer",
                column: "SeparationReason_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Interviewer_Interviewer_Id_Project_Id",
                table: "Project_Interviewer",
                columns: new[] { "Interviewer_Id", "Project_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_Language_Language_Id",
                table: "Project_Language",
                column: "Language_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Language_Project_Id_Language_Id",
                table: "Project_Language",
                columns: new[] { "Project_Id", "Language_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_User_UserRole_UserRole_Id",
                table: "Project_User_UserRole",
                column: "UserRole_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_User_UserRole_User_Id",
                table: "Project_User_UserRole",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_User_UserRole_Project_Id_User_Id",
                table: "Project_User_UserRole",
                columns: new[] { "Project_Id", "User_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNCI_NotifyingParty_Id",
                table: "ProjectNCI",
                column: "NotifyingParty_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNCI_Project_Id",
                table: "ProjectNCI",
                column: "Project_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_Project_Id",
                table: "ProjectQOL",
                column: "Project_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_Facility_DocumentFormat_Id_Representative",
                table: "ProjectQOL_Facility",
                column: "DocumentFormat_Id_Representative");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_Facility_DocumentFormat_Id_Resident",
                table: "ProjectQOL_Facility",
                column: "DocumentFormat_Id_Resident");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_Facility_Facility_Id",
                table: "ProjectQOL_Facility",
                column: "Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_Facility_PSA_Id",
                table: "ProjectQOL_Facility",
                column: "PSA_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_Facility_ProjectQOL_Id",
                table: "ProjectQOL_Facility",
                column: "ProjectQOL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_Facility_RepresentativeListStatus_Id",
                table: "ProjectQOL_Facility",
                column: "RepresentativeListStatus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_Facility_ReturnVisitReason_Id",
                table: "ProjectQOL_Facility",
                column: "ReturnVisitReason_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_FacilityLink_ProjectQOL_Facility_Id_B",
                table: "ProjectQOL_FacilityLink",
                column: "ProjectQOL_Facility_Id_B");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_FacilityLink_ProjectQOL_Facility_Id_A_ProjectQOL_Facility_Id_B",
                table: "ProjectQOL_FacilityLink",
                columns: new[] { "ProjectQOL_Facility_Id_A", "ProjectQOL_Facility_Id_B" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_FacilityReschedule_RescheduleReason_Id",
                table: "ProjectQOL_FacilityReschedule",
                column: "RescheduleReason_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_FacilityReschedule_ProjectQOL_Facility_Id_DateScheduleOriginal",
                table: "ProjectQOL_FacilityReschedule",
                columns: new[] { "ProjectQOL_Facility_Id", "DateScheduleOriginal" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_FacilitySchedule_VisitCode_Id",
                table: "ProjectQOL_FacilitySchedule",
                column: "VisitCode_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_FacilitySchedule_ProjectQOL_Facility_Id_VisitCode_Id",
                table: "ProjectQOL_FacilitySchedule",
                columns: new[] { "ProjectQOL_Facility_Id", "VisitCode_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_FacilitySchedule_Interviewer_Interviewer_Id",
                table: "ProjectQOL_FacilitySchedule_Interviewer",
                column: "Interviewer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectQOL_FacilitySchedule_Interviewer_ProjectQOL_FacilitySchedule_Id_Interviewer_Id",
                table: "ProjectQOL_FacilitySchedule_Interviewer",
                columns: new[] { "ProjectQOL_FacilitySchedule_Id", "Interviewer_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PSA_PSARegion_Id_Name",
                table: "PSA",
                columns: new[] { "PSARegion_Id", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PSARegion_ProjectQOL_Id_Name",
                table: "PSARegion",
                columns: new[] { "ProjectQOL_Id", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recommendation_Name",
                table: "Recommendation",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefusalReasonNCI_Code",
                table: "RefusalReasonNCI",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefusalReasonNCI_Name",
                table: "RefusalReasonNCI",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepresentativeListStatus_Name",
                table: "RepresentativeListStatus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepresentativeSurveyBatch_ProjectQOL_Id_Number",
                table: "RepresentativeSurveyBatch",
                columns: new[] { "ProjectQOL_Id", "Number" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepresentativeSurveyMethod_Name",
                table: "RepresentativeSurveyMethod",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RescheduleReason_Name",
                table: "RescheduleReason",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestartQOL_Interviewer_Id",
                table: "RestartQOL",
                column: "Interviewer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RestartQOL_ProjectQOL_Facility_Id",
                table: "RestartQOL",
                column: "ProjectQOL_Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RestartQOL_ResultCodeQOLIncomplete_Id",
                table: "RestartQOL",
                column: "ResultCodeQOLIncomplete_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RestartQOL_ResultCodeQOLNotInterviewedId",
                table: "RestartQOL",
                column: "ResultCodeQOLNotInterviewedId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultCategoryNCI_Name",
                table: "ResultCategoryNCI",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultCodeQOLIncomplete_Definition",
                table: "ResultCodeQOLIncomplete",
                column: "Definition",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultCodeQOLIncomplete_Number",
                table: "ResultCodeQOLIncomplete",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultCodeQOLNotInterviewed_Definition",
                table: "ResultCodeQOLNotInterviewed",
                column: "Definition",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultCodeQOLNotInterviewed_Number",
                table: "ResultCodeQOLNotInterviewed",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultNCI_Name",
                table: "ResultNCI",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultNCI_ResultCategoryNCI_Id",
                table: "ResultNCI",
                column: "ResultCategoryNCI_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnVisitReason_Name",
                table: "ReturnVisitReason",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sample_ProjectNCI_Id_Name",
                table: "Sample",
                columns: new[] { "ProjectNCI_Id", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sample_ResultCategoryNCI_ResultCategoryNCI_Id",
                table: "Sample_ResultCategoryNCI",
                column: "ResultCategoryNCI_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sample_ResultCategoryNCI_Sample_Id_ResultCategoryNCI_Id",
                table: "Sample_ResultCategoryNCI",
                columns: new[] { "Sample_Id", "ResultCategoryNCI_Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleAgeGroup_Name",
                table: "SampleAgeGroup",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleAgeGroup_Sample_Id",
                table: "SampleAgeGroup",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleAgeGroupMap_SampleAgeGroup_Id_Original",
                table: "SampleAgeGroupMap",
                column: "SampleAgeGroup_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleAgeGroupMap_SampleAgeGroup_Id_Standardized",
                table: "SampleAgeGroupMap",
                column: "SampleAgeGroup_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleAgency_Name",
                table: "SampleAgency",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleAgency_Sample_Id",
                table: "SampleAgency",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleAgencyMap_SampleAgency_Id_Original",
                table: "SampleAgencyMap",
                column: "SampleAgency_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleAgencyMap_SampleAgency_Id_Standardized",
                table: "SampleAgencyMap",
                column: "SampleAgency_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleCCO_Name",
                table: "SampleCCO",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleCCO_Sample_Id",
                table: "SampleCCO",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleCCOMap_SampleCCO_Id_Original",
                table: "SampleCCOMap",
                column: "SampleCCO_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleCCOMap_SampleCCO_Id_Standardized",
                table: "SampleCCOMap",
                column: "SampleCCO_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleEthnicity_Name",
                table: "SampleEthnicity",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleEthnicity_Sample_Id",
                table: "SampleEthnicity",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleEthnicityMap_SampleEthnicity_Id_Original",
                table: "SampleEthnicityMap",
                column: "SampleEthnicity_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleEthnicityMap_SampleEthnicity_Id_Standardized",
                table: "SampleEthnicityMap",
                column: "SampleEthnicity_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleGender_Name",
                table: "SampleGender",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleGender_Sample_Id",
                table: "SampleGender",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleGenderMap_SampleGender_Id_Original",
                table: "SampleGenderMap",
                column: "SampleGender_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleGenderMap_SampleGender_Id_Standardized",
                table: "SampleGenderMap",
                column: "SampleGender_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleGeography_Name",
                table: "SampleGeography",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleGeography_Sample_Id",
                table: "SampleGeography",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleGeographyMap_SampleGeography_Id_Original",
                table: "SampleGeographyMap",
                column: "SampleGeography_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleGeographyMap_SampleGeography_Id_Standardized",
                table: "SampleGeographyMap",
                column: "SampleGeography_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleHomeSetting_Name",
                table: "SampleHomeSetting",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleHomeSetting_Sample_Id",
                table: "SampleHomeSetting",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleHomeSettingMap_SampleHomeSetting_Id_Original",
                table: "SampleHomeSettingMap",
                column: "SampleHomeSetting_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleHomeSettingMap_SampleHomeSetting_Id_Standardized",
                table: "SampleHomeSettingMap",
                column: "SampleHomeSetting_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleLanguage_Name",
                table: "SampleLanguage",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleLanguage_Sample_Id",
                table: "SampleLanguage",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleLanguageMap_SampleLanguage_Id_Original",
                table: "SampleLanguageMap",
                column: "SampleLanguage_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleLanguageMap_SampleLanguage_Id_Standardized",
                table: "SampleLanguageMap",
                column: "SampleLanguage_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleProgram_Name",
                table: "SampleProgram",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleProgram_Sample_Id",
                table: "SampleProgram",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleProgramMap_SampleProgram_Id_Original",
                table: "SampleProgramMap",
                column: "SampleProgram_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleProgramMap_SampleProgram_Id_Standardized",
                table: "SampleProgramMap",
                column: "SampleProgram_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleRace_Name",
                table: "SampleRace",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleRace_Sample_Id",
                table: "SampleRace",
                column: "Sample_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SampleRaceMap_SampleRace_Id_Original",
                table: "SampleRaceMap",
                column: "SampleRace_Id_Original",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleRaceMap_SampleRace_Id_Standardized",
                table: "SampleRaceMap",
                column: "SampleRace_Id_Standardized");

            migrationBuilder.CreateIndex(
                name: "IX_SampleRateRepresentative_ProjectQOL_Id_SampleCount",
                table: "SampleRateRepresentative",
                columns: new[] { "ProjectQOL_Id", "SampleCount" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleRateResident_ProjectQOL_Id_SampleCount",
                table: "SampleRateResident",
                columns: new[] { "ProjectQOL_Id", "SampleCount" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeparationReason_Name",
                table: "SeparationReason",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_State_Name",
                table: "State",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatusLogNCI_Consumer_Id",
                table: "StatusLogNCI",
                column: "Consumer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_StatusLogNCI_Interviewer_Id",
                table: "StatusLogNCI",
                column: "Interviewer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_StatusLogNCI_RefusalReasonNCI_Id",
                table: "StatusLogNCI",
                column: "RefusalReasonNCI_Id");

            migrationBuilder.CreateIndex(
                name: "IX_StatusLogNCI_ResultCategoryNCI_Id",
                table: "StatusLogNCI",
                column: "ResultCategoryNCI_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQOL_IncompleteCode_Id",
                table: "SurveyQOL",
                column: "IncompleteCode_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQOL_Interviewer_Id",
                table: "SurveyQOL",
                column: "Interviewer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQOL_ProjectQOL_Facility_Id",
                table: "SurveyQOL",
                column: "ProjectQOL_Facility_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Initials",
                table: "User",
                column: "Initials",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Name",
                table: "User",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_WinUserId",
                table: "User",
                column: "WinUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_Name",
                table: "UserRole",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitCode_Name",
                table: "VisitCode",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Census");

            migrationBuilder.DropTable(
                name: "ConsumerContact");

            migrationBuilder.DropTable(
                name: "ConsumerGuardian");

            migrationBuilder.DropTable(
                name: "ConsumerNote");

            migrationBuilder.DropTable(
                name: "DateConflict");

            migrationBuilder.DropTable(
                name: "DeviceDeployment");

            migrationBuilder.DropTable(
                name: "DeviceNote");

            migrationBuilder.DropTable(
                name: "FacilityConflict");

            migrationBuilder.DropTable(
                name: "FacilityContact");

            migrationBuilder.DropTable(
                name: "FacilityDistance");

            migrationBuilder.DropTable(
                name: "FacilityNote");

            migrationBuilder.DropTable(
                name: "Incentive");

            migrationBuilder.DropTable(
                name: "Interviewer_Language");

            migrationBuilder.DropTable(
                name: "InterviewerConflict");

            migrationBuilder.DropTable(
                name: "InterviewerNote");

            migrationBuilder.DropTable(
                name: "NotInterviewedQOL");

            migrationBuilder.DropTable(
                name: "PayRate");

            migrationBuilder.DropTable(
                name: "Project_Interviewer");

            migrationBuilder.DropTable(
                name: "Project_Language");

            migrationBuilder.DropTable(
                name: "Project_User_UserRole");

            migrationBuilder.DropTable(
                name: "ProjectQOL_FacilityLink");

            migrationBuilder.DropTable(
                name: "ProjectQOL_FacilityReschedule");

            migrationBuilder.DropTable(
                name: "ProjectQOL_FacilitySchedule_Interviewer");

            migrationBuilder.DropTable(
                name: "RestartQOL");

            migrationBuilder.DropTable(
                name: "ResultNCI");

            migrationBuilder.DropTable(
                name: "Sample_ResultCategoryNCI");

            migrationBuilder.DropTable(
                name: "SampleAgeGroupMap");

            migrationBuilder.DropTable(
                name: "SampleAgencyMap");

            migrationBuilder.DropTable(
                name: "SampleCCOMap");

            migrationBuilder.DropTable(
                name: "SampleEthnicityMap");

            migrationBuilder.DropTable(
                name: "SampleGenderMap");

            migrationBuilder.DropTable(
                name: "SampleGeographyMap");

            migrationBuilder.DropTable(
                name: "SampleHomeSettingMap");

            migrationBuilder.DropTable(
                name: "SampleLanguageMap");

            migrationBuilder.DropTable(
                name: "SampleProgramMap");

            migrationBuilder.DropTable(
                name: "SampleRaceMap");

            migrationBuilder.DropTable(
                name: "SampleRateRepresentative");

            migrationBuilder.DropTable(
                name: "SampleRateResident");

            migrationBuilder.DropTable(
                name: "StatusLogNCI");

            migrationBuilder.DropTable(
                name: "SurveyQOL");

            migrationBuilder.DropTable(
                name: "RepresentativeSurveyBatch");

            migrationBuilder.DropTable(
                name: "RepresentativeSurveyMethod");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "FacilityNoteTheme");

            migrationBuilder.DropTable(
                name: "InterviewerNoteTheme");

            migrationBuilder.DropTable(
                name: "SeparationReason");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "RescheduleReason");

            migrationBuilder.DropTable(
                name: "ProjectQOL_FacilitySchedule");

            migrationBuilder.DropTable(
                name: "ResultCodeQOLNotInterviewed");

            migrationBuilder.DropTable(
                name: "Sample");

            migrationBuilder.DropTable(
                name: "Consumer");

            migrationBuilder.DropTable(
                name: "RefusalReasonNCI");

            migrationBuilder.DropTable(
                name: "ResultCategoryNCI");

            migrationBuilder.DropTable(
                name: "ResultCodeQOLIncomplete");

            migrationBuilder.DropTable(
                name: "Interviewer");

            migrationBuilder.DropTable(
                name: "DeviceModel");

            migrationBuilder.DropTable(
                name: "DeviceNfieldVersion");

            migrationBuilder.DropTable(
                name: "DeviceOS");

            migrationBuilder.DropTable(
                name: "ProjectQOL_Facility");

            migrationBuilder.DropTable(
                name: "VisitCode");

            migrationBuilder.DropTable(
                name: "ProjectNCI");

            migrationBuilder.DropTable(
                name: "SampleAgeGroup");

            migrationBuilder.DropTable(
                name: "SampleAgency");

            migrationBuilder.DropTable(
                name: "SampleCCO");

            migrationBuilder.DropTable(
                name: "SampleEthnicity");

            migrationBuilder.DropTable(
                name: "SampleGender");

            migrationBuilder.DropTable(
                name: "SampleGeography");

            migrationBuilder.DropTable(
                name: "SampleHomeSetting");

            migrationBuilder.DropTable(
                name: "SampleLanguage");

            migrationBuilder.DropTable(
                name: "SampleProgram");

            migrationBuilder.DropTable(
                name: "SampleRace");

            migrationBuilder.DropTable(
                name: "Recommendation");

            migrationBuilder.DropTable(
                name: "DocumentFormat");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "PSA");

            migrationBuilder.DropTable(
                name: "RepresentativeListStatus");

            migrationBuilder.DropTable(
                name: "ReturnVisitReason");

            migrationBuilder.DropTable(
                name: "NotifyingParty");

            migrationBuilder.DropTable(
                name: "County");

            migrationBuilder.DropTable(
                name: "PSARegion");

            migrationBuilder.DropTable(
                name: "ProjectQOL");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "InterviewerEmployer");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
