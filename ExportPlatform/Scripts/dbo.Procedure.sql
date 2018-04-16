CREATE PROCEDURE [dbo].[Procedure]
	@idJob int = 1
AS
	SET NOCOUNT ON;
	SELECT * FROM dbo.ProcessingJobs

RETURN 0
GO
