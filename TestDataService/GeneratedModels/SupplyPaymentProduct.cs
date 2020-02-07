using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupplyPaymentProduct")]
	public class SupplyPaymentProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="BaseQuantity")]
		public decimal BaseQuantity { get; set; }
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="Quantity")]
		public decimal Quantity { get; set; }
		[CProperty(ColumnPath ="SupplyPaymentElementId")]
		public Guid SupplyPaymentElementId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OrderProduct:ProductId")]
		public OrderProduct Product { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:SupplyPaymentElementId")]
		public SupplyPaymentElement SupplyPaymentElement { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InvoiceProduct:SupplyPaymentProductId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductBySupplyPaymentProduct { get; set; }
		[CProperty(Association ="VwInvoiceProduct:SupplyPaymentProductId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductBySupplyPaymentProduct { get; set; }
		[CProperty(Association ="VwSupplyPaymentProduct:SupplyPaymentProductId")]
		public virtual ICollection<VwSupplyPaymentProduct> VwSupplyPaymentProductBySupplyPaymentProduct { get; set; }
		#endregion
	}
}
