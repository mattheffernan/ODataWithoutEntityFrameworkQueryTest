using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using ODataWithoutEntityFrameworkQueryTest.Models;

namespace ODataWithoutEntityFrameworkQueryTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Book>("Books");
            builder.EntitySet<Customer>("Customers");
            var model = builder.GetEdmModel();

            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);

            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: model);

        }
    }
}
