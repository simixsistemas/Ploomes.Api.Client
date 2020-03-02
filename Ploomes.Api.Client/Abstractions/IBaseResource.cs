using Ploomes.Api.Client.Helpers;
using Ploomes.Api.Client.Models;
using System.Threading.Tasks;

namespace Ploomes.Api.Client.Abstractions {
    /// <summary>
    /// IBaseResource
    /// </summary>
    /// <typeparam name="TModel">Resource model</typeparam>
    public interface IBaseResource<TModel> where TModel : class {
        /// <summary>
        /// Get model´s async
        /// </summary>
        /// <param name="oData">Query string using OData protocol</param>
        /// <returns>ApiResult - TModel</returns>
        Task<ApiResult<TModel>> GetAsync(OData oData = null);
    }
}
