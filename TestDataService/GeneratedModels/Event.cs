using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Event")]
	public class Event : BaseEntity
	{
		#region Values
		private Guid _ActualizeStatusId;
		[CProperty(ColumnPath ="ActualizeStatusId")]
		public Guid ActualizeStatusId
		{
			get{return _ActualizeStatusId;}
			set
			{
				_ActualizeStatusId = value;
				OnPropertyChanged();
			}
		}
		private string _ActualResponse;
		[CProperty(ColumnPath ="ActualResponse")]
		public string ActualResponse
		{
			get{return _ActualResponse;}
			set
			{
				_ActualResponse = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignId;
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId
		{
			get{return _CampaignId;}
			set
			{
				_CampaignId = value;
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
		private string _Goal;
		[CProperty(ColumnPath ="Goal")]
		public string Goal
		{
			get{return _Goal;}
			set
			{
				_Goal = value;
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
		private Guid _IndustryId;
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId
		{
			get{return _IndustryId;}
			set
			{
				_IndustryId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastActualizeDate;
		[CProperty(ColumnPath ="LastActualizeDate")]
		public DateTime LastActualizeDate
		{
			get{return _LastActualizeDate;}
			set
			{
				_LastActualizeDate = value;
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
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryActualCost;
		[CProperty(ColumnPath ="PrimaryActualCost")]
		public decimal PrimaryActualCost
		{
			get{return _PrimaryActualCost;}
			set
			{
				_PrimaryActualCost = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryActualRevenue;
		[CProperty(ColumnPath ="PrimaryActualRevenue")]
		public decimal PrimaryActualRevenue
		{
			get{return _PrimaryActualRevenue;}
			set
			{
				_PrimaryActualRevenue = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryBudgetedCost;
		[CProperty(ColumnPath ="PrimaryBudgetedCost")]
		public decimal PrimaryBudgetedCost
		{
			get{return _PrimaryBudgetedCost;}
			set
			{
				_PrimaryBudgetedCost = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryExpectedRevenue;
		[CProperty(ColumnPath ="PrimaryExpectedRevenue")]
		public decimal PrimaryExpectedRevenue
		{
			get{return _PrimaryExpectedRevenue;}
			set
			{
				_PrimaryExpectedRevenue = value;
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
		private int _RecipientCount;
		[CProperty(ColumnPath ="RecipientCount")]
		public int RecipientCount
		{
			get{return _RecipientCount;}
			set
			{
				_RecipientCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _SegmentsStatusId;
		[CProperty(ColumnPath ="SegmentsStatusId")]
		public Guid SegmentsStatusId
		{
			get{return _SegmentsStatusId;}
			set
			{
				_SegmentsStatusId = value;
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
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountIndustry:IndustryId")]
		public AccountIndustry Industry { get; set; }
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="EventStatus:StatusId")]
		public EventStatus Status { get; set; }
		[CProperty(Navigation ="EventType:TypeId")]
		public EventType Type { get; set; }
		[CProperty(Navigation ="SegmentStatus:ActualizeStatusId")]
		public SegmentStatus ActualizeStatus { get; set; }
		[CProperty(Navigation ="SegmentStatus:SegmentsStatusId")]
		public SegmentStatus SegmentsStatus { get; set; }
		[CProperty(Navigation ="Territory:TerritoryId")]
		public Territory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:EventId")]
		public virtual ICollection<Activity> ActivityByEvent { get; set; }
		[CProperty(Association ="EventFile:EventId")]
		public virtual ICollection<EventFile> EventFileByEvent { get; set; }
		[CProperty(Association ="EventInFolder:EventId")]
		public virtual ICollection<EventInFolder> EventInFolderByEvent { get; set; }
		[CProperty(Association ="EventInTag:EntityId")]
		public virtual ICollection<EventInTag> EventInTagByEntity { get; set; }
		[CProperty(Association ="EventProduct:EventId")]
		public virtual ICollection<EventProduct> EventProductByEvent { get; set; }
		[CProperty(Association ="EventSegment:EventId")]
		public virtual ICollection<EventSegment> EventSegmentByEvent { get; set; }
		[CProperty(Association ="EventTarget:EventId")]
		public virtual ICollection<EventTarget> EventTargetByEvent { get; set; }
		[CProperty(Association ="EventTeam:EventId")]
		public virtual ICollection<EventTeam> EventTeamByEvent { get; set; }
		[CProperty(Association ="InternalRequest:EventId")]
		public virtual ICollection<InternalRequest> InternalRequestByEvent { get; set; }
		[CProperty(Association ="Invoice:EventId")]
		public virtual ICollection<Invoice> InvoiceByEvent { get; set; }
		[CProperty(Association ="Lead:EventId")]
		public virtual ICollection<Lead> LeadByEvent { get; set; }
		[CProperty(Association ="Order:EventId")]
		public virtual ICollection<Order> OrderByEvent { get; set; }
		[CProperty(Association ="Queue:EventId")]
		public virtual ICollection<Queue> QueueByEvent { get; set; }
		[CProperty(Association ="VwEventInCampaign:EventId")]
		public virtual ICollection<VwEventInCampaign> VwEventInCampaignByEvent { get; set; }
		[CProperty(Association ="VwEventInContact:EventId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByEvent { get; set; }
		[CProperty(Association ="VwLead:EventId")]
		public virtual ICollection<VwLead> VwLeadByEvent { get; set; }
		#endregion
	}
}
