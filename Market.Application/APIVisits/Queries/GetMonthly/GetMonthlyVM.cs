using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.APIVisits.Queries.GetMonthly
{
    public class GetMonthlyVM
    {
        public IList<VisitGroupingInfo> All { get; private set; }
        public IList<VisitGroupingInfo> Male { get; private set; }
        public IList<VisitGroupingInfo> Female { get; private set; }
        public IList<VisitGroupingInfo> Teenager { get; private set; }
        public IList<VisitGroupingInfo> Old { get; private set; }
        public IList<VisitGroupingInfo> Young { get; private set; }
        public IList<VisitGroupingInfo> Adult { get; private set; }

        public GetMonthlyVM()
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
            public int Day { get; private set; }
            public int Total { get; private set; }

            public VisitGroupingInfo(int day, int total)
            {
                this.Day = day;
                this.Total = total;
            }
        }
    }
}
