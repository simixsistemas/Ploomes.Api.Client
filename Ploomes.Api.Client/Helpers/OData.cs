using Ploomes.Api.Client.Extensions;
using System.Text;

namespace Ploomes.Api.Client.Helpers {
    /// <summary>
    /// Open Data Protocol <see cref="https://www.odata.org/"/>
    /// </summary>
    public sealed class OData {
        #region Properties

        /// <summary>
        /// Api filter
        /// <see cref="https://www.odata.org/documentation/odata-version-2-0/uri-conventions/"/>
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Api uri sorting component
        /// <see cref="https://www.odata.org/documentation/odata-version-2-0/uri-conventions/"/>
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Top system query option
        /// <see cref="https://www.odata.org/documentation/odata-version-2-0/uri-conventions/"/>
        /// </summary>
        public int? Top { get; set; }

        /// <summary>
        /// Skip system query option
        /// <see cref="https://www.odata.org/documentation/odata-version-2-0/uri-conventions/"/>
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// Select system query option
        /// <see cref="https://www.odata.org/documentation/odata-version-2-0/uri-conventions/"/>
        /// </summary>
        public string Select { get; set; }

        /// <summary>
        /// Expand system query option
        /// <see cref="https://www.odata.org/documentation/odata-version-2-0/uri-conventions/"/>
        /// </summary>
        public string Expand { get; set; }

        #endregion

        #region Override Methods

        public override string ToString() {
            var stringBuilder = new StringBuilder();

            AppendProperty(ref stringBuilder, "filter", Filter);
            AppendProperty(ref stringBuilder, "orderby", OrderBy);
            AppendProperty(ref stringBuilder, "limit", Top?.ToString());
            AppendProperty(ref stringBuilder, "skip", Skip?.ToString());
            AppendProperty(ref stringBuilder, "select", Select);
            AppendProperty(ref stringBuilder, "expand", Expand);

            return stringBuilder.IsEmpty()
                ? string.Empty : $"?{stringBuilder.ToString()}";
        }

        #endregion

        #region Private Methods

        private void AppendProperty(ref StringBuilder stringBuilder, string propertyName, string propertyValue) {
            if (string.IsNullOrEmpty(propertyValue)) return;

            if (!stringBuilder.IsEmpty())
                stringBuilder.Append($"&");

            stringBuilder.Append($"${propertyName}={propertyValue}");
        }

        #endregion
    }
}
