using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwLeadInQueue")]
	public class VwLeadInQueue : BaseEntity
	{
		#region Values
		private Guid _CloseReasonId;
		[CProperty(ColumnPath ="CloseReasonId")]
		public Guid CloseReasonId
		{
			get{return _CloseReasonId;}
			set
			{
				_CloseReasonId = value;
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
		private DateTime _Date;
		[CProperty(ColumnPath ="Date")]
		public DateTime Date
		{
			get{return _Date;}
			set
			{
				_Date = value;
				OnPropertyChanged();
			}
		}
		private Guid _ElementStatusId;
		[CProperty(ColumnPath ="ElementStatusId")]
		public Guid ElementStatusId
		{
			get{return _ElementStatusId;}
			set
			{
				_ElementStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityRecordId;
		[CProperty(ColumnPath ="EntityRecordId")]
		public Guid EntityRecordId
		{
			get{return _EntityRecordId;}
			set
			{
				_EntityRecordId = value;
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
		private Guid _OperatorId;
		[CProperty(ColumnPath ="OperatorId")]
		public Guid OperatorId
		{
			get{return _OperatorId;}
			set
			{
				_OperatorId = value;
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
		private string _QueueName;
		[CProperty(ColumnPath ="QueueName")]
		public string QueueName
		{
			get{return _QueueName;}
			set
			{
				_QueueName = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueuePriorityId;
		[CProperty(ColumnPath ="QueuePriorityId")]
		public Guid QueuePriorityId
		{
			get{return _QueuePriorityId;}
			set
			{
				_QueuePriorityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueStatusId;
		[CProperty(ColumnPath ="QueueStatusId")]
		public Guid QueueStatusId
		{
			get{return _QueueStatusId;}
			set
			{
				_QueueStatusId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OperatorId")]
		public Contact Operator { get; set; }
		[CProperty(Navigation ="QueueItemCloseReason:CloseReasonId")]
		public QueueItemCloseReason CloseReason { get; set; }
		[CProperty(Navigation ="QueueItemStatus:ElementStatusId")]
		public QueueItemStatus ElementStatus { get; set; }
		[CProperty(Navigation ="QueuePriority:QueuePriorityId")]
		public QueuePriority QueuePriority { get; set; }
		[CProperty(Navigation ="QueueStatus:QueueStatusId")]
		public QueueStatus QueueStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
