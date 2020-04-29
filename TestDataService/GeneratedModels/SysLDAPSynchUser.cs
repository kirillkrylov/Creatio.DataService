using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLDAPSynchUser")]
	public class SysLDAPSynchUser : BaseEntity
	{
		#region Values
		private string _Company;
		[CProperty(ColumnPath ="Company")]
		public string Company
		{
			get{return _Company;}
			set
			{
				_Company = value;
				OnPropertyChanged();
			}
		}
		private string _Dn;
		[CProperty(ColumnPath ="Dn")]
		public string Dn
		{
			get{return _Dn;}
			set
			{
				_Dn = value;
				OnPropertyChanged();
			}
		}
		private string _Email;
		[CProperty(ColumnPath ="Email")]
		public string Email
		{
			get{return _Email;}
			set
			{
				_Email = value;
				OnPropertyChanged();
			}
		}
		private string _FullName;
		[CProperty(ColumnPath ="FullName")]
		public string FullName
		{
			get{return _FullName;}
			set
			{
				_FullName = value;
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
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
				OnPropertyChanged();
			}
		}
		private string _JobTitle;
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle
		{
			get{return _JobTitle;}
			set
			{
				_JobTitle = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _Phone;
		[CProperty(ColumnPath ="Phone")]
		public string Phone
		{
			get{return _Phone;}
			set
			{
				_Phone = value;
				OnPropertyChanged();
			}
		}
		private Guid _RecordId;
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId
		{
			get{return _RecordId;}
			set
			{
				_RecordId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
