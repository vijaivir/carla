// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMMetadataBase
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMMetadataBase
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMMetadataBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMMetadataBase
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMMetadataBase(bool? hasChanged = default(bool?), string metadataId = default(string))
        {
            HasChanged = hasChanged;
            MetadataId = metadataId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasChanged")]
        public bool? HasChanged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataId")]
        public string MetadataId { get; set; }

    }
}
