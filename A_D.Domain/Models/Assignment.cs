using System;

namespace A_D.Domain.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public int Consumer_Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int? Interviewer_Id_Peer { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DriveTime { get; set; }
        public Double? Miles { get; set; }
        public Double? Payment { get; set; }
        public bool PaymentApproved { get; set; }
        public Double? PeerPayment { get; set; }
        public bool PeerPaymentApproved { get; set; }
        public bool VerificationSheet { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Consumer Consumer { get; set; }
        public Interviewer Interviewer { get; set; }
        public Interviewer PeerInterviewer { get; set; }
    }
}
