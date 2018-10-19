// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BillingAPI.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UsageDetailsDeNormalizedTitaniumJuly
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UsageDetailsDeNormalizedTitaniumJuly class.
        /// </summary>
        public UsageDetailsDeNormalizedTitaniumJuly()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UsageDetailsDeNormalizedTitaniumJuly class.
        /// </summary>
        public UsageDetailsDeNormalizedTitaniumJuly(string serviceName = default(string), string serviceTier = default(string), string location = default(string), bool? chargesBilledSeparately = default(bool?), string partNumber = default(string), string resourceGuid = default(string), string offerId = default(string), double? cost = default(double?), int? accountId = default(int?), int? productId = default(int?), int? resourceLocationId = default(int?), int? consumedServiceId = default(int?), int? departmentId = default(int?), string accountOwnerEmail = default(string), string accountName = default(string), string serviceAdministratorId = default(string), long? subscriptionId = default(long?), string subscriptionGuid = default(string), string subscriptionName = default(string), System.DateTime? date = default(System.DateTime?), string product = default(string), string meterId = default(string), string meterCategory = default(string), string meterSubCategory = default(string), string meterRegion = default(string), string meterName = default(string), double? consumedQuantity = default(double?), double? resourceRate = default(double?), string resourceLocation = default(string), string consumedService = default(string), string instanceId = default(string), string serviceInfo1 = default(string), string serviceInfo2 = default(string), string additionalInfo = default(string), string tags = default(string), string storeServiceIdentifier = default(string), string departmentName = default(string), string costCenter = default(string), string unitOfMeasure = default(string), string resourceGroup = default(string))
        {
            ServiceName = serviceName;
            ServiceTier = serviceTier;
            Location = location;
            ChargesBilledSeparately = chargesBilledSeparately;
            PartNumber = partNumber;
            ResourceGuid = resourceGuid;
            OfferId = offerId;
            Cost = cost;
            AccountId = accountId;
            ProductId = productId;
            ResourceLocationId = resourceLocationId;
            ConsumedServiceId = consumedServiceId;
            DepartmentId = departmentId;
            AccountOwnerEmail = accountOwnerEmail;
            AccountName = accountName;
            ServiceAdministratorId = serviceAdministratorId;
            SubscriptionId = subscriptionId;
            SubscriptionGuid = subscriptionGuid;
            SubscriptionName = subscriptionName;
            Date = date;
            Product = product;
            MeterId = meterId;
            MeterCategory = meterCategory;
            MeterSubCategory = meterSubCategory;
            MeterRegion = meterRegion;
            MeterName = meterName;
            ConsumedQuantity = consumedQuantity;
            ResourceRate = resourceRate;
            ResourceLocation = resourceLocation;
            ConsumedService = consumedService;
            InstanceId = instanceId;
            ServiceInfo1 = serviceInfo1;
            ServiceInfo2 = serviceInfo2;
            AdditionalInfo = additionalInfo;
            Tags = tags;
            StoreServiceIdentifier = storeServiceIdentifier;
            DepartmentName = departmentName;
            CostCenter = costCenter;
            UnitOfMeasure = unitOfMeasure;
            ResourceGroup = resourceGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceTier")]
        public string ServiceTier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "chargesBilledSeparately")]
        public bool? ChargesBilledSeparately { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partNumber")]
        public string PartNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "offerId")]
        public string OfferId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productId")]
        public int? ProductId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceLocationId")]
        public int? ResourceLocationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "consumedServiceId")]
        public int? ConsumedServiceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "departmentId")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountOwnerEmail")]
        public string AccountOwnerEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceAdministratorId")]
        public string ServiceAdministratorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public long? SubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionGuid")]
        public string SubscriptionGuid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionName")]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "meterId")]
        public string MeterId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "meterCategory")]
        public string MeterCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "meterSubCategory")]
        public string MeterSubCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "meterRegion")]
        public string MeterRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "meterName")]
        public string MeterName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "consumedQuantity")]
        public double? ConsumedQuantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceRate")]
        public double? ResourceRate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceLocation")]
        public string ResourceLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "consumedService")]
        public string ConsumedService { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceInfo1")]
        public string ServiceInfo1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceInfo2")]
        public string ServiceInfo2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "storeServiceIdentifier")]
        public string StoreServiceIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "departmentName")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "costCenter")]
        public string CostCenter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitOfMeasure")]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

    }
}