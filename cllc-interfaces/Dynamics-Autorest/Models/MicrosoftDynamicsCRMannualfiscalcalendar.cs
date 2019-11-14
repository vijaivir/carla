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
    /// Microsoft.Dynamics.CRM.annualfiscalcalendar
    /// </summary>
    public partial class MicrosoftDynamicsCRMannualfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMannualfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMannualfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMannualfiscalcalendar class.
        /// </summary>
        /// <param name="userfiscalcalendarid">Unique identifier of the user
        /// associated with the annual fiscal calendar.</param>
        /// <param name="modifiedon">Date and time when the annual fiscal
        /// calendar was last modified.</param>
        /// <param name="fiscalperiodtype">Type of fiscal period used in the
        /// sales quota.</param>
        /// <param name="effectiveon">Date and time when the fiscal calendar
        /// sales quota takes effect.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the annualfiscalcalendar.</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the annual fiscal calendar with respect to the base
        /// currency.</param>
        /// <param name="_salespersonidValue">Unique identifier of the sales
        /// person associated with the sales quota.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the annualfiscalcalendar.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the quota for the annual fiscal calendar.</param>
        /// <param name="_transactioncurrencyidValue">Unique identifier of the
        /// currency associated with the annual fiscal calendar.</param>
        /// <param name="createdon">Date and time when the quota for the annual
        /// fiscal calendar was created.</param>
        /// <param name="annualBase">Base currency equivalent of the sales
        /// quota for the first period in the fiscal year.</param>
        /// <param name="annual">Sales quota for the first period in the fiscal
        /// year.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the quota for the annual fiscal calendar.</param>
        public MicrosoftDynamicsCRMannualfiscalcalendar(string userfiscalcalendarid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? fiscalperiodtype = default(int?), System.DateTimeOffset? effectiveon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _businessunitidValue = default(string), decimal? exchangerate = default(decimal?), string _salespersonidValue = default(string), string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedbyValue = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), decimal? annualBase = default(decimal?), decimal? annual = default(decimal?), int? timezoneruleversionnumber = default(int?), string _createdbyValue = default(string), IList<MicrosoftDynamicsCRMbulkdeletefailure> annualFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> annualFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser))
        {
            Userfiscalcalendarid = userfiscalcalendarid;
            Modifiedon = modifiedon;
            Fiscalperiodtype = fiscalperiodtype;
            Effectiveon = effectiveon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._businessunitidValue = _businessunitidValue;
            Exchangerate = exchangerate;
            this._salespersonidValue = _salespersonidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdon = createdon;
            AnnualBase = annualBase;
            Annual = annual;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdbyValue = _createdbyValue;
            AnnualFiscalCalendarBulkDeleteFailures = annualFiscalCalendarBulkDeleteFailures;
            AnnualFiscalCalendarAsyncOperations = annualFiscalCalendarAsyncOperations;
            Transactioncurrencyid = transactioncurrencyid;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Salespersonid = salespersonid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user associated with the
        /// annual fiscal calendar.
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// Gets or sets date and time when the annual fiscal calendar was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets type of fiscal period used in the sales quota.
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// Gets or sets date and time when the fiscal calendar sales quota
        /// takes effect.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public System.DateTimeOffset? Effectiveon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the annualfiscalcalendar.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// annual fiscal calendar with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the sales person associated with
        /// the sales quota.
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// annualfiscalcalendar.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// quota for the annual fiscal calendar.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the currency associated with the
        /// annual fiscal calendar.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the quota for the annual fiscal
        /// calendar was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets base currency equivalent of the sales quota for the
        /// first period in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "annual_base")]
        public decimal? AnnualBase { get; set; }

        /// <summary>
        /// Gets or sets sales quota for the first period in the fiscal year.
        /// </summary>
        [JsonProperty(PropertyName = "annual")]
        public decimal? Annual { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the quota
        /// for the annual fiscal calendar.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AnnualFiscalCalendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AnnualFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AnnualFiscalCalendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AnnualFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

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
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

    }
}
