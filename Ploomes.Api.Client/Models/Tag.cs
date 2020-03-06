using Newtonsoft.Json;

namespace Ploomes.Api.Client.Models {
    /// <remarks/>
    public sealed class Tag {
        /// <remarks/>
        [JsonProperty("Tag")]
        public TagContent Content { get; set; }
    }

    /// <remarks/>
    public class TagContent {
        /// <remarks/>
        public int Id { get; set; }
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public string Color { get; set; }
        /// <remarks/>
        public int EntityId { get; set; }
    }
}
