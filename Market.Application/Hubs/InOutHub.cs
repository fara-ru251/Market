using Market.Application.InOutInfo;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Market.Application.Hubs
{
    public class InOutHub : Hub
    {
        private IConfiguration _configuration;

        public InOutHub(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //example method
        //public async Task SendAllValues()
        //{

        //    /* here we awaiting values from DB
        //     * and passing them to client method param
        //     */
        //    await Clients.Group(_configuration["SignalRGroupName"]).SendAsync("updateMarketValues");
        //}

        public override Task OnConnectedAsync()
        {
            Groups.AddToGroupAsync(Context.ConnectionId, _configuration["SignalRGroupName"]);

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            Groups.RemoveFromGroupAsync(Context.ConnectionId, _configuration["SignalRGroupName"]);

            return base.OnDisconnectedAsync(exception);
        }
    }
}
