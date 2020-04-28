using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmonlineProduct")]
	public class BpmonlineProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AutobuildProductCode")]
		public string AutobuildProductCode { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
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
		#endregion

		#region Associations
		[CProperty(Association ="BpmonlineBuild:BpmonlineProductId")]
		public virtual ICollection<BpmonlineBuild> BpmonlineBuildByBpmonlineProduct { get; set; }
		[CProperty(Association ="BpmonlineProductAddValue:BpmonlineProductId")]
		public virtual ICollection<BpmonlineProductAddValue> BpmonlineProductAddValueByBpmonlineProduct { get; set; }
		[CProperty(Association ="BpmonlineProductUpdateScenario:BpmonlineProductId")]
		public virtual ICollection<BpmonlineProductUpdateScenario> BpmonlineProductUpdateScenarioByBpmonlineProduct { get; set; }
		[CProperty(Association ="ConfItem:BpmonlineProductId")]
		public virtual ICollection<ConfItem> ConfItemByBpmonlineProduct { get; set; }
		[CProperty(Association ="ModuleInProduct:BpmonlineProductId")]
		public virtual ICollection<ModuleInProduct> ModuleInProductByBpmonlineProduct { get; set; }
		[CProperty(Association ="Release:BpmonlineProductId")]
		public virtual ICollection<Release> ReleaseByBpmonlineProduct { get; set; }
		#endregion
	}
}
