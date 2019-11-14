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
    /// Microsoft.Dynamics.CRM.mobileofflineprofile
    /// </summary>
    public partial class MicrosoftDynamicsCRMmobileofflineprofile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMmobileofflineprofile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofile class.
        /// </summary>
        /// <param name="selectedentitymetadata">Internal Use Only</param>
        /// <param name="mobileofflineprofileid">Unique identifier of the
        /// mobile offline profile.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="ismanaged">For internal use only.</param>
        /// <param name="stageid">Shows the ID of the stage.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="name">Enter the name of the mobile offline
        /// profile.</param>
        /// <param name="processid">Shows the ID of the process.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="mobileofflineprofileidunique">For Internal Use
        /// Only</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="description">Enter a description of the mobile offline
        /// profile.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the Mobile Offline Profile.</param>
        /// <param name="traversedpath">For internal use only.</param>
        /// <param name="publishedon">Displays the last published date
        /// time.</param>
        /// <param name="isvalidated">Information about whether profile is
        /// validated or not</param>
        /// <param name="versionnumber">Version number of the Mobile Offline
        /// Profile.</param>
        /// <param name="introducedversion">Version in which the Mobile offline
        /// Profile is introduced.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who updated the record
        /// on behalf of another user.</param>
        public MicrosoftDynamicsCRMmobileofflineprofile(string selectedentitymetadata = default(string), string mobileofflineprofileid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? ismanaged = default(bool?), string stageid = default(string), string solutionid = default(string), string _modifiedbyValue = default(string), string name = default(string), string processid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string mobileofflineprofileidunique = default(string), string _createdonbehalfbyValue = default(string), int? componentstate = default(int?), string description = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _organizationidValue = default(string), string traversedpath = default(string), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), bool? isvalidated = default(bool?), string versionnumber = default(string), string introducedversion = default(string), string _modifiedonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMorganization> defaultMobileOfflineProfileOrganization = default(IList<MicrosoftDynamicsCRMorganization>), IList<MicrosoftDynamicsCRMmobileofflineprofileitem> mobileOfflineProfileMobileOfflineProfileItem = default(IList<MicrosoftDynamicsCRMmobileofflineprofileitem>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsystemuser> mobileOfflineProfileSystemUser = default(IList<MicrosoftDynamicsCRMsystemuser>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Selectedentitymetadata = selectedentitymetadata;
            Mobileofflineprofileid = mobileofflineprofileid;
            Modifiedon = modifiedon;
            Ismanaged = ismanaged;
            Stageid = stageid;
            Solutionid = solutionid;
            this._modifiedbyValue = _modifiedbyValue;
            Name = name;
            Processid = processid;
            Overwritetime = overwritetime;
            Mobileofflineprofileidunique = mobileofflineprofileidunique;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Componentstate = componentstate;
            Description = description;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            this._organizationidValue = _organizationidValue;
            Traversedpath = traversedpath;
            Publishedon = publishedon;
            Isvalidated = isvalidated;
            Versionnumber = versionnumber;
            Introducedversion = introducedversion;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedonbehalfby = modifiedonbehalfby;
            DefaultMobileOfflineProfileOrganization = defaultMobileOfflineProfileOrganization;
            MobileOfflineProfileMobileOfflineProfileItem = mobileOfflineProfileMobileOfflineProfileItem;
            Organizationid = organizationid;
            Createdby = createdby;
            Modifiedby = modifiedby;
            MobileOfflineProfileSystemUser = mobileOfflineProfileSystemUser;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets internal Use Only
        /// </summary>
        [JsonProperty(PropertyName = "selectedentitymetadata")]
        public string Selectedentitymetadata { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the mobile offline profile.
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileid")]
        public string Mobileofflineprofileid { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the stage.
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets enter the name of the mobile offline profile.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the process.
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets for Internal Use Only
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileidunique")]
        public string Mobileofflineprofileidunique { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets enter a description of the mobile offline profile.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the Mobile Offline Profile.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// Gets or sets displays the last published date time.
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// Gets or sets information about whether profile is validated or not
        /// </summary>
        [JsonProperty(PropertyName = "isvalidated")]
        public bool? Isvalidated { get; set; }

        /// <summary>
        /// Gets or sets version number of the Mobile Offline Profile.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets version in which the Mobile offline Profile is
        /// introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// Gets or sets shows who updated the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultMobileOfflineProfile_Organization")]
        public IList<MicrosoftDynamicsCRMorganization> DefaultMobileOfflineProfileOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineProfile_MobileOfflineProfileItem")]
        public IList<MicrosoftDynamicsCRMmobileofflineprofileitem> MobileOfflineProfileMobileOfflineProfileItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineProfile_SystemUser")]
        public IList<MicrosoftDynamicsCRMsystemuser> MobileOfflineProfileSystemUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
