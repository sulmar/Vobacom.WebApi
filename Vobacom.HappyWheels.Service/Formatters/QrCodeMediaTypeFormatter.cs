using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.Service.Formatters
{
    public class QrCodeMediaTypeFormatter : MediaTypeFormatter
    {
        public QrCodeMediaTypeFormatter()
        {
            SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("image/png"));
        }

        public override bool CanReadType(Type type)
        {
            return false;
        }

        public override bool CanWriteType(Type type)
        {
            return type == typeof(Bike);
        }

        public override async Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            var bike = value as Bike;

            var uri = $"https://chart.googleapis.com/chart?cht=qr&chs=300x300&chl={HttpUtility.UrlEncode(bike.SerialNumber)}";

            using (var client = new WebClient())
            {
                var data = await client.DownloadDataTaskAsync(uri);

                await writeStream.WriteAsync(data, 0, data.Length);


            }
        }
    }
}