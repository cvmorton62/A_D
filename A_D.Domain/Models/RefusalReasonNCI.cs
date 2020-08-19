using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class RefusalReasonNCI
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<StatusLogNCI> StatusLogsNCI { get; set; }
    }
}
