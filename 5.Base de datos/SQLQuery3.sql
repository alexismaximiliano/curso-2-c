/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Titulo]
      ,[FechaLanzamiento]
      ,[CantidadCanciones]
      ,[UrlImagenTapa]
      ,[IdEstilo]
      ,[IdTipoEdicion]
  FROM [DISCOS_DB].[dbo].[DISCOS]

  select 