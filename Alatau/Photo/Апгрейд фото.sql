UPDATE dbo.Officiant
SET ���� = BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Officiant\123.jpg', Single_Blob) as EmployeePicture
WHERE ������� = 23
