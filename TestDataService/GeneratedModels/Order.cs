using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Order")]
	public class Order : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ActualDate")]
		public DateTime ActualDate { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContactNumber")]
		public string ContactNumber { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="DeliveryAddress")]
		public string DeliveryAddress { get; set; }
		[CProperty(ColumnPath ="DeliveryStatusId")]
		public Guid DeliveryStatusId { get; set; }
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PaymentStatusId")]
		public Guid PaymentStatusId { get; set; }
		[CProperty(ColumnPath ="PaymentTypeId")]
		public Guid PaymentTypeId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReceiverName")]
		public string ReceiverName { get; set; }
		[CProperty(ColumnPath ="SourceOrderId")]
		public Guid SourceOrderId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="WorkId")]
		public string WorkId { get; set; }
		[CProperty(ColumnPath ="WorkOwnerId")]
		public Guid WorkOwnerId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:WorkOwnerId")]
		public Contact WorkOwner { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="DeliveryType:DeliveryTypeId")]
		public DeliveryType DeliveryType { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OrderDeliveryStatus:DeliveryStatusId")]
		public OrderDeliveryStatus DeliveryStatus { get; set; }
		[CProperty(Navigation ="OrderPaymentStatus:PaymentStatusId")]
		public OrderPaymentStatus PaymentStatus { get; set; }
		[CProperty(Navigation ="OrderStatus:StatusId")]
		public OrderStatus Status { get; set; }
		[CProperty(Navigation ="PaymentType:PaymentTypeId")]
		public PaymentType PaymentType { get; set; }
		[CProperty(Navigation ="SourceOrder:SourceOrderId")]
		public SourceOrder SourceOrder { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:OrderId")]
		public virtual ICollection<Activity> ActivityByOrder { get; set; }
		[CProperty(Association ="Call:OrderId")]
		public virtual ICollection<Call> CallByOrder { get; set; }
		[CProperty(Association ="Contract:OrderId")]
		public virtual ICollection<Contract> ContractByOrder { get; set; }
		[CProperty(Association ="Document:OrderId")]
		public virtual ICollection<Document> DocumentByOrder { get; set; }
		[CProperty(Association ="Invoice:OrderId")]
		public virtual ICollection<Invoice> InvoiceByOrder { get; set; }
		[CProperty(Association ="Lead:OrderId")]
		public virtual ICollection<Lead> LeadByOrder { get; set; }
		[CProperty(Association ="OrderFile:OrderId")]
		public virtual ICollection<OrderFile> OrderFileByOrder { get; set; }
		[CProperty(Association ="OrderInFolder:OrderId")]
		public virtual ICollection<OrderInFolder> OrderInFolderByOrder { get; set; }
		[CProperty(Association ="OrderInTag:EntityId")]
		public virtual ICollection<OrderInTag> OrderInTagByEntity { get; set; }
		[CProperty(Association ="OrderProduct:OrderId")]
		public virtual ICollection<OrderProduct> OrderProductByOrder { get; set; }
		[CProperty(Association ="OrderVisa:OrderId")]
		public virtual ICollection<OrderVisa> OrderVisaByOrder { get; set; }
		[CProperty(Association ="SupplyPaymentElement:OrderId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByOrder { get; set; }
		[CProperty(Association ="VwQueueItem:OrderId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByOrder { get; set; }
		#endregion
	}
}
