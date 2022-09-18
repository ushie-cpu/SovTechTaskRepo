using System.Threading.Tasks;

namespace SwapiChuckApi.Services.IServices
{
    public interface IChucksService
    {
        Task<string> GetAllAsync();
        Task<string> GetByCategoryAsync(string category);
        Task<string> Search(string term);
        //Task<T> CreateAsync<T>();
        //Task<T> DeleteAsync<T>();
        //Task<T> UpdateAsync<T>();

    }
}
