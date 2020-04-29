using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysRecentEntity")]
	public class SysRecentEntity : BaseEntity
	{
		#region Values
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
		private string _EntityCaption;
		[CProperty(ColumnPath ="EntityCaption")]
		public string EntityCaption
		{
			get{return _EntityCaption;}
			set
			{
				_EntityCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityId;
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId
		{
			get{return _EntityId;}
			set
			{
				_EntityId = value;
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
		private Guid _SysEntitySchemaUId;
		[CProperty(ColumnPath ="SysEntitySchemaUId")]
		public Guid SysEntitySchemaUId
		{
			get{return _SysEntitySchemaUId;}
			set
			{
				_SysEntitySchemaUId = value;
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
		private DateTime _UsedOn;
		[CProperty(ColumnPath ="UsedOn")]
		public DateTime UsedOn
		{
			get{return _UsedOn;}
			set
			{
				_UsedOn = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysUserId")]
		public SysAdminUnit SysUser { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
