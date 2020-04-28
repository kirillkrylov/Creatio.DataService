using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductFilter")]
	public class ProductFilter : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption { get; set; }
		[CProperty(ColumnPath ="ColumnDataValueType")]
		public int ColumnDataValueType { get; set; }
		[CProperty(ColumnPath ="ColumnPath")]
		public string ColumnPath { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductTypeId")]
		public Guid ProductTypeId { get; set; }
		[CProperty(ColumnPath ="ReferenceSchemaName")]
		public string ReferenceSchemaName { get; set; }
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProductFilterType:TypeId")]
		public ProductFilterType Type { get; set; }
		[CProperty(Navigation ="ProductType:ProductTypeId")]
		public ProductType ProductType { get; set; }
		[CProperty(Navigation ="Specification:SpecificationId")]
		public Specification Specification { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
