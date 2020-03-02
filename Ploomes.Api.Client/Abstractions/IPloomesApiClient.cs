using Ploomes.Api.Client.Models;
using Refit;
using System.Threading.Tasks;

namespace Ploomes.Api.Client.Abstractions {
    [Headers("accept: application/json")]
    public interface IPloomesApiClient {
        [Get("/{resourceName}{queryString}")]
        Task<ApiResult<T>> GetAsync<T>(
            [Header("User-Key")]string token,
            [AliasAs("resourceName")] string resourceName,
            [AliasAs("queryString")] string oData = "") where T : class;
    }
}
