using Market.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Market.API.Logic.PresentationVisits.Query
{
    public class GetAllVisitsHandler : IRequestHandler<GetAllVisits, List<VisitsAllTimeSPVM>>
    {
        private ConDbContext _context;

        public GetAllVisitsHandler(ConDbContext context)
        {
            _context = context;
        }



        public Task<List<VisitsAllTimeSPVM>> Handle(GetAllVisits request, CancellationToken cancellationToken)
        {
            //var result = _context.GetAllVisitsSP.FromSql("get_all_visits").AsEnumerable();

            List<VisitsAllTimeSPVM> ans = new List<VisitsAllTimeSPVM>();
            //foreach (var item in result)
            //{
            //    ans.Add(new VisitsAllTimeSPVM()
            //    {
            //        ZoneID = item.ZoneID,
            //        AdultCount = item.AdultCount,
            //        Female = item.Female,
            //        Male = item.Male,
            //        OldCount = item.OldCount,
            //        TeenagerCount = item.TeenagerCount,
            //        YoungCount = item.YoungCount
            //    });
            //}

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT 
                                            t.zone_id,
		                                    CAST(COUNT(CASE WHEN t.age = 'old' THEN t.visit_id END) AS INT) old_count,
		                                    CAST(COUNT(CASE WHEN t.age = 'young' THEN t.visit_id END) AS INT) young_count,
		                                    CAST(COUNT(CASE WHEN t.age = 'teenager' THEN t.visit_id END) AS INT) teenager_count,
		                                    CAST(COUNT(CASE WHEN t.age = 'adult' THEN t.visit_id END) AS INT) adult_count,
		                                    CAST(COUNT(CASE WHEN t.gender = 'male' THEN t.visit_id END) AS INT) male_count,
		                                    CAST(COUNT(CASE WHEN t.gender = 'female' THEN t.visit_id END) AS INT) female_count,
		                                    CAST(COUNT(*) AS INT) AS all_count
                                        FROM visits AS t
                                        GROUP BY t.zone_id
                                        ORDER BY zone_id;";
                if (command.Connection.State == ConnectionState.Closed)
                    command.Connection.Open();
                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    ans.Add(new VisitsAllTimeSPVM()
                    {
                        ZoneID = reader.GetInt32(0),
                        AdultCount = reader.GetInt32(1),
                        Female = reader.GetInt32(2),
                        Male = reader.GetInt32(3),
                        OldCount = reader.GetInt32(4),
                        TeenagerCount = reader.GetInt32(5),
                        YoungCount = reader.GetInt32(6)
                    });
                }
            }

            return Task.FromResult(ans);
        }
    }
}
