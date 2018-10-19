using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BillingAPI.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BillingAPI
{

    /// <summary>
    /// Erstellung der RestAPI siehe https://github.com/Azure/autorest/blob/master/docs/generating-a-client.md
    /// Beispiel:
    /// C:\Users\dzeller>autorest --input-file=https://consumption.azure.com/swagger/docs/v3 --csharp --output-folder=BillingAPI --namespace=BillingAPI
    /// </summary>
    class Program
    {        
        private static string _connectionString = "";
        private static string _enrollmentNumber = "";
        private static string _apiKey = ""; 

        static void Main(string[] args)
        {
            ReadSettings();
         
            var consumptionTable = PrepareDataTable();
            var api = GetAuthenticatedApiHandle();

            var startDate = GetMaxConsumptionDate();
            var consumptionData = api.UsageDetailsV3.Get(_enrollmentNumber, startDate, DateTime.Now.Date);
            AddToTable(consumptionTable, consumptionData.Data);
            
            while (!String.IsNullOrEmpty(consumptionData.NextLink))
            {
                var res = api.HttpClient.GetAsync(consumptionData.NextLink).GetAwaiter().GetResult();
                var content = res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                consumptionData = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<PagedJsonDataTitaniumJuly>(content, api.DeserializationSettings);
                AddToTable(consumptionTable, consumptionData.Data);
            }

            SaveData(consumptionTable);
        }

        private static void ReadSettings()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AzureConsumption"].ConnectionString;
            _enrollmentNumber = ConfigurationManager.AppSettings["EnrollmentNumber"].ToString();
            _apiKey = ConfigurationManager.AppSettings["ApiKey"].ToString();
        }

        private static EnterpriseReportingv3APIspreview GetAuthenticatedApiHandle()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);
            return new EnterpriseReportingv3APIspreview(httpClient, true);
        }

        static void SaveData(DataTable consumptionTable)
        {            
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.BulkCopyTimeout = 1000;
                    bulkCopy.DestinationTableName = "dbo.importConsumption";
                    bulkCopy.WriteToServer(consumptionTable);
                }                
            }
        }

        private static DateTime GetMaxConsumptionDate()
        {
            DateTime startTime;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("dbo.uspGetMaxConsumptionDate", connection) { CommandType = CommandType.StoredProcedure })
                {
                    startTime = (DateTime)command.ExecuteScalar();
                }
            }

            return startTime;
        }

        static DataTable PrepareDataTable()
        {
            var table = new DataTable("Consumption");

            table.Columns.Add("serviceName", typeof(string));
            table.Columns.Add("serviceTier", typeof(string)); 
            table.Columns.Add("location", typeof(string));
            table.Columns.Add("chargesBilledSeparately", typeof(bool));
            table.Columns.Add("partNumber", typeof(string));
            table.Columns.Add("resourceGuid", typeof(string));
            table.Columns.Add("offerId", typeof(string));
            table.Columns.Add("cost", typeof(double));
            table.Columns.Add("accountId", typeof(int));
            table.Columns.Add("productId", typeof(int));
            table.Columns.Add("resourceLocationId", typeof(int));
            table.Columns.Add("consumedServiceId", typeof(int));
            table.Columns.Add("departmentId", typeof(int));
            table.Columns.Add("accountOwnerEmail", typeof(string));
            table.Columns.Add("accountName", typeof(string));
            table.Columns.Add("serviceAdministratorId", typeof(string));
            table.Columns.Add("subscriptionId", typeof(long));
            table.Columns.Add("subscriptionGuid", typeof(string));
            table.Columns.Add("subscriptionName", typeof(string));
            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("product", typeof(string));
            table.Columns.Add("meterId", typeof(string));
            table.Columns.Add("meterCategory", typeof(string));
            table.Columns.Add("meterSubCategory", typeof(string));
            table.Columns.Add("meterRegion", typeof(string));
            table.Columns.Add("meterName", typeof(string));
            table.Columns.Add("consumedQuantity", typeof(double));
            table.Columns.Add("resourceRate", typeof(double));
            table.Columns.Add("resourceLocation", typeof(string));
            table.Columns.Add("consumedService", typeof(string));
            table.Columns.Add("instanceId", typeof(string));
            table.Columns.Add("serviceInfo1", typeof(string));
            table.Columns.Add("serviceInfo2", typeof(string));
            table.Columns.Add("additionalInfo", typeof(string));
            table.Columns.Add("tags", typeof(string));
            table.Columns.Add("storeServiceIdentifier", typeof(string));
            table.Columns.Add("departmentName", typeof(string));
            table.Columns.Add("costCenter", typeof(string));
            table.Columns.Add("unitOfMeasure", typeof(string));
            table.Columns.Add("resourceGroup", typeof(string));

            return table;
        }

        static void AddToTable(DataTable table, IList<UsageDetailsDeNormalizedTitaniumJuly> consumption)
        {
            foreach (var item in consumption)
            {
                var row = table.NewRow();
                row["serviceName"] = item.ServiceName;
                row["serviceTier"] = item.ServiceTier;
                row["location"] = item.Location;
                row["chargesBilledSeparately"] = item.ChargesBilledSeparately;
                row["partNumber"] = item.PartNumber;
                row["resourceGuid"] = item.ResourceGuid;
                row["offerId"] = item.OfferId;
                row["cost"] = item.Cost;
                row["accountId"] = item.AccountId;
                row["productId"] = item.ProductId;
                row["resourceLocationId"] = item.ResourceLocationId;
                row["consumedServiceId"] = item.ConsumedServiceId;
                row["departmentId"] = item.DepartmentId;
                row["accountOwnerEmail"] = item.AccountOwnerEmail;
                row["accountName"] = item.AccountName;
                row["serviceAdministratorId"] = item.ServiceAdministratorId;
                row["subscriptionId"] = item.SubscriptionId;
                row["subscriptionGuid"] = item.SubscriptionGuid;
                row["subscriptionName"] = item.SubscriptionName;
                row["date"] = item.Date;
                row["product"] = item.Product;
                row["meterId"] = item.MeterId;
                row["meterCategory"] = item.MeterCategory;
                row["meterSubCategory"] = item.MeterSubCategory;
                row["meterRegion"] = item.MeterRegion;
                row["meterName"] = item.MeterName;
                row["consumedQuantity"] = item.ConsumedQuantity;
                row["resourceRate"] = item.ResourceRate;
                row["resourceLocation"] = item.ResourceLocation;
                row["consumedService"] = item.ConsumedService;
                row["instanceId"] = item.InstanceId;
                row["serviceInfo1"] = item.ServiceInfo1;
                row["serviceInfo2"] = item.ServiceInfo2;
                row["additionalInfo"] = item.AdditionalInfo;
                row["tags"] = item.Tags;
                row["storeServiceIdentifier"] = item.StoreServiceIdentifier;
                row["departmentName"] = item.DepartmentName;
                row["costCenter"] = item.CostCenter;
                row["unitOfMeasure"] = item.UnitOfMeasure;
                row["resourceGroup"] = item.ResourceGroup;

                table.Rows.Add(row);
            }
        }
    }
}
