﻿using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class SeparationReason
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Project_Interviewer> Projects_Interviewers { get; set; }
    }
}
