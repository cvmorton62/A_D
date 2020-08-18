using System;

namespace A_D.Domain.Models
{
    public class Project_Interviewer
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int Interviewer_Id_Peer { get; set; }
        public int Interviewer_Id_QAM { get; set; }
        public int Project_Id { get; set; }
        public int PSA_Id { get; set; }
        public int Recommendation_Id { get; set; }
        public int SeparationReason_Id { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateMaterialsIssue { get; set; }
        public DateTime DateMaterialsReturn { get; set; }
        public bool MaterialsCallSheet { get; set; }
        public bool MaterialsClipboard { get; set; }
        public bool MaterialsConsentForm { get; set; }
        public bool MaterialsHearingAmplifier { get; set; }
        public bool MaterialsLaminate { get; set; }
        public bool MaterialsLockBox { get; set; }
        public bool MaterialsNameTag { get; set; }
        public bool MaterialsReferenceManual { get; set; }
        public bool MaterialsTablet { get; set; }
        public bool MaterialsTabletAccessories { get; set; }
        public bool QAM { get; set; }
        public bool Trainer { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Interviewer Interviewer { get; set; }
        public Interviewer PeerInterviewer { get; set; }
        public Interviewer QAMInterviewer { get; set; }
        public Project Project { get; set; }
        public PSA PSA { get; set; }
        public Recommendation Recommendation { get; set; }
        public SeparationReason SeparationReason { get; set; }
    }
}
