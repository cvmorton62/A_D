using System;
using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class Interviewer
    {
        public int Id { get; set; }
        public int Recommendation_Id { get; set; }
        public int State_Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string NfieldId { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }
        public string Profession { get; set; }
        public string UserId { get; set; }
        public string ZipCode { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public List<InterviewerNote> InterviewerNotes { get; set; }
        public Recommendation Recommendation { get; set; }
        public State State { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Assignment> PeerAssignments { get; set; }
        public List<Interviewer_Language> Interviewers_Languages { get; set; }
        public List<DeviceDeployment> DeviceDeployments { get; set; }
        public List<ProjectQOL_FacilitySchedule_Interviewer> ProjectQOL_FacilitySchedule_Interviewers { get; set; }
        public List<FacilityConflict> FacilityConflicts { get; set; }
        public List<InterviewerConflict> InterviewerAConflicts { get; set; }
        public List<InterviewerConflict> InterviewerBConflicts { get; set; }
        public List<DateConflict> DateConflicts { get; set; }
        public List<FacilityDistance> FacilityDistances { get; set; }
        public List<SurveyQOL> SurveysQOL { get; set; }
        public List<NotInterviewedQOL> NotInterviewedsQOL { get; set; }
        public List<RestartQOL> RestartsQOL { get; set; }
    }
}
