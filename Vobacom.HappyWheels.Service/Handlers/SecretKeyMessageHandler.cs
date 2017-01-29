using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Vobacom.HappyWheels.Service.Handlers
{
    public class SecretKeyMessageHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response;

            if (IsValideKey(request))
            {
                response = await base.SendAsync(request, cancellationToken);
            }
            else
            {
                response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            }


            return response;
            
        }

        private bool IsValideKey(HttpRequestMessage request)
        {
            IEnumerable<string> headerValues;

            if (request.Headers.TryGetValues("Secret-Key", out headerValues))
            {
                string secretKey = headerValues.First();

                return secretKey == "12345";
            }
            else
                return false;

        }
    }
}