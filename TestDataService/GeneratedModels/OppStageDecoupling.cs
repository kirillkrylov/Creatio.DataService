using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OppStageDecoupling")]
	public class OppStageDecoupling : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AvailableStageId")]
		public Guid AvailableStageId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrentStageId")]
		public Guid CurrentStageId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OpportunityStage:CurrentStageId")]
		public OpportunityStage CurrentStage { get; set; }
		[CProperty(Navigation ="OpportunityStage:AvailableStageId")]
		public OpportunityStage AvailableStage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
