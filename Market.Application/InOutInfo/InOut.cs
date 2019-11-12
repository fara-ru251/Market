using Market.Application.APIVisits.Queries.GetAll;
using Market.Application.Hubs;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Market.Application.InOutInfo
{
    public class InOut
    {
        //private readonly TimeSpan _updateInterval = TimeSpan.FromMinutes(1);

        //private readonly int[] data = new int[5];
        private IConfiguration _configuration;
        private IMediator _mediator;


        public InOut(IHubContext<InOutHub> hub, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            Hub = hub;
            _configuration = configuration;
            //LoadDefaultValues();
        }

        //public InOut()
        //{
        //    LoadDefaultValues();
        //}

        private IHubContext<InOutHub> Hub { get; set; }
       

        //public IEnumerable<int> GetAllValues()
        //{
        //    return data;
        //}

        //private void LoadDefaultValues()
        //{
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        data[i] = i;
        //    }
        //}


        public async Task BroadcastMarketValues()
        {
            var answer = await _mediator.Send(new GetAllVisitsQuery());
            await Hub.Clients.Group(_configuration["SignalRGroupName"]).SendAsync("updateMarketValues", answer);
        }
    }
}
