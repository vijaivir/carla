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

    public partial class MicrosoftDynamicsCRMadoxioContravention
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContravention class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContravention()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContravention class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContravention(string _adoxioComplaintValue = default(string), string _adoxioInspectionValue = default(string), string _adoxioInvestigationValue = default(string), string _adoxioLicenceValue = default(string), string _adoxioViolationproductValue = default(string), string _adoxioViolationtypeValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _transactioncurrencyidValue = default(string), MicrosoftDynamicsCRMadoxioComplaint adoxioComplaint = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMincident adoxioInspection = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMadoxioInvestigation adoxioInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences adoxioLicence = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMproduct adoxioViolationProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMadoxioViolationtype adoxioViolationType = default(MicrosoftDynamicsCRMadoxioViolationtype), IList<MicrosoftDynamicsCRMadoxioViolationnotification> adoxioAdoxioContraventionAdoxioViolationnotificationRelatedContravention = default(IList<MicrosoftDynamicsCRMadoxioViolationnotification>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioContraventionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioContraventionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsyncerror> adoxioContraventionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), System.DateTimeOffset? adoxioContraventiondatetime = default(System.DateTimeOffset?), string adoxioContraventionid = default(string), string adoxioContraventionnoticenumber = default(string), int? adoxioContraventionoutcome = default(int?), string adoxioGmrational = default(string), int? adoxioIsalternative = default(int?), string adoxioManagerpenaltytext = default(string), double? adoxioMonetarypenalty = default(double?), double? adoxioMonetarypenaltyBase = default(double?), string adoxioName = default(string), string adoxioOtherfactors = default(string), bool? adoxioOutcome = default(bool?), string adoxioPenaltyexecuted = default(string), string adoxioSection = default(string), int? adoxioSuspensionpenalty = default(int?), string adoxioWipenaltyreason = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), double? exchangerate = default(double?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), int? statecode = default(int?), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object))
        {
            this._adoxioComplaintValue = _adoxioComplaintValue;
            this._adoxioInspectionValue = _adoxioInspectionValue;
            this._adoxioInvestigationValue = _adoxioInvestigationValue;
            this._adoxioLicenceValue = _adoxioLicenceValue;
            this._adoxioViolationproductValue = _adoxioViolationproductValue;
            this._adoxioViolationtypeValue = _adoxioViolationtypeValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            AdoxioComplaint = adoxioComplaint;
            AdoxioInspection = adoxioInspection;
            AdoxioInvestigation = adoxioInvestigation;
            AdoxioLicence = adoxioLicence;
            AdoxioViolationProduct = adoxioViolationProduct;
            AdoxioViolationType = adoxioViolationType;
            AdoxioAdoxioContraventionAdoxioViolationnotificationRelatedContravention = adoxioAdoxioContraventionAdoxioViolationnotificationRelatedContravention;
            AdoxioContraventionAsyncOperations = adoxioContraventionAsyncOperations;
            AdoxioContraventionBulkDeleteFailures = adoxioContraventionBulkDeleteFailures;
            AdoxioContraventionDuplicateBaseRecord = adoxioContraventionDuplicateBaseRecord;
            AdoxioContraventionDuplicateMatchingRecord = adoxioContraventionDuplicateMatchingRecord;
            AdoxioContraventionSyncErrors = adoxioContraventionSyncErrors;
            AdoxioContraventiondatetime = adoxioContraventiondatetime;
            AdoxioContraventionid = adoxioContraventionid;
            AdoxioContraventionnoticenumber = adoxioContraventionnoticenumber;
            AdoxioContraventionoutcome = adoxioContraventionoutcome;
            AdoxioGmrational = adoxioGmrational;
            AdoxioIsalternative = adoxioIsalternative;
            AdoxioManagerpenaltytext = adoxioManagerpenaltytext;
            AdoxioMonetarypenalty = adoxioMonetarypenalty;
            AdoxioMonetarypenaltyBase = adoxioMonetarypenaltyBase;
            AdoxioName = adoxioName;
            AdoxioOtherfactors = adoxioOtherfactors;
            AdoxioOutcome = adoxioOutcome;
            AdoxioPenaltyexecuted = adoxioPenaltyexecuted;
            AdoxioSection = adoxioSection;
            AdoxioSuspensionpenalty = adoxioSuspensionpenalty;
            AdoxioWipenaltyreason = adoxioWipenaltyreason;
            Createdbyname = createdbyname;
            Createdon = createdon;
            Createdonbehalfbyname = createdonbehalfbyname;
            Exchangerate = exchangerate;
            Importsequencenumber = importsequencenumber;
            Modifiedbyname = modifiedbyname;
            Modifiedon = modifiedon;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Overriddencreatedon = overriddencreatedon;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Statecode = statecode;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Transactioncurrencyid = transactioncurrencyid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_complaint_value")]
        public string _adoxioComplaintValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspection_value")]
        public string _adoxioInspectionValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_investigation_value")]
        public string _adoxioInvestigationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licence_value")]
        public string _adoxioLicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_violationproduct_value")]
        public string _adoxioViolationproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_violationtype_value")]
        public string _adoxioViolationtypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Complaint")]
        public MicrosoftDynamicsCRMadoxioComplaint AdoxioComplaint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Inspection")]
        public MicrosoftDynamicsCRMincident AdoxioInspection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Investigation")]
        public MicrosoftDynamicsCRMadoxioInvestigation AdoxioInvestigation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ViolationProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioViolationProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ViolationType")]
        public MicrosoftDynamicsCRMadoxioViolationtype AdoxioViolationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_contravention_adoxio_violationnotification_RelatedContravention")]
        public IList<MicrosoftDynamicsCRMadoxioViolationnotification> AdoxioAdoxioContraventionAdoxioViolationnotificationRelatedContravention { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioContraventionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioContraventionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioContraventionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioContraventionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioContraventionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventiondatetime")]
        public System.DateTimeOffset? AdoxioContraventiondatetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionid")]
        public string AdoxioContraventionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionnoticenumber")]
        public string AdoxioContraventionnoticenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionoutcome")]
        public int? AdoxioContraventionoutcome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_gmrational")]
        public string AdoxioGmrational { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isalternative")]
        public int? AdoxioIsalternative { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_managerpenaltytext")]
        public string AdoxioManagerpenaltytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_monetarypenalty")]
        public double? AdoxioMonetarypenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_monetarypenalty_base")]
        public double? AdoxioMonetarypenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_otherfactors")]
        public string AdoxioOtherfactors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_outcome")]
        public bool? AdoxioOutcome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_penaltyexecuted")]
        public string AdoxioPenaltyexecuted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_section")]
        public string AdoxioSection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_suspensionpenalty")]
        public int? AdoxioSuspensionpenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_wipenaltyreason")]
        public string AdoxioWipenaltyreason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
