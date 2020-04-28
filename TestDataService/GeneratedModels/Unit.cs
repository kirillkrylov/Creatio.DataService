using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Unit")]
	public class Unit : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="ShortName")]
		public string ShortName { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DocumentProduct:UnitId")]
		public virtual ICollection<DocumentProduct> DocumentProductByUnit { get; set; }
		[CProperty(Association ="InvoiceProduct:UnitId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByUnit { get; set; }
		[CProperty(Association ="OrderProduct:UnitId")]
		public virtual ICollection<OrderProduct> OrderProductByUnit { get; set; }
		[CProperty(Association ="Product:UnitId")]
		public virtual ICollection<Product> ProductByUnit { get; set; }
		[CProperty(Association ="ProductUnit:UnitId")]
		public virtual ICollection<ProductUnit> ProductUnitByUnit { get; set; }
		[CProperty(Association ="ProjectProduct:UnitId")]
		public virtual ICollection<ProjectProduct> ProjectProductByUnit { get; set; }
		[CProperty(Association ="VwDocumentProduct:UnitId")]
		public virtual ICollection<VwDocumentProduct> VwDocumentProductByUnit { get; set; }
		[CProperty(Association ="VwInvoiceProduct:UnitId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByUnit { get; set; }
		[CProperty(Association ="VwOrderProduct:UnitId")]
		public virtual ICollection<VwOrderProduct> VwOrderProductByUnit { get; set; }
		[CProperty(Association ="VwProjectProduct:UnitId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByUnit { get; set; }
		#endregion
	}
}
