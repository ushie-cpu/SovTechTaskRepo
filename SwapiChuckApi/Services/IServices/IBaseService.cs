using SwapiChuckApi.Models;
using System.Threading.Tasks;

namespace SwapiChuckApi.Services.IServices
{
    public interface IBaseService
    {
        Task<string> SendReqAsync<T>(ApiRequestModel apiRequestModel);
    }
}
