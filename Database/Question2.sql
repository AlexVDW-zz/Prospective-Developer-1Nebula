UPDATE [Database].[dbo].[Employee]
SET [email] = CONCAT(
			SUBSTRING([email], 1, CHARINDEX('@',[email], 1) /*everything up until the first '@'*/ ), --user
			'company',  -- host
			SUBSTRING([email], CHARINDEX('.',[email], CHARINDEX('@',[email],1) /*first '.' after the host*/), LEN([email])) --domain
			);