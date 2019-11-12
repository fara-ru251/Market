using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Domain.Entities
{
    public class GetAllVisitsSP
    {
        public int ZoneID { get; set; }
        public int OldCount { get; set; }
        public int YoungCount { get; set; }
        public int TeenagerCount { get; set; }
        public int AdultCount { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
    }
}
