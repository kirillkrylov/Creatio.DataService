using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Queue")]
	public class Queue : BaseEntity
	{
		#region Values
		private bool _AssignOperatorAutomatically;
		[CProperty(ColumnPath ="AssignOperatorAutomatically")]
		public bool AssignOperatorAutomatically
		{
			get{return _AssignOperatorAutomatically;}
			set
			{
				_AssignOperatorAutomatically = value;
				OnPropertyChanged();
			}
		}
		private Guid _BusinessProcessSchemaId;
		[CProperty(ColumnPath ="BusinessProcessSchemaId")]
		public Guid BusinessProcessSchemaId
		{
			get{return _BusinessProcessSchemaId;}
			set
			{
				_BusinessProcessSchemaId = value;
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
		private string _EntitySchemaCaption;
		[CProperty(ColumnPath ="EntitySchemaCaption")]
		public string EntitySchemaCaption
		{
			get{return _EntitySchemaCaption;}
			set
			{
				_EntitySchemaCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntitySchemaUId;
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId
		{
			get{return _EntitySchemaUId;}
			set
			{
				_EntitySchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EventId;
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId
		{
			get{return _EventId;}
			set
			{
				_EventId = value;
				OnPropertyChanged();
			}
		}
		private string _FilterData;
		[CProperty(ColumnPath ="FilterData")]
		public string FilterData
		{
			get{return _FilterData;}
			set
			{
				_FilterData = value;
				OnPropertyChanged();
			}
		}
		private string _FilterEditData;
		[CProperty(ColumnPath ="FilterEditData")]
		public string FilterEditData
		{
			get{return _FilterEditData;}
			set
			{
				_FilterEditData = value;
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
		private string _IgnorePriorityFilterData;
		[CProperty(ColumnPath ="IgnorePriorityFilterData")]
		public string IgnorePriorityFilterData
		{
			get{return _IgnorePriorityFilterData;}
			set
			{
				_IgnorePriorityFilterData = value;
				OnPropertyChanged();
			}
		}
		private bool _IsManuallyFilling;
		[CProperty(ColumnPath ="IsManuallyFilling")]
		public bool IsManuallyFilling
		{
			get{return _IsManuallyFilling;}
			set
			{
				_IsManuallyFilling = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadTypeId;
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId
		{
			get{return _LeadTypeId;}
			set
			{
				_LeadTypeId = value;
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
		private Guid _PriorityId;
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId
		{
			get{return _PriorityId;}
			set
			{
				_PriorityId = value;
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
		private string _ProcessSchemaCaption;
		[CProperty(ColumnPath ="ProcessSchemaCaption")]
		public string ProcessSchemaCaption
		{
			get{return _ProcessSchemaCaption;}
			set
			{
				_ProcessSchemaCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessSchemaUId;
		[CProperty(ColumnPath ="ProcessSchemaUId")]
		public Guid ProcessSchemaUId
		{
			get{return _ProcessSchemaUId;}
			set
			{
				_ProcessSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueEntitySchemaId;
		[CProperty(ColumnPath ="QueueEntitySchemaId")]
		public Guid QueueEntitySchemaId
		{
			get{return _QueueEntitySchemaId;}
			set
			{
				_QueueEntitySchemaId = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueItemAdditionId;
		[CProperty(ColumnPath ="QueueItemAdditionId")]
		public Guid QueueItemAdditionId
		{
			get{return _QueueItemAdditionId;}
			set
			{
				_QueueItemAdditionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueUpdateFrequencyId;
		[CProperty(ColumnPath ="QueueUpdateFrequencyId")]
		public Guid QueueUpdateFrequencyId
		{
			get{return _QueueUpdateFrequencyId;}
			set
			{
				_QueueUpdateFrequencyId = value;
				OnPropertyChanged();
			}
		}
		private bool _SentEmailToOperator;
		[CProperty(ColumnPath ="SentEmailToOperator")]
		public bool SentEmailToOperator
		{
			get{return _SentEmailToOperator;}
			set
			{
				_SentEmailToOperator = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="QueueItemAddition:QueueItemAdditionId")]
		public QueueItemAddition QueueItemAddition { get; set; }
		[CProperty(Navigation ="QueuePriority:PriorityId")]
		public QueuePriority Priority { get; set; }
		[CProperty(Navigation ="QueueStatus:StatusId")]
		public QueueStatus Status { get; set; }
		[CProperty(Navigation ="QueueUpdateFrequency:QueueUpdateFrequencyId")]
		public QueueUpdateFrequency QueueUpdateFrequency { get; set; }
		[CProperty(Navigation ="VwQueueSysProcess:BusinessProcessSchemaId")]
		public VwQueueSysProcess BusinessProcessSchema { get; set; }
		[CProperty(Navigation ="VwQueueSysSchema:QueueEntitySchemaId")]
		public VwQueueSysSchema QueueEntitySchema { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:QueueId")]
		public virtual ICollection<Activity> ActivityByQueue { get; set; }
		[CProperty(Association ="QueueFilteredItem:QueueId")]
		public virtual ICollection<QueueFilteredItem> QueueFilteredItemByQueue { get; set; }
		[CProperty(Association ="QueueInFolder:QueueId")]
		public virtual ICollection<QueueInFolder> QueueInFolderByQueue { get; set; }
		[CProperty(Association ="QueueInTag:EntityId")]
		public virtual ICollection<QueueInTag> QueueInTagByEntity { get; set; }
		[CProperty(Association ="QueueItem:QueueId")]
		public virtual ICollection<QueueItem> QueueItemByQueue { get; set; }
		[CProperty(Association ="QueueItemReaction:QueueId")]
		public virtual ICollection<QueueItemReaction> QueueItemReactionByQueue { get; set; }
		[CProperty(Association ="QueueOperator:QueueId")]
		public virtual ICollection<QueueOperator> QueueOperatorByQueue { get; set; }
		[CProperty(Association ="VwQueueItem:QueueId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByQueue { get; set; }
		[CProperty(Association ="VwQueueItemDashboard:QueueId")]
		public virtual ICollection<VwQueueItemDashboard> VwQueueItemDashboardByQueue { get; set; }
		[CProperty(Association ="VwQueueItemDashboardC:QueueId")]
		public virtual ICollection<VwQueueItemDashboardC> VwQueueItemDashboardCByQueue { get; set; }
		[CProperty(Association ="VwQueueItemSuper:QueueId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByQueue { get; set; }
		#endregion
	}
}
