USE AndyWeb;
GO

EXEC sp_MSforeachtable 'DELETE FROM ?';