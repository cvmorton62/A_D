using System;
using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int? InterviewerEmployer_Id { get; set; }
        public int State_Id { get; set; }
        public Double? Budget { get; set; }
        public string FolderPath { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DatePHIDelete { get; set; }
        public bool Inactive { get; set; }
        public bool InterraterAgreement { get; set; }
        public string Name { get; set; }
        public bool QualityAssurance { get; set; }
        public string TrainingLocation { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public InterviewerEmployer InterviewerEmployer { get; set; }
        public ProjectNCI ProjectNCI { get; set; }
        public ProjectQOL ProjectQOL { get; set; }
        public State State { get; set; }
        public List<Project_Language> Projects_Languages { get; set; }
        public List<Project_User_UserRole> Projects_Users_UserRoles { get; set; }
    }
}
