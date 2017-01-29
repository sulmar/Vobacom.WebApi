using FluentValidation.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Vobacom.HappyWheels.Service.Formatters;
using Vobacom.HappyWheels.Service.Handlers;

namespace Vobacom.HappyWheels.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            
            config.MessageHandlers.Add(new TraceMessageHandler());
            // config.MessageHandlers.Add(new SecretKeyMessageHandler());
          //  config.MessageHandlers.Add(new FormatMessageHandler());

            config.Formatters.Add(new QrCodeMediaTypeFormatter());

            FluentValidationModelValidatorProvider.Configure(config);
        }
    }
}
