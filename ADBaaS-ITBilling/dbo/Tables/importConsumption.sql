CREATE TABLE [dbo].[importConsumption] (
    [servicename]             VARCHAR (200)    NULL,
	[servicetier]			  VARCHAR (200)    NULL,
	[location]				  VARCHAR (200)    NULL,
	[chargesBilledSeparately] BIT			   NULL,
	[partnumber]              VARCHAR (200)    NULL,
	[resourceGuid]			  VARCHAR (200)    NULL,
	[offerId]				  VARCHAR (200)    NULL,
	[cost]                    DECIMAL (26, 15) NULL,
    [accountId]               INT              NULL,
    [productId]               INT              NULL,
    [resourceLocationId]      INT              NULL,
    [consumedServiceId]       INT              NULL,
    [departmentId]            INT              NULL,
    [accountOwnerEmail]       VARCHAR (200)    NULL,
    [accountName]             VARCHAR (200)    NULL,
    [serviceAdministratorId]  VARCHAR (200)    NULL,
    [subscriptionId]          BIGINT           NULL,
    [subscriptionGuid]        VARCHAR (50)     NULL,
    [subscriptionName]        VARCHAR (200)    NULL,
    [date]                    DATE             NULL,
    [product]                 VARCHAR (200)    NULL,
    [meterId]                 VARCHAR (200)    NULL,
    [meterCategory]           VARCHAR (200)    NULL,
    [meterSubCategory]        VARCHAR (200)    NULL,
    [meterRegion]             VARCHAR (200)    NULL,
    [meterName]               VARCHAR (200)    NULL,
    [consumedQuantity]        DECIMAL (26, 15) NULL,
    [resourceRate]            DECIMAL (26, 15) NULL,
    [resourceLocation]        VARCHAR (200)    NULL,
    [consumedService]         VARCHAR (200)    NULL,
    [instanceId]              VARCHAR (500)    NULL,
    [serviceInfo1]            VARCHAR (500)    NULL,
    [serviceInfo2]            VARCHAR (500)    NULL,
    [additionalInfo]          VARCHAR (MAX)    NULL,
    [tags]                    VARCHAR (MAX)    NULL,
    [storeServiceIdentifier]  VARCHAR (200)    NULL,
    [departmentName]          VARCHAR (200)    NULL,
    [costCenter]              VARCHAR (200)    NULL,
    [unitOfMeasure]           VARCHAR (50)     NULL,
    [resourceGroup]           VARCHAR (200)    NULL
);							  

GO
/****** Object:  Index [IX_meterId]    Script Date: 31.10.2017 08:56:40 ******/
CREATE NONCLUSTERED INDEX [IX_meterId] ON [dbo].[importConsumption]
(
	[meterId] ASC
)
INCLUDE ( 	[subscriptionId],
	[instanceId],
	[resourceGroup]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
