/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [Key]
      ,[Content]
      ,[Id]
      ,[When]
      ,[Room_Key]
      ,[User_Key]
      ,[HtmlEncoded]
      ,[HtmlContent]
      ,[ImageUrl]
      ,[Source]
      ,[MessageType]
  FROM [andyweb_jabbr].[dbo].[ChatMessages]
  
  DELETE FROM ChatMessages where Room_Key = (SELECT c.[Key] FROM ChatRooms c WHERE c.Name = 'General') AND [When] < DATEADD(HOUR, -1, GETDATE())