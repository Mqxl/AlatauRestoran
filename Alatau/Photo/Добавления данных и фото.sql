INSERT INTO dbo.Napitki(��������,������,����,����) 
SELECT '������������ �������','0.5','150', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture

INSERT INTO dbo.Napitki(��������,������,����,����) 
SELECT '������������ �������','1','200', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture


INSERT INTO dbo.Napitki(��������,������,����,����) 
SELECT '������������ �������','1.5','250', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture


INSERT INTO dbo.Napitki(��������,������,����,����) 
SELECT '������������ �������','2','350', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture

INSERT INTO dbo.Napitki(��������,������,����,����) 
SELECT '���','0.3','100', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture

INSERT INTO dbo.Napitki(��������,������,����,����) 
SELECT '����','0.3','100', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture










