using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class PSARegion
    {
        public int Id { get; set; }
        public int ProjectQOL_Id { get; set; }
        public string Name { get; set; }
        public ProjectQOL ProjectQOL { get; set; }
        public List<PSA> PSAs { get; set; }
    }
}