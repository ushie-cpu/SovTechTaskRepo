using System.Threading.Tasks;

namespace SwapiChuckApi.Services.IServices
{
    public interface ISwapiService
    {
        Task<string> GetAllAsync(int page);
        Task<string> GetByIdAsync(int Id);
        Task<string> Search(string term);
    }
}
