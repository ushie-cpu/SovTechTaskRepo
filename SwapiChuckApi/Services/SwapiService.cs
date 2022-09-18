using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SwapiChuckApi.Models;
using SwapiChuckApi.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwapiChuckApi.Services
{
    public class SwapiService : BaseService, ISwapiService
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly IConfiguration _config;

        public SwapiService(IHttpClientFactory httpClientFactory, IConfiguration configuration): base(httpClientFactory)
        {
            _httpClient = httpClientFactory;
            _config = configuration;
        }

        public async Task<string> GetAllAsync(int page)
        {
            return await this.SendReqAsync<string>(new ApiRequestModel
            {
                type = RequestType.GET,
                Url = _config.GetSection("BaseUrls:SwapiApi").Value + "/people/?page=" + page,
                AccessToken = ""
            });
        }

        public async Task<string> GetByIdAsync(int Id)
        {
            return await this.SendReqAsync<string>(new ApiRequestModel
            {
                type = RequestType.GET,
                Url = _config.GetSection("BaseUrls:SwapiApi").Value + "/people/" + Id,
                AccessToken = ""
            });
        }

        public async Task<string> Search(string term)
        {
            return await this.SendReqAsync<string>(new ApiRequestModel
            {
                type = RequestType.GET,
                Url = _config.GetSection("BaseUrls:SwapiApi").Value + "/people/?search=" + term,
                AccessToken = ""
            });
        }
    }
}
