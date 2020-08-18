using System;
using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class ProjectQOL
    {
        public int Id { get; set; }
        public int Project_Id { get; set; }
        public bool FamilyData { get; set; }
        public bool LinkedFacilities { get; set; }
        public bool ShortTerm { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Project Project { get; set; }
        public List<PSARegion> PSARegions { get; set; }
        public List<ProjectQOL_Facility> ProjectsQOL_Facilities { get; set; }
        public List<SampleRateRepresentative> SampleRatesRepresentative { get; set; }
        public List<SampleRateResident> SampleRatesResident { get; set; }
        public List<RepresentativeSurveyBatch> RepresentativeSurveyBatches { get; set; }
    }
}
