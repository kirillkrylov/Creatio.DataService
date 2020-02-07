using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupplyPaymentElement")]
	public class SupplyPaymentElement : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AmountFact")]
		public decimal AmountFact { get; set; }
		[CProperty(ColumnPath ="AmountPlan")]
		public decimal AmountPlan { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateFact")]
		public DateTime DateFact { get; set; }
		[CProperty(ColumnPath ="DatePlan")]
		public DateTime DatePlan { get; set; }
		[CProperty(ColumnPath ="Delay")]
		public int Delay { get; set; }
		[CProperty(ColumnPath ="DelayTypeId")]
		public Guid DelayTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="Percentage")]
		public decimal Percentage { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="PreviousElementId")]
		public Guid PreviousElementId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountFact")]
		public decimal PrimaryAmountFact { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountPlan")]
		public decimal PrimaryAmountPlan { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="Products")]
		public string Products { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrderProduct:ProductId")]
		public OrderProduct Product { get; set; }
		[CProperty(Navigation ="SupplyPaymentDelay:DelayTypeId")]
		public SupplyPaymentDelay DelayType { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:PreviousElementId")]
		public SupplyPaymentElement PreviousElement { get; set; }
		[CProperty(Navigation ="SupplyPaymentState:StateId")]
		public SupplyPaymentState State { get; set; }
		[CProperty(Navigation ="SupplyPaymentType:TypeId")]
		public SupplyPaymentType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SupplyPaymentElement:PreviousElementId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByPreviousElement { get; set; }
		[CProperty(Association ="SupplyPaymentProduct:SupplyPaymentElementId")]
		public virtual ICollection<SupplyPaymentProduct> SupplyPaymentProductBySupplyPaymentElement { get; set; }
		[CProperty(Association ="VwSupplyPaymentProduct:SupplyPaymentElementId")]
		public virtual ICollection<VwSupplyPaymentProduct> VwSupplyPaymentProductBySupplyPaymentElement { get; set; }
		#endregion
	}
}
