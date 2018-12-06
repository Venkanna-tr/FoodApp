using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class ProofTypes
    {
        public ProofTypes()
        {
            UserProofs = new HashSet<UserProofs>();
        }

        public int ProofTypeId { get; set; }
        public string ProofName { get; set; }

        public virtual ICollection<UserProofs> UserProofs { get; set; }
    }
}
