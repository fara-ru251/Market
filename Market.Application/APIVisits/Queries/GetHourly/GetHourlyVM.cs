using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.APIVisits.Queries.GetHourly
{
    public class GetHourlyVM
    {
        public IList<VisitGroupingInfo> All { get; private set; }
        public IList<VisitGroupingInfo> Male { get; private set; }
        public IList<VisitGroupingInfo> Female { get; private set; }
        public IList<VisitGroupingInfo> Teenager { get; private set; }
        public IList<VisitGroupingInfo> Old { get; private set; }
        public IList<VisitGroupingInfo> Young { get; private set; }
        public IList<VisitGroupingInfo> Adult { get; private set; }

        public GetHourlyVM()
        {
            All = new List<VisitGroupingInfo>();
            Male = new List<VisitGroupingInfo>();
            Female = new List<VisitGroupingInfo>();
            Teenager = new List<VisitGroupingInfo>();
            Old = new List<VisitGroupingInfo>();
            Young = new List<VisitGroupingInfo>();
            Adult = new List<VisitGroupingInfo>();
        }

        public class VisitGroupingInfo
        {
            public int Hour { get; private set; }
            public int Total { get; private set; }

            public VisitGroupingInfo(int hour, int total)
            {
                this.Hour = hour;
                this.Total = total;
            }
        }
    }
}
