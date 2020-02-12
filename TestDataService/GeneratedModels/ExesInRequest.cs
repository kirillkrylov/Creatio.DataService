using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExesInRequest")]
	public class ExesInRequest : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AmountEuro")]
		public decimal AmountEuro { get; set; }
		[CProperty(ColumnPath ="AvailabilityOfPrimaryDocuments")]
		public bool AvailabilityOfPrimaryDocuments { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="ExesNumber")]
		public string ExesNumber { get; set; }
		[CProperty(ColumnPath ="ExesStatusId")]
		public Guid ExesStatusId { get; set; }
		[CProperty(ColumnPath ="FactualAmount")]
		public decimal FactualAmount { get; set; }
		[CProperty(ColumnPath ="FactualAmountBaseCurrency")]
		public decimal FactualAmountBaseCurrency { get; set; }
		[CProperty(ColumnPath ="FinanceExecutorId")]
		public Guid FinanceExecutorId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId { get; set; }
		[CProperty(ColumnPath ="LeadSourceId")]
		public Guid LeadSourceId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PartialPayment")]
		public bool PartialPayment { get; set; }
		[CProperty(ColumnPath ="PayDate")]
		public DateTime PayDate { get; set; }
		[CProperty(ColumnPath ="PayerTerritoryId")]
		public Guid PayerTerritoryId { get; set; }
		[CProperty(ColumnPath ="PaymentReasonId")]
		public Guid PaymentReasonId { get; set; }
		[CProperty(ColumnPath ="PaymentTypeId")]
		public Guid PaymentTypeId { get; set; }
		[CProperty(ColumnPath ="PlannedPayDate")]
		public DateTime PlannedPayDate { get; set; }
		[CProperty(ColumnPath ="PrimaryTotalAmountWithoutTax")]
		public decimal PrimaryTotalAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RequestExesId")]
		public Guid RequestExesId { get; set; }
		[CProperty(ColumnPath ="RequestExesTypeId")]
		public Guid RequestExesTypeId { get; set; }
		[CProperty(ColumnPath ="SettlementAccountId")]
		public Guid SettlementAccountId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId { get; set; }
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId { get; set; }
		[CProperty(ColumnPath ="TotalAmountWithoutTax")]
		public decimal TotalAmountWithoutTax { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:SupplierId")]
		public Account Supplier { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:FinanceExecutorId")]
		public Contact FinanceExecutor { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="ExesStatus:ExesStatusId")]
		public ExesStatus ExesStatus { get; set; }
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="LeadSource:LeadSourceId")]
		public LeadSource LeadSource { get; set; }
		[CProperty(Navigation ="PaymentReason:PaymentReasonId")]
		public PaymentReason PaymentReason { get; set; }
		[CProperty(Navigation ="PaymentType:PaymentTypeId")]
		public PaymentType PaymentType { get; set; }
		[CProperty(Navigation ="RequestExes:RequestExesId")]
		public RequestExes RequestExes { get; set; }
		[CProperty(Navigation ="RequestExesType:RequestExesTypeId")]
		public RequestExesType RequestExesType { get; set; }
		[CProperty(Navigation ="SettlementAccounts:SettlementAccountId")]
		public SettlementAccounts SettlementAccount { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		[CProperty(Navigation ="Territory:PayerTerritoryId")]
		public Territory PayerTerritory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ExesInRequestHistory:ExesInRequestId")]
		public virtual ICollection<ExesInRequestHistory> ExesInRequestHistoryByExesInRequest { get; set; }
		[CProperty(Association ="ExesInRequestInFolder:ExesInRequestId")]
		public virtual ICollection<ExesInRequestInFolder> ExesInRequestInFolderByExesInRequest { get; set; }
		[CProperty(Association ="ExesInRequestInTag:EntityId")]
		public virtual ICollection<ExesInRequestInTag> ExesInRequestInTagByEntity { get; set; }
		[CProperty(Association ="ExesScheduleOfPayments:ExesInRequestId")]
		public virtual ICollection<ExesScheduleOfPayments> ExesScheduleOfPaymentsByExesInRequest { get; set; }
		#endregion
	}
}
