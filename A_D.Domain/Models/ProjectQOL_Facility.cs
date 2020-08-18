using System;
using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class ProjectQOL_Facility
    {
        public int Id { get; set; }
        public int DocumentFormat_Id_Representative { get; set; }
        public int DocumentFormat_Id_Resident { get; set; }
        public int Facility_Id { get; set; }
        public int ProjectQOL_Id { get; set; }
        public int PSA_Id { get; set; }
        public int RepresentativeListStatus_Id { get; set; }
        public int ReturnVisitReason_Id { get; set; }
        public DateTime? DateContact { get; set; }
        public DateTime? DateEmailCensus { get; set; }
        public DateTime? DateEmailConfirmation { get; set; }
        public DateTime? DateEmailFollowUp { get; set; }
        public DateTime? DateEmailReminder { get; set; }
        public DateTime? DateImportRepresentativeList { get; set; }
        public DateTime? DateImportResidentList { get; set; }
        public DateTime? DateNonCompliant { get; set; }
        public DateTime? DateReceiveRepresentativeList { get; set; }
        public DateTime? DateReceiveResidentList { get; set; }
        public bool DoNotSchedule { get; set; }
        public bool NoBackupList { get; set; }
        public bool NonCompliant { get; set; }
        public string NonCompliantComment { get; set; }
        public bool Reminder { get; set; }
        public string RepresentativeListNote { get; set; }
        public int? ResidentCountEligibleEstimate { get; set; }
        public int? ResidentCountEligibleLongTerm { get; set; }
        public int? ResidentCountEligibleShortTerm { get; set; }
        public int? ResidentCountGuardianRefusal { get; set; }
        public int? ResidentCountIsolation { get; set; }
        public int? ResidentCountLongTerm { get; set; }
        public int? ResidentCountPreliminary { get; set; }
        public int? ResidentCountResidentList { get; set; }
        public int? ResidentCountResidentListBackup { get; set; }
        public int? ResidentCountShortTerm { get; set; }
        public bool ResidentListComplete { get; set; }
        public bool ResidentListReturnVisitComplete { get; set; }
        public string ResidentListNote { get; set; }
        public int? ResidentSurveyCountActual { get; set; }
        public int? ResidentSurveyCountActualLongTerm { get; set; }
        public int? ResidentSurveyCountActualPrevious { get; set; }
        public int? ResidentSurveyCountActualReportedLongTerm { get; set; }
        public int? ResidentSurveyCountActualReportedShortTerm { get; set; }
        public int? ResidentSurveyCountActualShortTerm { get; set; }
        public int? ResidentSurveyCountGoalEstimate { get; set; }
        public int? ResidentSurveyCountGoalLongTerm { get; set; }
        public int? ResidentSurveyCountGoalReturnVisit { get; set; }
        public int? ResidentSurveyCountGoalShortTerm { get; set; }
        public string ReturnVisitNote { get; set; }
        public bool ReturnVisitRequired { get; set; }
        public string ScheduleNote { get; set; }
        public bool TestFacility { get; set; }
        public bool TrainingFacility { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public DocumentFormat DocumentFormat_Representative { get; set; }
        public DocumentFormat DocumentFormat_Resident { get; set; }
        public Facility Facility { get; set; }
        public ProjectQOL ProjectQOL { get; set; }
        public PSA PSA { get; set; }
        public RepresentativeListStatus RepresentativeListStatus { get; set; }
        public ReturnVisitReason ReturnVisitReason { get; set; }
        public List<ProjectQOL_FacilityLink> ProjectQOL_FacilityLinksA { get; set; }
        public List<ProjectQOL_FacilityLink> ProjectQOL_FacilityLinksB { get; set; }
        public List<ProjectQOL_FacilitySchedule> ProjectQOL_FacilitySchedules { get; set; }
        public List<ProjectQOL_FacilityReschedule> ProjectQOL_FacilityReschedules { get; set; }
        public List<FacilityConflict> FacilityConflicts { get; set; }
        public List<InterviewerConflict> InterviewerConflicts { get; set; }
        public List<FacilityDistance> FacilityDistances { get; set; }
        public List<SurveyQOL> SurveysQOL { get; set; }
        public List<NotInterviewedQOL> NotInterviewedsQOL { get; set; }
        public List<RestartQOL> RestartsQOL { get; set; }
        public List<Census> Censuses { get; set; }
    }
}
