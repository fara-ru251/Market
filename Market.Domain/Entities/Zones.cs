using System;
using System.Collections.Generic;

namespace Market.Domain
{
    public partial class Zones
    {
        public Zones()
        {
            CameraZones = new HashSet<CameraZones>();
        }

        public int ZoneId { get; set; }
        public string ZoneName { get; set; }

        public virtual ICollection<CameraZones> CameraZones { get; set; }
    }
}
