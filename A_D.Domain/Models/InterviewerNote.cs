using System;
using VR.Domain;

namespace A_D.Domain.Models
{
    public class InterviewerNote
    {
        public int Id { get; set; }
        public int Interviewer_Id { get; set; }
        public int InterviewerNoteTheme_Id { get; set; }
        public int User_Id { get; set; }
        public string Note { get; set; }
        public bool Retain { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Interviewer Interviewer { get; set; }
        public InterviewerNoteTheme InterviewerNoteTheme { get; set; }
        public User User { get; set; }
    }
}
