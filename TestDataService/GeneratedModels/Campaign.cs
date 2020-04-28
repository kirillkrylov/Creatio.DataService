using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Campaign")]
	public class Campaign : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignSchemaUId")]
		public Guid CampaignSchemaUId { get; set; }
		[CProperty(ColumnPath ="CampaignStatusId")]
		public Guid CampaignStatusId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="FirePeriod")]
		public int FirePeriod { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="INFLUSync")]
		public bool INFLUSync { get; set; }
		[CProperty(ColumnPath ="InProgress")]
		public bool InProgress { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NextFireTime")]
		public DateTime NextFireTime { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PrevExecutedOn")]
		public DateTime PrevExecutedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ScheduledStartDate")]
		public DateTime ScheduledStartDate { get; set; }
		[CProperty(ColumnPath ="ScheduledStartModeId")]
		public Guid ScheduledStartModeId { get; set; }
		[CProperty(ColumnPath ="ScheduledStopDate")]
		public DateTime ScheduledStopDate { get; set; }
		[CProperty(ColumnPath ="ScheduledStopModeId")]
		public Guid ScheduledStopModeId { get; set; }
		[CProperty(ColumnPath ="SchemaData")]
		public string SchemaData { get; set; }
		[CProperty(ColumnPath ="SegmentsStatusId")]
		public Guid SegmentsStatusId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="TargetAchieve")]
		public int TargetAchieve { get; set; }
		[CProperty(ColumnPath ="TargetDescription")]
		public string TargetDescription { get; set; }
		[CProperty(ColumnPath ="TargetPercent")]
		public decimal TargetPercent { get; set; }
		[CProperty(ColumnPath ="TargetTotal")]
		public int TargetTotal { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UtmCampaign")]
		public string UtmCampaign { get; set; }
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
