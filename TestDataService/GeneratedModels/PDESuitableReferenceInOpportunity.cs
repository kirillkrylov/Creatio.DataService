using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDESuitableReferenceInOpportunity")]
	public class PDESuitableReferenceInOpportunity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PDECountryFilter")]
		public bool PDECountryFilter { get; set; }
		[CProperty(ColumnPath ="PDEIndustryFilter")]
		public bool PDEIndustryFilter { get; set; }
		[CProperty(ColumnPath ="PDENeedCombinationFilter")]
		public bool PDENeedCombinationFilter { get; set; }
		[CProperty(ColumnPath ="PDENeedFilter")]
		public bool PDENeedFilter { get; set; }
		[CProperty(ColumnPath ="PDEOpportunityId")]
		public Guid PDEOpportunityId { get; set; }
		[CProperty(ColumnPath ="PDEReferenceId")]
		public Guid PDEReferenceId { get; set; }
		[CProperty(ColumnPath ="PDETerritoryFilter")]
		public bool PDETerritoryFilter { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Case:PDEReferenceId")]
		public Case PDEReference { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Opportunity:PDEOpportunityId")]
		public Opportunity PDEOpportunity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
