using Newtonsoft.Json;
using SwapiChuckApi.Models;
using SwapiChuckApi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwapiChuckApi.Services
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClient;

        public BaseService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        // for http request related to GET, POST, DELETE, UPDATE, PUT 
        public async Task<string> SendReqAsync<T>(ApiRequestModel apiRequestModel)
        {

            try
            {
                var client = _httpClient.CreateClient("swapichuckapi");
                var message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequestModel.Url);
                client.DefaultRequestHeaders.Clear();

                if (apiRequestModel.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequestModel.Data),
                        System.Text.Encoding.UTF8, "application/json");
                }

                var response = new HttpResponseMessage();
                switch (apiRequestModel.type)
                {
                    case RequestType.GET:
                        message.Method = HttpMethod.Get;
                        break;

                    case RequestType.POST:
                        message.Method = HttpMethod.Post;
                        break;

                    case RequestType.PUT:
                        message.Method = HttpMethod.Put;
                        break;

                    case RequestType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                }

                response = await client.SendAsync(message);
                var responseContent = await response.Content.ReadAsStringAsync();

                //var reponseDto = JsonConvert.DeserializeObject<T>(responseContent);

                return responseContent;
            }
            catch (Exception ex)
            {
                var resError = new ResponseModel
                {
                    Message = "Error",
                    Error = new List<string> { Convert.ToString(ex.Message) },
                    IsSucessful = false
                };

                var ErrRes = JsonConvert.SerializeObject(resError);
                return ErrRes;
            }
        }
    }
}
