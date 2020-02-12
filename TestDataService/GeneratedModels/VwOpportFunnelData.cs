using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOpportFunnelData")]
	public class VwOpportFunnelData : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="fCreatedOn")]
		public DateTime fCreatedOn { get; set; }
		[CProperty(ColumnPath ="fDueDate")]
		public DateTime fDueDate { get; set; }
		[CProperty(ColumnPath ="fEnd")]
		public bool fEnd { get; set; }
		[CProperty(ColumnPath ="fStageId")]
		public Guid fStageId { get; set; }
		[CProperty(ColumnPath ="fStageNumber")]
		public int fStageNumber { get; set; }
		[CProperty(ColumnPath ="fStartDate")]
		public DateTime fStartDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsInStageConversion")]
		public int IsInStageConversion { get; set; }
		[CProperty(ColumnPath ="lCreatedOn")]
		public DateTime lCreatedOn { get; set; }
		[CProperty(ColumnPath ="lDueDate")]
		public DateTime lDueDate { get; set; }
		[CProperty(ColumnPath ="lStageId")]
		public Guid lStageId { get; set; }
		[CProperty(ColumnPath ="lStageNumber")]
		public int lStageNumber { get; set; }
		[CProperty(ColumnPath ="lStartDate")]
		public DateTime lStartDate { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityStage:fStageId")]
		public OpportunityStage fStage { get; set; }
		[CProperty(Navigation ="OpportunityStage:lStageId")]
		public OpportunityStage lStage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
