SELECT [j30c_editorial_id]
      ,[j30c_action]
      ,[j30c_user_name]
      ,[j30c_date]
	  ,convert(varchar(10), dateadd(second, [j30c_date] /1000 - 4 * 60 * 60, '19700101'), 11) as j30c_converted_date
      ,[j30c_description]
      ,[j30c_path]
FROM [Mediabeacon].[dbo].[j30t_changelog]
WHERE [j30c_user_name] = 'jchaves'
ORDER by [j30c_date]

select distinct j30c_action from j30t_changelog

select j30c_user_name, j30c_converted_date,
	[login] as LoginAction, [delete] as DeleteAction, [download] as DownloadAction, [export] as ExportAction, [failedLogin] as FailedLoginAction
from
    (select 
		j30c_user_name, convert(varchar(10), dateadd(second, [j30c_date] /1000 - 4 * 60 * 60, '19700101'), 11) as j30c_converted_date, j30c_action 
	from 
		j30t_changelog
	where
		j30c_user_name like 'jchaves'
    ) as ps
pivot
    (count(j30c_action) for j30c_action in 
		([login], [delete], [download], [failedLogin], [export])
    ) as pvt
