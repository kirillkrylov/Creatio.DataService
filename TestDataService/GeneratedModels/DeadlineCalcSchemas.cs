using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DeadlineCalcSchemas")]
	public class DeadlineCalcSchemas : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AlternativeRuleId")]
		public Guid AlternativeRuleId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Default")]
		public bool Default { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Handler")]
		public string Handler { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DeadlineCalcSchemas:AlternativeRuleId")]
		public DeadlineCalcSchemas AlternativeRule { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DeadlineCalcSchemas:AlternativeRuleId")]
		public virtual ICollection<DeadlineCalcSchemas> DeadlineCalcSchemasByAlternativeRule { get; set; }
		#endregion
	}
}
