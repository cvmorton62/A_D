﻿using A_D.Domain.Models;
using System.Collections.Generic;

namespace A_D.Domain
{
    public class InterviewerNoteTheme
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public string Name { get; set; }
        public List<InterviewerNote> InterviewerNotes { get; set; }
    }
}