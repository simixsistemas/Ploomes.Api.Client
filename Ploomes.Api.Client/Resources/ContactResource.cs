using Ploomes.Api.Client.Abstractions;
using Ploomes.Api.Client.Models;

namespace Ploomes.Api.Client.Resources {
    /// <summary>
    /// Contact resource
    /// </summary>
    public sealed class ContactResource : BaseResource<Contact>, IContactResource {
        #region Properties

        /// <summary>
        /// Resource name
        /// </summary>
        protected override string ResourceName => "Contacts";

        #endregion

        #region Constructors

        /// <summary>
        /// Build contact resouce with access token
        /// </summary>
        /// <param name="accessToken">Ploomes api access token</param>
        public ContactResource(string accessToken)
            : base(accessToken) { }

        /// <summary>
        /// Build contact resource with access token and base url
        /// </summary>
        /// <param name="accessToken">Ploomes api access token</param>
        /// <param name="baseUrl">Ploomes api base url</param>
        public ContactResource(string accessToken, string baseUrl)
            : base(accessToken, baseUrl) { }

        #endregion
    }
}
