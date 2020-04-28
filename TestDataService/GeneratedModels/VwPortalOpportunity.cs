using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwPortalOpportunity")]
	public class VwPortalOpportunity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Budget")]
		public decimal Budget { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PartnerRoles")]
		public string PartnerRoles { get; set; }
		[CProperty(ColumnPath ="Probability")]
		public int Probability { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="OpportunityStage:StageId")]
		public OpportunityStage Stage { get; set; }
		[CProperty(Navigation ="OpportunityType:TypeId")]
		public OpportunityType Type { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
