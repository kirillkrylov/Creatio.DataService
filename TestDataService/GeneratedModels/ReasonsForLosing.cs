using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ReasonsForLosing")]
	public class ReasonsForLosing : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DetailReasonId")]
		public Guid DetailReasonId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="LosingCompetitorReasonId")]
		public Guid LosingCompetitorReasonId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DetailedReason:DetailReasonId")]
		public DetailedReason DetailReason { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="LosingCompetitorReason:LosingCompetitorReasonId")]
		public LosingCompetitorReason LosingCompetitorReason { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
