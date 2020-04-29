using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Call")]
	public class Call : BaseEntity
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
		private Guid _ActivityId;
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId
		{
			get{return _ActivityId;}
			set
			{
				_ActivityId = value;
				OnPropertyChanged();
			}
		}
		private int _BeforeConnectionTime;
		[CProperty(ColumnPath ="BeforeConnectionTime")]
		public int BeforeConnectionTime
		{
			get{return _BeforeConnectionTime;}
			set
			{
				_BeforeConnectionTime = value;
				OnPropertyChanged();
			}
		}
		private string _CalledId;
		[CProperty(ColumnPath ="CalledId")]
		public string CalledId
		{
			get{return _CalledId;}
			set
			{
				_CalledId = value;
				OnPropertyChanged();
			}
		}
		private string _CallerId;
		[CProperty(ColumnPath ="CallerId")]
		public string CallerId
		{
			get{return _CallerId;}
			set
			{
				_CallerId = value;
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
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
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
		private Guid _DirectionId;
		[CProperty(ColumnPath ="DirectionId")]
		public Guid DirectionId
		{
			get{return _DirectionId;}
			set
			{
				_DirectionId = value;
				OnPropertyChanged();
			}
		}
		private int _Duration;
		[CProperty(ColumnPath ="Duration")]
		public int Duration
		{
			get{return _Duration;}
			set
			{
				_Duration = value;
				OnPropertyChanged();
			}
		}
		private DateTime _EndDate;
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate
		{
			get{return _EndDate;}
			set
			{
				_EndDate = value;
				OnPropertyChanged();
			}
		}
		private string _GloballyUniqueCallLinkageId;
		[CProperty(ColumnPath ="GloballyUniqueCallLinkageId")]
		public string GloballyUniqueCallLinkageId
		{
			get{return _GloballyUniqueCallLinkageId;}
			set
			{
				_GloballyUniqueCallLinkageId = value;
				OnPropertyChanged();
			}
		}
		private int _HoldTime;
		[CProperty(ColumnPath ="HoldTime")]
		public int HoldTime
		{
			get{return _HoldTime;}
			set
			{
				_HoldTime = value;
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
		private string _IntegrationId;
		[CProperty(ColumnPath ="IntegrationId")]
		public string IntegrationId
		{
			get{return _IntegrationId;}
			set
			{
				_IntegrationId = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
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
		private string _ParentCallId;
		[CProperty(ColumnPath ="ParentCallId")]
		public string ParentCallId
		{
			get{return _ParentCallId;}
			set
			{
				_ParentCallId = value;
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
		private string _RedirectingId;
		[CProperty(ColumnPath ="RedirectingId")]
		public string RedirectingId
		{
			get{return _RedirectingId;}
			set
			{
				_RedirectingId = value;
				OnPropertyChanged();
			}
		}
		private string _RedirectionId;
		[CProperty(ColumnPath ="RedirectionId")]
		public string RedirectionId
		{
			get{return _RedirectionId;}
			set
			{
				_RedirectionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ResultId;
		[CProperty(ColumnPath ="ResultId")]
		public Guid ResultId
		{
			get{return _ResultId;}
			set
			{
				_ResultId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private int _TalkTime;
		[CProperty(ColumnPath ="TalkTime")]
		public int TalkTime
		{
			get{return _TalkTime;}
			set
			{
				_TalkTime = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation ="ActivityResult:ResultId")]
		public ActivityResult Result { get; set; }
		[CProperty(Navigation ="CallDirection:DirectionId")]
		public CallDirection Direction { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CallFile:CallId")]
		public virtual ICollection<CallFile> CallFileByCall { get; set; }
		[CProperty(Association ="CallInFolder:CallId")]
		public virtual ICollection<CallInFolder> CallInFolderByCall { get; set; }
		[CProperty(Association ="CallInTag:EntityId")]
		public virtual ICollection<CallInTag> CallInTagByEntity { get; set; }
		[CProperty(Association ="SysActiveCall:CallId")]
		public virtual ICollection<SysActiveCall> SysActiveCallByCall { get; set; }
		[CProperty(Association ="SysActiveCall:ParentCallId")]
		public virtual ICollection<SysActiveCall> SysActiveCallByParentCall { get; set; }
		[CProperty(Association ="VwRecentCall:CallId")]
		public virtual ICollection<VwRecentCall> VwRecentCallByCall { get; set; }
		#endregion
	}
}
