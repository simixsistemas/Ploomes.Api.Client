using Ploomes.Api.Client.Abstractions;
using Ploomes.Api.Client.Helpers;
using Ploomes.Api.Client.Resources;
using System;

namespace Ploomes.Api.Client {
    /// <summary>
    /// Ploomes client
    /// </summary>
    public sealed class PloomesClient {
        #region Fields

        private static PloomesApiClientOptions _clientOptions;

        private readonly Lazy<IDealResource> _dealResouce =
            new Lazy<IDealResource>(() => new DealResource(_clientOptions.Token));

        private readonly Lazy<IContactResource> _contactResouce =
            new Lazy<IContactResource>(() => new ContactResource(_clientOptions.Token));

        #endregion

        #region Properties

        /// <summary>
        /// Deals Resources
        /// </summary>
        public IDealResource Deals => _dealResouce.Value;

        /// <summary>
        /// Contacts resources
        /// </summary>
        public IContactResource Contacts => _contactResouce.Value;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="clientOptions">Api client options</param>
        public PloomesClient(PloomesApiClientOptions clientOptions) {
            if (string.IsNullOrWhiteSpace(clientOptions.Token))
                throw new ArgumentNullException(nameof(clientOptions.Token), "Token can't be null");

            _clientOptions = clientOptions;
        }

        #endregion
    }
}
