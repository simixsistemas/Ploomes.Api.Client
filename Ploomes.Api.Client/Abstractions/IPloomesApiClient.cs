using Ploomes.Api.Client.Models;
using Refit;
using System.Threading.Tasks;

namespace Ploomes.Api.Client.Abstractions {
    /// <summary>
    /// IPloomes api client
    /// </summary>
    [Headers("accept: application/json")]
    public interface IPloomesApiClient {
        /// <summary>
        /// Get model async
        /// </summary>
        /// <typeparam name="T">Model result</typeparam>
        /// <param name="token">Access token</param>
        /// <param name="resourceName">Api resource name</param>
        /// <param name="oData">OData query string</param>
        /// <returns></returns>
        [Get("/{resourceName}{queryString}")]
        Task<ApiResult<T>> GetAsync<T>(
            [Header("User-Key")]string token,
            [AliasAs("resourceName")] string resourceName,
            [AliasAs("queryString")] string oData = "") where T : class;
    }
}
