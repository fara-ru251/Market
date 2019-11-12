using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.APIVisits.Queries.GetAll
{
    public class VisitsAllTimeVM
    {
        public int ZoneID { get; set; }
        public int Total { get; set; }
        public IEnumerable<VisitByCharacteristics> GenderInfo { get; set; }
        public IEnumerable<VisitByCharacteristics> AgeInfo { get; set; }
    }

    public class VisitByCharacteristics
    {
        public string Type { get; set; }
        public int Total { get; set; }
    }

    public class VisitAllTimeDTO
    {
        public int zone_id { get; set; }
        public int old_count { get; set; }
        public int young_count { get; set; }
        public int teenager_count { get; set; }
        public int adult_count { get; set; }
        public int male_count { get; set; }
        public int female_count { get; set; }
    }
}
