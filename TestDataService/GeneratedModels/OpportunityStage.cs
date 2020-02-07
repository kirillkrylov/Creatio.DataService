using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityStage")]
	public class OpportunityStage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Color")]
		public string Color { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="End")]
		public bool End { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MaxProbability")]
		public int MaxProbability { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NextStepTerm")]
		public int NextStepTerm { get; set; }
		[CProperty(ColumnPath ="Number")]
		public int Number { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ShowInFunnel")]
		public bool ShowInFunnel { get; set; }
		[CProperty(ColumnPath ="ShowInProgressBar")]
		public bool ShowInProgressBar { get; set; }
		[CProperty(ColumnPath ="Successful")]
		public bool Successful { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Opportunity:StageId")]
		public virtual ICollection<Opportunity> OpportunityByStage { get; set; }
		[CProperty(Association ="OpportunityInStage:StageId")]
		public virtual ICollection<OpportunityInStage> OpportunityInStageByStage { get; set; }
		[CProperty(Association ="OppStageDecoupling:CurrentStageId")]
		public virtual ICollection<OppStageDecoupling> OppStageDecouplingByCurrentStage { get; set; }
		[CProperty(Association ="OppStageDecoupling:AvailableStageId")]
		public virtual ICollection<OppStageDecoupling> OppStageDecouplingByAvailableStage { get; set; }
		[CProperty(Association ="VwOpportFunnelData:fStageId")]
		public virtual ICollection<VwOpportFunnelData> VwOpportFunnelDataByfStage { get; set; }
		[CProperty(Association ="VwOpportFunnelData:lStageId")]
		public virtual ICollection<VwOpportFunnelData> VwOpportFunnelDataBylStage { get; set; }
		[CProperty(Association ="VwOpportInStageForAnalysis:StageId")]
		public virtual ICollection<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisByStage { get; set; }
		[CProperty(Association ="VwOpportunityInStage:StageId")]
		public virtual ICollection<VwOpportunityInStage> VwOpportunityInStageByStage { get; set; }
		[CProperty(Association ="VwPortalOpportunity:StageId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByStage { get; set; }
		#endregion
	}
}
