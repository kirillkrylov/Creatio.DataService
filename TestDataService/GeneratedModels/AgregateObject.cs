using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AgregateObject")]
	public class AgregateObject : BaseEntity
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
		private Guid _OneCObjectColumnAggregateId;
		[CProperty(ColumnPath ="OneCObjectColumnAggregateId")]
		public Guid OneCObjectColumnAggregateId
		{
			get{return _OneCObjectColumnAggregateId;}
			set
			{
				_OneCObjectColumnAggregateId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCObjectColumnLinkId;
		[CProperty(ColumnPath ="OneCObjectColumnLinkId")]
		public Guid OneCObjectColumnLinkId
		{
			get{return _OneCObjectColumnLinkId;}
			set
			{
				_OneCObjectColumnLinkId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCObjectId;
		[CProperty(ColumnPath ="OneCObjectId")]
		public Guid OneCObjectId
		{
			get{return _OneCObjectId;}
			set
			{
				_OneCObjectId = value;
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
		private Guid _SyncColumnId;
		[CProperty(ColumnPath ="SyncColumnId")]
		public Guid SyncColumnId
		{
			get{return _SyncColumnId;}
			set
			{
				_SyncColumnId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OneCObject:OneCObjectId")]
		public OneCObject OneCObject { get; set; }
		[CProperty(Navigation ="OneCObjectColumn:OneCObjectColumnLinkId")]
		public OneCObjectColumn OneCObjectColumnLink { get; set; }
		[CProperty(Navigation ="OneCObjectColumn:OneCObjectColumnAggregateId")]
		public OneCObjectColumn OneCObjectColumnAggregate { get; set; }
		[CProperty(Navigation ="SyncColumn:SyncColumnId")]
		public SyncColumn SyncColumn { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
