using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TimberBusinessProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
              "getplywood",
              "api/getplywood",
              new { controller = "Products", action = "GetPlywood" }

          );
            config.Routes.MapHttpRoute(
              "getpinewood",
              "api/getpinewood",
              new { controller = "Products", action = "GetPinewood" }

          );
            config.Routes.MapHttpRoute(
              "getbamboo",
              "api/getbamboo",
              new { controller = "Products", action = "GetBamboo" }

          );
            config.Routes.MapHttpRoute(
              "addBamboo",
              "api/addBamboo",
              new { controller = "Products", action = "addBamboo" }

          );
            config.Routes.MapHttpRoute(
              "addWoodProp",
              "api/addWoodProp",
              new { controller = "Products", action = "addWoodProp" }

          );
            
            config.Routes.MapHttpRoute(
              "getwoodprop",
              "api/getwoodprop",
              new { controller = "Products", action = "GetWoodProp" }

          );

            config.Routes.MapHttpRoute(
              "GetWoodPropWithPrice",
              "api/GetWoodPropWithPrice",
              new { controller = "Products", action = "GetWoodPropWithPrice" }

          );

            
            config.Routes.MapHttpRoute(
              "getpercent",
              "api/getpercent",
              new { controller = "Products", action = "getpercent" }

          );
            config.Routes.MapHttpRoute(
              "getpinewooddetail",
              "api/getpinewooddetail/{id}",
              new { controller = "Products", action = "GetPineWoodDetail" }

          );

            config.Routes.MapHttpRoute(
              "getwoodpropdetail",
              "api/getwoodpropdetail/{id}",
              new { controller = "Products", action = "GetWoodPropDetail" }

          );
            config.Routes.MapHttpRoute(
              "getbamboodetail",
              "api/getbamboodetail/{id}",
              new { controller = "Products", action = "GetBambooDetail" }

          );
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
