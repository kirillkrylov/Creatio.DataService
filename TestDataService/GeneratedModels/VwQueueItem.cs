using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwQueueItem")]
	public class VwQueueItem : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private int _AttemptsToCall;
		[CProperty(ColumnPath ="AttemptsToCall")]
		public int AttemptsToCall
		{
			get{return _AttemptsToCall;}
			set
			{
				_AttemptsToCall = value;
				OnPropertyChanged();
			}
		}
		private string _CallPurpose;
		[CProperty(ColumnPath ="CallPurpose")]
		public string CallPurpose
		{
			get{return _CallPurpose;}
			set
			{
				_CallPurpose = value;
				OnPropertyChanged();
			}
		}
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseId;
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId
		{
			get{return _CaseId;}
			set
			{
				_CaseId = value;
				OnPropertyChanged();
			}
		}
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
		private Guid _CurrentActivityId;
		[CProperty(ColumnPath ="CurrentActivityId")]
		public Guid CurrentActivityId
		{
			get{return _CurrentActivityId;}
			set
			{
				_CurrentActivityId = value;
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
		private bool _IgnoreQueuePriority;
		[CProperty(ColumnPath ="IgnoreQueuePriority")]
		public bool IgnoreQueuePriority
		{
			get{return _IgnoreQueuePriority;}
			set
			{
				_IgnoreQueuePriority = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSentEmailToOperator;
		[CProperty(ColumnPath ="IsSentEmailToOperator")]
		public bool IsSentEmailToOperator
		{
			get{return _IsSentEmailToOperator;}
			set
			{
				_IsSentEmailToOperator = value;
				OnPropertyChanged();
			}
		}
		private Guid _LastActivityId;
		[CProperty(ColumnPath ="LastActivityId")]
		public Guid LastActivityId
		{
			get{return _LastActivityId;}
			set
			{
				_LastActivityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
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
		private DateTime _NextProcessingDate;
		[CProperty(ColumnPath ="NextProcessingDate")]
		public DateTime NextProcessingDate
		{
			get{return _NextProcessingDate;}
			set
			{
				_NextProcessingDate = value;
				OnPropertyChanged();
			}
		}
		private int _NextProcessingDateOrder;
		[CProperty(ColumnPath ="NextProcessingDateOrder")]
		public int NextProcessingDateOrder
		{
			get{return _NextProcessingDateOrder;}
			set
			{
				_NextProcessingDateOrder = value;
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
		private Guid _OrderId;
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId
		{
			get{return _OrderId;}
			set
			{
				_OrderId = value;
				OnPropertyChanged();
			}
		}
		private int _PostponesCount;
		[CProperty(ColumnPath ="PostponesCount")]
		public int PostponesCount
		{
			get{return _PostponesCount;}
			set
			{
				_PostponesCount = value;
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
		private Guid _QueueId;
		[CProperty(ColumnPath ="QueueId")]
		public Guid QueueId
		{
			get{return _QueueId;}
			set
			{
				_QueueId = value;
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
		private Guid _SysProcessDataId;
		[CProperty(ColumnPath ="SysProcessDataId")]
		public Guid SysProcessDataId
		{
			get{return _SysProcessDataId;}
			set
			{
				_SysProcessDataId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Activity:CurrentActivityId")]
		public Activity CurrentActivity { get; set; }
		[CProperty(Navigation ="Activity:LastActivityId")]
		public Activity LastActivity { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OperatorId")]
		public Contact Operator { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="Queue:QueueId")]
		public Queue Queue { get; set; }
		[CProperty(Navigation ="QueueItemCloseReason:CloseReasonId")]
		public QueueItemCloseReason CloseReason { get; set; }
		[CProperty(Navigation ="QueueItemStatus:StatusId")]
		public QueueItemStatus Status { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:QueueItemId")]
		public virtual ICollection<Activity> ActivityByQueueItem { get; set; }
		#endregion
	}
}
