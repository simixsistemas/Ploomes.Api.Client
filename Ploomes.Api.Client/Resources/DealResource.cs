using Ploomes.Api.Client.Abstractions;
using Ploomes.Api.Client.Models;

namespace Ploomes.Api.Client.Resources {
    /// <summary>
    /// DealResource
    /// </summary>
    public sealed class DealResource : BaseResource<Deal>, IDealResource {
        #region Properties

        /// <summary>
        /// Resource name
        /// </summary>
        protected override string ResourceName => "Deals";

        #endregion

        #region Constructors

        /// <summary>
        /// Build deal resource with access token
        /// </summary>
        /// <param name="accessToken">Ploomes api access token</param>
        public DealResource(string accessToken) : base(accessToken) {
        }

        /// <summary>
        /// Build deal resource with access token and base url
        /// </summary>
        /// <param name="accessToken">Ploomes api access token</param>
        /// <param name="baseUrl">Ploomes api base url</param>
        public DealResource(string accessToken, string baseUrl)
            : base(accessToken, baseUrl) {
        }

        #endregion
    }
}
