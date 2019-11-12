using System;
using System.Collections.Generic;

namespace Market.Domain
{
    public partial class OperatorService
    {
        public int ServiceId { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public int? OperatorId { get; set; }

        public virtual Operators Operator { get; set; }
    }
}
