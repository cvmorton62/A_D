using System;
using A_D.Domain.Models;

namespace VR.Domain
{
    public class PayRate
    {
        public int Id { get; set; }
        public int Sample_Id { get; set; }
        public double Amount { get; set; }
        public int MilesMaximum { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public Sample Sample { get; set; }
    }
}