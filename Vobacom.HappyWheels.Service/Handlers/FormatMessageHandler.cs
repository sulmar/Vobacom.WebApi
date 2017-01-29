﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Vobacom.HappyWheels.Service.Handlers
{
    public class FormatMessageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var parameters = request.GetQueryNameValuePairs();

            var keyvalue = parameters.FirstOrDefault(s => s.Key == "format");

            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(keyvalue.Value, 1));

            //request.RequestUri

            return base.SendAsync(request, cancellationToken);
        }
    }
}