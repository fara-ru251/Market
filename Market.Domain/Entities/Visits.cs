using System;
using System.Collections.Generic;

namespace Market.Domain
{
    public partial class Visits
    {
        public int VisitId { get; set; }
        public int CameraId { get; set; }
        public int ZoneId { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public genders Gender { get; set; }
        public ages Age { get; set; }

        public virtual CameraZones CameraZones { get; set; }
    }

    public enum genders 
    {
        male,// = 0,
        female// = 1
    }

    public enum ages
    {
        young, //= 0,
        teenager,// = 1,
        adult, //= 2,
        old //= 3
    }
}
