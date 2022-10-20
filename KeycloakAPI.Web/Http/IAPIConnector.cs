using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeycloakAPI.Web.Http
{
    internal interface IAPIConnector
    {
        Task<T> Get<T>(Uri uri);
        Task<T> Get<T>(Uri uri, IDictionary<string, string>? parameters);

        Task<T> Post<T>(Uri uri);
        Task<T> Post<T>(Uri uri, IDictionary<string, string>? parameters);
        Task<T> Post<T>(Uri uri, IDictionary<string, string>? parameters, object? body);

        Task<T> SendAPIRequestAsync<T>(
            Uri uri, 
            HttpMethod method,
            IDictionary<string, string>? parameters = null,
            object? body = null,
            IDictionary<string, string>? headers = null);
    }
}
