// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.customcontroldefaultconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMcustomcontroldefaultconfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcustomcontroldefaultconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomcontroldefaultconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcustomcontroldefaultconfig class.
        /// </summary>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="primaryentitytypecode">Entity Type Code of the Custom
        /// Control Default Config.</param>
        /// <param name="introducedversion">Version in which the form is
        /// introduced.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="customcontroldefaultconfigidunique">For internal use
        /// only.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="versionnumber">Version number of the Custom Control
        /// Default Config.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the web resource.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="controldescriptionxml">controlDescriptionXML of the
        /// custom control default config.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="eventsxml">The events XML of the custom control
        /// default config.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="customcontroldefaultconfigid">Unique identifier of the
        /// Custom Control Default Config for the Microsoft Dynamics
        /// 365.</param>
        public MicrosoftDynamicsCRMcustomcontroldefaultconfig(string _createdbyValue = default(string), string primaryentitytypecode = default(string), string introducedversion = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string customcontroldefaultconfigidunique = default(string), int? componentstate = default(int?), string versionnumber = default(string), string _organizationidValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string solutionid = default(string), string controldescriptionxml = default(string), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), string eventsxml = default(string), bool? ismanaged = default(bool?), string _modifiedonbehalfbyValue = default(string), string customcontroldefaultconfigid = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._createdbyValue = _createdbyValue;
            Primaryentitytypecode = primaryentitytypecode;
            Introducedversion = introducedversion;
            Createdon = createdon;
            Customcontroldefaultconfigidunique = customcontroldefaultconfigidunique;
            Componentstate = componentstate;
            Versionnumber = versionnumber;
            this._organizationidValue = _organizationidValue;
            Overwritetime = overwritetime;
            Modifiedon = modifiedon;
            Solutionid = solutionid;
            Controldescriptionxml = controldescriptionxml;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Eventsxml = eventsxml;
            Ismanaged = ismanaged;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Customcontroldefaultconfigid = customcontroldefaultconfigid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets entity Type Code of the Custom Control Default Config.
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// Gets or sets version in which the form is introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "customcontroldefaultconfigidunique")]
        public string Customcontroldefaultconfigidunique { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets version number of the Custom Control Default Config.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the web resource.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// Gets or sets controlDescriptionXML of the custom control default
        /// config.
        /// </summary>
        [JsonProperty(PropertyName = "controldescriptionxml")]
        public string Controldescriptionxml { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets the events XML of the custom control default config.
        /// </summary>
        [JsonProperty(PropertyName = "eventsxml")]
        public string Eventsxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the Custom Control Default Config
        /// for the Microsoft Dynamics 365.
        /// </summary>
        [JsonProperty(PropertyName = "customcontroldefaultconfigid")]
        public string Customcontroldefaultconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
