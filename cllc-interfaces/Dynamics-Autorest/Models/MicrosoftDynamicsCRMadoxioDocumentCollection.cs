// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of adoxio_document
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_documentCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioDocumentCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioDocumentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioDocumentCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioDocumentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioDocumentCollection(IList<MicrosoftDynamicsCRMadoxioDocument> value = default(IList<MicrosoftDynamicsCRMadoxioDocument>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioDocument> Value { get; set; }

    }
}
