using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmonlineProductUpdateScenario")]
	public class BpmonlineProductUpdateScenario : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BpmonlineProductId")]
		public Guid BpmonlineProductId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Localization")]
		public string Localization { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SourceVersion")]
		public string SourceVersion { get; set; }
		[CProperty(ColumnPath ="TargetVersion")]
		public string TargetVersion { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BpmonlineProduct:BpmonlineProductId")]
		public BpmonlineProduct BpmonlineProduct { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
