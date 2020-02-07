using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Event")]
	public class Event : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualizeStatusId")]
		public Guid ActualizeStatusId { get; set; }
		[CProperty(ColumnPath ="ActualResponse")]
		public string ActualResponse { get; set; }
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="Goal")]
		public string Goal { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId { get; set; }
		[CProperty(ColumnPath ="LastActualizeDate")]
		public DateTime LastActualizeDate { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PrimaryActualCost")]
		public decimal PrimaryActualCost { get; set; }
		[CProperty(ColumnPath ="PrimaryActualRevenue")]
		public decimal PrimaryActualRevenue { get; set; }
		[CProperty(ColumnPath ="PrimaryBudgetedCost")]
		public decimal PrimaryBudgetedCost { get; set; }
		[CProperty(ColumnPath ="PrimaryExpectedRevenue")]
		public decimal PrimaryExpectedRevenue { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecipientCount")]
		public int RecipientCount { get; set; }
		[CProperty(ColumnPath ="SegmentsStatusId")]
		public Guid SegmentsStatusId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
		[CProperty(Association ="Lead:EventId")]
		public virtual ICollection<Lead> LeadByEvent { get; set; }
		[CProperty(Association ="VwEventInCampaign:EventId")]
		public virtual ICollection<VwEventInCampaign> VwEventInCampaignByEvent { get; set; }
		#endregion
	}
}
