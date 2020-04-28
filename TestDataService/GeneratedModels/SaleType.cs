using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SaleType")]
	public class SaleType : BaseEntity
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Bonus:SaleTypeId")]
		public virtual ICollection<Bonus> BonusBySaleType { get; set; }
		[CProperty(Association ="BonusProduct:SaleTypeId")]
		public virtual ICollection<BonusProduct> BonusProductBySaleType { get; set; }
		[CProperty(Association ="InvoiceProduct:SaleTypeId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductBySaleType { get; set; }
		[CProperty(Association ="OrderProduct:SaleTypeId")]
		public virtual ICollection<OrderProduct> OrderProductBySaleType { get; set; }
		[CProperty(Association ="ProductCoefficients:SaleTypeId")]
		public virtual ICollection<ProductCoefficients> ProductCoefficientsBySaleType { get; set; }
		[CProperty(Association ="VwInvoiceProduct:SaleTypeId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductBySaleType { get; set; }
		#endregion
	}
}
