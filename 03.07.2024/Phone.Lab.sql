
DECLARE @code varchar(5), @operator varchar(5), @number varchar(20), @phone varchar(50) = '+90(532)123 45 55';

SELECT @code = LEFT(@phone, CHARINDEX('(',@phone) - 1),
		@operator = SUBSTRING(@phone, CHARINDEX('(', @phone) + 1 , CHARINDEX(')', @phone) - CHARINDEX('(',@phone) - 1),
		@number = RIGHT(@phone, LEN(@phone) - CHARINDEX(')', @phone))

PRINT 'Phone    : ' + @phone + CHAR(13) + 
      'Code     : ' + @code  + CHAR(13) + 
      'Operator : ' + @operator + CHAR(13) + 
      'Number   : ' + @number;