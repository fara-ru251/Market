using System;
using System.Collections.Generic;

namespace Market.Domain
{
    public partial class CameraZones
    {
        public CameraZones()
        {
            Visits = new HashSet<Visits>();
        }

        public int ZoneId { get; set; }
        public int CameraId { get; set; }
        public string Coordinates { get; set; }

        public virtual Cameras Camera { get; set; }
        public virtual Zones Zone { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
