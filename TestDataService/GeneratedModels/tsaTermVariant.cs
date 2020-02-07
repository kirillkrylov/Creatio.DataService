using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "tsaTermVariant")]
	public class tsaTermVariant : BaseEntity
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
		[CProperty(ColumnPath ="ParentProcessUId")]
		public Guid ParentProcessUId { get; set; }
		[CProperty(ColumnPath ="ParentSubProcessUId")]
		public Guid ParentSubProcessUId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProcessUId")]
		public Guid ProcessUId { get; set; }
		[CProperty(ColumnPath ="SubProcessUId")]
		public Guid SubProcessUId { get; set; }
		[CProperty(ColumnPath ="tsaCompetitorId")]
		public Guid tsaCompetitorId { get; set; }
		[CProperty(ColumnPath ="tsaTermId")]
		public Guid tsaTermId { get; set; }
		[CProperty(ColumnPath ="tsaTermVariantTypeId")]
		public Guid tsaTermVariantTypeId { get; set; }
		[CProperty(ColumnPath ="tsaVariantComment")]
		public string tsaVariantComment { get; set; }
		[CProperty(ColumnPath ="tsaVariantName")]
		public string tsaVariantName { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CompetitorProduct:tsaCompetitorId")]
		public CompetitorProduct tsaCompetitor { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="tsaTerm:tsaTermId")]
		public tsaTerm tsaTerm { get; set; }
		[CProperty(Navigation ="tsaTermVariantType:tsaTermVariantTypeId")]
		public tsaTermVariantType tsaTermVariantType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
