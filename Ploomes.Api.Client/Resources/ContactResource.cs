using Ploomes.Api.Client.Abstractions;
using Ploomes.Api.Client.Models;

namespace Ploomes.Api.Client.Resources {
    public sealed class ContactResource : BaseResource<Contact>, IContactResource {
        #region Properties

        protected override string ResourceName => "Contacts";

        #endregion

        #region Constructors

        public ContactResource(string accessToken)
            : base(accessToken) { }

        public ContactResource(string accessToken, string baseUrl)
            : base(accessToken, baseUrl) { }

        #endregion
    }
}
