using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExesScheduleOfPayments")]
	public class ExesScheduleOfPayments : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="ExesInRequestId")]
		public Guid ExesInRequestId { get; set; }
		[CProperty(ColumnPath ="FactualAmount")]
		public decimal FactualAmount { get; set; }
		[CProperty(ColumnPath ="FactualAmountBaseCurrency")]
		public decimal FactualAmountBaseCurrency { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PaymentDate")]
		public DateTime PaymentDate { get; set; }
		[CProperty(ColumnPath ="PaymentStatusId")]
		public Guid PaymentStatusId { get; set; }
		[CProperty(ColumnPath ="PlannedAmount")]
		public decimal PlannedAmount { get; set; }
		[CProperty(ColumnPath ="PlannedAmountBaseCurrency")]
		public decimal PlannedAmountBaseCurrency { get; set; }
		[CProperty(ColumnPath ="PlannedPaymentDate")]
		public DateTime PlannedPaymentDate { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SettlementAccountId")]
		public Guid SettlementAccountId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="ExesInRequest:ExesInRequestId")]
		public ExesInRequest ExesInRequest { get; set; }
		[CProperty(Navigation ="ExesPaymentStatus:PaymentStatusId")]
		public ExesPaymentStatus PaymentStatus { get; set; }
		[CProperty(Navigation ="SettlementAccounts:SettlementAccountId")]
		public SettlementAccounts SettlementAccount { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
