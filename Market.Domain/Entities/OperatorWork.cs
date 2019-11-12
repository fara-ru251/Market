using System;
using System.Collections.Generic;

namespace Market.Domain
{
    public partial class OperatorWork
    {
        public int OwId { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public int? OperatorId { get; set; }

        public virtual Operators Operator { get; set; }
    }
}
