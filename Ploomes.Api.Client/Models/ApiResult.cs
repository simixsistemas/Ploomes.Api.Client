using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ploomes.Api.Client.Models {
    /// <summary>
    /// Ploomes api default response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class ApiResult<T> where T : class {
        /// <summary>
        /// Api response context
        /// </summary>
        [JsonProperty("odatacontext")]
        public string Context { get; set; }

        /// <summary>
        /// Api response value
        /// </summary>
        [JsonProperty("value")]
        public IEnumerable<T> Results { get; set; }
    }
}
