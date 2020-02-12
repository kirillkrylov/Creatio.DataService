using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDESuitablePainAndSolutionInOpportunity")]
	public class PDESuitablePainAndSolutionInOpportunity : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="PDEIndustryFilter")]
		public bool PDEIndustryFilter { get; set; }
		[CProperty(ColumnPath ="PDENeedCombinationFilter")]
		public bool PDENeedCombinationFilter { get; set; }
		[CProperty(ColumnPath ="PDENeedFilter")]
		public bool PDENeedFilter { get; set; }
		[CProperty(ColumnPath ="PDEOpportunityId")]
		public Guid PDEOpportunityId { get; set; }
		[CProperty(ColumnPath ="PDEPainAndSolutionId")]
		public Guid PDEPainAndSolutionId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="KnowledgeBase:PDEPainAndSolutionId")]
		public KnowledgeBase PDEPainAndSolution { get; set; }
		[CProperty(Navigation ="Opportunity:PDEOpportunityId")]
		public Opportunity PDEOpportunity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
