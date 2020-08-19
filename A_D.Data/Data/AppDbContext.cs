using A_D.Data.Configuration;
using A_D.Domain;
using A_D.Domain.Models;
using AD.Domain;
using Microsoft.EntityFrameworkCore;

namespace A_D.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<Census> Census { get; set; }
        public DbSet<Consumer> Consumer { get; set; }
        public DbSet<ConsumerContact> ConsumerContact { get; set; }
        public DbSet<ConsumerGuardian> ConsumerGuardian { get; set; }
        public DbSet<ConsumerNote> ConsumerNote { get; set; }
        public DbSet<County> County { get; set; }
        public DbSet<DateConflict> DateConflict { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<DeviceDeployment> DeviceDeployment { get; set; }
        public DbSet<DeviceModel> DeviceModel { get; set; }
        public DbSet<DeviceNfieldVersion> DeviceNfieldVersion { get; set; }
        public DbSet<DeviceNote> DeviceNote { get; set; }
        public DbSet<DeviceOS> DeviceOS { get; set; }
        public DbSet<DocumentFormat> DocumentFormat { get; set; }
        public DbSet<Facility> Facility { get; set; }
        public DbSet<FacilityConflict> FacilityConflict { get; set; }
        public DbSet<FacilityContact> FacilityContact { get; set; }
        public DbSet<FacilityDistance> FacilityDistance { get; set; }
        public DbSet<FacilityNote> FacilityNote { get; set; }
        public DbSet<FacilityNoteTheme> FacilityNoteTheme { get; set; }
        public DbSet<Incentive> Incentive { get; set; }
        public DbSet<Interviewer> Interviewer { get; set; }
        public DbSet<Interviewer_Language> Interviewer_Language { get; set; }
        public DbSet<InterviewerConflict> InterviewerConflict { get; set; }
        public DbSet<InterviewerEmployer> InterviewerEmployer { get; set; }
        public DbSet<InterviewerNote> InterviewerNote { get; set; }
        public DbSet<InterviewerNoteTheme> InterviewerNoteTheme { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<NotifyingParty> NotifyingParty { get; set; }
        public DbSet<NotInterviewedQOL> NotInterviewedQOL { get; set; }
        public DbSet<PayRate> PayRate { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Project_Interviewer> Project_Interviewer { get; set; }
        public DbSet<Project_Language> Project_Language { get; set; }
        public DbSet<Project_User_UserRole> Project_User_UserRole { get; set; }
        public DbSet<ProjectNCI> ProjectNCI { get; set; }
        public DbSet<ProjectQOL> ProjectQOL { get; set; }
        public DbSet<ProjectQOL_Facility> ProjectQOL_Facility { get; set; }
        public DbSet<ProjectQOL_FacilityLink> ProjectQOL_FacilityLink { get; set; }
        public DbSet<ProjectQOL_FacilityReschedule> ProjectQOL_FacilityReschedule { get; set; }
        public DbSet<ProjectQOL_FacilitySchedule> ProjectQOL_FacilitySchedule { get; set; }
        public DbSet<ProjectQOL_FacilitySchedule_Interviewer> ProjectQOL_FacilitySchedule_Interviewer { get; set; }
        public DbSet<PSA> PSA { get; set; }
        public DbSet<PSARegion> PSARegion { get; set; }
        public DbSet<Recommendation> Recommendation { get; set; }
        public DbSet<RefusalReasonNCI> RefusalReasonNCI { get; set; }
        public DbSet<RepresentativeListStatus> RepresentativeListStatus { get; set; }
        public DbSet<RepresentativeSurveyBatch> RepresentativeSurveyBatch { get; set; }
        public DbSet<RepresentativeSurveyMethod> RepresentativeSurveyMethod { get; set; }
        public DbSet<RescheduleReason> RescheduleReason { get; set; }
        public DbSet<RestartQOL> RestartQOL { get; set; }
        public DbSet<ResultCategoryNCI> ResultCategoryNCI { get; set; }
        public DbSet<ResultCodeQOLIncomplete> ResultCodeQOLIncomplete { get; set; }
        public DbSet<ResultCodeQOLNotInterviewed> ResultCodeQOLNotInterviewed { get; set; }
        public DbSet<ResultNCI> ResultNCI { get; set; }
        public DbSet<ReturnVisitReason> ReturnVisitReason { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<Sample_ResultCategoryNCI> Sample_ResultCategoryNCI { get; set; }
        public DbSet<SampleAgeGroup> SampleAgeGroup { get; set; }
        public DbSet<SampleAgeGroupMap> SampleAgeGroupMap { get; set; }
        public DbSet<SampleAgency> SampleAgency { get; set; }
        public DbSet<SampleAgencyMap> SampleAgencyMap { get; set; }
        public DbSet<SampleCCO> SampleCCO { get; set; }
        public DbSet<SampleCCOMap> SampleCCOMap { get; set; }
        public DbSet<SampleEthnicity> SampleEthnicity { get; set; }
        public DbSet<SampleEthnicityMap> SampleEthnicityMap { get; set; }
        public DbSet<SampleGender> SampleGender { get; set; }
        public DbSet<SampleGenderMap> SampleGenderMap { get; set; }
        public DbSet<SampleGeography> SampleGeography { get; set; }
        public DbSet<SampleGeographyMap> SampleGeographyMap { get; set; }
        public DbSet<SampleHomeSetting> SampleHomeSetting { get; set; }
        public DbSet<SampleHomeSettingMap> SampleHomeSettingMap { get; set; }
        public DbSet<SampleLanguage> SampleLanguage { get; set; }
        public DbSet<SampleLanguageMap> SampleLanguageMap { get; set; }
        public DbSet<SampleProgram> SampleProgram { get; set; }
        public DbSet<SampleProgramMap> SampleProgramMap { get; set; }
        public DbSet<SampleRace> SampleRace { get; set; }
        public DbSet<SampleRaceMap> SampleRaceMap { get; set; }
        public DbSet<SampleRateRepresentative> SampleRateRepresentative { get; set; }
        public DbSet<SampleRateResident> SampleRateResident { get; set; }
        public DbSet<SeparationReason> SeparationReason { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<StatusLogNCI> StatusLogNCI { get; set; }
        public DbSet<SurveyQOL> SurveyQOL { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<User> UserRole { get; set; }
        public DbSet<VisitCode> VisitCode { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssignmentConfiguration());
            modelBuilder.ApplyConfiguration(new CensusConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumerConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumerContactConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumerGuardianConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumerNoteConfiguration());
            modelBuilder.ApplyConfiguration(new CountyConfiguration());
            modelBuilder.ApplyConfiguration(new DateConflictConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceDeploymentConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceModelConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceNfieldVersionConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceNoteConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceOSConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentFormatConfiguration());
            modelBuilder.ApplyConfiguration(new FacilityConfiguration());
            modelBuilder.ApplyConfiguration(new FacilityConflictConfiguration());
            modelBuilder.ApplyConfiguration(new FacilityContactConfiguration());
            modelBuilder.ApplyConfiguration(new FacilityDistanceConfiguration());
            modelBuilder.ApplyConfiguration(new FacilityNoteConfiguration());
            modelBuilder.ApplyConfiguration(new FacilityNoteThemeConfiguration());
            modelBuilder.ApplyConfiguration(new IncentiveConfiguration());
            modelBuilder.ApplyConfiguration(new InterviewerConfiguration());
            modelBuilder.ApplyConfiguration(new Interviewer_LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new InterviewerConflictConfiguration());
            modelBuilder.ApplyConfiguration(new InterviewerEmployerConfiguration());
            modelBuilder.ApplyConfiguration(new InterviewerNoteConfiguration());
            modelBuilder.ApplyConfiguration(new InterviewerNoteThemeConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new NotifyingPartyConfiguration());
            modelBuilder.ApplyConfiguration(new NotInterviewedQOLConfiguration());
            modelBuilder.ApplyConfiguration(new PayRateConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new Project_InterviewerConfiguration());
            modelBuilder.ApplyConfiguration(new Project_LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new Project_User_UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectNCIConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectQOLConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectQOL_FacilityConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectQOL_FacilityLinkConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectQOL_FacilityRescheduleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectQOL_FacilityScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectQOL_FacilitySchedule_InterviewerConfiguration());
            modelBuilder.ApplyConfiguration(new PSAConfiguration());
            modelBuilder.ApplyConfiguration(new PSARegionConfiguration());
            modelBuilder.ApplyConfiguration(new RecommendationConfiguration());
            modelBuilder.ApplyConfiguration(new RefusalReasonNCIConfiguration());
            modelBuilder.ApplyConfiguration(new RepresentativeListStatusConfiguration());
            modelBuilder.ApplyConfiguration(new RepresentativeSurveyBatchConfiguration());
            modelBuilder.ApplyConfiguration(new RepresentativeSurveyMethodConfiguration());
            modelBuilder.ApplyConfiguration(new RescheduleReasonConfiguration());
            modelBuilder.ApplyConfiguration(new RestartQOLConfiguration());
            modelBuilder.ApplyConfiguration(new ResultCategoryNCIConfiguration());
            modelBuilder.ApplyConfiguration(new ResultCodeQOLIncompleteConfiguration());
            modelBuilder.ApplyConfiguration(new ResultCodeQOLNotInterviewedConfiguration());
            modelBuilder.ApplyConfiguration(new ResultNCIConfiguration());
            modelBuilder.ApplyConfiguration(new ReturnVisitReasonConfiguration());
            modelBuilder.ApplyConfiguration(new SampleConfiguration());
            modelBuilder.ApplyConfiguration(new Sample_ResultCategoryNCIConfiguration());
            modelBuilder.ApplyConfiguration(new SampleAgeGroupConfiguration());
            modelBuilder.ApplyConfiguration(new SampleAgeGroupMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleAgencyConfiguration());
            modelBuilder.ApplyConfiguration(new SampleAgencyMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleCCOConfiguration());
            modelBuilder.ApplyConfiguration(new SampleCCOMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleEthnicityConfiguration());
            modelBuilder.ApplyConfiguration(new SampleEthnicityMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleGenderConfiguration());
            modelBuilder.ApplyConfiguration(new SampleGenderMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleGeographyConfiguration());
            modelBuilder.ApplyConfiguration(new SampleGeographyMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleHomeSettingConfiguration());
            modelBuilder.ApplyConfiguration(new SampleHomeSettingMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleLanguageConfiguration());
            modelBuilder.ApplyConfiguration(new SampleLanguageMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleProgramConfiguration());
            modelBuilder.ApplyConfiguration(new SampleProgramMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleRaceConfiguration());
            modelBuilder.ApplyConfiguration(new SampleRaceMapConfiguration());
            modelBuilder.ApplyConfiguration(new SampleRateRepresentativeConfiguration());
            modelBuilder.ApplyConfiguration(new SampleRateResidentConfiguration());
            modelBuilder.ApplyConfiguration(new SeparationReasonConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new StatusLogNCIConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyQOLConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new VisitCodeConfiguration());
        }
    }
}
