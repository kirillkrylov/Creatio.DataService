using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProfileData")]
	public class SysProfileData : BaseEntity
	{
		#region Values
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private string _Key;
		[CProperty(ColumnPath ="Key")]
		public string Key
		{
			get{return _Key;}
			set
			{
				_Key = value;
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
		private byte[] _ObjectData;
		[CProperty(ColumnPath ="ObjectData")]
		public byte[] ObjectData
		{
			get{return _ObjectData;}
			set
			{
				_ObjectData = value;
				OnPropertyChanged();
			}
		}
		private byte[] _ObjectDifference;
		[CProperty(ColumnPath ="ObjectDifference")]
		public byte[] ObjectDifference
		{
			get{return _ObjectDifference;}
			set
			{
				_ObjectDifference = value;
				OnPropertyChanged();
			}
		}
		private Guid _ObjectId;
		[CProperty(ColumnPath ="ObjectId")]
		public Guid ObjectId
		{
			get{return _ObjectId;}
			set
			{
				_ObjectId = value;
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
		private Guid _SysCultureId;
		[CProperty(ColumnPath ="SysCultureId")]
		public Guid SysCultureId
		{
			get{return _SysCultureId;}
			set
			{
				_SysCultureId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysUserId;
		[CProperty(ColumnPath ="SysUserId")]
		public Guid SysUserId
		{
			get{return _SysUserId;}
			set
			{
				_SysUserId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysUserId")]
		public SysAdminUnit SysUser { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
