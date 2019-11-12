using System;
using System.Collections.Generic;

namespace Market.Domain
{
    public partial class Operators
    {
        public Operators()
        {
            OperatorService = new HashSet<OperatorService>();
            OperatorWork = new HashSet<OperatorWork>();
        }

        public int OperatorId { get; set; }
        public string OperatorName { get; set; }

        public virtual ICollection<OperatorService> OperatorService { get; set; }
        public virtual ICollection<OperatorWork> OperatorWork { get; set; }
    }
}
