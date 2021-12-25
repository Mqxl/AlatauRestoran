INSERT INTO dbo.Napitki(Название,Размер,Цена,Фото) 
SELECT 'Газированный напиток','0.5','150', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture

INSERT INTO dbo.Napitki(Название,Размер,Цена,Фото) 
SELECT 'Газированный напиток','1','200', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture


INSERT INTO dbo.Napitki(Название,Размер,Цена,Фото) 
SELECT 'Газированный напиток','1.5','250', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture


INSERT INTO dbo.Napitki(Название,Размер,Цена,Фото) 
SELECT 'Газированный напиток','2','350', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture

INSERT INTO dbo.Napitki(Название,Размер,Цена,Фото) 
SELECT 'Чай','0.3','100', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture

INSERT INTO dbo.Napitki(Название,Размер,Цена,Фото) 
SELECT 'Кофе','0.3','100', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\Selim\source\repos\Alatau\Alatau\Photo\Povar\123.jpg', Single_Blob) as EmployeePicture










