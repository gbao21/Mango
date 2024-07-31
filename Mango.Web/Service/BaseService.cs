using Mango.Web.Models;
using Mango.Web.Service.ISErvice;
using Newtonsoft.Json;
using System.Text;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BaseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ResponseDto?> IBaseService.SendAsync(RequestDto requestDTO)
        {
            HttpClient client = _httpClientFactory.CreateClient("MangoAPI");
            HttpRequestMessage message = new();
            message.Headers.Add("Content-Type", "application/json");
            //token

            message.RequestUri = new Uri(requestDTO.Url);
            if(requestDTO.Data != null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(requestDTO.Data), Encoding.UTF8,"application/json");
            }

            HttpResponseMessage? apiResponse = null;
            switch (requestDTO.ApiType)
            {
                case ApiType.POST:
                    message.Method = HttpMethod.Get;
                    break;
                case ApiType.PUT:
                    message.Method = HttpMethod.Get;
                    break;
                case ApiType.DELETE:
                    message.Method = HttpMethod.Get;
                    break;
                default:
                    message.Method = HttpMethod.Get;
                    break;
            }

        }
    }
} 
