using Ploomes.Api.Client.Abstractions;
using Ploomes.Api.Client.Models;

namespace Ploomes.Api.Client.Resources {
    public sealed class DealResource : BaseResource<Deal>, IDealResource {
        #region Properties

        protected override string ResourceName => "Deals";

        #endregion

        #region Constructors

        public DealResource(string accessToken) : base(accessToken) {
        }

        public DealResource(string accessToken, string baseUrl)
            : base(accessToken, baseUrl) {
        }

        #endregion
    }
}
