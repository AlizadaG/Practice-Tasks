DECLARE @firstName nvarchar(50), @lastName nvarchar(50), @mail nvarchar(100) = 'gozal.alizada@code.az', @domain varchar(20), @extension varchar(10), @test varchar(10);

SELECT @firstName = SUBSTRING(@mail, 1, CHARINDEX('.', @mail)),
		@lastName = SUBSTRING(@mail, CHARINDEX('.', @mail) + 1 , CHARINDEX('@', @mail) - CHARINDEX('.', @mail) - 1),
		@test = SUBSTRING(@mail, CHARINDEX('@', @mail) + 1 , CHARINDEX('@', @mail) + len(@mail))
		
SELECT @domain = SUBSTRING(@test, 0, CHARINDEX('.', @mail) - 1),
		@extension = SUBSTRING(@test, CHARINDEX('.', @mail), len(@test))

SELECT @firstName =  UPPER(SUBSTRING(@firstName, 1 , 1)) + SUBSTRING(@firstName, 2 , len(@firstName)),
		@lastName = UPPER(SUBSTRING(@lastName, 1 , 1)) + SUBSTRING(@lastName, 2 , len(@lastName))


PRINT N'Adı'+ ':'+ @firstName + N'
Soyadı' + ':'+ @lastName+   N'           
Mail' + ':'+ @mail + N'
Domain' +  ':'+ @domain + N'
Extension' + ':'+ @extension

