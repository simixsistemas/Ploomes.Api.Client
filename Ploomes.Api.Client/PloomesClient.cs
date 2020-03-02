using Ploomes.Api.Client.Abstractions;
using Ploomes.Api.Client.Helpers;
using Ploomes.Api.Client.Resources;
using System;

namespace Ploomes.Api.Client {
    public sealed class PloomesClient {
        #region Fields

        private static PloomersApiClientOptions _clientOptions;

        private readonly Lazy<IDealResource> _dealResouce =
            new Lazy<IDealResource>(() => new DealResource(_clientOptions.Token));

        private readonly Lazy<IContactResource> _contactResouce =
            new Lazy<IContactResource>(() => new ContactResource(_clientOptions.Token));

        #endregion

        #region Properties

        public IDealResource Deals => _dealResouce.Value;

        public IContactResource Contacts => _contactResouce.Value;

        #endregion

        #region Constructors

        public PloomesClient(PloomersApiClientOptions clientOptions) {
            if (string.IsNullOrWhiteSpace(clientOptions.Token))
                throw new ArgumentNullException(nameof(clientOptions.Token), "Token can't be null");

            _clientOptions = clientOptions;
        }

        #endregion
    }
}
