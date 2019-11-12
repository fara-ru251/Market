using System;
using System.Collections.Generic;

namespace Market.Domain
{
    public partial class Cameras
    {
        public Cameras()
        {
            CameraZones = new HashSet<CameraZones>();
        }

        public int CameraId { get; set; }
        public string CameraName { get; set; }

        public virtual ICollection<CameraZones> CameraZones { get; set; }
    }
}
