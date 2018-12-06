using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class PlanMaster
    {
        public PlanMaster()
        {
            Plans = new HashSet<Plans>();
        }

        public int PlanMasterId { get; set; }
        public string Name { get; set; }
        public int? StatusTypeId { get; set; }

        public virtual StatusTypes StatusType { get; set; }
        public virtual ICollection<Plans> Plans { get; set; }
    }
}
