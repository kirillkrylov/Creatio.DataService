using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WebitelServerSettings")]
	public class WebitelServerSettings : BaseEntity
	{
		#region Values
		private string _AdminUserName;
		[CProperty(ColumnPath ="AdminUserName")]
		public string AdminUserName
		{
			get{return _AdminUserName;}
			set
			{
				_AdminUserName = value;
				OnPropertyChanged();
			}
		}
		private string _AdminUserPassword;
		[CProperty(ColumnPath ="AdminUserPassword")]
		public string AdminUserPassword
		{
			get{return _AdminUserPassword;}
			set
			{
				_AdminUserPassword = value;
				OnPropertyChanged();
			}
		}
		private string _BpmonlineProductVersion;
		[CProperty(ColumnPath ="BpmonlineProductVersion")]
		public string BpmonlineProductVersion
		{
			get{return _BpmonlineProductVersion;}
			set
			{
				_BpmonlineProductVersion = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private string _ServerURL;
		[CProperty(ColumnPath ="ServerURL")]
		public string ServerURL
		{
			get{return _ServerURL;}
			set
			{
				_ServerURL = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
