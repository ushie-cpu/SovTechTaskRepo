using Microsoft.AspNetCore.Server.Kestrel.Core;
using SwapiChuckApi.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;
using SwapiChuckApi.Models;
using Microsoft.Extensions.Configuration;

namespace SwapiChuckApi.Services
{
    public class ChucksService : BaseService, IChucksService
    {
        private readonly IHttpClientFactory _clientFactory; 
        private readonly IConfiguration _config;

        public ChucksService(IHttpClientFactory httpClient, IConfiguration configuration): base(httpClient)
        {
            _clientFactory = httpClient;
            _config = configuration;
        }

        public async Task<string> GetAllAsync()
        {
            return await this.SendReqAsync<string>(new ApiRequestModel
            {
                type = RequestType.GET,
                Url = _config.GetSection("BaseUrls:ChucksApi").Value + "/jokes/categories",
                AccessToken = ""
            });
        }

        public async Task<string> GetByCategoryAsync(string category)
        {
            return await this.SendReqAsync<string>(new ApiRequestModel
            {
                type = RequestType.GET,
                Url = _config.GetSection("BaseUrls:ChucksApi").Value + "/jokes/random?category=" + category,
                AccessToken = ""
            });
        }

        public async Task<string> Search(string term)
        {
            return await this.SendReqAsync<string>(new ApiRequestModel
            {
                type = RequestType.GET,
                Url = _config.GetSection("BaseUrls:ChucksApi").Value + "/jokes/search?query=" + term,
                AccessToken = ""
            });
        }
    }
}
