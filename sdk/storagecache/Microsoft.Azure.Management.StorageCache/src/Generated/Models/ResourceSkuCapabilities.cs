// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A resource SKU capability.
    /// </summary>
    public partial class ResourceSkuCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSkuCapabilities class.
        /// </summary>
        public ResourceSkuCapabilities()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSkuCapabilities class.
        /// </summary>
        /// <param name="name">Name of a capability, such as ops/sec.</param>
        /// <param name="value">Quantity, if the capability is measured by
        /// quantity.</param>
        public ResourceSkuCapabilities(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of a capability, such as ops/sec.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets quantity, if the capability is measured by quantity.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
