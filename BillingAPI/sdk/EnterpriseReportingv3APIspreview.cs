// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BillingAPI
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// The Reporting APIs enable Enterprise Azure customers to
    /// programmatically pull consumption and billing data into preferred data
    /// analysis tools. Generate API Key on Enterprise portal and follow the
    /// tutorial under Help - Reporting APIs. The first section under this help
    /// article explains how to generate\retrieve the API key for the specified
    /// enrollment. &lt;a
    /// href="https://docs.microsoft.com/en-us/azure/billing/billing-enterprise-api"
    /// data-linktype="external"&gt;Billing Enterprise API official
    /// documentation&lt;/a&gt;
    /// </summary>
    public partial class EnterpriseReportingv3APIspreview : ServiceClient<EnterpriseReportingv3APIspreview>, IEnterpriseReportingv3APIspreview
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Gets the IMarketplacesV3.
        /// </summary>
        public virtual IMarketplacesV3 MarketplacesV3 { get; private set; }

        /// <summary>
        /// Gets the IPriceSheetsV3.
        /// </summary>
        public virtual IPriceSheetsV3 PriceSheetsV3 { get; private set; }

        /// <summary>
        /// Gets the IReservedInstancesV3.
        /// </summary>
        public virtual IReservedInstancesV3 ReservedInstancesV3 { get; private set; }

        /// <summary>
        /// Gets the IUsageDetailsV3.
        /// </summary>
        public virtual IUsageDetailsV3 UsageDetailsV3 { get; private set; }

        /// <summary>
        /// Initializes a new instance of the EnterpriseReportingv3APIspreview class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling EnterpriseReportingv3APIspreview.Dispose(). False: will not dispose provided httpClient</param>
        public EnterpriseReportingv3APIspreview(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the EnterpriseReportingv3APIspreview class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public EnterpriseReportingv3APIspreview(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the EnterpriseReportingv3APIspreview class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public EnterpriseReportingv3APIspreview(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the EnterpriseReportingv3APIspreview class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public EnterpriseReportingv3APIspreview(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the EnterpriseReportingv3APIspreview class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public EnterpriseReportingv3APIspreview(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            MarketplacesV3 = new MarketplacesV3(this);
            PriceSheetsV3 = new PriceSheetsV3(this);
            ReservedInstancesV3 = new ReservedInstancesV3(this);
            UsageDetailsV3 = new UsageDetailsV3(this);
            BaseUri = new System.Uri("https://consumption.azure.com:443");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
