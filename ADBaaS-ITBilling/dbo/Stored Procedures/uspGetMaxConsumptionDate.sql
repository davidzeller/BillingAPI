-- =============================================
-- Author:		Michael Müller
-- Create date: 2017-06-12
-- Description:	Get last import date
-- =============================================
CREATE PROCEDURE [dbo].[uspGetMaxConsumptionDate] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE FROM importConsumption WHERE [date] > GETDATE()-5

	SELECT isnull(max(date), convert(date, '2017-01-01')) FROM importConsumption
END