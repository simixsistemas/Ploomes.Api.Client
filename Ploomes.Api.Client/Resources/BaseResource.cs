using Ploomes.Api.Client.Abstractions;
using Ploomes.Api.Client.Helpers;
using Ploomes.Api.Client.Models;
using Polly;
using Refit;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Ploomes.Api.Client.Resources {
    public abstract class BaseResource<TModel> where TModel : class {
        #region Fields

        private const int NUMBER_OF_RETRIES = 3;
        private const string PLOOMES_API_BASE_URL = "https://api2.ploomes.com";

        private readonly IPloomesApiClient _ploomesApiClient;
        private readonly IAsyncPolicy _asyncPolicy;
        private readonly string _token;

        protected abstract string ResourceName { get; }

        #endregion

        #region Constructors

        protected BaseResource(string accessToken)
            : this(accessToken, PLOOMES_API_BASE_URL) { }

        protected BaseResource(string accessToken, string baseUrl) {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentNullException(nameof(accessToken), "Token can't be null");

            _token = accessToken;
            _ploomesApiClient = Refit.RestService.For<IPloomesApiClient>(baseUrl);

            _asyncPolicy = Policy
                .Handle<ApiException>(ex => ex.StatusCode != HttpStatusCode.NotFound && ex.StatusCode != HttpStatusCode.Forbidden)
                .RetryAsync(NUMBER_OF_RETRIES);
        }

        #endregion

        #region Public Methods

        public async Task<ApiResult<TModel>> GetAsync(OData oData = null) =>
            await RequestWithPolicy(GetModels(oData)).ConfigureAwait(false);

        #endregion

        #region Protected Methods

        protected Func<Task<ApiResult<TModel>>> GetModels(OData oData = null) =>
            () => _ploomesApiClient.GetAsync<TModel>(_token, ResourceName, oData?.ToString());

        protected async Task<T> RequestWithPolicy<T>(Func<Task<T>> func) =>
            await _asyncPolicy.ExecuteAsync(func).ConfigureAwait(false);

        #endregion
    }
}
