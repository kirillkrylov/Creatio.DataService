using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityPartnerHistory")]
	public class OpportunityPartnerHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualMargin")]
		public decimal ActualMargin { get; set; }
		[CProperty(ColumnPath ="ActualMarginPct")]
		public decimal ActualMarginPct { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PartnerOwnerId")]
		public Guid PartnerOwnerId { get; set; }
		[CProperty(ColumnPath ="PartnerProjectRoleId")]
		public Guid PartnerProjectRoleId { get; set; }
		[CProperty(ColumnPath ="PerentRecord")]
		public Guid PerentRecord { get; set; }
		[CProperty(ColumnPath ="PlanMarginPct")]
		public decimal PlanMarginPct { get; set; }
		[CProperty(ColumnPath ="PlannedMargin")]
		public decimal PlannedMargin { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="RecordModifyId")]
		public Guid RecordModifyId { get; set; }
		[CProperty(ColumnPath ="Winner")]
		public bool Winner { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:PartnerOwnerId")]
		public Contact PartnerOwner { get; set; }
		[CProperty(Navigation ="Contact:RecordModifyId")]
		public Contact RecordModify { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="PartnerProjectRole:PartnerProjectRoleId")]
		public PartnerProjectRole PartnerProjectRole { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
