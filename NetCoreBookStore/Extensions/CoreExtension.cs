using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBookStore.Extensions
{
    public static class CoreExtension
    {
        public static bool IsAjaxRequest(HttpRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.Headers != null)
                return (request.Headers["X-Requested-With"] == "XMLHttpRequest");

            else
                return false;
        }

    }
}
