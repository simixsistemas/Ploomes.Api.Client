using Ploomes.Api.Client.Abstractions;
using Ploomes.Api.Client.Helpers;
using Ploomes.Api.Client.Models;
using Polly;
using Refit;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ploomes.Api.Client.Resources {
    /// <summary>
    /// BaseResource
    /// </summary>
    /// <typeparam name="TModel">Resource model</typeparam>
    public abstract class BaseResource<TModel> where TModel : class {
        #region Fields

        private const int NUMBER_OF_RETRIES = 3;
        private const string PLOOMES_API_BASE_URL = "https://api2.ploomes.com";

        private readonly IPloomesApiClient _ploomesApiClient;
        private readonly IAsyncPolicy _asyncPolicy;
        private readonly string _token;

        #endregion

        #region Properties

        /// <summary>
        /// Resource name
        /// </summary>
        protected abstract string ResourceName { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Build resource with access token
        /// </summary>
        /// <param name="accessToken">Ploomes api access token</param>
        protected BaseResource(string accessToken)
            : this(accessToken, PLOOMES_API_BASE_URL) { }

        /// <summary>
        /// Build resource with access token and baseurl
        /// </summary>
        /// <param name="accessToken">Ploomes api access token</param>
        /// <param name="baseUrl">Ploomes api base url</param>
        protected BaseResource(string accessToken, string baseUrl) {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentNullException(nameof(accessToken), "Token can't be null");

            _token = accessToken;
            _ploomesApiClient = RestService.For<IPloomesApiClient>(baseUrl, new RefitSettings { HttpMessageHandlerFactory = () => new UriQueryUnescapingHandler() });

            _asyncPolicy = Policy
                .Handle<ApiException>(ex => ex.StatusCode != HttpStatusCode.NotFound && ex.StatusCode != HttpStatusCode.Forbidden)
                .RetryAsync(NUMBER_OF_RETRIES);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get model´s async
        /// </summary>
        /// <param name="oData">Query string using OData protocol</param>
        /// <returns>ApiResult - TModel</returns>
        public async Task<ApiResult<TModel>> GetAsync(OData oData = null) =>
            await RequestWithPolicy(GetModels(oData)).ConfigureAwait(false);

        #endregion

        #region Protected Methods

        /// <summary>
        /// Get api function for models
        /// </summary>
        /// <param name="oData">Query string based on OData protocol</param>
        /// <returns></returns>
        protected Func<Task<ApiResult<TModel>>> GetModels(OData oData = null) =>
            () => _ploomesApiClient.GetAsync<TModel>(_token, ResourceName, oData?.ToString());

        /// <summary>
        /// Do async request with policy
        /// </summary>
        /// <typeparam name="T">Request result</typeparam>
        /// <param name="func">Function to get async request</param>
        /// <returns>Request result</returns>
        protected async Task<T> RequestWithPolicy<T>(Func<Task<T>> func) =>
            await _asyncPolicy.ExecuteAsync(func).ConfigureAwait(false);

        #endregion
    }
}
