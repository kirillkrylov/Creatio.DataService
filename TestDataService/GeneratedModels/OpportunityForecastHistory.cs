using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityForecastHistory")]
	public class OpportunityForecastHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="Changes")]
		public string Changes { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Days")]
		public int Days { get; set; }
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate { get; set; }
		[CProperty(ColumnPath ="DeliveryId")]
		public Guid DeliveryId { get; set; }
		[CProperty(ColumnPath ="Expenses")]
		public decimal Expenses { get; set; }
		[CProperty(ColumnPath ="ForecastOwnerId")]
		public Guid ForecastOwnerId { get; set; }
		[CProperty(ColumnPath ="ForecastProductTypeId")]
		public Guid ForecastProductTypeId { get; set; }
		[CProperty(ColumnPath ="GrossMargin")]
		public decimal GrossMargin { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="IsContractSigned")]
		public bool IsContractSigned { get; set; }
		[CProperty(ColumnPath ="IsForecastItem")]
		public bool IsForecastItem { get; set; }
		[CProperty(ColumnPath ="IsTargetChanges")]
		public bool IsTargetChanges { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OpportunityForecastId")]
		public Guid OpportunityForecastId { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="PaymentModelId")]
		public Guid PaymentModelId { get; set; }
		[CProperty(ColumnPath ="PercentOfTCV")]
		public decimal PercentOfTCV { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="Proceeds")]
		public decimal Proceeds { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductKindId")]
		public Guid ProductKindId { get; set; }
		[CProperty(ColumnPath ="Quantity")]
		public decimal Quantity { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ForecastOwnerId")]
		public Contact ForecastOwner { get; set; }
		[CProperty(Navigation ="ForecastProductType:ForecastProductTypeId")]
		public ForecastProductType ForecastProductType { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityForecast:OpportunityForecastId")]
		public OpportunityForecast OpportunityForecast { get; set; }
		[CProperty(Navigation ="OpportunityForecastStatus:StatusId")]
		public OpportunityForecastStatus Status { get; set; }
		[CProperty(Navigation ="OpportunityForecastType:TypeId")]
		public OpportunityForecastType Type { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrderProductPeriod:PeriodId")]
		public OrderProductPeriod Period { get; set; }
		[CProperty(Navigation ="PaymentModel:PaymentModelId")]
		public PaymentModel PaymentModel { get; set; }
		[CProperty(Navigation ="ProductKind:ProductKindId")]
		public ProductKind ProductKind { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:DeliveryId")]
		public SupplyPaymentElement Delivery { get; set; }
		[CProperty(Navigation ="SupportLevel:SupportLevelId")]
		public SupportLevel SupportLevel { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
