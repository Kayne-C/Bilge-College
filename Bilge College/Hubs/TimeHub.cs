using Bilge_College.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bilge_College.Hubs
{
    public class TimeHub : Hub
    {
        public async Task SendTime()
        {
            DateHelper dateHelper = new DateHelper();
            var request = Context.GetHttpContext();
            var data = request.Session.GetString("noties");
            var list = JsonConvert.DeserializeObject<List<MyClass>>(data);
            list.ForEach(x => {
                x.Time = $"{ dateHelper.timeSpan(x.CreatedDate)} önce gönderildi.";
            });
            await Clients.All.SendAsync("ReceiveTime", list);
        }
    }
}
