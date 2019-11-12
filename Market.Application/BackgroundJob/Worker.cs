
using Market.Application.Hubs;
using Market.Application.InOutInfo;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Market.Application.BackgroundJob
{
    public class Worker : BackgroundService
    {
        //private readonly IHubContext<InOutHub> _Hub;
        //private IConfiguration _configuration;
        private readonly InOut _inOut;

        public Worker(InOut inOut)
        {
            //_Hub = hub;
            //_configuration = configuration;
            _inOut = inOut;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _inOut.BroadcastMarketValues();

                await Task.Delay(TimeSpan.FromSeconds(15), stoppingToken);
            }
        }
    }
}
