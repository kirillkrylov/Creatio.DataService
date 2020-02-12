using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadCompetitor")]
	public class LeadCompetitor : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CompetitorAmount")]
		public decimal CompetitorAmount { get; set; }
		[CProperty(ColumnPath ="CompetitorId")]
		public Guid CompetitorId { get; set; }
		[CProperty(ColumnPath ="CompetitorProductId")]
		public Guid CompetitorProductId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateFrom")]
		public DateTime DateFrom { get; set; }
		[CProperty(ColumnPath ="DateTo")]
		public DateTime DateTo { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsWinner")]
		public bool IsWinner { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Strengths")]
		public string Strengths { get; set; }
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId { get; set; }
		[CProperty(ColumnPath ="Weakness")]
		public string Weakness { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:CompetitorId")]
		public Account Competitor { get; set; }
		[CProperty(Navigation ="Account:SupplierId")]
		public Account Supplier { get; set; }
		[CProperty(Navigation ="CompetitorProduct:CompetitorProductId")]
		public CompetitorProduct CompetitorProduct { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
