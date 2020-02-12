using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSupplyPaymentProduct")]
	public class VwSupplyPaymentProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AvailableAmount")]
		public decimal AvailableAmount { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DiscountPercent")]
		public decimal DiscountPercent { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDistributed")]
		public int IsDistributed { get; set; }
		[CProperty(ColumnPath ="MaxQuantity")]
		public decimal MaxQuantity { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OrderProductId")]
		public Guid OrderProductId { get; set; }
		[CProperty(ColumnPath ="Price")]
		public decimal Price { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RenewalDate")]
		public DateTime RenewalDate { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="SupplyPaymentElementId")]
		public Guid SupplyPaymentElementId { get; set; }
		[CProperty(ColumnPath ="SupplyPaymentProductId")]
		public Guid SupplyPaymentProductId { get; set; }
		[CProperty(ColumnPath ="TotalPrice")]
		public decimal TotalPrice { get; set; }
		[CProperty(ColumnPath ="UsedAmount")]
		public decimal UsedAmount { get; set; }
		[CProperty(ColumnPath ="UsedQuantity")]
		public decimal UsedQuantity { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OrderProduct:OrderProductId")]
		public OrderProduct OrderProduct { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:SupplyPaymentElementId")]
		public SupplyPaymentElement SupplyPaymentElement { get; set; }
		[CProperty(Navigation ="SupplyPaymentProduct:SupplyPaymentProductId")]
		public SupplyPaymentProduct SupplyPaymentProduct { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
