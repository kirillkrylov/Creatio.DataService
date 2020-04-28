using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SalesProcessEvent")]
	public class SalesProcessEvent : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DepartmentManagerId")]
		public Guid DepartmentManagerId { get; set; }
		[CProperty(ColumnPath ="EventDate")]
		public DateTime EventDate { get; set; }
		[CProperty(ColumnPath ="EventTypeId")]
		public Guid EventTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LeadCloseReasonId")]
		public Guid LeadCloseReasonId { get; set; }
		[CProperty(ColumnPath ="LeadDisqualifyReasonId")]
		public Guid LeadDisqualifyReasonId { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OpportunityCloseReasonId")]
		public Guid OpportunityCloseReasonId { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegisterMethodId")]
		public Guid RegisterMethodId { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ManagerId")]
		public Contact Manager { get; set; }
		[CProperty(Navigation ="Contact:DepartmentManagerId")]
		public Contact DepartmentManager { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="LeadCloseReason:LeadCloseReasonId")]
		public LeadCloseReason LeadCloseReason { get; set; }
		[CProperty(Navigation ="LeadDisqualifyReason:LeadDisqualifyReasonId")]
		public LeadDisqualifyReason LeadDisqualifyReason { get; set; }
		[CProperty(Navigation ="LeadRegisterMethod:RegisterMethodId")]
		public LeadRegisterMethod RegisterMethod { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityCloseReason:OpportunityCloseReasonId")]
		public OpportunityCloseReason OpportunityCloseReason { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		[CProperty(Navigation ="SalesProcessEventType:EventTypeId")]
		public SalesProcessEventType EventType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
