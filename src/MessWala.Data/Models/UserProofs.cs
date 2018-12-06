using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class UserProofs
    {
        public int UserProofId { get; set; }
        public string ProofDocumentpath { get; set; }
        public int? ProofTypeId { get; set; }
        public int? UserId { get; set; }

        public virtual ProofTypes ProofType { get; set; }
        public virtual Users User { get; set; }
    }
}
