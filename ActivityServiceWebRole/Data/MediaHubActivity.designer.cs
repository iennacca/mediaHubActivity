﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivityServiceWebRole.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mediaHubActivity")]
	public partial class MediaHubActivityDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public MediaHubActivityDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["mediaHubActivityConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MediaHubActivityDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MediaHubActivityDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MediaHubActivityDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MediaHubActivityDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ActivityDetail> ActivityDetails
		{
			get
			{
				return this.GetTable<ActivityDetail>();
			}
		}
		
		public System.Data.Linq.Table<j30t_changelog> j30t_changelogs
		{
			get
			{
				return this.GetTable<j30t_changelog>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ActivityDetails")]
	public partial class ActivityDetail
	{
		
		private System.Nullable<long> _j30c_editorial_id;
		
		private string _j30c_action;
		
		private string _j30c_user_name;
		
		private System.Nullable<long> _j30c_date;
		
		private string _j30c_description;
		
		private string _j30c_path;
		
		private System.Nullable<int> _j30c_event_type;
		
		private string _j30c_title;
		
		public ActivityDetail()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_editorial_id", DbType="BigInt")]
		public System.Nullable<long> j30c_editorial_id
		{
			get
			{
				return this._j30c_editorial_id;
			}
			set
			{
				if ((this._j30c_editorial_id != value))
				{
					this._j30c_editorial_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_action", DbType="NVarChar(32)")]
		public string j30c_action
		{
			get
			{
				return this._j30c_action;
			}
			set
			{
				if ((this._j30c_action != value))
				{
					this._j30c_action = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_user_name", DbType="NVarChar(255)")]
		public string j30c_user_name
		{
			get
			{
				return this._j30c_user_name;
			}
			set
			{
				if ((this._j30c_user_name != value))
				{
					this._j30c_user_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_date", DbType="BigInt")]
		public System.Nullable<long> j30c_date
		{
			get
			{
				return this._j30c_date;
			}
			set
			{
				if ((this._j30c_date != value))
				{
					this._j30c_date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string j30c_description
		{
			get
			{
				return this._j30c_description;
			}
			set
			{
				if ((this._j30c_description != value))
				{
					this._j30c_description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_path", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string j30c_path
		{
			get
			{
				return this._j30c_path;
			}
			set
			{
				if ((this._j30c_path != value))
				{
					this._j30c_path = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_event_type", DbType="Int")]
		public System.Nullable<int> j30c_event_type
		{
			get
			{
				return this._j30c_event_type;
			}
			set
			{
				if ((this._j30c_event_type != value))
				{
					this._j30c_event_type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_title", DbType="NVarChar(128)")]
		public string j30c_title
		{
			get
			{
				return this._j30c_title;
			}
			set
			{
				if ((this._j30c_title != value))
				{
					this._j30c_title = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.j30t_changelog")]
	public partial class j30t_changelog
	{
		
		private System.Nullable<long> _j30c_editorial_id;
		
		private string _j30c_action;
		
		private string _j30c_user_name;
		
		private System.Nullable<long> _j30c_date;
		
		private string _j30c_description;
		
		private string _j30c_path;
		
		private System.Nullable<int> _j30c_event_type;
		
		private string _j30c_title;
		
		public j30t_changelog()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_editorial_id", DbType="BigInt")]
		public System.Nullable<long> j30c_editorial_id
		{
			get
			{
				return this._j30c_editorial_id;
			}
			set
			{
				if ((this._j30c_editorial_id != value))
				{
					this._j30c_editorial_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_action", DbType="NVarChar(32)")]
		public string j30c_action
		{
			get
			{
				return this._j30c_action;
			}
			set
			{
				if ((this._j30c_action != value))
				{
					this._j30c_action = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_user_name", DbType="NVarChar(255)")]
		public string j30c_user_name
		{
			get
			{
				return this._j30c_user_name;
			}
			set
			{
				if ((this._j30c_user_name != value))
				{
					this._j30c_user_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_date", DbType="BigInt")]
		public System.Nullable<long> j30c_date
		{
			get
			{
				return this._j30c_date;
			}
			set
			{
				if ((this._j30c_date != value))
				{
					this._j30c_date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string j30c_description
		{
			get
			{
				return this._j30c_description;
			}
			set
			{
				if ((this._j30c_description != value))
				{
					this._j30c_description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_path", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string j30c_path
		{
			get
			{
				return this._j30c_path;
			}
			set
			{
				if ((this._j30c_path != value))
				{
					this._j30c_path = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_event_type", DbType="Int")]
		public System.Nullable<int> j30c_event_type
		{
			get
			{
				return this._j30c_event_type;
			}
			set
			{
				if ((this._j30c_event_type != value))
				{
					this._j30c_event_type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_j30c_title", DbType="NVarChar(128)")]
		public string j30c_title
		{
			get
			{
				return this._j30c_title;
			}
			set
			{
				if ((this._j30c_title != value))
				{
					this._j30c_title = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
