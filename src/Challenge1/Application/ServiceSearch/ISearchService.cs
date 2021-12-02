using Application.DTOs.Search;
using System.Threading.Tasks;

namespace Application.ServiceSearch
{
    public interface ISearchService
    {
        Task<Search> Search(string product);
    }
}