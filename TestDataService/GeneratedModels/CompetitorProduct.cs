using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CompetitorProduct")]
	public class CompetitorProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CompetitorId")]
		public Guid CompetitorId { get; set; }
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
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Strengths")]
		public string Strengths { get; set; }
		[CProperty(ColumnPath ="Weakness")]
		public string Weakness { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:CompetitorId")]
		public Account Competitor { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OpportunityCompetitor:CompetitorProductId")]
		public virtual ICollection<OpportunityCompetitor> OpportunityCompetitorByCompetitorProduct { get; set; }
		[CProperty(Association ="tsaTermVariant:tsaCompetitorId")]
		public virtual ICollection<tsaTermVariant> tsaTermVariantBytsaCompetitor { get; set; }
		#endregion
	}
}
