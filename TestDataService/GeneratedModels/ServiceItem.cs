using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServiceItem")]
	public class ServiceItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId { get; set; }
		[CProperty(ColumnPath ="CaseCategoryId")]
		public Guid CaseCategoryId { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReactionTime")]
		public string ReactionTime { get; set; }
		[CProperty(ColumnPath ="ReactionTimeUnitId")]
		public Guid ReactionTimeUnitId { get; set; }
		[CProperty(ColumnPath ="ReactionTimeValue")]
		public int ReactionTimeValue { get; set; }
		[CProperty(ColumnPath ="SolutionTime")]
		public string SolutionTime { get; set; }
		[CProperty(ColumnPath ="SolutionTimeUnitId")]
		public Guid SolutionTimeUnitId { get; set; }
		[CProperty(ColumnPath ="SolutionTimeValue")]
		public int SolutionTimeValue { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation ="CaseCategory:CaseCategoryId")]
		public CaseCategory CaseCategory { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="ServiceCategory:CategoryId")]
		public ServiceCategory Category { get; set; }
		[CProperty(Navigation ="ServiceStatus:StatusId")]
		public ServiceStatus Status { get; set; }
		[CProperty(Navigation ="TimeUnit:ReactionTimeUnitId")]
		public TimeUnit ReactionTimeUnit { get; set; }
		[CProperty(Navigation ="TimeUnit:SolutionTimeUnitId")]
		public TimeUnit SolutionTimeUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:ServiceItemId")]
		public virtual ICollection<Case> CaseByServiceItem { get; set; }
		[CProperty(Association ="CaseLifecycle:ServiceItemId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByServiceItem { get; set; }
		[CProperty(Association ="ChangeServiceItem:ServiceItemId")]
		public virtual ICollection<ChangeServiceItem> ChangeServiceItemByServiceItem { get; set; }
		[CProperty(Association ="Problem:ServiceItemId")]
		public virtual ICollection<Problem> ProblemByServiceItem { get; set; }
		[CProperty(Association ="ReleaseServiceItem:ServiceItemId")]
		public virtual ICollection<ReleaseServiceItem> ReleaseServiceItemByServiceItem { get; set; }
		[CProperty(Association ="ServiceEngineer:ServiceItemId")]
		public virtual ICollection<ServiceEngineer> ServiceEngineerByServiceItem { get; set; }
		[CProperty(Association ="ServiceInConfItem:ServiceItemId")]
		public virtual ICollection<ServiceInConfItem> ServiceInConfItemByServiceItem { get; set; }
		[CProperty(Association ="ServiceInServicePact:ServiceItemId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactByServiceItem { get; set; }
		[CProperty(Association ="ServiceItemFile:ServiceItemId")]
		public virtual ICollection<ServiceItemFile> ServiceItemFileByServiceItem { get; set; }
		[CProperty(Association ="ServiceItemInFolder:ServiceItemId")]
		public virtual ICollection<ServiceItemInFolder> ServiceItemInFolderByServiceItem { get; set; }
		[CProperty(Association ="ServiceItemInTag:EntityId")]
		public virtual ICollection<ServiceItemInTag> ServiceItemInTagByEntity { get; set; }
		[CProperty(Association ="ServiceRelationship:ServiceItemAId")]
		public virtual ICollection<ServiceRelationship> ServiceRelationshipByServiceItemA { get; set; }
		[CProperty(Association ="ServiceRelationship:ServiceItemBId")]
		public virtual ICollection<ServiceRelationship> ServiceRelationshipByServiceItemB { get; set; }
		[CProperty(Association ="VwServiceInConfItem:ServiceItemId")]
		public virtual ICollection<VwServiceInConfItem> VwServiceInConfItemByServiceItem { get; set; }
		[CProperty(Association ="VwServiceRecepients:ServiceId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByService { get; set; }
		[CProperty(Association ="VwServiceRelationship:ServiceItemAId")]
		public virtual ICollection<VwServiceRelationship> VwServiceRelationshipByServiceItemA { get; set; }
		[CProperty(Association ="VwServiceRelationship:ServiceItemBId")]
		public virtual ICollection<VwServiceRelationship> VwServiceRelationshipByServiceItemB { get; set; }
		#endregion
	}
}
