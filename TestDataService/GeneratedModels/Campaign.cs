using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Campaign")]
	public class Campaign : BaseEntity
	{
		#region Values
		private Guid _CampaignSchemaUId;
		[CProperty(ColumnPath ="CampaignSchemaUId")]
		public Guid CampaignSchemaUId
		{
			get{return _CampaignSchemaUId;}
			set
			{
				_CampaignSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignStatusId;
		[CProperty(ColumnPath ="CampaignStatusId")]
		public Guid CampaignStatusId
		{
			get{return _CampaignStatusId;}
			set
			{
				_CampaignStatusId = value;
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
		private int _FirePeriod;
		[CProperty(ColumnPath ="FirePeriod")]
		public int FirePeriod
		{
			get{return _FirePeriod;}
			set
			{
				_FirePeriod = value;
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
		private bool _INFLUSync;
		[CProperty(ColumnPath ="INFLUSync")]
		public bool INFLUSync
		{
			get{return _INFLUSync;}
			set
			{
				_INFLUSync = value;
				OnPropertyChanged();
			}
		}
		private bool _InProgress;
		[CProperty(ColumnPath ="InProgress")]
		public bool InProgress
		{
			get{return _InProgress;}
			set
			{
				_InProgress = value;
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
		private DateTime _NextFireTime;
		[CProperty(ColumnPath ="NextFireTime")]
		public DateTime NextFireTime
		{
			get{return _NextFireTime;}
			set
			{
				_NextFireTime = value;
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
		private DateTime _PrevExecutedOn;
		[CProperty(ColumnPath ="PrevExecutedOn")]
		public DateTime PrevExecutedOn
		{
			get{return _PrevExecutedOn;}
			set
			{
				_PrevExecutedOn = value;
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
		private DateTime _ScheduledStartDate;
		[CProperty(ColumnPath ="ScheduledStartDate")]
		public DateTime ScheduledStartDate
		{
			get{return _ScheduledStartDate;}
			set
			{
				_ScheduledStartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScheduledStartModeId;
		[CProperty(ColumnPath ="ScheduledStartModeId")]
		public Guid ScheduledStartModeId
		{
			get{return _ScheduledStartModeId;}
			set
			{
				_ScheduledStartModeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ScheduledStopDate;
		[CProperty(ColumnPath ="ScheduledStopDate")]
		public DateTime ScheduledStopDate
		{
			get{return _ScheduledStopDate;}
			set
			{
				_ScheduledStopDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScheduledStopModeId;
		[CProperty(ColumnPath ="ScheduledStopModeId")]
		public Guid ScheduledStopModeId
		{
			get{return _ScheduledStopModeId;}
			set
			{
				_ScheduledStopModeId = value;
				OnPropertyChanged();
			}
		}
		private string _SchemaData;
		[CProperty(ColumnPath ="SchemaData")]
		public string SchemaData
		{
			get{return _SchemaData;}
			set
			{
				_SchemaData = value;
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
		private int _TargetAchieve;
		[CProperty(ColumnPath ="TargetAchieve")]
		public int TargetAchieve
		{
			get{return _TargetAchieve;}
			set
			{
				_TargetAchieve = value;
				OnPropertyChanged();
			}
		}
		private string _TargetDescription;
		[CProperty(ColumnPath ="TargetDescription")]
		public string TargetDescription
		{
			get{return _TargetDescription;}
			set
			{
				_TargetDescription = value;
				OnPropertyChanged();
			}
		}
		private decimal _TargetPercent;
		[CProperty(ColumnPath ="TargetPercent")]
		public decimal TargetPercent
		{
			get{return _TargetPercent;}
			set
			{
				_TargetPercent = value;
				OnPropertyChanged();
			}
		}
		private int _TargetTotal;
		[CProperty(ColumnPath ="TargetTotal")]
		public int TargetTotal
		{
			get{return _TargetTotal;}
			set
			{
				_TargetTotal = value;
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
		private string _UtmCampaign;
		[CProperty(ColumnPath ="UtmCampaign")]
		public string UtmCampaign
		{
			get{return _UtmCampaign;}
			set
			{
				_UtmCampaign = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CampaignScheduledMode:ScheduledStartModeId")]
		public CampaignScheduledMode ScheduledStartMode { get; set; }
		[CProperty(Navigation ="CampaignScheduledMode:ScheduledStopModeId")]
		public CampaignScheduledMode ScheduledStopMode { get; set; }
		[CProperty(Navigation ="CampaignStatus:CampaignStatusId")]
		public CampaignStatus CampaignStatus { get; set; }
		[CProperty(Navigation ="CampaignType:TypeId")]
		public CampaignType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="SegmentStatus:SegmentsStatusId")]
		public SegmentStatus SegmentsStatus { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmail:CampaignId")]
		public virtual ICollection<BulkEmail> BulkEmailByCampaign { get; set; }
		[CProperty(Association ="CampaignFile:CampaignId")]
		public virtual ICollection<CampaignFile> CampaignFileByCampaign { get; set; }
		[CProperty(Association ="CampaignInFolder:CampaignId")]
		public virtual ICollection<CampaignInFolder> CampaignInFolderByCampaign { get; set; }
		[CProperty(Association ="CampaignInTag:EntityId")]
		public virtual ICollection<CampaignInTag> CampaignInTagByEntity { get; set; }
		[CProperty(Association ="CampaignItem:CampaignId")]
		public virtual ICollection<CampaignItem> CampaignItemByCampaign { get; set; }
		[CProperty(Association ="CampaignLog:CampaignId")]
		public virtual ICollection<CampaignLog> CampaignLogByCampaign { get; set; }
		[CProperty(Association ="CampaignParticipant:CampaignId")]
		public virtual ICollection<CampaignParticipant> CampaignParticipantByCampaign { get; set; }
		[CProperty(Association ="CampaignParticipantOp:CampaignId")]
		public virtual ICollection<CampaignParticipantOp> CampaignParticipantOpByCampaign { get; set; }
		[CProperty(Association ="CampaignSegment:CampaignId")]
		public virtual ICollection<CampaignSegment> CampaignSegmentByCampaign { get; set; }
		[CProperty(Association ="CampaignStep:CampaignId")]
		public virtual ICollection<CampaignStep> CampaignStepByCampaign { get; set; }
		[CProperty(Association ="CampaignTarget:CampaignId")]
		public virtual ICollection<CampaignTarget> CampaignTargetByCampaign { get; set; }
		[CProperty(Association ="CampaignVersion:CampaignId")]
		public virtual ICollection<CampaignVersion> CampaignVersionByCampaign { get; set; }
		[CProperty(Association ="ContactFolder:CampaignId")]
		public virtual ICollection<ContactFolder> ContactFolderByCampaign { get; set; }
		[CProperty(Association ="Event:CampaignId")]
		public virtual ICollection<Event> EventByCampaign { get; set; }
		[CProperty(Association ="Lead:CampaignId")]
		public virtual ICollection<Lead> LeadByCampaign { get; set; }
		[CProperty(Association ="Opportunity:CampaignId")]
		public virtual ICollection<Opportunity> OpportunityByCampaign { get; set; }
		[CProperty(Association ="VwBulkEmailInCampaign:CampaignId")]
		public virtual ICollection<VwBulkEmailInCampaign> VwBulkEmailInCampaignByCampaign { get; set; }
		[CProperty(Association ="VwCampaignLog:CampaignId")]
		public virtual ICollection<VwCampaignLog> VwCampaignLogByCampaign { get; set; }
		[CProperty(Association ="VwEventInCampaign:CampaignId")]
		public virtual ICollection<VwEventInCampaign> VwEventInCampaignByCampaign { get; set; }
		[CProperty(Association ="VwFolderInCampaign:CampaignId")]
		public virtual ICollection<VwFolderInCampaign> VwFolderInCampaignByCampaign { get; set; }
		[CProperty(Association ="VwLandingInCampaign:CampaignId")]
		public virtual ICollection<VwLandingInCampaign> VwLandingInCampaignByCampaign { get; set; }
		[CProperty(Association ="VwLead:CampaignId")]
		public virtual ICollection<VwLead> VwLeadByCampaign { get; set; }
		#endregion
	}
}
