using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Vobacom.HappyWheels.Service.Handlers
{
    public class TraceMessageHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"{request.Method}: {request.RequestUri}");

            var content = await request.Content.ReadAsStringAsync();

            Debug.WriteLine(content);

            var response  = await base.SendAsync(request, cancellationToken);

            if (response.Content!=null)
                Debug.WriteLine(await response.Content.ReadAsStringAsync());

            return response;
        }
    }
}