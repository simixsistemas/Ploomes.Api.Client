using Ploomes.Api.Client.Helpers;
using Ploomes.Api.Client.Models;
using System.Threading.Tasks;

namespace Ploomes.Api.Client.Abstractions {
    public interface IBaseResource<TModel> where TModel : class {
        Task<ApiResult<TModel>> GetAsync(OData oData = null);
    }
}
